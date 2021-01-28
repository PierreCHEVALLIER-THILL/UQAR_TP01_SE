﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp01_SE
{
    public partial class AddProcessForm : Form
    {
        private List<Processus> lstProcessus;
        public AddProcessForm(ref List<Processus> lstProcessus)
        {
            InitializeComponent();
            this.lstProcessus = lstProcessus;
        }

        private void lblPriorite_Click(object sender, EventArgs e)
        {

        }

        private Thread nbThread()
        {

            if (this.rdBtnMono.Checked) {
                return (Thread.mono);
            } else if (this.rdBtn2Thread.Checked)
            {
                return (Thread.couple);
            } else if (this.rdBtn3Thread.Checked)
            {
                return (Thread.triple);
            } else if (this.rdBtn1et3Thread.Checked)
            {
                return (Thread.random);
            }

            return (Thread.mono);
        }

        private bool checkInputFilled()
        {
            if (this.txtNom.Text == "" || this.numPriorite.Value == 0  || this.numNbInstructCalc.Value == 0 || this.numNbInstructES.Value == 0 || this.numNbCycle.Value == 0)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Processus currentProcessus = new Processus(this.lstProcessus.Count(), this.txtNom.Text, this.numPriorite.Value, this.numNbInstructCalc.Value, this.numNbInstructES.Value, this.numNbCycle.Value, this.nbThread());
            if (this.checkInputFilled())
            {
                this.lstProcessus.Add(currentProcessus);
                this.Close();
            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
