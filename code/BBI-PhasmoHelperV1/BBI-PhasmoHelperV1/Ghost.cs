using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBI_PhasmoHelperV1
{
    class Ghost
    {
        public string Name { get; private set; }
        public string[] Evidence { get; private set; }
        public bool TurnsOffBreaker { get; private set; }
        public bool CanTurnOnLights { get; private set; }

        public string Strengths { get; private set; }
        public string Weaknesses { get; private set; }
        public string TipsAndStrats { get; private set; }
        public string Note { get; set; }
        public string Ability { get; private set; }
        public string HuntSanity { get; private set; }

        //public int HuntThreshold { get; private set; }
        //public string Ability { get; private set; }

        /// <summary>
        /// make a new ghost object that autosaves to the ghosts folder, will also create folder if not found, evidence must be 3 pieces long!
        /// </summary>
        /// <note>if the bool</note>
        /// <param name="name"></param>
        /// <param name="evidence"></param>
        /// <param name="turnsOffBreaker"></param>
        /// <param name="canTurnOnLights"></param>
        /// <param name="strengths"></param>
        /// <param name="weaknesses"></param>
        /// <param name="tipsAndStrats"></param>
        /// <param name="note"></param>
        /// <param name="ability"></param>
        /// <param name="huntSanity"></param>
        /// <exception cref="ArgumentException"></exception>
        public Ghost(string name, string[] evidence, bool turnsOffBreaker, bool canTurnOnLights, string strengths, string weaknesses, string tipsAndStrats, string note, string ability, string huntSanity)
        {
            if (evidence.Length != 3)
            {
                throw new ArgumentException("There must be 3 pieces of evidence");
            }
            else if (name == null || name == "")
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            else if (strengths == null || weaknesses == null)
            {
                throw new ArgumentException("Strengths and/or weaknesses cannot be null");
            }
            Name = name;
            Evidence = evidence;
            TurnsOffBreaker = turnsOffBreaker;
            CanTurnOnLights = canTurnOnLights;
            Strengths = strengths;
            Weaknesses = weaknesses;
            TipsAndStrats = tipsAndStrats;
            Note = note;
            Ability = ability;
            HuntSanity = huntSanity;
        }

        bool HasEvidence(string evidence)
        {
            foreach (string evi in Evidence)
            {
                if (evi == evidence)
                {
                    return true;
                }
            }
            return false;
        }
    }
}