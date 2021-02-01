using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp01_SE
{
    public partial class PrincipalForm : Form
    {
        public List<Processus> lstProcessus;
        public PrincipalForm()
        {
            InitializeComponent();
            this.lstProcessus = new List<Processus>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue sur l'outil: Ordonnanceur\n" +
                            "Version: Beta\n" +
                            "Author: Bétil Charlotte & Chevallier Pierre\n" +
                            "Organisation: UQAR\n");

        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(4%1);
            MessageBox.Show("Lancement de la simulation");
            //Algo principale
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Ajout");
            Form form = new AddProcessForm(ref this.lstProcessus);
            form.ShowDialog();
            this.displayLstThread();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Form form = new SupProcessForm(ref this.lstProcessus);
            form.ShowDialog();
        }

        private void displayLstThread()
        {
            this.lstRAM.BeginUpdate();
            //Je clear les items de la listBox, pour pas que ça reécrive le process précedant
            this.lstRAM.Items.Clear();            
            tblRAM.Controls.Clear();
            tblRAM.RowCount = 1;
            tblRAM.ColumnCount = 0;
            Debug.WriteLine("Affichage des threads: nbProcess:" + this.lstProcessus.Count());
            foreach (Processus process in this.lstProcessus)
            {
                tblRAM.RowCount = 1;
                Debug.WriteLine("nbThread: " + process.getThreads().Count());
                foreach(Thread thread in process.getThreads())
                {
                    this.lstRAM.Items.Add(thread.getInfoThread());
                    tblRAM.ColumnCount++;
                    tblRAM.RowCount = 1;                                                   
                    //Ajouter un rowstyle
                    tblRAM.RowStyles.Add(new RowStyle(SizeType.Absolute));
                    //Ajouter une ligne
                    Label lbl = new Label();
                    lbl.Height = 70;
                    lbl.Text = thread.getInfoThread();
                    tblRAM.Controls.Add(lbl, tblRAM.ColumnCount - 1, tblRAM.RowCount - 1);                                   
                    foreach (string instruct in thread.getInstructions())
                    {                        
                        this.lstRAM.Items.Add(instruct);                        
                        tblRAM.RowCount++;
                        Label lbl2 = new Label();
                        lbl2.Height = 25;
                        lbl2.Text = instruct;
                        tblRAM.Controls.Add(lbl2, tblRAM.ColumnCount - 1, tblRAM.RowCount - 1);                                         
                    }
                }
                TableLayoutRowStyleCollection styles = tblRAM.RowStyles;
                foreach (RowStyle style in styles)
                {
                    if (style.SizeType == SizeType.Absolute)
                    {
                        style.Height = 30;
                    }
                    else
                    {
                        style.Height = 100;
                    }
                }
            }
            this.lstRAM.EndUpdate();
        }

        private void lstRAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
