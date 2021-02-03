using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        public void handleOddNb()
        {
            
            
        }
        public void initLstThread()
        {
            if (this.nbThread == 1)
            {
                Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(false,false));
                this.lstThread.Add(newThread);
            } else
            {
                bool flagCalc = false;
                bool flagES = false;

                for (int i = 0; i < this.nbThread; i++) {
                    if ((this.nbInstructCalc % this.nbThread) != 0 && (this.nbInstructES % this.nbThread) != 0 && ((flagCalc == false) && flagES == false)) {
                        Debug.WriteLine("Les deux impaire:" + (this.PID * 10) + this.lstThread.Count());
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(true, true));
                        this.lstThread.Add(newThread);
                        flagCalc = true;
                        flagES = true;
                    } else if ((this.nbInstructCalc % this.nbThread) != 0 && (flagCalc == false)) {
                        Debug.WriteLine("Ajout instruct Calc en plus:" + (this.PID * 10) + this.lstThread.Count());
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(true, false));
                        flagCalc = true;
                        this.lstThread.Add(newThread);
                    } else if ((this.nbInstructES % this.nbThread) != 0 && (flagES == false))  {
                        Debug.WriteLine("Ajout instruct Calc en plus:" + (this.PID * 10) + this.lstThread.Count());
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(false, true));
                        flagES = true;
                        this.lstThread.Add(newThread);
                    } else {
                        Debug.WriteLine("Ajout classique: " + (this.PID * 10) + this.lstThread.Count());
                        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(false, false));
                        this.lstThread.Add(newThread);
                    }
                }
            }

        }

        public List<Instruction> initInstruction(bool ajoutInstructCalc, bool ajoutInstructES) {
             
            List<Instruction> listInstructions = new List<Instruction>();
            int ajoutCalc = 0;
            int ajoutES = 0;
            if (ajoutInstructCalc)
            {
                ajoutCalc = 1;
            }
            if (ajoutInstructES)
            {
                ajoutES = 1;
            }
            Debug.WriteLine("Nb Calc Instruc: " + ((this.nbInstructCalc / this.nbThread) + ajoutCalc));
            Debug.WriteLine("Nb ES Instruc: " + ((this.nbInstructES / this.nbThread) + ajoutES));
            for (int i = 1; i <= ((this.nbInstructCalc / this.nbThread) + ajoutCalc) ; i++)
            {
                Debug.WriteLine(i);
                Instruction instruction = new Instruction(Enums.type.Calcul);
                listInstructions.Add(instruction);
            }
            for (int i = 1; i <= ((this.nbInstructES / this.nbThread) + ajoutES); i++)
            {
                Instruction instruction = new Instruction(Enums.type.EntreeSortie);
                listInstructions.Add(instruction);
            }

            var random = new System.Random();
            listInstructions.Sort((x, y) => random.Next(-1, 2));

            return (listInstructions);
        }


    }
}

/*
for (int i = 0; i < this.nbThread; i++)
{
    if (((this.nbInstructCalc % this.nbThread) != 0 && !flagCalc) && ((this.nbInstructES % this.nbThread) != 0 && !flagES))
    {
        Debug.WriteLine("Les deux sont impaire" + (this.PID * 10) + this.lstThread.Count());
        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(true, false));
        this.lstThread.Add(newThread);
        flagCalc = true;
        flagES = true;
    }
    else if ((this.nbInstructCalc % this.nbThread) != 0 && !flagCalc)
    {
        Debug.WriteLine("Le nombre de calc est impaire" + (this.PID * 10) + this.lstThread.Count());
        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(true, false));
        this.lstThread.Add(newThread);
        flagES = true;
    }
    else if ((this.nbInstructES % this.nbThread) != 0 && !flagES)
    {
        Debug.WriteLine("Le nombre de ES est impaire" + (this.PID * 10) + this.lstThread.Count());
        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(false, true));
        this.lstThread.Add(newThread);
        flagCalc = true;
    }
    else
    {
        Debug.WriteLine("Tout est ok" + (this.PID * 10) + this.lstThread.Count());
        Thread newThread = new Thread(this.nom, this.PID, this.priorite, (this.PID * 10) + this.lstThread.Count(), this.initInstruction(false, false));
        this.lstThread.Add(newThread);
    }
}*/