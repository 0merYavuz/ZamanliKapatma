using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZamanliKapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZamanla_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt16(nmrSaat.Value);
            int dakika = Convert.ToInt16(nmrDakika.Value);
            int saniye = Convert.ToInt16(nmrSaniye.Value);
            int toplamSaniye = saat*3600 + dakika*60 + saniye;
            Process.Start("cmd.exe", "/c" + "shutdown -s -f -t "+toplamSaniye);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c" + "shutdown /a");
        }
    }
}
