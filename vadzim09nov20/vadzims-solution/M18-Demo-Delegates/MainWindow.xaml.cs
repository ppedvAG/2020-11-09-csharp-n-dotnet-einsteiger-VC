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

namespace M18_Demo_Delegates
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Types
        delegate int MathOps(int zahl1, int zahl2);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void opsBtn_Click(object sender, RoutedEventArgs e)
        {
            MathOps mOps = new MathOps(Addiere);
            // mOps = mOps + Subtrahiere;
            mOps += Subtrahiere;
            // return vom Delegaten ist return von der Methode
            // die als letzte hinzugefügt wurde
            mOps += Multipliziere;
            mOps += Dividiere;
            // ausgabeTxtBlck.Text = mOps.Invoke(int.Parse(zahl1TxtBx.Text), int.Parse(zahl2TxtBx.Text)).ToString();
            // Ohne Invoke geht es auch. mOps funktioniert wie eine Methode:
            ausgabeTxtBlck.Text = mOps(int.Parse(zahl1TxtBx.Text), int.Parse(zahl2TxtBx.Text)).ToString();
            mOps -= Dividiere;
            ausgabeTxtBlck.Text += $"\n{mOps.Invoke(int.Parse(zahl1TxtBx.Text), int.Parse(zahl2TxtBx.Text))}";
        }
        public int Addiere(int z1, int z2)
        {
            Console.WriteLine("Addiere");
            return z1 + z2;
        }
        public int Subtrahiere(int z1, int z2)
        {
            Console.WriteLine("Subtrahiere");
            return z1 - z2;
        }
        public int Multipliziere(int z1, int z2)
        {
            Console.WriteLine("Multipliziere");
            return z1 * z2;
        }
        public int Dividiere(int z1, int z2)
        {
            Console.WriteLine("Dividiere");
            return z1 / z2;
        }

        private void findBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> städte = new List<string>() { "Berlin", "Leipzig", "München" };
            string resultat;
            //bool FindeStadtMitM(string s) {
            //    if (s[0] == 'M')
            //        return true;
            //    else
            //        return false;
            //}
            // Aufruf von Find mit einer benannten Methode
            // resultat = städte.Find(FindeStadtMitM);
            // wird FindeStadtMitM nur an einer einzelnen Stelle gebraucht,
            // kann man die Methode auch direkt in Find() deklarieren:

            // Aufruf von Find mit einer Anonymen Methode
            //resultat = städte.Find(
            //    delegate (string stadt)
            //    {
            //        if (stadt[0] == 'M')
            //            return true;
            //        else
            //            return false;
            //    });

            // gleicher Aufruf kürzer:
            // mit ternärem Operator
            //resultat = städte.Find(
            //    delegate (string stadt)
            //    {
            //        return (stadt[0] == 'M') ? true : false;
            //    });

            // gleicher Aufruf kürzer:
            // mit Pfeilfunktion / Lambda-Ausdruck
            // resultat = städte.Find((string stadt) => (stadt[0] == 'M') ? true : false);

            // gleicher Aufruf kürzer:
            // Es ist eindeutig, dass Variable stadt ein string ist
            // bekommt die Pfeilmethode nur ein Argument, sind die runden Klammern optional
            // resultat = städte.Find(stadt => (stadt[0] == 'M') ? true : false);

            // Aufruf mit StartsWith()-Methode von strings
            resultat = städte.Find(stadt => stadt.StartsWith("M")); 
            // M als string, nicht als char, weil man auch nach Mü suchen könnte

            (sender as Button).Content = resultat;
        }
    }
}
