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
    public partial class Form1 : Form
    {
        public List<Visitor> visitors = new List<Visitor>();

        public Form1()
        {
            InitializeComponent();
            pinTextBox.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string carReg;
            if (regTextBox.Text == "M1111MCR")
            {
                if (pinTextBox.Text == "1111")
                {
                    //carReg = regTextBox.Text;
                    //visitors.Add(new Visitor(carReg));
                    Console.Beep();
                    var form2 = new Form2(visitors);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Enter The Correct PIN");
                }
            }
            else
                MessageBox.Show("Please Enter The Correct Registration");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }
    }

    public class Visitor
    {
        //public string carReg;
        public int bay;
        public int power;
        public int duration;
        public int charge;
        public int cost;

        public Visitor( int bay, int power, int duration, int charge, int cost)
        {
            this.bay = bay;
            this.power = power;
            this.duration = duration;
            this.charge = charge;
            this.cost = cost;
        }

        //public Visitor(string carReg)
        //{
        //    this.carReg = carReg;
        //}

        //public string getCarReg()
        //{
        //    return carReg;
        //}
        public int getBay()
        {
            return bay;
        }

        public int getPower()
        {
            return power;
        }

        public int getDuration()
        {
            return duration;
        }
        public int getCharge()
        {
            return charge;
        }
        public int getCost()
        {
            return cost;
        }
    }
}
