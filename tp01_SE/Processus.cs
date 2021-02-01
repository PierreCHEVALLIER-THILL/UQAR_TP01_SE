using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_SE
{
    public class Processus
    {
        private int PID;
        private string nom;
        private decimal priorite;
        private decimal nbInstructCalc;
        private decimal nbInstructES;
        private decimal nbCycle;
        public int nbThread;
        private List<Thread> lstThread = new List<Thread>();
        public Processus(int PID, string nom, decimal priorite, decimal nbInstructCalc, decimal nbInstructES, decimal nbCycle, int nbThread)
        {
            this.PID = PID;
            this.nom = nom;
            this.priorite = priorite;
            this.nbInstructCalc = nbInstructCalc;
            this.nbInstructES = nbInstructES;
            this.nbCycle = nbCycle;
            this.nbThread = nbThread;
            this.initLstThread();
        }

        public string getName() 
        {
            return (this.nom);
        }

        public List<Thread> getThreads()
        {
            return (this.lstThread);
        }


        public void initLstThread()
        {
            if (this.nbThread == 1)
            {
                Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(0,0));
                this.lstThread.Add(newThread);
            } else
            {
                bool flagCalc = false;
                bool flagES = false;
                for (int i = 0; i < this.nbThread; i++)
                {
                    if (((this.nbInstructCalc % this.nbThread) != 0 && !flagCalc) && ((this.nbInstructES % this.nbThread) != 0 && !flagES))
                    {
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(1, 1));
                        this.lstThread.Add(newThread);
                        flagCalc = true;
                        flagES = true;

                    }

                    else if ((this.nbInstructCalc % this.nbThread) != 0 && flagCalc)
                    {
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(1, 0));
                        this.lstThread.Add(newThread);
                        flagES = true;
                    }         

                    else if ((this.nbInstructES % this.nbThread) != 0 && !flagES)
                    {
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(0, 1));
                        this.lstThread.Add(newThread);
                        flagCalc = true;
                    }                    
                    else {
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(0, 0));
                        this.lstThread.Add(newThread);
                    }
                }
            }

        }

        public List<string> initInstruction(int ajoutNbInstructCalc, int ajoutNbInstructES) {
            List<string> instruct = new List<string>();
            for (int i = 0; i < (nbInstructCalc + ajoutNbInstructCalc) ; i++)
            {
                instruct.Add("Calcul");
            }
            for (int i = 0; i < (nbInstructES + ajoutNbInstructES); i++)
            {
                instruct.Add("Entree Sortie");
            }
            return (instruct);
        }


    }
}
