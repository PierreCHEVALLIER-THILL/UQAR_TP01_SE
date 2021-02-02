using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_SE
{
    public class Instruction
    {
        private Enums.etat etat;
        private Enums.type type;

        public Instruction(Enums.etat etat, Enums.type type)
        {

            this.etat = etat;
            this.type = type;
            
        }
        public Enums.etat Etat
        {
            get { return etat; }
            set { this.etat = value; }
        }
        public Enums.type Type
        {
            get { return type; }
            set { this.type = value; }
        }

    }
}
