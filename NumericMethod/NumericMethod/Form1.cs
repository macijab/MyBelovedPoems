using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //przestrzeń nazw dla kolekcji
using System.IO; //przestrzeń nazw dla operacji na plikach 

namespace NumericMethod
{
    public partial class Form1 : Form
    {
        private ArrayList funkcja = null;
        private DataTable zestawFunkcji = null;
        public Form1()
        {
            InitializeComponent();
            funkcja = new ArrayList();
        }

        private void UpdateGrid()
        {
            if (funkcja != null)
            { 
                zestawFunkcji = new DataTable("Punkty Funkcji");//1. Utwórz obiekt klasy DataTable
                DataColumn x = new DataColumn("x");// utworzenie kolumny na argumenty
                DataColumn y = new DataColumn("y");
            //3. Dodaj kolumny do tabeli danych
                zestawFunkcji.Columns.Add(x);
                zestawFunkcji.Columns.Add(y);
                //i analogicznie dodaj pozostałe kolumny
                //4. Wykonaj iteracje po elementach listy aby utworzyć wiersze:
                //(Dla obiektów c klasy Car w kolekcji cars)
                foreach (Punkt p in funkcja)
                {
                    DataRow wiersz; //wiersz rekordem danych pojazdu
                    wiersz = zestawFunkcji.NewRow();
                    wiersz["x"] = p.getX();
                    wiersz["y"] = p.getY();
                    //i analogicznie przypisz dane do pozostałych kolumn wiersza.
                    //Dodaj wiersz (tzn. rekord danych do ewidencji:
                    zestawFunkcji.Rows.Add(wiersz);
                }
                //5. Przypisz tą tablicę danych do kontrolki dataGridView1:
                dataGridView1.DataSource = zestawFunkcji;
            }
        }

        private void wczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnWczytaj.Visible = true;
            btnDodaj.Visible = false;
            btnLosuj.Visible = false;
            Nud1.Visible = false;
            nud2.Visible = false;
            nudIle.Visible = false;
            lblDo.Visible = false;
            lblIle.Visible = false;
            lblOd.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLosuj.Visible = true;
            lblZakres.Visible = true;
            Nud1.Visible = true;
            Nud1.Value = 0;
            nud2.Visible = true;
            nud2.Value = 10;
            nudIle.Visible = true;
            nudIle.Value = 10; 
            lblDo.Visible = true;
            lblIle.Visible = true;
            lblOd.Visible = true;
        }

        private void losujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLosuj.Visible = true;
            btnDodaj.Visible = false;
            btnWczytaj.Visible = false;
            Nud1.Visible = true;
            Nud1.Value = 0;
            nud2.Visible = true;
            nud2.Value = 10;
            nudIle.Visible = true;
            nudIle.Value = 10;
            lblDo.Visible = true;
            lblIle.Visible = true;
            lblOd.Visible = true;
            lblX.Visible = false;
            lblY.Visible = false;
        }

        private void wpiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLosuj.Visible = false;
            btnDodaj.Visible = true;
            btnWczytaj.Visible = false;
            Nud1.Visible = true;
            Nud1.Value = 0;
            nud2.Visible = true;
            nud2.Value = 0;
            nudIle.Visible = false;
            lblDo.Visible = false;
            lblIle.Visible = false;
            lblOd.Visible = false;
            lblX.Visible = true;
            lblY.Visible = true;
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();
            for(int i = 0; i < (int)nudIle.Value; i++)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
