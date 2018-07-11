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
        
        List<Punkt> funkcja = new List<Punkt>(); //Generowanie listy punktów, które symbolizują w naszym programie funckcje
        private DataTable tabelaNaFunkcje = null; //Użycie obiektu Data table, który słuzy do aktualizowania i wyświetlania wartości z listy Funkcja
        public Form1()
        {

            InitializeComponent();
            
        }
        private void UpdateGrid()// metoda służąca do aktualizacji DataGrida
        {
            if (funkcja != null)
            {
                tabelaNaFunkcje = new DataTable("Punkty Funkcji");//1. Utworzrenie obiektu klasy DataTable
                DataColumn x = new DataColumn("x");// utworzenie kolumny na argumenty
                DataColumn y = new DataColumn("y");
                tabelaNaFunkcje.Columns.Add(x);    //3. Dodanie kolumny do tabeli danych
                tabelaNaFunkcje.Columns.Add(y);

                foreach (Punkt p in funkcja)//4. Wykonanie iteracje po elementach listy aby utworzyć wiersze: (Dla obiektów p klasy Punkt w kolekcji funkcja)
                {
                    DataRow wiersz; //wiersz rekordem danych funkcji
                    wiersz = tabelaNaFunkcje.NewRow();
                    wiersz["x"] = p.getX();
                    wiersz["y"] = p.getY();
                    tabelaNaFunkcje.Rows.Add(wiersz);//Dodanie wiersza (tzn. rekord danych do ewidencji)
                }

                dataGridView1.DataSource = tabelaNaFunkcje;//5. Przypisanie tablicy danych do kontrolki dataGridView1:
            }
        }

        private void wczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e) // metoda słóżąca do dostosowania formatki do wczytywania z pliku
        {
            btnWczytaj.Visible = true;
            btnDodaj.Visible = false;
            btnLosuj.Visible = false;
            nudOd.Visible = false;
            nudDo.Visible = false;
            nudIle.Visible = false;
            lblDo.Visible = false;
            lblIle.Visible = false;
            lblOd.Visible = false;
            lblX.Visible = false;
            lblY.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e) //Ustawienie formatki domyślnej, w tym programowanie, na losowanie funkcji.
        {
            btnLosuj.Visible = true;
            lblZakres.Visible = true;
            nudOd.Visible = true;
            nudOd.Value = 0;
            nudDo.Visible = true;
            nudDo.Value = 10;
            nudIle.Visible = true;
            nudIle.Value = 10;
            lblDo.Visible = true;
            lblIle.Visible = true;
            lblOd.Visible = true;
        }

        private void losujToolStripMenuItem_Click(object sender, EventArgs e) //Metoda ustawiająca formularz na losowanie
        {
            btnLosuj.Visible = true;
            btnDodaj.Visible = false;
            btnWczytaj.Visible = false;
            nudOd.Visible = true;
            nudOd.Value = 0;
            nudDo.Visible = true;
            nudDo.Value = 10;
            nudIle.Visible = true;
            nudIle.Value = 10;
            lblDo.Visible = true;
            lblIle.Visible = true;
            lblOd.Visible = true;
            lblX.Visible = false;
            lblY.Visible = false;
        }

        private void wpiszToolStripMenuItem_Click(object sender, EventArgs e)//metoda ustawiająca formularz na wczytywanie przykładowych punktów z klawiatury
        {
            btnLosuj.Visible = false;
            btnDodaj.Visible = true;
            btnWczytaj.Visible = false;
            nudOd.Visible = true;
            nudOd.Value = 0;
            nudDo.Visible = true;
            nudDo.Value = 0;
            nudIle.Visible = false;
            lblDo.Visible = false;
            lblIle.Visible = false;
            lblOd.Visible = false;
            lblX.Visible = true;
            lblY.Visible = true;
        }

        private void btnLosuj_Click(object sender, EventArgs e) //Metoda losująca przykadową funkcje;
        {
            Random r1 = new Random();//początek losowania
            double od = Convert.ToDouble(nudOd.Value);//ustawienie wartości początkowej losowania
            double doo = Convert.ToDouble(nudDo.Value);//ustawienie wartości maksymalnej losowania
            Double a = 0;//zmienna do przychowywania argumentu funkcji 
            Double b = 0;//zmienna do przechowywania wartosci funkcji 
            Punkt p1 = new Punkt(a, b); // Inicjowanie punktu mającego przechowywać pojedyńczy punkt dla funkcji
            if (funkcja.Count != 0) // sprawdzenie czy lista na funkcje są puste, gdyż generujemy nową funkcje
            {
                funkcja.Clear(); //czyści listę funkcji
            }
            if (tabelaNaFunkcje != null)//sprawdzenie czy tablica wyśfietlająca funkcje czysta
            {
                tabelaNaFunkcje.Clear(); //czyści tablicę na funkcje
            }
            if (funkcja.Count == 0)// Dodanie pierwszego argumentu do "listy funkcja" 
            {
                a = Math.Round((r1.NextDouble() * (doo - od)) + od,4);//losowanie argumentu
                b = Math.Round((r1.NextDouble() * (doo - od)) + od,4);//losowanie wartości
                p1.setXY(a, b);//ustawienie wartości punktu 
                funkcja.Add(p1);//dodanie punktu do listy funkcja
            }
            bool czy = false; // zmienna logiczna sprawdzająca czy argument w funkcji się nie powtarza
            while (Convert.ToInt32(nudIle.Value) - 1 > funkcja.Count)// pętla generująca punkty do funkcji
            {
                a = Math.Round((r1.NextDouble() * (doo - od) )+ od ,4); // losowanie argumentu funkcji
                foreach (Punkt p in funkcja)//pętla sprawdzająca czy argument funkcji się nie powtarza 
                {
                    if (p.getX() == a)  
                    {
                        czy = true;
                        break;
                    }
                }
                if (czy == true) // warunek sprawdzający, czy dany argument już istnieje dla funkcji
                {
                    czy = false;
                    continue;//pętla wykonuje się w następnej iteracji, losując kolejny argument
                }
                b = Math.Round((r1.NextDouble() * (doo - od)) + od,4);// losujemy wartość dla funkcji
                Punkt zmiennaLokalna = new Punkt(a, b);//dodajemy wartości do obiektu punkt
                funkcja.Add(zmiennaLokalna);// dodajemy wartości do listy funkcja
            }

            UpdateGrid();
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
            if (tabelaNaFunkcje != null)
            {
                tabelaNaFunkcje.Clear(); //czyści tablicę tabelaNaFunkcje
            }
            string[] rekord = new string[2]; //rekord danych zapisanych w wierszu pliku
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Czytaj kolejne wiersze pliku i zapisuj je do listy funkcja:
                foreach (string line in File.ReadLines(openFileDialog1.FileName))
                {
                    rekord = line.Split(';'); //przecinek rozdziela dane w wierszu
                    if (funkcja.Count == 0) {
                        funkcja.Add(new Punkt(Convert.ToDouble(rekord[0]), Convert.ToDouble(rekord[1])));
                    }
                    else//sprawdzenie czy argument się nie powtarza
                    {
                        foreach (Punkt punkt in funkcja)
                        {
                            if (punkt.getX() == Convert.ToDouble(rekord[0]))
                            {
                                MessageBox.Show("To nie jest funkcja");//jeżeli się powtarza, wyrzucamy błąd;
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
            Punkt p1 = new Punkt(Convert.ToDouble(nudOd.Value), Convert.ToDouble(nudDo.Value));//generowanie nowego punktu
            foreach (Punkt punkt in funkcja)//pętla sprawdzająca, czy aby się argument nie powtórzył
            {
                if (p1.getX() == punkt.getX())
                {
                    MessageBox.Show("Nie może być dwóch takich samych argumentów");//jeżeli się powtórzył, wyrzucamy błąd
                    return;
                }
            }
            funkcja.Add(p1);//jeżeli nie, dodajemy go do funkcji
            UpdateGrid();// uaktualniamy tabele
        }
        public double getSX()//pobieranie zaznaczonego przez nas argumentu funkcji
        {
            int i = dataGridView1.CurrentRow.Index;
            return funkcja[i].getX();
        }
        public double getSY()//pobiewranie zanznaczonej przez nas wartości funkcji//pobiewranie zanznaczonej przez nas wartości funkcji
        {
            int i = dataGridView1.CurrentRow.Index;
            return funkcja[i].getY();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)//usuwanie wybranego punktu
        {
            int i = dataGridView1.CurrentRow.Index;
            int j = dataGridView1.CurrentCell.ColumnIndex;
            funkcja.RemoveAt(i); //usunie punktu z kolekcji
            UpdateGrid(); //zaktualizuje wyświetlanie kolekcji
        }

        private void btnWyczysc_Click(object sender, EventArgs e)// metoda czyszcząca tabele
        {
            funkcja.Clear(); //czyści listę punktów funkcji
            tabelaNaFunkcje.Clear(); //czyści tablicę ewidencja
        }

        private void btnSortuj_Click(object sender, EventArgs e)//metoda sortująca tabele
        {
            this.sortowanie();
        }
        public void sortowanie() //funkcja sortujące 
        {
            for (int i = 1; i < funkcja.Count - 1; i++)
            {
                for (int j = funkcja.Count - 1; j >= 1; j--)
                {
                    if (funkcja[j].getX() < funkcja[j - 1].getX())
                    {
                        Punkt bufor = new Punkt(0.0, 0.0);
                        bufor = funkcja[j - 1];//bufor przechowujący zmienną którą bd zamieniac
                        funkcja[j - 1] = funkcja[j];
                        funkcja[j] = bufor;
                    }
                }
            }
            UpdateGrid();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            sortowanie();
            Całka c1 = new Całka();//generowanie funkcji całkującej
            if (nudLP.Value != 0)//ustawienie liczby przedziałów dla których liczymy całke
            {
                c1.setLP(Convert.ToInt32(nudLP.Value));
            }
            else// warunek gdy liczba tych przedziałów jest błędnie podana
            {
                MessageBox.Show("liczba przedziałów całkowania musi być większa od 0");
                return;
            }
            double pole =0;// deklaracja zmiennej pole na pole funkcji;
            for(int i = 0; i <= funkcja.Count - 2; i++)//pętla licząca pole pod krzywą dla kolejnych punktów
            {
               pole += c1.metodaTrapezów(funkcja[i].getX(), funkcja[i + 1].getX(), funkcja[i].getY(),funkcja[i+1].getY());
            }
            c1.setWynik(pole);//ustawienie wyniku
            txtWynikCalkowania.Text = Convert.ToString(c1.getWynik());//wyrzucenie wyniku do textboxa
        }
    }
}