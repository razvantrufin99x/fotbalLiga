using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fotbalLiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ligafc Liga1 = new ligafc();

        private void Form1_Load(object sender, EventArgs e)
        {
            Liga1.echipe.Add(new echipa("fcsb"));
            Liga1.echipe.Add(new echipa("dinamo"));

            Liga1.meciurile.meciuri.Add(new meci(1, Liga1.echipe[0], Liga1.echipe[1]));
            Liga1.meciurile.meciuri.Add(new meci(2, Liga1.echipe[1], Liga1.echipe[0]));

            clasament acasa = new clasament();
            clasament deplasare = new clasament();
            clasament totalclasament = new clasament();
            Liga1.clasamentul.clasamente.Add(new clasament());
            Liga1.clasamentul.clasamente[0] = acasa;
            Liga1.clasamentul.clasamente.Add(new clasament());
            Liga1.clasamentul.clasamente[1] = deplasare;
            Liga1.clasamentul.clasamente.Add(new clasament());
            Liga1.clasamentul.clasamente[2] = totalclasament;

            Liga1.clasamentul.clasamente[0].echipele.Add(new elementclasament(Liga1.echipe[0]));
            Liga1.clasamentul.clasamente[0].echipele.Add(new elementclasament(Liga1.echipe[1]));

            textBox1.Text += Liga1.echipe[0].denumire;
            textBox2.Text += Liga1.echipe[1].denumire;

            textBox3.Text += Liga1.meciurile.meciuri[0].numar.ToString(); textBox3.Text += " ";
            textBox3.Text += Liga1.meciurile.meciuri[0].eg.denumire.ToString(); textBox3.Text += " ";
            textBox3.Text += Liga1.meciurile.meciuri[0].eo.denumire.ToString(); textBox3.Text += " ";

            textBox4.Text += Liga1.meciurile.meciuri[1].numar.ToString(); textBox4.Text += " ";
            textBox4.Text += Liga1.meciurile.meciuri[1].eg.denumire.ToString(); textBox4.Text += " ";
            textBox4.Text += Liga1.meciurile.meciuri[1].eo.denumire.ToString(); textBox4.Text += " ";

            
        
        }
    }
}
