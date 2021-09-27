using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem5Team
{
    public partial class Form1 : Form
    {
        public string carNumber;
        public string Phone;
        public string carNumber2;
        public string carNumber3;
        public string carnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            carnum = tbcarnum.Text + tbcarnum2.Text + tbcarnum3.Text;
            if(tbcarnum.Text == "" || tbcarnum2.Text == "" || tbcarnum3.Text == "")
            {
                MessageBox.Show("빈칸없이 입력해주세요.");
            }
            else
            {
                Member dlg = new Member();
                dlg.Owner = this;

                carNumber = tbcarnum.Text;
                carNumber2 = tbcarnum2.Text;
                carNumber3 = tbcarnum3.Text;

                tbcarnum.Clear();
                tbcarnum2.Clear();
                tbcarnum3.Clear();
                dlg.ShowDialog();
                dlg.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carnum = tbcarnum.Text + tbcarnum2.Text + tbcarnum3.Text;
            if (tbcarnum.Text == "" || tbcarnum2.Text == "" || tbcarnum3.Text == "")
            {
                MessageBox.Show("빈칸없이 입력해주세요.");
            }
            else
            {
                Nonmember dlg = new Nonmember();
                dlg.Owner = this;

                carNumber = tbcarnum.Text;
                carNumber2 = tbcarnum2.Text;
                carNumber3 = tbcarnum3.Text;

                tbcarnum.Clear();
                tbcarnum2.Clear();
                tbcarnum3.Clear();
                dlg.ShowDialog();
                dlg.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterPark register = new RegisterPark();
            register.ShowDialog();
            register.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reservation rese = new reservation();
            rese.ShowDialog();
            rese.Dispose();
        }
    }
}
