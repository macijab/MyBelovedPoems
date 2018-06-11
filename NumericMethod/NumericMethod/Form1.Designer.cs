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
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
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
            this.dgvX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.groupBox1.Controls.Add(this.lblY);
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
            this.groupBox1.Size = new System.Drawing.Size(483, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PktWejściowe";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(304, 203);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(195, 71);
            this.btnWczytaj.TabIndex = 12;
            this.btnWczytaj.Text = "wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Visible = false;
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
            this.btnDodaj.Location = new System.Drawing.Point(239, 150);
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvX,
            this.dgvY});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(250, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvX
            // 
            this.dgvX.HeaderText = "X";
            this.dgvX.Name = "dgvX";
            // 
            // dgvY
            // 
            this.dgvY.HeaderText = "Y";
            this.dgvY.Name = "dgvY";
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(22, 272);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 33);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(116, 272);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 33);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(359, 271);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 34);
            this.btnOblicz.TabIndex = 6;
            this.btnOblicz.Text = "oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colN,
            this.colCalka});
            this.dataGridView2.Location = new System.Drawing.Point(58, 311);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(399, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // colN
            // 
            this.colN.HeaderText = "N";
            this.colN.Name = "colN";
            // 
            // colCalka
            // 
            this.colCalka.HeaderText = "Calka";
            this.colCalka.Name = "colCalka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 523);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalka;
    }
}

