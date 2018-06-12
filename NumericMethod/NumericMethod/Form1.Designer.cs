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
            this.btnOblicz = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.nudIle = new System.Windows.Forms.NumericUpDown();
            this.lblIle = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblZakres = new System.Windows.Forms.Label();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.Nud1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtWynikCalkowania = new System.Windows.Forms.TextBox();
            this.lblWynikCalkowania = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDokladnosc = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(517, 28);
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
            this.groupBox1.Controls.Add(this.btnWczytaj);
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.btnEdytuj);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnLosuj);
            this.groupBox1.Controls.Add(this.nudIle);
            this.groupBox1.Controls.Add(this.lblIle);
            this.groupBox1.Controls.Add(this.lblDo);
            this.groupBox1.Controls.Add(this.lblOd);
            this.groupBox1.Controls.Add(this.lblZakres);
            this.groupBox1.Controls.Add(this.nud2);
            this.groupBox1.Controls.Add(this.Nud1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PktWejściowe";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(179, 55);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 34);
            this.btnOblicz.TabIndex = 6;
            this.btnOblicz.Text = "oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(284, 122);
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
            this.btnUsun.Location = new System.Drawing.Point(135, 241);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 33);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(283, 68);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 17);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y";
            this.lblY.Visible = false;
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(27, 241);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 33);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(283, 38);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(286, 122);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 71);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj pkt";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(286, 122);
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
            this.nudIle.Location = new System.Drawing.Point(337, 94);
            this.nudIle.Name = "nudIle";
            this.nudIle.Size = new System.Drawing.Size(120, 22);
            this.nudIle.TabIndex = 7;
            this.nudIle.Visible = false;
            // 
            // lblIle
            // 
            this.lblIle.AutoSize = true;
            this.lblIle.Location = new System.Drawing.Point(283, 96);
            this.lblIle.Name = "lblIle";
            this.lblIle.Size = new System.Drawing.Size(22, 17);
            this.lblIle.TabIndex = 6;
            this.lblIle.Text = "ile";
            this.lblIle.Visible = false;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(281, 68);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 17);
            this.lblDo.TabIndex = 5;
            this.lblDo.Text = "do";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(281, 40);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 17);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "od";
            // 
            // lblZakres
            // 
            this.lblZakres.AutoSize = true;
            this.lblZakres.Location = new System.Drawing.Point(360, 18);
            this.lblZakres.Name = "lblZakres";
            this.lblZakres.Size = new System.Drawing.Size(52, 17);
            this.lblZakres.TabIndex = 3;
            this.lblZakres.Text = "Zakres";
            this.lblZakres.Visible = false;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(337, 66);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 22);
            this.nud2.TabIndex = 2;
            this.nud2.Visible = false;
            // 
            // Nud1
            // 
            this.Nud1.Location = new System.Drawing.Point(337, 38);
            this.Nud1.Name = "Nud1";
            this.Nud1.Size = new System.Drawing.Size(120, 22);
            this.Nud1.TabIndex = 1;
            this.Nud1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(248, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtWynikCalkowania
            // 
            this.txtWynikCalkowania.Location = new System.Drawing.Point(236, 106);
            this.txtWynikCalkowania.Name = "txtWynikCalkowania";
            this.txtWynikCalkowania.Size = new System.Drawing.Size(146, 22);
            this.txtWynikCalkowania.TabIndex = 3;
            // 
            // lblWynikCalkowania
            // 
            this.lblWynikCalkowania.AutoSize = true;
            this.lblWynikCalkowania.Location = new System.Drawing.Point(56, 111);
            this.lblWynikCalkowania.Name = "lblWynikCalkowania";
            this.lblWynikCalkowania.Size = new System.Drawing.Size(121, 17);
            this.lblWynikCalkowania.TabIndex = 4;
            this.lblWynikCalkowania.Text = "Wynik Całkowania";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDokladnosc);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnOblicz);
            this.groupBox2.Controls.Add(this.lblWynikCalkowania);
            this.groupBox2.Controls.Add(this.txtWynikCalkowania);
            this.groupBox2.Location = new System.Drawing.Point(22, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyniki";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(300, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // lblDokladnosc
            // 
            this.lblDokladnosc.AutoSize = true;
            this.lblDokladnosc.Location = new System.Drawing.Point(56, 27);
            this.lblDokladnosc.Name = "lblDokladnosc";
            this.lblDokladnosc.Size = new System.Drawing.Size(82, 17);
            this.lblDokladnosc.TabIndex = 8;
            this.lblDokladnosc.Text = "Dokładność";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 523);
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
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown Nud1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtWynikCalkowania;
        private System.Windows.Forms.Label lblWynikCalkowania;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDokladnosc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

