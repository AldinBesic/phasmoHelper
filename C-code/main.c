#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <signal.h>
#include <sys/wait.h>

#define PORT 8080
#define BUFFER_SIZE 129 // 1 byte for command + 128 bytes for data
#define MAX_CLIENTS 5

void error(const char *msg)
{
    perror(msg);
    exit(1);
}

void handle_client(int newsockfd)
{
    char buffer[BUFFER_SIZE];
    int n;

    bzero(buffer, BUFFER_SIZE);
    n = read(newsockfd, buffer, BUFFER_SIZE - 1);
    if (n < 0)
        error("ERROR reading from socket");
    else if (n == 0)
        return; // client disconnected

    printf("Here is the message: %s\n", buffer);

    if (buffer[0] == 0x01 && strcmp(buffer + 1, "PING") == 0)
    {
        n = write(newsockfd, "\x01PONG", 5);
    }
    else
    {
        n = write(newsockfd, "received", 8);
    }

    if (n < 0)
        error("ERROR writing to socket");

    if (close(newsockfd) < 0)
        error("ERROR closing socket");
}

void sigchld_handler(int s)
{
    while(waitpid(-1, NULL, WNOHANG) > 0);
}

int main()
{
    int sockfd, newsockfd, portno;
    socklen_t clilen;
    struct sockaddr_in serv_addr, cli_addr;
    int active_clients = 0;

    sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if (sockfd < 0)
        error("ERROR opening socket");

    int opt = 1;
    if (setsockopt(sockfd, SOL_SOCKET, SO_REUSEADDR, &opt, sizeof(int)) < 0)
        error("ERROR setting socket options");

    bzero((char *)&serv_addr, sizeof(serv_addr));
    portno = PORT;

    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;
    serv_addr.sin_port = htons(portno);

    if (bind(sockfd, (struct sockaddr *)&serv_addr, sizeof(serv_addr)) < 0)
        error("ERROR on binding");

    if (listen(sockfd, 5) < 0)
        error("ERROR on listen");

    clilen = sizeof(cli_addr);

    struct sigaction sa;
    sa.sa_handler = sigchld_handler; // reap all dead processes
    sigemptyset(&sa.sa_mask);
    sa.sa_flags = SA_RESTART;
    if (sigaction(SIGCHLD, &sa, NULL) == -1) {
        perror("sigaction");
        exit(1);
    }

    while (1)
    {
        if (active_clients >= MAX_CLIENTS)
        {
            printf("Too many clients, waiting for one to disconnect...\n");
            continue;
        }

        newsockfd = accept(sockfd, (struct sockaddr *)&cli_addr, &clilen);
        if (newsockfd < 0)
            error("ERROR on accept");

        int pid = fork();
        if (pid < 0)
        {
            error("ERROR on fork");
        }
        else if (pid == 0)
        {
            close(sockfd);
            handle_client(newsockfd);
            exit(0);
        }
        else
        {
            active_clients++;
            close(newsockfd);
        }
    }

    if (close(sockfd) < 0)
        error("ERROR closing socket");

    return 0;
}

