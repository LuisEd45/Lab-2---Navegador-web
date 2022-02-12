using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorador_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
            string bus = " ";
            if (comboBox1.Text != null)
                bus = comboBox1.Text;
            else if (comboBox1.SelectedItem != null)
                bus = comboBox1.SelectedItem.ToString();
            if (!bus.Contains("."))
                bus = "https://www.google.com/search?q=" + bus;
            if (!bus.Contains("https://"))
                bus = "https://" + bus;

            comboBox1.Items.Add(comboBox1.Text);
            comboBox1.Text = " "; 
            webBrowser1.Navigate(new Uri(bus));
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
