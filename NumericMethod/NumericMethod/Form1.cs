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
        Random r1 = new Random();
        List<Punkt> funkcja = new List<Punkt>();
        private DataTable zestawFunkcji = null;
        public Form1()
        {

            InitializeComponent();
            
        }
        private void UpdateGrid()
        {
            if (funkcja.Count != 0)
            {
                zestawFunkcji = new DataTable("Punkty Funkcji");//1. Utwórz obiekt klasy DataTable
                DataColumn x = new DataColumn("x");// utworzenie kolumny na argumenty
                DataColumn y = new DataColumn("y");
                zestawFunkcji.Columns.Add(x);    //3. Dodanie kolumny do tabeli danych
                zestawFunkcji.Columns.Add(y);

                foreach (Punkt p in funkcja)//4. Wykonaj iteracje po elementach listy aby utworzyć wiersze: (Dla obiektów p klasy Punkt w kolekcji cars)
                {
                    DataRow wiersz; //wiersz rekordem danych pojazdu
                    wiersz = zestawFunkcji.NewRow();
                    wiersz["x"] = p.getX();
                    wiersz["y"] = p.getY();
                    zestawFunkcji.Rows.Add(wiersz);//Dodanie wiersza (tzn. rekord danych do ewidencji:
                }

                dataGridView1.DataSource = zestawFunkcji;//5. Przypisz tą tablicę danych do kontrolki dataGridView1:
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
            double od = Convert.ToDouble(Nud1.Value);
            double doo = Convert.ToDouble(nud2.Value);
            Double a = 0;
            Double b = 0;
            Punkt p1 = new Punkt(a, b);
            if (funkcja.Count != 0)
            {
                funkcja.Clear(); //czyści listę cars
            }
            if (zestawFunkcji != null)
            {
                zestawFunkcji.Clear(); //czyści tablicę ewidencja
            }
            if (funkcja.Count == 0)
            {
                a = (r1.NextDouble() * (doo - od)) + od;
                b = (r1.NextDouble() * (doo - od)) + od;
                p1.setXY(a, b);
                funkcja.Add(p1);
            }
            else
            {
                while (Convert.ToInt32(nudIle.Value) > funkcja.Count)
                {
                    a = (r1.NextDouble() * (doo - od)) + od;
                    foreach (Punkt p2 in funkcja)
                    {
                        if (p2.getX() == a)
                        {
                            continue;
                        }

                    }
                    b = (r1.NextDouble() * (doo - od)) + od;
                    p1.setXY(a, b);
                    funkcja.Add(item: p1);
                }
                UpdateGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWczytaj_Click(object sender, EventArgs e) //wczytywanie z pliku
        {
            if (funkcja != null)
            {
                funkcja.Clear(); //czyści listę funkcja
            }
            if (zestawFunkcji != null)
            {
                zestawFunkcji.Clear(); //czyści tablicę zestawFunkcji
            }
            string[] rekord = new string[2]; //rekord danych zapisanych w wierszu pliku
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Czytaj kolejne wiersze pliku i zapisuj je do kolekcji funkcja:
                foreach (string line in File.ReadLines(openFileDialog1.FileName))
                {
                    rekord = line.Split(','); //przecinek rozdziela dane w wierszu
                    if (funkcja.Count == 0) {
                        funkcja.Add(new Punkt(Convert.ToDouble(rekord[0]), Convert.ToDouble(rekord[1])));
                    }
                    else
                    {
                        foreach (Punkt punkt in funkcja)
                        {
                            if (punkt.getX() == Convert.ToDouble(rekord[0]))
                            {
                                MessageBox.Show("To nie jest funkcja");
                                return;
                            }
                        }
                        funkcja.Add(new Punkt(Convert.ToDouble(rekord[0]), Convert.ToDouble(rekord[1])));
                    }
                }
                UpdateGrid(); //uaktualnij tabelę
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)//dodawanie nowego punktu
        {
            Punkt p1 = new Punkt(Convert.ToDouble(Nud1.Value), Convert.ToDouble(nud2.Value));
            foreach (Punkt punkt in funkcja)
            {
                if (p1.getX() == punkt.getX())
                {
                    MessageBox.Show("Nie może być dwóch takich samych argumentów");
                    return;
                }
            }
            funkcja.Add(p1);
            UpdateGrid();
        }
        public double getSX()
        {
            int i = dataGridView1.CurrentRow.Index;
            return funkcja[i].getX();
        }
        public double getSY()
        {
            int i = dataGridView1.CurrentRow.Index;
            return funkcja[i].getY();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
          /*  Form2 d = new Form2();
            d.ShowDialog();//
            int i = dataGridView1.CurrentRow.Index;
            if (d.ShowDialog() == DialogResult.OK)
            {
                funkcja.RemoveAt(i);
                funkcja.Add(d.p11);
            }*/
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            int j = dataGridView1.CurrentCell.ColumnIndex;
            funkcja.RemoveAt(i); //usunie punktu z kolekcji
            UpdateGrid(); //zaktualizuje wyświetlanie kolekcji
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            funkcja.Clear(); //czyści listę punktów funkcji
            zestawFunkcji.Clear(); //czyści tablicę ewidencja
        }

        private void btnSortuj_Click(object sender, EventArgs e)
        {
            Punkt bufor = new Punkt(0.0,0.0);
            for(int i = 1; i < funkcja.Count-1; i++)
            {
                for(int j = funkcja.Count-1; j > 1; j--)
                {
                    if(funkcja[j].getX() < funkcja[j - 1].getX())
                    {
                        bufor = funkcja[j];
                        funkcja[j - 1] = funkcja[j];
                        funkcja[j] = bufor;
                    }
                }
            }
            UpdateGrid();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            Całka c1 = new Całka();
            if (nudLP.Value != 0)
            {
                c1.setLP(Convert.ToInt32(nudLP.Value));
            }
            else
            {
                MessageBox.Show("liczba przedziałów musi być większa od 0");
                return;
            }
            double suma =0;
            c1.setWynik(0);
            for(int i = 0; i <= funkcja.Count - 2; i++)
            {
               suma += c1.metodaTrapezów(funkcja[i].getX(), funkcja[i + 1].getX(), funkcja[i].getY(),funkcja[i+1].getY());
            }
            c1.setWynik(suma);
            txtWynikCalkowania.Text = Convert.ToString(c1.getWynik());
        }
    }
}