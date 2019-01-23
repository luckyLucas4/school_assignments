using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personregister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Person nyPerson;
        List<Person> personLista = new List<Person>();

        private void btn_nyPerson_Click(object sender, EventArgs e)
        {
            nyPerson = new Person();
            nyPerson.namn = textBox1.Text;
            nyPerson.ålder = textBox2.Text;
            MessageBox.Show("En ny person skapades i minnet");
        }

        private void btn_inIListan_Click(object sender, EventArgs e)
        {
            personLista.Add(nyPerson);
            MessageBox.Show("En ny person lades till i listan");
        }

        private void btn_visaListan_Click(object sender, EventArgs e)
        {
            lsbx_namn.Items.Clear();
            lsbx_ålder.Items.Clear();
            foreach(Person person in personLista)
            {
                lsbx_namn.Items.Add(person.namn);
                lsbx_ålder.Items.Add(person.ålder.ToString());
            }
        }

        private void btn_sortera_Click(object sender, EventArgs e)
        {
            personLista.Sort();
        }

        private void btn_vänd_Click(object sender, EventArgs e)
        {

        }
    }
}
