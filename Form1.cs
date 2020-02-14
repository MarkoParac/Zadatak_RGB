using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;
        }

        private void Ocisti()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            txtNaziv.Text = "";
        }

        private List<MyColor> color = new List<MyColor>();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MyColor mc = new MyColor((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, txtNaziv.Text);
            color.Add(mc);

            if (!comboBox1.Items.Contains(txtNaziv.Text))
            {
                comboBox1.Items.Add(color.Last().Name);
            }
            else
            {
                MessageBox.Show("Naziv već postoji!");
            }

            panel1.BackColor = color.Last().GetColor();

            Ocisti();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var boja in color)
            {
               if(boja.Name == comboBox1.SelectedItem)
                {
                    int crvena = boja.Red;
                    int zelena = boja.Green;
                    int plava = boja.Blue;
                    panel1.BackColor = Color.FromArgb(crvena, zelena, plava);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
