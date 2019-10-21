using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceForm
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();

            animals.Add(new Cat("Name1"));
            animals.Add(new Dog("Name2"));
            animals.Add(new Bird("Name3"));



            foreach (Animal a in animals)
            {
                cbNames.Items.Add(a.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindexchanged = cbNames.SelectedIndex;
            Animal animal = animals[selectedindexchanged];
            lbSpecies.Text = animal.Species.ToString();
            lbCanFly.Text = (animal.CanFly ? "Kan flyga" : "Kan INTE flyga");
        }
    }
}
