using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tb2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomEvento = tb1.Text;
            string fecha = tb2.Text;
            string cat = comboBox1.Text;
            string evento = tb1.Text + " " + tb2.Text + " " + comboBox1.Text;

            comboBox2.Items.Add(evento);

            tb1.Text = "";
            tb2.Text = "";
            comboBox1.Text="";


        }

        private void bEli_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(comboBox2.SelectedItem);

            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string categoria = textBox1.Text;

            comboBox1.Items.Add(categoria);

            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            comboBox2.Text = "";
        }
    }
}
