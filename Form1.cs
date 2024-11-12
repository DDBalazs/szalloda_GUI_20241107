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

namespace szalloda_GUI_20241107
{
    public partial class Form1 : Form
    {
        List<Vendegek> lista = new List<Vendegek>();
        public void betoltes()
        {
            rbteljes.Focus();
            rtadatok.Clear();
            rttorzsvendek.Clear();
            FileStream fs = new FileStream("..\\..\\src\\vendegek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                rtadatok.Text = rtadatok.Text+sor+"\n";
                Vendegek v=new Vendegek(sor);
                lista.Add(v);
            }
            sr.Close();
            fs.Close();
            int vendegejszam = 0;
            int vendegteljesszam = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                vendegejszam = vendegejszam + lista[i].VendegEjszakakSzamitas();
                if (lista[i].Ellatas == "p")
                {
                    vendegteljesszam++;
                }
            }
            lbvendegejszakak.Text = "Vendégéjszakák száma összesen: " + vendegejszam.ToString();
            lbvendegteljes.Text = "A teljes ellátást igénybevevők száma: "+vendegteljesszam.ToString();

            for (int i = 0; i < lista.Count; i++)
            {
                cbejszakak.Items.Add(i + 1).ToString();
                if (lista[i].Ellatas == "p")
                {
                    rttorzsvendek.Text = rttorzsvendek.Text + lista[i].Nev + "\n";
                }
            }
        }
        public void vendegejszakakszama()
        {
            if (txvendegszam.TextLength > 0 && cbejszakak.SelectedItem != null)
            {
                int ossz = Convert.ToInt32(txvendegszam.Text) * Convert.ToInt32(cbejszakak.Text);
                lbujszamok.Text = "Vendég éjszakák száma: "+ossz.ToString();
                lbujszamok.Visible = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txvendegnev_TextChanged(object sender, EventArgs e)
        {
        }

        private void txvendegszam_TextChanged(object sender, EventArgs e)
        {
            if(txvendegszam.Text.Length > 0)
            {
            try
            {
                int szam = Convert.ToInt32(txvendegszam.Text);
                vendegejszakakszama();
            }
            catch
            {
                MessageBox.Show("Nem egész számot adtál meg!", "Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvendegszam.Clear();
                txvendegszam.Focus();
            }

            }
        }

        private void cbejszakak_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendegejszakakszama();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txvendegnev.Text.Length == 0)
            {
                MessageBox.Show("Nem adtad meg a vendég nevát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvendegnev.Focus();
            }
            else if(cbejszakak.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki az éjszakák számát","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cbejszakak.Focus();
            }
            else if(txvendegszam.Text.Length == 0)
            {
                MessageBox.Show("Nem adtad meg hány vendégre foglalnál!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvendegszam.Focus();
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\src\\vendegek.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                if (rbteljes.Checked)
                {
                    sw.Write("\n"+txvendegnev.Text+";"+cbejszakak.SelectedItem+";"+txvendegszam.Text+";"+"p");
                    MessageBox.Show("Sikeres adatfeltöltés!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbfel.Checked)
                {
                    sw.Write("\n" + txvendegnev.Text + ";" + cbejszakak.SelectedItem + ";" + txvendegszam.Text + ";" + "fp");
                    MessageBox.Show("Sikeres adatfeltöltés!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbno.Checked)
                {
                    sw.Write("\n" + txvendegnev.Text + ";" + cbejszakak.SelectedItem + ";" + txvendegszam.Text + ";" + "no");
                    MessageBox.Show("Sikeres adatfeltöltés!","Siker!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                sw.Close();
                fs.Close();
                txvendegnev.Clear();
                cbejszakak.SelectedItem = null;
                txvendegszam.Clear();
                rbteljes.Checked = true;
                betoltes();
            }
        }
    }
}
