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
        /* WSTĘPNE INFORMACJE:
         * Pokazanie okna formy i przeciąganie podstawowych kontrolek (label, button, checkbox)
         * Pokazanie okna Properties zawierającego pola kontrolek i manipulowanie nimi (manualna zmiana nazwy kontrolki w klasie, manualna zmiana tekstu na kontrolce)
         * Później pokazanie również zakładki Events z wydarzeniami podczas pokazywania działania operationalButton_Click (na dole tej klasy)
         * Później pokazanie przypisywania wartości pól oraz Eventów w metodzie InitializeComponent() <-- kod generowany przez Visual Studio
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

        //Pokazanie możliwości rzutowania obiektu wywołującego wydarzenie na konkretną kontrolkę i ponowne użycie wbudowanych pól kontrolek
        private void operationalButton_Click(object sender, EventArgs e)
        {
            //Pokazanie sprawdzenia źródła wywołującego wydarzenie
            if ((sender as Button).Name == this.addButton.Name)
            {
                //Parsowanie string na int - dodanie wartości do inta - parsowanie z powrotem na string
                this.numberLabel.Text = (Int32.Parse(this.numberLabel.Text) + 1).ToString();
            }
            else if ((sender as Button).Name == this.subtractButton.Name)
            {
                this.numberLabel.Text = (Int32.Parse(this.numberLabel.Text) - 1).ToString();
            }
        }
    }
}
