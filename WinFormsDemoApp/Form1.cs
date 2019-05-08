using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemoApp
{
    public partial class Form1 : Form
    {
        /* INFORMACJE:
         * Po kliknięciu prawym przyciskiem myszy na klasę Formy dostępne są opcje View Code, View Designer 
         * Dodajemy kontrolki korzystając z zakładki Toolbox po lewej stronie okna, przeciągamy je na docelową Formę
         * Zakładka Properties (prawa część okna Visual Studio) zawieraja pola kontrolek i umożliwia manipulowanie nimi (wymaga najpierw kliknięcia na kontrolkę w Designerze)
         * Opcje Events (wydarzenia generowane w kodzie) zawarte są w zakładce Properties, w górnej części z ikonką błyskawicy. Tworzymy je klikając dwukrotnie na kontrolkę.
         * Metoda InitializeComponent() jest generowana przez Visual Studio, nie należy jej modyfikować
         */
        public Form1()
        {
            InitializeComponent();
        }

        //Pokazanie działania eventu i wykonywanie operacji na kontrolkach + pokazanie możliwości wykorzystania pól klasy do trzymania danych
        private int _clicks = 0;
        private void singleButton_Click(object sender, EventArgs e)
        {
            //Przypisanie wartości do prywatnego pola klasy
            this._clicks += 1;
            //Aktualizacja tekstu na kontrolce
            this.buttonLabel.Text = "Button clicked " + _clicks.ToString() + " times";
        }

        //Pokazanie wbudowanych pól (właściwości) kontrolek i manipulowanie (odczyt/zapis) nimi w naszym programie
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Odczyt wartości pola checkboxa i sprawdzenie jego statusu
            if(this.checkBox.Checked == true)
            {
                this.checkboxLabel.Text = "Status: ON";
            }
            else
            {
                this.checkboxLabel.Text = "Status: OFF";
            }
        }

        //Użycie tego samego Eventu (wydarzenia) dla dwóch kontrolek dodanych w Designerze. Zostały dodane poprzez wybranie nazwy metody w zakładce Properties -> Events (błyskawica)
        private void operationalButton_Click(object sender, EventArgs e)
        {
            //Sprawdzenie, czy kontrolka wywołująca zdarzenie to przycisk
            if(sender is Button)
            {
                //Utworzenie w kodzie obiektu z przycisku otrzymanego z kontrolki
                Button button = (sender as Button);
                //Przetworzenie danych z kontrolki (Labela) na liczbę możliwą do edycji
                int oldNumber = Int32.Parse(this.numberLabel.Text);

                //Sprawdzenie, który przycisk został kliknięty
                if (button.Name == this.addButton.Name)
                {
                    //Zwiększenie wartości zmiennej typu 'int' i zmiana na string -> przypisanie do tekstu Labela
                    this.numberLabel.Text = (oldNumber + 1).ToString();
                }
                else if (button.Name == this.subtractButton.Name)
                {
                    this.numberLabel.Text = (oldNumber - 1).ToString();
                }
            }
        }
    }
}
