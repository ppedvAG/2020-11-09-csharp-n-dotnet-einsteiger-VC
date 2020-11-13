using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M17_Demo_Enumeratoren
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Types
        // enum - Hinweis für den Compiler, einen neuen Datentyp anzulegen
        // die möglichen Werte für diesen Typ sind gleich aufgelistet
        enum Wochentag
        {
            Mo, Di, Mi, Do, Fr, Sa, So
        }
        // Variablen
        // _Datentyp_ _variablenName_;
        // _Datentyp_ _variablenName_ = _initialValue_;

        // Zahlen sind nicht möglich
        //enum Zahl
        //{ 
        //    "1", "345", "454"
        //}

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(WeekdaysCombi.SelectedIndex); // 4
            Console.WriteLine(WeekdaysCombi.SelectedItem); // Freitag
            Console.WriteLine(WeekdaysCombi.SelectedValue); // Freitag
            DemonstrateEnumerator();
        }

        private void DemonstrateEnumerator()
        {
            int eingabe = WeekdaysCombi.SelectedIndex;
            // Int-Variablen können in den Typ Wochentag umgewandelt werden
            // Weil die Werte vom Enumerator indexiert sind (Mo = 0, Di = 1, ...)
            // In den runden Klammern wird bei Type-Casting der gewünschte Typ gestellt
            // Falls die Typen kompatibel sind, findet die Typumwandlung statt
            Wochentag tag = (Wochentag)eingabe;
            // const string mo = "Mo";

            switch (tag)
            {
                case Wochentag.Mo:
                    ausgabeTextBlock.Text = "Pizza";
                    break;
                case Wochentag.Di:
                    ausgabeTextBlock.Text = "Königsberger Klöpse";
                    break;
                case Wochentag.Mi:
                    ausgabeTextBlock.Text = "Spaghetti Carbonara";
                    break;
                case Wochentag.Do:
                    ausgabeTextBlock.Text = "Pilzenpfanne";
                    break;
                case Wochentag.Fr:
                    ausgabeTextBlock.Text = "Fisch mit Kartoffeln";
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    ausgabeTextBlock.Text = "20 % auf alle Gerichte";
                    break;                
            }
        }
    }
}
