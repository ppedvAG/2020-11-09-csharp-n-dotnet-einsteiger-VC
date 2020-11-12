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

namespace M13_Demo_Exceptions_Und_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // snippets: 
            // try tab tab
            // tryf tab tab
            ushort alter = 0; // soll initialisiert werden, 
            // weil bei einem misslungenen try hat die Variable in finally keinen Wert
            try
            {
                alter = ushort.Parse(eingabe.Text);

                if (alter < 15)
                    throw new Under15Exception("Jünger als 15 nicht erlaubt");
                // ohne Extra Catch-Block wird Under15Exception  im Exception-Block abgefangen
                // sind extra Anweisungen bei Under15Exception vorgesehen, 
                // dann dafür entsprechenden Catch-Block bauen

            }
            catch (FormatException fExcptn)
            {
                Console.WriteLine(fExcptn.Message);
                Console.WriteLine("Format Exception");
            }
            catch (OverflowException oExcptn)
            {
                Console.WriteLine(oExcptn.Message);
                Console.WriteLine("Overflow Exception");
            }
            catch (Under15Exception uExcptn)
            {
                Console.WriteLine(uExcptn.Message);
                Console.WriteLine("Nur in Begleitung mit Eltern dürfen Sie eintreten");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Exception");
            }
            finally //ohne Finally keine ausgabe
            {
                Console.WriteLine("try catch durchgelaufen, alter: " + alter);
            }
        }

        //private string Test()
        //{
        //    if (!true)
        //    {
        //        return "text";
        //    }
        //}
    }

    class Under15Exception : Exception
    {
        public Under15Exception(string message) : base(message)
        {

        }
    }
}
