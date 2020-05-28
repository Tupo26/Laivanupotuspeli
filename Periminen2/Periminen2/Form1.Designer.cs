namespace Periminen2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlMeri = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKoordinaatit = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblViesti = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUpotetut = new System.Windows.Forms.Label();
            this.tmrAnimaatio = new System.Windows.Forms.Timer(this.components);
            this.pnlOmaMeri = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAmmu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMeri
            // 
            this.pnlMeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMeri.Location = new System.Drawing.Point(26, 28);
            this.pnlMeri.Name = "pnlMeri";
            this.pnlMeri.Size = new System.Drawing.Size(301, 301);
            this.pnlMeri.TabIndex = 0;
            this.pnlMeri.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMeri_Paint);
            this.pnlMeri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlMeri_MouseClick);
            this.pnlMeri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMeri_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koordinaatit";
            // 
            // lblKoordinaatit
            // 
            this.lblKoordinaatit.AutoSize = true;
            this.lblKoordinaatit.Location = new System.Drawing.Point(670, 54);
            this.lblKoordinaatit.Name = "lblKoordinaatit";
            this.lblKoordinaatit.Size = new System.Drawing.Size(22, 13);
            this.lblKoordinaatit.TabIndex = 2;
            this.lblKoordinaatit.Text = "0:0";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(670, 86);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(108, 13);
            this.lblAmmo.TabIndex = 3;
            this.lblAmmo.Text = "Ammuksia Käytetty: 0";
            // 
            // lblViesti
            // 
            this.lblViesti.AutoSize = true;
            this.lblViesti.Location = new System.Drawing.Point(670, 114);
            this.lblViesti.Name = "lblViesti";
            this.lblViesti.Size = new System.Drawing.Size(52, 13);
            this.lblViesti.TabIndex = 4;
            this.lblViesti.Text = "Ei osumia";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(667, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUpotetut
            // 
            this.lblUpotetut.AutoSize = true;
            this.lblUpotetut.Location = new System.Drawing.Point(670, 144);
            this.lblUpotetut.Name = "lblUpotetut";
            this.lblUpotetut.Size = new System.Drawing.Size(24, 13);
            this.lblUpotetut.TabIndex = 6;
            this.lblUpotetut.Text = "0/5";
            // 
            // tmrAnimaatio
            // 
            this.tmrAnimaatio.Enabled = true;
            this.tmrAnimaatio.Tick += new System.EventHandler(this.tmrAnimaatio_Tick);
            // 
            // pnlOmaMeri
            // 
            this.pnlOmaMeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlOmaMeri.Location = new System.Drawing.Point(350, 28);
            this.pnlOmaMeri.Name = "pnlOmaMeri";
            this.pnlOmaMeri.Size = new System.Drawing.Size(301, 301);
            this.pnlOmaMeri.TabIndex = 1;
            this.pnlOmaMeri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlOmaMeri_MouseClick);
            this.pnlOmaMeri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOmaMeri_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vihollismeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Oma meri";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(345, 332);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(141, 29);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "Sijoita laivat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Huom! Laivat eivät saa olla peräkkäin tai vierekkäin.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oikea hiiren korva kääntää laivan.";
            // 
            // lblAmmu
            // 
            this.lblAmmu.AutoSize = true;
            this.lblAmmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAmmu.Location = new System.Drawing.Point(43, 336);
            this.lblAmmu.Name = "lblAmmu";
            this.lblAmmu.Size = new System.Drawing.Size(249, 29);
            this.lblAmmu.TabIndex = 13;
            this.lblAmmu.Text = "Ammu vihollisen laivat";
            this.lblAmmu.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sininen = Ohi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Punainen = Osuma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Musta = Ohi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tikku-ukko = Osui ja upposi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 435);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAmmu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlOmaMeri);
            this.Controls.Add(this.lblUpotetut);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblViesti);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblKoordinaatit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKoordinaatit;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblViesti;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblUpotetut;
        private System.Windows.Forms.Timer tmrAnimaatio;
        private System.Windows.Forms.Panel pnlOmaMeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAmmu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

