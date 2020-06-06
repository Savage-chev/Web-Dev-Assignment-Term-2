using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricVehicleChargingPoint1
{
    public partial class Form3 : Form
    {
        public List<Visitor> visitors;
        public Form3(List<Visitor> visitors)
        {
            this.visitors = visitors;
            InitializeComponent();
            foreach (Visitor v in visitors)
            {
                listBox1.Items.Clear();
                //listBox1.Items.Add("Car Reg: " + v.getCarReg());
                listBox1.Items.Add("Charging Bay: " + v.getBay());
                listBox1.Items.Add("Charging Power: " + v.getPower() + " kWh");
                listBox1.Items.Add("Charging Duration: " + v.getDuration());
                listBox1.Items.Add("Overall Charge: " + v.getCharge() + " kWh");
                listBox1.Items.Add("Cost: £" + v.getCost());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form2 = new Form2(visitors);
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            MessageBox.Show("Have a lovely day!");
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form4 = new Form4(visitors);
            form4.Show();
            this.Hide();
        }

        private void sETCHARGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form2 = new Form2(visitors);
            form2.Show();
            this.Hide();
        }

        private void pAYMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form3 = new Form3(visitors);
            form3.Show();
            this.Hide();
        }

        private void cHARGINGDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form4 = new Form4(visitors);
            form4.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            MessageBox.Show("Have a lovely day!");
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
