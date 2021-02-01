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
            this.rdBtn1et3Thread = new System.Windows.Forms.RadioButton();
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
            this.lblNom.Location = new System.Drawing.Point(228, 27);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPriorite
            // 
            this.lblPriorite.AutoSize = true;
            this.lblPriorite.Location = new System.Drawing.Point(215, 66);
            this.lblPriorite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriorite.Name = "lblPriorite";
            this.lblPriorite.Size = new System.Drawing.Size(61, 17);
            this.lblPriorite.TabIndex = 1;
            this.lblPriorite.Text = "Priorité :";
            this.lblPriorite.Click += new System.EventHandler(this.lblPriorite_Click);
            // 
            // lblNbInstructCalc
            // 
            this.lblNbInstructCalc.AutoSize = true;
            this.lblNbInstructCalc.Location = new System.Drawing.Point(60, 109);
            this.lblNbInstructCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbInstructCalc.Name = "lblNbInstructCalc";
            this.lblNbInstructCalc.Size = new System.Drawing.Size(213, 17);
            this.lblNbInstructCalc.TabIndex = 2;
            this.lblNbInstructCalc.Text = "Nombre d\'instructions de calcul :";
            // 
            // lblNbInstructES
            // 
            this.lblNbInstructES.AutoSize = true;
            this.lblNbInstructES.Location = new System.Drawing.Point(28, 151);
            this.lblNbInstructES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbInstructES.Name = "lblNbInstructES";
            this.lblNbInstructES.Size = new System.Drawing.Size(248, 17);
            this.lblNbInstructES.TabIndex = 3;
            this.lblNbInstructES.Text = "Nombre d\'instructions d\'entrée/sortie :";
            // 
            // lblNbCycle
            // 
            this.lblNbCycle.AutoSize = true;
            this.lblNbCycle.Location = new System.Drawing.Point(16, 191);
            this.lblNbCycle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbCycle.Name = "lblNbCycle";
            this.lblNbCycle.Size = new System.Drawing.Size(261, 17);
            this.lblNbCycle.TabIndex = 4;
            this.lblNbCycle.Text = "Nombre de cycle(s) avant l\'initialisation :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(288, 23);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 22);
            this.txtNom.TabIndex = 5;
            // 
            // numPriorite
            // 
            this.numPriorite.Location = new System.Drawing.Point(288, 64);
            this.numPriorite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPriorite.Name = "numPriorite";
            this.numPriorite.Size = new System.Drawing.Size(133, 22);
            this.numPriorite.TabIndex = 10;
            // 
            // numNbCycle
            // 
            this.numNbCycle.Location = new System.Drawing.Point(288, 188);
            this.numNbCycle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbCycle.Name = "numNbCycle";
            this.numNbCycle.Size = new System.Drawing.Size(133, 22);
            this.numNbCycle.TabIndex = 11;
            // 
            // numNbInstructES
            // 
            this.numNbInstructES.Location = new System.Drawing.Point(288, 149);
            this.numNbInstructES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbInstructES.Name = "numNbInstructES";
            this.numNbInstructES.Size = new System.Drawing.Size(133, 22);
            this.numNbInstructES.TabIndex = 12;
            // 
            // numNbInstructCalc
            // 
            this.numNbInstructCalc.Location = new System.Drawing.Point(288, 107);
            this.numNbInstructCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbInstructCalc.Name = "numNbInstructCalc";
            this.numNbInstructCalc.Size = new System.Drawing.Size(133, 22);
            this.numNbInstructCalc.TabIndex = 13;
            // 
            // gbThread
            // 
            this.gbThread.Controls.Add(this.rdBtn1et3Thread);
            this.gbThread.Controls.Add(this.rdBtn3Thread);
            this.gbThread.Controls.Add(this.rdBtn2Thread);
            this.gbThread.Controls.Add(this.rdBtnMono);
            this.gbThread.Location = new System.Drawing.Point(20, 234);
            this.gbThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbThread.Name = "gbThread";
            this.gbThread.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbThread.Size = new System.Drawing.Size(401, 159);
            this.gbThread.TabIndex = 14;
            this.gbThread.TabStop = false;
            this.gbThread.Text = "Thread";
            // 
            // rdBtn1et3Thread
            // 
            this.rdBtn1et3Thread.AutoSize = true;
            this.rdBtn1et3Thread.Location = new System.Drawing.Point(25, 126);
            this.rdBtn1et3Thread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtn1et3Thread.Name = "rdBtn1et3Thread";
            this.rdBtn1et3Thread.Size = new System.Drawing.Size(155, 21);
            this.rdBtn1et3Thread.TabIndex = 3;
            this.rdBtn1et3Thread.TabStop = true;
            this.rdBtn1et3Thread.Text = "Entre 1 et 3 threads";
            this.rdBtn1et3Thread.UseVisualStyleBackColor = true;
            // 
            // rdBtn3Thread
            // 
            this.rdBtn3Thread.AutoSize = true;
            this.rdBtn3Thread.Location = new System.Drawing.Point(25, 97);
            this.rdBtn3Thread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtn3Thread.Name = "rdBtn3Thread";
            this.rdBtn3Thread.Size = new System.Drawing.Size(89, 21);
            this.rdBtn3Thread.TabIndex = 2;
            this.rdBtn3Thread.TabStop = true;
            this.rdBtn3Thread.Text = "3 threads";
            this.rdBtn3Thread.UseVisualStyleBackColor = true;
            // 
            // rdBtn2Thread
            // 
            this.rdBtn2Thread.AutoSize = true;
            this.rdBtn2Thread.Location = new System.Drawing.Point(25, 68);
            this.rdBtn2Thread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtn2Thread.Name = "rdBtn2Thread";
            this.rdBtn2Thread.Size = new System.Drawing.Size(89, 21);
            this.rdBtn2Thread.TabIndex = 1;
            this.rdBtn2Thread.TabStop = true;
            this.rdBtn2Thread.Text = "2 threads";
            this.rdBtn2Thread.UseVisualStyleBackColor = true;
            // 
            // rdBtnMono
            // 
            this.rdBtnMono.AutoSize = true;
            this.rdBtnMono.Location = new System.Drawing.Point(25, 39);
            this.rdBtnMono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBtnMono.Name = "rdBtnMono";
            this.rdBtnMono.Size = new System.Drawing.Size(110, 21);
            this.rdBtnMono.TabIndex = 0;
            this.rdBtnMono.TabStop = true;
            this.rdBtnMono.Text = "Mono-thread";
            this.rdBtnMono.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(219, 412);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(327, 412);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // AddProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 455);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton rdBtn1et3Thread;
        private System.Windows.Forms.RadioButton rdBtn3Thread;
        private System.Windows.Forms.RadioButton rdBtn2Thread;
        private System.Windows.Forms.RadioButton rdBtnMono;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
    }
}