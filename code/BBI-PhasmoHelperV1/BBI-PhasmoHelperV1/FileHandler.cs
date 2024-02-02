using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BBI_PhasmoHelperV1.Evidence;

namespace BBI_PhasmoHelperV1
{
    static class FileHandler
    {

        enum PrimaryEvidenceType
        {
            EMF5,
            SpiritBox,
            Fingerprints,
            GhostOrbs,
            GhostWriting,
            FreezingTemperatures,
            Dots
        }

        /// <summary>
        /// this function will return a ghost type by reading the added file. it will read all lines and use them to create a ghost object. the filename is the name of the ghost. dont include .txt
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public Ghost FileInGhostOut(string fileName)
        {
            //get current directory
            string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //get the ghosts directory
            string ghostsDirectory = Path.Combine(runningDirectory, "ghosts");
            //get the file
            string ghostFile = Path.Combine(ghostsDirectory, fileName + ".txt");

            //variables
            string weakness = "";
            string strengths = "";
            string strats = "";
            string note = "";
            string ability = "";
            string huntThreshhold = "";
            string e1 = "";
            string e2 = "";
            string e3 = "";
            bool turnsOffBreaker = false;
            bool turnsOffLights = false;

            if (File.Exists(ghostFile))
            {
                // Read the file lines
                string[] lines = File.ReadAllLines(ghostFile);

                foreach (string line in lines)
                {
                    if (line.StartsWith("Weakness: "))
                    {
                        weakness = line.Substring("Weakness: ".Length);
                    }
                    else if (line.StartsWith("Strengths: "))
                    {
                        strengths = line.Substring("Strengths: ".Length);
                    }
                    else if (line.StartsWith("Strats: "))
                    {
                        strats = line.Substring("Strats: ".Length);
                    }
                    else if (line.StartsWith("Note: "))
                    {
                        note = line.Substring("Note: ".Length);
                    }
                    else if (line.StartsWith("E1"))
                    {
                        e1 = line.Substring("E1: ".Length);
                    }
                    else if (line.StartsWith("E2"))
                    {
                        e2 = line.Substring("E2: ".Length);
                    }
                    else if (line.StartsWith("E3"))
                    {
                        e3 = line.Substring("E3: ".Length);
                    }
                    else if (line.StartsWith("Ability:"))
                    {
                        ability = line.Substring("Ability: ".Length);
                    }
                    else if (line.StartsWith("Threshold:"))
                    {
                        huntThreshhold = line.Substring("Threshold: ".Length);
                    }
                    else if (line.StartsWith("TurnsOffBreaker"))
                    {
                        turnsOffBreaker = true;
                    }
                    else if (line.StartsWith("TurnsOffLights"))
                    {
                        turnsOffLights= true;
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }

            //create the string
            string[] evidence = new string[] { e1, e2, e3 };

            //create ghost object
            Ghost ghost = new Ghost(fileName, evidence, turnsOffBreaker, turnsOffLights, strengths, weakness, strats, note, ability, huntThreshhold);

            return ghost;
        }
    }
}
