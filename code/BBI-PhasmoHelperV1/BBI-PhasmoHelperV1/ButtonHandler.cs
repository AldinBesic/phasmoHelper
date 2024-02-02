using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBI_PhasmoHelperV1
{
    class ButtonHandler
    {
        public enum PrimaryEvidenceType
        {
            EMF5,
            SpiritBox,
            Fingerprints,
            GhostOrbs,
            GhostWriting,
            FreezingTemperatures,
            Dots
        }

        public enum EvidenceButtonStates
        {
            TBD,
            Found,
            CrossedOut,
            Possible
        };
        public string Text { get; private set; }
        public EvidenceButtonStates CurrentState { get; private set; }

        public ButtonHandler(string text)
        {
            Text = text;
            CurrentState = EvidenceButtonStates.TBD;
        }

        public void ChangeState()
        {
            switch (CurrentState)
            {
                case EvidenceButtonStates.TBD:
                    CurrentState = EvidenceButtonStates.Found;
                    break;
                case EvidenceButtonStates.Found:
                    CurrentState = EvidenceButtonStates.CrossedOut;
                    break;
                case EvidenceButtonStates.CrossedOut:
                    CurrentState = EvidenceButtonStates.Possible;
                    break;
                case EvidenceButtonStates.Possible:
                    CurrentState = EvidenceButtonStates.TBD;
                    break;
            }
        }
        public void ResetState()
        {
            CurrentState = EvidenceButtonStates.TBD;
        }
        // public void backwards (leftclick)

    }
}
