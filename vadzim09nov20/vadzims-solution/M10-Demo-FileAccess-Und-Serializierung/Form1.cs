using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace M10_Demo_FileAccess_Und_Serializierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Felder / Variablen
        TransportmittelSrlzng transportmittel;
        StreamWriter streamWriter;
        StreamReader sr;

        private void generateTransportmittel()
        {
            transportmittel = new TransportmittelSrlzng("Auto", 55000.23, 220);
            
            MessageBox.Show(transportmittel.BeschreibeMich());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hallo in die Konsole");
            MessageBox.Show("Hallo in die MessageBox");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generateTransportmittel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // mit relativem Pfad
            // StreamWriter streamWriter = new StreamWriter("TransportAlsString.txt");
            // mit absolutem Pfad
            streamWriter = new StreamWriter("C:\\Users\\vn3\\Desktop\\TransportAlsString.txt");
            
            // Environment.GetEnvironmentVariables(); // \%userprofile% // todo
            // StreamWriter streamWriter = new StreamWriter("\\Desktop\\TransportDurchUserProfile.txt");
            streamWriter.WriteLine(transportmittel.BeschreibeMich());
            streamWriter.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("C:\\Users\\vn3\\Desktop\\TransportAlsString.txt");
            string rückgabeVonSR = sr.ReadToEnd();
            MessageBox.Show(rückgabeVonSR);
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Serialize(transportmittel);
            string result = JsonConvert.SerializeObject(transportmittel);

            streamWriter = new StreamWriter("C:\\Users\\vn3\\Desktop\\TransportAlsJsonString.txt");

            // Nur Public Props werden serialisiert!
            streamWriter.Write(result);
            streamWriter.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("C:\\Users\\vn3\\Desktop\\TransportAlsJsonString.txt");
            string jsonString = sr.ReadToEnd();
            transportmittel = JsonConvert.DeserializeObject<TransportmittelSrlzng>(jsonString);
            sr.Close();
            MessageBox.Show($"Typ: {transportmittel.GetType().ToString()}, Preis: {transportmittel.Preis}");
        }
    }
}
