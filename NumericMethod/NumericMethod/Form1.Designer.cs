namespace NumericMethod
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.losujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wpiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortuj = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.nudIle = new System.Windows.Forms.NumericUpDown();
            this.lblIle = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblZakres = new System.Windows.Forms.Label();
            this.nudDo = new System.Windows.Forms.NumericUpDown();
            this.nudOd = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtWynikCalkowania = new System.Windows.Forms.TextBox();
            this.lblWynikCalkowania = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLiczbaPrzedziałow = new System.Windows.Forms.Label();
            this.nudLP = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losujToolStripMenuItem,
            this.wczytajZPlikuToolStripMenuItem,
            this.wpiszToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // losujToolStripMenuItem
            // 
            this.losujToolStripMenuItem.Name = "losujToolStripMenuItem";
            this.losujToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.losujToolStripMenuItem.Text = "Losuj";
            this.losujToolStripMenuItem.Click += new System.EventHandler(this.losujToolStripMenuItem_Click);
            // 
            // wczytajZPlikuToolStripMenuItem
            // 
            this.wczytajZPlikuToolStripMenuItem.Name = "wczytajZPlikuToolStripMenuItem";
            this.wczytajZPlikuToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.wczytajZPlikuToolStripMenuItem.Text = "Wczytaj z Pliku";
            this.wczytajZPlikuToolStripMenuItem.Click += new System.EventHandler(this.wczytajZPlikuToolStripMenuItem_Click);
            // 
            // wpiszToolStripMenuItem
            // 
            this.wpiszToolStripMenuItem.Name = "wpiszToolStripMenuItem";
            this.wpiszToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.wpiszToolStripMenuItem.Text = "Wpisz";
            this.wpiszToolStripMenuItem.Click += new System.EventHandler(this.wpiszToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSortuj);
            this.groupBox1.Controls.Add(this.btnWyczysc);
            this.groupBox1.Controls.Add(this.btnWczytaj);
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnLosuj);
            this.groupBox1.Controls.Add(this.nudIle);
            this.groupBox1.Controls.Add(this.lblIle);
            this.groupBox1.Controls.Add(this.lblDo);
            this.groupBox1.Controls.Add(this.lblOd);
            this.groupBox1.Controls.Add(this.lblZakres);
            this.groupBox1.Controls.Add(this.nudDo);
            this.groupBox1.Controls.Add(this.nudOd);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PktWejściowe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSortuj
            // 
            this.btnSortuj.Location = new System.Drawing.Point(236, 370);
            this.btnSortuj.Name = "btnSortuj";
            this.btnSortuj.Size = new System.Drawing.Size(83, 31);
            this.btnSortuj.TabIndex = 14;
            this.btnSortuj.Text = "Sortuj";
            this.btnSortuj.UseVisualStyleBackColor = true;
            this.btnSortuj.Click += new System.EventHandler(this.btnSortuj_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(120, 369);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(75, 32);
            this.btnWyczysc.TabIndex = 13;
            this.btnWyczysc.Text = "Wyczysc";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(403, 195);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(195, 71);
            this.btnWczytaj.TabIndex = 12;
            this.btnWczytaj.Text = "wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Visible = false;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(24, 369);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 33);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(440, 98);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 17);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y";
            this.lblY.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(445, 43);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(417, 195);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 71);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj pkt";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(412, 195);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(178, 71);
            this.btnLosuj.TabIndex = 8;
            this.btnLosuj.Text = "Losuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Visible = false;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // nudIle
            // 
            this.nudIle.Location = new System.Drawing.Point(470, 146);
            this.nudIle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIle.Name = "nudIle";
            this.nudIle.Size = new System.Drawing.Size(120, 22);
            this.nudIle.TabIndex = 7;
            this.nudIle.Visible = false;
            // 
            // lblIle
            // 
            this.lblIle.AutoSize = true;
            this.lblIle.Location = new System.Drawing.Point(440, 148);
            this.lblIle.Name = "lblIle";
            this.lblIle.Size = new System.Drawing.Size(22, 17);
            this.lblIle.TabIndex = 6;
            this.lblIle.Text = "ile";
            this.lblIle.Visible = false;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(440, 98);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 17);
            this.lblDo.TabIndex = 5;
            this.lblDo.Text = "do";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(440, 43);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 17);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "od";
            // 
            // lblZakres
            // 
            this.lblZakres.AutoSize = true;
            this.lblZakres.Location = new System.Drawing.Point(429, 18);
            this.lblZakres.Name = "lblZakres";
            this.lblZakres.Size = new System.Drawing.Size(116, 17);
            this.lblZakres.TabIndex = 3;
            this.lblZakres.Text = "Wprowadź Dane:";
            this.lblZakres.Visible = false;
            // 
            // nudDo
            // 
            this.nudDo.DecimalPlaces = 4;
            this.nudDo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudDo.Location = new System.Drawing.Point(470, 96);
            this.nudDo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDo.Name = "nudDo";
            this.nudDo.Size = new System.Drawing.Size(120, 22);
            this.nudDo.TabIndex = 2;
            this.nudDo.Visible = false;
            // 
            // nudOd
            // 
            this.nudOd.DecimalPlaces = 4;
            this.nudOd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudOd.Location = new System.Drawing.Point(470, 38);
            this.nudOd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudOd.Name = "nudOd";
            this.nudOd.Size = new System.Drawing.Size(120, 22);
            this.nudOd.TabIndex = 1;
            this.nudOd.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnOblicz
            // 
            this.btnOblicz.AutoSize = true;
            this.btnOblicz.Location = new System.Drawing.Point(18, 27);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(141, 87);
            this.btnOblicz.TabIndex = 6;
            this.btnOblicz.Text = "oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtWynikCalkowania
            // 
            this.txtWynikCalkowania.Location = new System.Drawing.Point(343, 116);
            this.txtWynikCalkowania.Name = "txtWynikCalkowania";
            this.txtWynikCalkowania.Size = new System.Drawing.Size(146, 22);
            this.txtWynikCalkowania.TabIndex = 3;
            // 
            // lblWynikCalkowania
            // 
            this.lblWynikCalkowania.AutoSize = true;
            this.lblWynikCalkowania.Location = new System.Drawing.Point(192, 116);
            this.lblWynikCalkowania.Name = "lblWynikCalkowania";
            this.lblWynikCalkowania.Size = new System.Drawing.Size(121, 17);
            this.lblWynikCalkowania.TabIndex = 4;
            this.lblWynikCalkowania.Text = "Wynik Całkowania";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLiczbaPrzedziałow);
            this.groupBox2.Controls.Add(this.nudLP);
            this.groupBox2.Controls.Add(this.btnOblicz);
            this.groupBox2.Controls.Add(this.lblWynikCalkowania);
            this.groupBox2.Controls.Add(this.txtWynikCalkowania);
            this.groupBox2.Location = new System.Drawing.Point(28, 547);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyniki";
            // 
            // lblLiczbaPrzedziałow
            // 
            this.lblLiczbaPrzedziałow.AutoSize = true;
            this.lblLiczbaPrzedziałow.Location = new System.Drawing.Point(192, 27);
            this.lblLiczbaPrzedziałow.Name = "lblLiczbaPrzedziałow";
            this.lblLiczbaPrzedziałow.Size = new System.Drawing.Size(127, 17);
            this.lblLiczbaPrzedziałow.TabIndex = 8;
            this.lblLiczbaPrzedziałow.Text = "Liczba przedziałów";
            // 
            // nudLP
            // 
            this.nudLP.Location = new System.Drawing.Point(343, 27);
            this.nudLP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLP.Name = "nudLP";
            this.nudLP.Size = new System.Drawing.Size(146, 22);
            this.nudLP.TabIndex = 7;
            this.nudLP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem losujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wpiszToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.NumericUpDown nudIle;
        private System.Windows.Forms.Label lblIle;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblZakres;
        private System.Windows.Forms.NumericUpDown nudDo;
        private System.Windows.Forms.NumericUpDown nudOd;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtWynikCalkowania;
        private System.Windows.Forms.Label lblWynikCalkowania;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLiczbaPrzedziałow;
        private System.Windows.Forms.NumericUpDown nudLP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSortuj;
    }
}

