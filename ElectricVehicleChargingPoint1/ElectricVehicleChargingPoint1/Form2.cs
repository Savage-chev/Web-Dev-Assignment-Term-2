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
    
    public partial class Form2 : Form
    {
        public List<Visitor> visitors;
        public Form2(List<Visitor> visitors)
        {
            this.visitors = visitors;
            InitializeComponent();
            foreach (Visitor v in visitors)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Charging Bay: " + v.getBay());
                listBox1.Items.Add("Charging Power: " + v.getPower() + " kWh");
                listBox1.Items.Add("Charging Duration: " + v.getDuration());
                listBox1.Items.Add("Overall Charge: " + v.getCharge() + " kWh");
                listBox1.Items.Add("Cost: £" + v.getCost());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bay = -1;
            if (bayRayBtn1.Checked)
                bay = 1;
            else if (bayRayBtn2.Checked)
                bay = 2;
            else if (bayRayBtn3.Checked)
                bay = 3;
            else if (bayRayBtn4.Checked)
                bay = 4;
            else if (bayRayBtn5.Checked)
                bay = 5;
            else if (bayRayBtn6.Checked)
                bay = 6;
            else if (bayRayBtn7.Checked)
                bay = 7;
            else if (bayRayBtn8.Checked)
                bay = 8;
            else if (bayRayBtn9.Checked)
                bay = 9;
            else if (bayRayBtn10.Checked)
                bay = 10;
            else if (bay == -1)
            {
                MessageBox.Show("Please enter your charging bay");
            }

            int power = -1;
            if (powerRayBtn1.Checked)
                power = 5;
            else if (powerRayBtn2.Checked)
                power = 10;
            else if (powerRayBtn3.Checked)
                power = 15;
            else if (powerRayBtn4.Checked)
                power = 20;
            else if (powerRayBtn5.Checked)
                power = 25;
            else if (power == -1)
            {
                MessageBox.Show("Please enter the desired charging level");
            }

            int duration = -1;
            if (durationRayBtn1.Checked)
                duration = 1;
            else if (durationRayBtn2.Checked)
                duration = 2;
            else if (durationRayBtn3.Checked)
                duration = 3;
            else if (durationRayBtn4.Checked)
                duration = 4;
            else if (durationRayBtn5.Checked)
                duration = 5;
            else if (duration == -1)
            {
                MessageBox.Show("Please enter the desired charging duration");
            }
            int charge = power * duration;
            int cost = power * duration / 2;

            visitors.Add(new Visitor(bay, power, duration, charge, cost));

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

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form3 = new Form3(visitors);
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form2 = new Form2(visitors);
            form2.Show();
            this.Hide();
        }

        private void pAYMENTDETAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form3 = new Form3(visitors);
            form3.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var form4 = new Form4(visitors);
            form4.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Console.Beep();
            MessageBox.Show("Have a lovely day!");
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

