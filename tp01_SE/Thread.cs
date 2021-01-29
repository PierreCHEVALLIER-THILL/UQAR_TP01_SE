﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_SE
{
    public class Thread
    {
        private string processNom;
        private int PID;
        private decimal priorite;
        private int TID;
        private List<string> lstInstructions = new List<string>();
        public Thread(string processNom, int PID, decimal priorite, int TID, List<string>  lstInstructions)
        {
            this.processNom = processNom;
            this.PID = PID;
            this.priorite = priorite;
            this.TID = TID;
            this.lstInstructions = lstInstructions;
        }

        /*public string getProcessName()
        {
            return (this.processName);
        }
        public int getPID()
        {
            return (this.PID);
        }
        public int getPriority()
        {
            return (this.priority);
        }
        public int getPID()
        {
            return (this.PID);
        }*/

        public string getInfoThread()
        {
            string infos = "Processus: " + this.processNom + "\n\t";
            infos += "PID: " + this.PID + "\n\t";
            infos += "TID: " + this.TID + "\n\t";
            infos += "Priorité: " + this.priorite + "\n\t";
            infos += "Etat:";
            return (infos);
        }
        public List<string> getInstructions()
        {
            return (this.lstInstructions);
        }
    }
}
