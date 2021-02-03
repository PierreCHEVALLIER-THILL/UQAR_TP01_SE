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
        Color[,] bgColors;
        Boolean bgColorsOk = false;

    //    Color[,] bgColors = new Color[2, 8] {
    //{ SystemColors.Control, SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control, SystemColors.Control },
    //{ SystemColors.Control, SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control,SystemColors.Control, SystemColors.Control }
    //    };

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
            /*
            foreach (Processus process in lstProcessus)
            {
                //Algo test
                lstProcessus.First().getThreads().First().getInstructions().First().Etat = Enums.etat.EnCours.ToString();
                updateCouleur();
                System.Threading.Thread.Sleep(3000);
                lstProcessus.First().getThreads().First().getInstructions().First().Etat = Enums.etat.Termine.ToString();
                lstProcessus.First().getThreads().First().getInstructions()[2].Etat = Enums.etat.EnCours.ToString();
                updateCouleur();
                System.Threading.Thread.Sleep(3000);
                lstProcessus.First().getThreads().First().getInstructions()[2].Etat = Enums.etat.Termine.ToString();
                updateCouleur();
            } */
            lstProcessus.First().getThreads().First().getInstructions().First().Etat = Enums.etat.EnCours;
            updateCouleur();
            System.Threading.Thread.Sleep(3000);
            lstProcessus.First().getThreads().First().getInstructions().First().Etat = Enums.etat.Termine;
            lstProcessus.First().getThreads().First().getInstructions()[2].Etat = Enums.etat.EnCours;
            updateCouleur();
            System.Threading.Thread.Sleep(3000);
            lstProcessus.First().getThreads().First().getInstructions()[2].Etat = Enums.etat.Termine;
            updateCouleur();

            lstProcessus[1].getThreads().First().getInstructions().First().Etat = Enums.etat.EnCours;
            updateCouleur();
            System.Threading.Thread.Sleep(3000);
            lstProcessus[1].getThreads().First().getInstructions().First().Etat = Enums.etat.Termine;
            lstProcessus[1].getThreads().First().getInstructions()[3].Etat = Enums.etat.EnCours;
            updateCouleur();
            System.Threading.Thread.Sleep(3000);
            lstProcessus[1].getThreads().First().getInstructions()[3].Etat = Enums.etat.Termine;
            updateCouleur();



        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Form form = new AddProcessForm(ref this.lstProcessus);
            form.ShowDialog();
            this.displayLstThread();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            Form form = new SupProcessForm(ref this.lstProcessus);
            form.ShowDialog();
            this.displayLstThread();
        }

        private void displayLstThread()
        {
            this.lstRAM.BeginUpdate();
            //Je clear les items de la listBox, pour pas que ça reécrive le process précedant
            this.lstRAM.Items.Clear();            
            tblRAM.Controls.Clear();
            tblRAM.RowCount = 1;
            tblRAM.ColumnCount = 0;
            foreach (Processus process in this.lstProcessus)
            {
                tblRAM.RowCount = 1;
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
                    lbl.BackColor = Color.Transparent;
                    lbl.Text = thread.getInfoThread();
                    tblRAM.Controls.Add(lbl, tblRAM.ColumnCount - 1, tblRAM.RowCount - 1);                                   
                    foreach (Instruction instruct in thread.getInstructions())
                    {                        
                        this.lstRAM.Items.Add(instruct);                        
                        tblRAM.RowCount++;
                        Label lbl2 = new Label();
                        lbl2.Height = 25;
                        lbl2.BackColor = Color.Transparent;
                        lbl2.Text = instruct.Type.ToString();
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

            createCellColor(tblRAM.ColumnCount, tblRAM.RowCount);
        }
        private void createCellColor(int column, int row)
        {
            bgColors = new Color[column, row];
            for (int i = 0; i < column; i++)
            {
                
                for (int y = 0; y < row; y++)
                {
                    bgColors[i, y] = SystemColors.Control;
                }
                
            }
            bgColorsOk = true;
            tblRAM.Refresh();
            bgColorsOk = false;



        }
        private void lstRAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntestcouleur_Click(object sender, EventArgs e)
        {

            bgColors[0, 2] = Color.Red;
            tblRAM.Refresh();
        }

        private void tblRAM_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //createCellColor(tblRAM.ColumnCount, tblRAM.RowCount);
            if (bgColorsOk == true)
            {
                using (var b = new SolidBrush(bgColors[e.Column, e.Row]))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }

            }

        }

        private void updateCouleur()
        {

            int column = 0;
            foreach (Processus process in lstProcessus)
            {
                
                foreach (Thread thread in process.getThreads())
                {
                    int row = 1;
                    foreach (Instruction instruction in thread.getInstructions())
                    {
                        
                        if (instruction.Etat.Equals(Enums.etat.EnCours.ToString()))
                        {
                            bgColors[column, row] = Color.Red;
                            bgColorsOk = true;
                            tblRAM.Refresh();
                        }
                        if (instruction.Etat.Equals(Enums.etat.Termine.ToString()))
                        {
                            bgColors[column, row] = Color.LightGray;
                            bgColorsOk = true;
                            tblRAM.Refresh();
                        }
                        if (instruction.Etat.Equals(Enums.etat.Initialise.ToString()))
                        {
                            bgColors[column, row] = Color.Blue;
                            bgColorsOk = true;
                            tblRAM.Refresh();
                        }
                        row++;
                    }
                    column++;
                }
            }
            bgColorsOk = false;
        }
    }
}
