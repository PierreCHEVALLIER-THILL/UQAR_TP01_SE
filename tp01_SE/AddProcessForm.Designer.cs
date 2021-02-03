namespace tp01_SE
{
    partial class AddProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPriorite = new System.Windows.Forms.Label();
            this.lblNbInstructCalc = new System.Windows.Forms.Label();
            this.lblNbInstructES = new System.Windows.Forms.Label();
            this.lblNbCycle = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.numPriorite = new System.Windows.Forms.NumericUpDown();
            this.numNbCycle = new System.Windows.Forms.NumericUpDown();
            this.numNbInstructES = new System.Windows.Forms.NumericUpDown();
            this.numNbInstructCalc = new System.Windows.Forms.NumericUpDown();
            this.gbThread = new System.Windows.Forms.GroupBox();
            this.rdBtn3Thread = new System.Windows.Forms.RadioButton();
            this.rdBtn2Thread = new System.Windows.Forms.RadioButton();
            this.rdBtnMono = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPriorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbInstructES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbInstructCalc)).BeginInit();
            this.gbThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(256, 34);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Location = new System.Drawing.Point(242, 82);
            this.lblPriorite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(66, 20);
            this.lblPriorite.TabIndex = 1;
            this.lblPriorite.Text = "Priorité :";
            this.lblPriorite.Click += new System.EventHandler(this.lblPriorite_Click);
            // 
            // lblNbInstructCalc
            // 
            this.lblNbInstructCalc.AutoSize = true;
            this.lblNbInstructCalc.Location = new System.Drawing.Point(68, 136);
            this.lblNbInstructCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbInstructCalc.Name = "lblNbInstructCalc";
            this.lblNbInstructCalc.Size = new System.Drawing.Size(236, 20);
            this.lblNbInstructCalc.TabIndex = 2;
            this.lblNbInstructCalc.Text = "Nombre d\'instructions de calcul :";
            // 
            // lblNbInstructES
            // 
            this.lblNbInstructES.AutoSize = true;
            this.lblNbInstructES.Location = new System.Drawing.Point(32, 189);
            this.lblNbInstructES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbInstructES.Name = "lblNbInstructES";
            this.lblNbInstructES.Size = new System.Drawing.Size(275, 20);
            this.lblNbInstructES.TabIndex = 3;
            this.lblNbInstructES.Text = "Nombre d\'instructions d\'entrée/sortie :";
            // 
            // lblNbCycle
            // 
            this.lblNbCycle.AutoSize = true;
            this.lblNbCycle.Location = new System.Drawing.Point(18, 239);
            this.lblNbCycle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbCycle.Name = "lblNbCycle";
            this.lblNbCycle.Size = new System.Drawing.Size(286, 20);
            this.lblNbCycle.TabIndex = 4;
            this.lblNbCycle.Text = "Nombre de cycle(s) avant l\'initialisation :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(324, 29);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 26);
            this.txtNom.TabIndex = 5;
            // 
            // numPriorite
            // 
            this.numPriorite.Location = new System.Drawing.Point(324, 80);
            this.numPriorite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPriorite.Name = "numPriorite";
            this.numPriorite.Size = new System.Drawing.Size(150, 26);
            this.numPriorite.TabIndex = 10;
            // 
            // numNbCycle
            // 
            this.numNbCycle.Location = new System.Drawing.Point(324, 235);
            this.numNbCycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNbCycle.Name = "numNbCycle";
            this.numNbCycle.Size = new System.Drawing.Size(150, 26);
            this.numNbCycle.TabIndex = 11;
            // 
            // numNbInstructES
            // 
            this.numNbInstructES.Location = new System.Drawing.Point(324, 186);
            this.numNbInstructES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNbInstructES.Name = "numNbInstructES";
            this.numNbInstructES.Size = new System.Drawing.Size(150, 26);
            this.numNbInstructES.TabIndex = 12;
            // 
            // numNbInstructCalc
            // 
            this.numNbInstructCalc.Location = new System.Drawing.Point(324, 134);
            this.numNbInstructCalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNbInstructCalc.Name = "numNbInstructCalc";
            this.numNbInstructCalc.Size = new System.Drawing.Size(150, 26);
            this.numNbInstructCalc.TabIndex = 13;
            // 
            // gbThread
            // 
            this.gbThread.Controls.Add(this.rdBtn3Thread);
            this.gbThread.Controls.Add(this.rdBtn2Thread);
            this.gbThread.Controls.Add(this.rdBtnMono);
            this.gbThread.Location = new System.Drawing.Point(22, 302);
            this.gbThread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbThread.Name = "gbThread";
            this.gbThread.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbThread.Size = new System.Drawing.Size(451, 155);
            this.gbThread.TabIndex = 14;
            this.gbThread.TabStop = false;
            this.gbThread.Text = "Thread";
            // 
            // rdBtn3Thread
            // 
            this.rdBtn3Thread.AutoSize = true;
            this.rdBtn3Thread.Location = new System.Drawing.Point(28, 111);
            this.rdBtn3Thread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtn3Thread.Name = "rdBtn3Thread";
            this.rdBtn3Thread.Size = new System.Drawing.Size(101, 24);
            this.rdBtn3Thread.TabIndex = 2;
            this.rdBtn3Thread.TabStop = true;
            this.rdBtn3Thread.Text = "3 threads";
            this.rdBtn3Thread.UseVisualStyleBackColor = true;
            // 
            // rdBtn2Thread
            // 
            this.rdBtn2Thread.AutoSize = true;
            this.rdBtn2Thread.Location = new System.Drawing.Point(28, 75);
            this.rdBtn2Thread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtn2Thread.Name = "rdBtn2Thread";
            this.rdBtn2Thread.Size = new System.Drawing.Size(101, 24);
            this.rdBtn2Thread.TabIndex = 1;
            this.rdBtn2Thread.TabStop = true;
            this.rdBtn2Thread.Text = "2 threads";
            this.rdBtn2Thread.UseVisualStyleBackColor = true;
            // 
            // rdBtnMono
            // 
            this.rdBtnMono.AutoSize = true;
            this.rdBtnMono.Checked = true;
            this.rdBtnMono.Location = new System.Drawing.Point(28, 39);
            this.rdBtnMono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtnMono.Name = "rdBtnMono";
            this.rdBtnMono.Size = new System.Drawing.Size(125, 24);
            this.rdBtnMono.TabIndex = 0;
            this.rdBtnMono.TabStop = true;
            this.rdBtnMono.Text = "Mono-thread";
            this.rdBtnMono.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(246, 497);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(368, 497);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(112, 35);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // AddProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 548);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbThread);
            this.Controls.Add(this.numNbInstructCalc);
            this.Controls.Add(this.numNbInstructES);
            this.Controls.Add(this.numNbCycle);
            this.Controls.Add(this.numPriorite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNbCycle);
            this.Controls.Add(this.lblNbInstructES);
            this.Controls.Add(this.lblNbInstructCalc);
            this.Controls.Add(this.lblPriorite);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProcessForm";
            this.Text = "Ajout de Processus";
            ((System.ComponentModel.ISupportInitialize)(this.numPriorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbInstructES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbInstructCalc)).EndInit();
            this.gbThread.ResumeLayout(false);
            this.gbThread.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPriorite;
        private System.Windows.Forms.Label lblNbInstructCalc;
        private System.Windows.Forms.Label lblNbInstructES;
        private System.Windows.Forms.Label lblNbCycle;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.NumericUpDown numPriorite;
        private System.Windows.Forms.NumericUpDown numNbCycle;
        private System.Windows.Forms.NumericUpDown numNbInstructES;
        private System.Windows.Forms.NumericUpDown numNbInstructCalc;
        private System.Windows.Forms.GroupBox gbThread;
        private System.Windows.Forms.RadioButton rdBtn3Thread;
        private System.Windows.Forms.RadioButton rdBtn2Thread;
        private System.Windows.Forms.RadioButton rdBtnMono;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
    }
}