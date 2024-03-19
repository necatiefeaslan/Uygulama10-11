using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama10_11
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
          foreach (var sehir in sehirler)
           lbListe.Items.Add(sehir);
        }
    }
}
