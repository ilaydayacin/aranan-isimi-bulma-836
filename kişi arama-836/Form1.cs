using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kişi_arama_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVarMi_Click(object sender, EventArgs e)
        {
            string ara = Convert.ToString(txtAra.Text);
            int sayac = 0;

            for (int i = 0; i < lbİsim.Items.Count; i++)
            {
                if (ara == lbİsim.Items[i].ToString())
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                MessageBox.Show("Aranan kişi Bulunamadı");
                lblKac.Text = "kaç kere ismi yazılı: " + sayac;
            }
            else
            {
                MessageBox.Show("aranan kişi Bulundu");
                lblKac.Text = "kaç kere ismi yazılı: " + sayac;
            }
        }
    }
}
