using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingSystem5Team
{
    public partial class MainParkingSystem : Form
    { 
        public string CarNum; //합쳐진 차량번호
        public string cn; //차량번호 앞자리
        public string cn2; //차량번호 중간 자리
        public string cn3; //차량번호 뒷자리
        public string ph; //등록차량 핸드폰번호

        public string resSpot; //예약 주차 자리 확인을 위한 변수

        public string[] parkSpot = new string[28];

        public void Reser()
        {
            TextBox[] tb = new TextBox[28] { t1, t2, t3, t4,t5, t6, t7, t8, t9, t10,
            t11, t12, t13, t14,t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28};
            for (int i = 0; i < 28; i++)
            {
                parkSpot[i] = tb[i].Text;
            }
        }
        public MainParkingSystem()
        {
            InitializeComponent();
        }
        public static string[] Carstr = new string[100];
        private void btnReserve_Click(object sender, EventArgs e) //예약 버튼 눌렀을때 이벤트
        {
            Reser();
            if (File.Exists(@"C:\ParkingSystem\Register\Register.csv") == false)
            {
                return;
            }
            FileStream fs = File.OpenRead(@"C:\ParkingSystem\Register\Register.csv");
            StreamReader sr = new StreamReader(fs);
            int i = 0;
            while (sr.EndOfStream == false)
            {
                string data = sr.ReadLine();
                if (data == null) { break; }
                string[] sitems = data.Split('\t', '\n');
                Carstr[i] = sitems[0];
                i++;
            }
            sr.Close();
            fs.Close();
            int a = 0;
            if (txtCarNumber.Text == "")
                MessageBox.Show("번호를 입력해주세요");
            else
            {
                for (int j = 1; j < i; j++)
                {
                    if (txtCarNumber.Text == Carstr[j])
                    {
                        a = 1;
                        break;
                    }
                    else
                    {
                        a = 0;
                    }
                }
                if (a == 1)
                {
                    reservation rese = new reservation();
                    rese.Owner = this;
                    CarNum = txtCarNumber.Text;
                    rese.ShowDialog();
                }
                else
                {
                    MessageBox.Show("등록된 차량이 아닙니다.\n예약이 불가능합니다.");
                }
            }

        }
        
        public static string[] Carstr2 = new string[100];
        public static string[] Phonestr = new string[100];
        public void strCompare()
        {
            if (File.Exists(@"C:\ParkingSystem\Register\Register.csv") == false)
            {
                return;
            }
            FileStream fs = File.OpenRead(@"C:\ParkingSystem\Register\Register.csv");
            StreamReader sr = new StreamReader(fs);

            int i = 0;
            while (sr.EndOfStream == false)
            {
                string data = sr.ReadLine();
                if (data == null) { break; }
                string[] sitems = data.Split('\t', '\n');
                Carstr2[i] = sitems[0];
                Phonestr[i] = sitems[2];
                i++;
            }
            sr.Close();
            fs.Close();
            
            Member Mem = new Member();
            Nonmember nonMem = new Nonmember();

            int Compare = 0; //폰넘버 집어넣을 인덱스값을 찾기위한 정수형 변수
            for (int j = 1; j < i; j++)
            {
                if (txtCarNumber.Text == Carstr2[j])
                {
                    Compare = j;
                    break;
                }
                else
                {
                    Compare = 0;
                }
            }
            if (Compare != 0)
            {
                Mem.Owner = this;
                cn = txtCarNumber.Text.Substring(0, 3);
                cn2 = txtCarNumber.Text.Substring(3, 1);
                cn3 = txtCarNumber.Text.Substring(4, 4);
                ph = Phonestr[Compare];
                Mem.ShowDialog();
                Mem.Dispose();
            }
            else
            {
                nonMem.Owner = this;
                cn = txtCarNumber.Text.Substring(0, 3);
                cn2 = txtCarNumber.Text.Substring(3, 1);
                cn3 = txtCarNumber.Text.Substring(4, 4);
                nonMem.ShowDialog();
                //nonMem.Dispose();
            }
        }
        private void Blue() //파란불
        {
            BlueBox.BackColor = Color.Blue;
            RedBox.BackColor = Color.Black;
            YellowBox.BackColor = Color.Black;
        }
        private void Red() //빨간불
        {
            RedBox.BackColor = Color.Red;
            BlueBox.BackColor = Color.Black;
            YellowBox.BackColor = Color.Black;
        }
        private void Yellow() //노란불
        {
            RedBox.BackColor = Color.Black;
            BlueBox.BackColor = Color.Black;
            YellowBox.BackColor = Color.Yellow;
        }
        private void White() //default
        {
            BlueBox.BackColor = Color.Black;
            RedBox.BackColor = Color.Black;
            YellowBox.BackColor = Color.Black;
        }
        public void ReservationState() //예약 상태 확인을 위한 선언
        {
            reservation res = new reservation();
            res.Owner = this;
            res.Dispose();
        }
        private void t_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t1.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t1.Text && A1.Visible == true || txtCarNumber.Text == "")
            {
                MessageBox.Show("주차가 불가능합니다.");
            }
            else if (txtCarNumber.Text == t1.Text)
            {
                strCompare();
                Blue();
                A1.Visible = false;
                PA1.Visible = true;
                txtCarNumber.Text = t1.Text;
                t1.Text = "1";
            }
            else
            {
                t1.Text = txtCarNumber.Text;
                if (t1.Text == t2.Text || t1.Text == t3.Text || t1.Text == t4.Text
                    || t1.Text == t5.Text || t1.Text == t6.Text || t1.Text == t7.Text
                    || t1.Text == t8.Text || t1.Text == t9.Text || t1.Text == t10.Text
                    || t1.Text == t11.Text || t1.Text == t12.Text || t1.Text == t13.Text
                    || t1.Text == t14.Text || t1.Text == t15.Text || t1.Text == t16.Text
                    || t1.Text == t17.Text || t1.Text == t18.Text || t1.Text == t19.Text
                    || t1.Text == t20.Text || t1.Text == t21.Text || t1.Text == t22.Text
                    || t1.Text == t23.Text || t1.Text == t24.Text || t1.Text == t25.Text
                    || t1.Text == t26.Text || t1.Text == t27.Text || t1.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t1.Text = "1";
                }
                else
                {
                    strCompare();
                    Red();
                    A1.Visible = true;
                    PA1.Visible = false;
                }
            }
        }
  
        private void t1_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t2.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t2.Text && A2.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t2.Text)
            {
                strCompare();
                Blue();
                A2.Visible = false;
                PA2.Visible = true;
                txtCarNumber.Text = t2.Text;
                t2.Text = "2";
            }
            else
            {
                t2.Text = txtCarNumber.Text;
                if (t2.Text == t1.Text || t2.Text == t3.Text || t2.Text == t4.Text
                    || t2.Text == t5.Text || t2.Text == t6.Text || t2.Text == t7.Text
                    || t2.Text == t8.Text || t2.Text == t9.Text || t2.Text == t10.Text
                    || t2.Text == t11.Text || t2.Text == t12.Text || t2.Text == t13.Text
                    || t2.Text == t14.Text || t2.Text == t15.Text || t2.Text == t16.Text
                    || t2.Text == t17.Text || t2.Text == t18.Text || t2.Text == t19.Text
                    || t2.Text == t20.Text || t2.Text == t21.Text || t2.Text == t22.Text
                    || t2.Text == t23.Text || t2.Text == t24.Text || t2.Text == t25.Text
                    || t2.Text == t26.Text || t2.Text == t27.Text || t2.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t2.Text = "2";
                }
                else
                {
                    strCompare();
                    Red();
                    A2.Visible = true;
                    PA2.Visible = false;
                }

            }
        }

        private void t2_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t3.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t3.Text && A3.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t3.Text)
            {
                strCompare();
                Blue();
                A3.Visible = false;
                PA3.Visible = true;
                txtCarNumber.Text = t3.Text;
                t3.Text = "3";
            }
            else
            {
                t3.Text = txtCarNumber.Text;
                if (t3.Text == t1.Text || t3.Text == t2.Text || t3.Text == t4.Text
                    || t3.Text == t5.Text || t3.Text == t6.Text || t3.Text == t7.Text
                    || t3.Text == t8.Text || t3.Text == t9.Text || t3.Text == t10.Text
                    || t3.Text == t11.Text || t3.Text == t12.Text || t3.Text == t13.Text
                    || t3.Text == t14.Text || t3.Text == t15.Text || t3.Text == t16.Text
                    || t3.Text == t17.Text || t3.Text == t18.Text || t3.Text == t19.Text
                    || t3.Text == t20.Text || t3.Text == t21.Text || t3.Text == t22.Text
                    || t3.Text == t23.Text || t3.Text == t24.Text || t3.Text == t25.Text
                    || t3.Text == t26.Text || t3.Text == t27.Text || t3.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t3.Text = "3";
                }
                else
                {
                    strCompare();
                    Red();
                    A3.Visible = true;
                    PA3.Visible = false;

                }
            }
        }

        private void t3_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t4.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t4.Text && A4.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t4.Text)
            {
                strCompare();
                Blue();
                A4.Visible = false;
                PA4.Visible = true;
                txtCarNumber.Text = t4.Text;
                t4.Text = "4";
            }
            else
            {
                t4.Text = txtCarNumber.Text;
                if (t4.Text == t1.Text || t4.Text == t2.Text || t4.Text == t3.Text
                    || t4.Text == t5.Text || t4.Text == t6.Text || t4.Text == t7.Text
                    || t4.Text == t8.Text || t4.Text == t9.Text || t4.Text == t10.Text
                    || t4.Text == t11.Text || t4.Text == t12.Text || t4.Text == t13.Text
                    || t4.Text == t14.Text || t4.Text == t15.Text || t4.Text == t16.Text
                    || t4.Text == t17.Text || t4.Text == t18.Text || t4.Text == t19.Text
                    || t4.Text == t20.Text || t4.Text == t21.Text || t4.Text == t22.Text
                    || t4.Text == t23.Text || t4.Text == t24.Text || t4.Text == t25.Text
                    || t4.Text == t26.Text || t4.Text == t27.Text || t4.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t4.Text = "4";
                }
                else
                {
                    strCompare();
                    Red();
                    A4.Visible = true;
                    PA4.Visible = false;
                }

            }
        }

        private void t4_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t5.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t5.Text && A5.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t5.Text)
            {
                strCompare();
                Blue();
                A5.Visible = false;
                PA5.Visible = true;
                txtCarNumber.Text = t5.Text;
                t5.Text = "5";
            }
            else
            {
                t5.Text = txtCarNumber.Text;
                if (t5.Text == t1.Text || t5.Text == t2.Text || t5.Text == t3.Text
                    || t5.Text == t4.Text || t5.Text == t6.Text || t5.Text == t7.Text
                    || t5.Text == t8.Text || t5.Text == t9.Text || t5.Text == t10.Text
                    || t5.Text == t11.Text || t5.Text == t12.Text || t5.Text == t13.Text
                    || t5.Text == t14.Text || t5.Text == t15.Text || t5.Text == t16.Text
                    || t5.Text == t17.Text || t5.Text == t18.Text || t5.Text == t19.Text
                    || t5.Text == t20.Text || t5.Text == t21.Text || t5.Text == t22.Text
                    || t5.Text == t23.Text || t5.Text == t24.Text || t5.Text == t25.Text
                    || t5.Text == t26.Text || t5.Text == t27.Text || t5.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t5.Text = "5";
                }
                else
                {
                    strCompare();
                    Red();
                    A5.Visible = true;
                    PA5.Visible = false;
                }
            }
        }

        private void t5_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t6.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t6.Text && A6.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t6.Text)
            {
                strCompare();
                Blue();
                A6.Visible = false;
                PA6.Visible = true;
                txtCarNumber.Text = t6.Text;
                t6.Text = "6";
            }
            else
            {
                t6.Text = txtCarNumber.Text;
                if (t6.Text == t1.Text || t6.Text == t2.Text || t6.Text == t3.Text
                    || t6.Text == t4.Text || t6.Text == t5.Text || t6.Text == t7.Text
                    || t6.Text == t8.Text || t6.Text == t9.Text || t6.Text == t10.Text
                    || t6.Text == t11.Text || t6.Text == t12.Text || t6.Text == t13.Text
                    || t6.Text == t14.Text || t6.Text == t15.Text || t6.Text == t16.Text
                    || t6.Text == t17.Text || t6.Text == t18.Text || t6.Text == t19.Text
                    || t6.Text == t20.Text || t6.Text == t21.Text || t6.Text == t22.Text
                    || t6.Text == t23.Text || t6.Text == t24.Text || t6.Text == t25.Text
                    || t6.Text == t26.Text || t6.Text == t27.Text || t6.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t6.Text = "6";
                }
                else
                {
                    strCompare();
                    Red();
                    A6.Visible = true;
                    PA6.Visible = false;

                }

            }
        }

        private void t6_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t7.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t7.Text && A7.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t7.Text)
            {
                strCompare();
                Blue();
                A7.Visible = false;
                PA7.Visible = true;
                txtCarNumber.Text = t7.Text;
                t7.Text = "7";
            }
            else
            {
                t7.Text = txtCarNumber.Text;
                if (t7.Text == t1.Text || t7.Text == t2.Text || t7.Text == t3.Text
                    || t7.Text == t4.Text || t7.Text == t5.Text || t7.Text == t6.Text
                    || t7.Text == t8.Text || t7.Text == t9.Text || t7.Text == t10.Text
                    || t7.Text == t11.Text || t7.Text == t12.Text || t7.Text == t13.Text
                    || t7.Text == t14.Text || t7.Text == t15.Text || t7.Text == t16.Text
                    || t7.Text == t17.Text || t7.Text == t18.Text || t7.Text == t19.Text
                    || t7.Text == t20.Text || t7.Text == t21.Text || t7.Text == t22.Text
                    || t7.Text == t23.Text || t7.Text == t24.Text || t7.Text == t25.Text
                    || t7.Text == t26.Text || t7.Text == t27.Text || t7.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t7.Text = "7";
                }
                else
                {
                    strCompare();
                    Red();
                    A7.Visible = true;
                    PA7.Visible = false;
                }
            }
        }

        private void t7_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t8.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t8.Text && B1.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t8.Text)
            {
                strCompare();
                Blue();
                B1.Visible = false;
                PB1.Visible = true;
                txtCarNumber.Text = t8.Text;
                t8.Text = "8";
            }
            else
            {
                t8.Text = txtCarNumber.Text;
                if (t8.Text == t1.Text || t8.Text == t2.Text || t8.Text == t3.Text
                    || t8.Text == t4.Text || t8.Text == t5.Text || t8.Text == t6.Text
                    || t8.Text == t7.Text || t8.Text == t9.Text || t8.Text == t10.Text
                    || t8.Text == t11.Text || t8.Text == t12.Text || t8.Text == t13.Text
                    || t8.Text == t14.Text || t8.Text == t15.Text || t8.Text == t16.Text
                    || t8.Text == t17.Text || t8.Text == t18.Text || t8.Text == t19.Text
                    || t8.Text == t20.Text || t8.Text == t21.Text || t8.Text == t22.Text
                    || t8.Text == t23.Text || t8.Text == t24.Text || t8.Text == t25.Text
                    || t8.Text == t26.Text || t8.Text == t27.Text || t8.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t8.Text = "8";
                }
                else
                {
                    strCompare();
                    Red();
                    B1.Visible = true;
                    PB1.Visible = false;
                }
            }
        }

        private void t8_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t9.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t9.Text && B2.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t9.Text)
            {
                strCompare();
                Blue();
                B2.Visible = false;
                PB2.Visible = true;
                txtCarNumber.Text = t9.Text;
                t9.Text = "9";
            }
            else
            {
                t9.Text = txtCarNumber.Text;
                if (t9.Text == t1.Text || t9.Text == t2.Text || t8.Text == t3.Text
                    || t9.Text == t4.Text || t9.Text == t5.Text || t9.Text == t6.Text
                    || t9.Text == t7.Text || t9.Text == t8.Text || t9.Text == t10.Text
                    || t9.Text == t11.Text || t9.Text == t12.Text || t9.Text == t13.Text
                    || t9.Text == t14.Text || t9.Text == t15.Text || t9.Text == t16.Text
                    || t9.Text == t17.Text || t9.Text == t18.Text || t9.Text == t19.Text
                    || t9.Text == t20.Text || t9.Text == t21.Text || t9.Text == t22.Text
                    || t9.Text == t23.Text || t9.Text == t24.Text || t9.Text == t25.Text
                    || t9.Text == t26.Text || t9.Text == t27.Text || t9.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t9.Text = "9";
                }
                else
                {
                    strCompare();
                    Red();
                    B2.Visible = true;
                    PB2.Visible = false;
                }
            }
        }

        private void t9_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t10.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t10.Text && B3.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t10.Text)
            {
                strCompare();
                Blue();
                B3.Visible = false;
                PB3.Visible = true;
                txtCarNumber.Text = t10.Text;
                t10.Text = "10";
            }
            else
            {
                t10.Text = txtCarNumber.Text;
                if (t10.Text == t1.Text || t10.Text == t2.Text || t10.Text == t3.Text
                    || t10.Text == t4.Text || t10.Text == t5.Text || t10.Text == t6.Text
                    || t10.Text == t7.Text || t10.Text == t8.Text || t10.Text == t9.Text
                    || t10.Text == t11.Text || t10.Text == t12.Text || t10.Text == t13.Text
                    || t10.Text == t14.Text || t10.Text == t15.Text || t10.Text == t16.Text
                    || t10.Text == t17.Text || t10.Text == t18.Text || t10.Text == t19.Text
                    || t10.Text == t20.Text || t10.Text == t21.Text || t10.Text == t22.Text
                    || t10.Text == t23.Text || t10.Text == t24.Text || t10.Text == t25.Text
                    || t10.Text == t26.Text || t10.Text == t27.Text || t10.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t10.Text = "10";
                }
                else
                {
                    strCompare();
                    Red();
                    B3.Visible = true;
                    PB3.Visible = false;
                }
            }
        }

        private void t10_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t11.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t11.Text && B4.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t11.Text)
            {
                strCompare();
                Blue();
                B4.Visible = false;
                PB4.Visible = true;
                txtCarNumber.Text = t11.Text;
                t11.Text = "11";
            }
            else
            {
                t11.Text = txtCarNumber.Text;
                if (t11.Text == t1.Text || t11.Text == t2.Text || t1.Text == t3.Text
                    || t11.Text == t4.Text || t11.Text == t5.Text || t1.Text == t6.Text
                    || t11.Text == t7.Text || t11.Text == t8.Text || t1.Text == t9.Text
                    || t11.Text == t10.Text || t11.Text == t12.Text || t1.Text == t13.Text
                    || t11.Text == t14.Text || t11.Text == t15.Text || t1.Text == t16.Text
                    || t11.Text == t17.Text || t11.Text == t18.Text || t1.Text == t19.Text
                    || t11.Text == t20.Text || t11.Text == t21.Text || t1.Text == t22.Text
                    || t11.Text == t23.Text || t11.Text == t24.Text || t1.Text == t25.Text
                    || t11.Text == t26.Text || t11.Text == t27.Text || t1.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t11.Text = "11";
                }
                else
                {
                    strCompare();
                    Red();
                    B4.Visible = true;
                    PB4.Visible = false;
                }
            }
        }

        private void t11_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t12.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t12.Text && B5.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t12.Text)
            {
                strCompare();
                Blue();
                B5.Visible = false;
                PB5.Visible = true;
                txtCarNumber.Text = t12.Text;
                t12.Text = "12";
            }
            else
            {
                t12.Text = txtCarNumber.Text;
                if (t12.Text == t1.Text || t12.Text == t2.Text || t12.Text == t3.Text
                    || t12.Text == t4.Text || t12.Text == t5.Text || t12.Text == t6.Text
                    || t12.Text == t7.Text || t12.Text == t8.Text || t12.Text == t9.Text
                    || t12.Text == t10.Text || t12.Text == t11.Text || t12.Text == t13.Text
                    || t12.Text == t14.Text || t12.Text == t15.Text || t12.Text == t16.Text
                    || t12.Text == t17.Text || t12.Text == t18.Text || t12.Text == t19.Text
                    || t12.Text == t20.Text || t12.Text == t21.Text || t12.Text == t22.Text
                    || t12.Text == t23.Text || t12.Text == t24.Text || t12.Text == t25.Text
                    || t12.Text == t26.Text || t12.Text == t27.Text || t12.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t12.Text = "12";
                }
                else
                {
                    strCompare();
                    Red();
                    B5.Visible = true;
                    PB5.Visible = false;
                }
            }
        }

        private void t12_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t13.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t13.Text && B6.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t13.Text)
            {
                strCompare();
                Blue();
                B6.Visible = false;
                PB6.Visible = true;
                txtCarNumber.Text = t13.Text;
                t13.Text = "13";
            }
            else
            {
                t13.Text = txtCarNumber.Text;
                if (t13.Text == t1.Text || t13.Text == t2.Text || t13.Text == t3.Text
                    || t13.Text == t4.Text || t13.Text == t5.Text || t13.Text == t6.Text
                    || t13.Text == t7.Text || t13.Text == t8.Text || t13.Text == t9.Text
                    || t13.Text == t10.Text || t13.Text == t11.Text || t13.Text == t12.Text
                    || t13.Text == t14.Text || t13.Text == t15.Text || t13.Text == t16.Text
                    || t13.Text == t17.Text || t13.Text == t18.Text || t13.Text == t19.Text
                    || t13.Text == t20.Text || t13.Text == t21.Text || t13.Text == t22.Text
                    || t13.Text == t23.Text || t13.Text == t24.Text || t13.Text == t25.Text
                    || t13.Text == t26.Text || t13.Text == t27.Text || t13.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t13.Text = "13";
                }
                else
                {
                    strCompare();
                    Red();
                    B6.Visible = true;
                    PB6.Visible = false;
                }
            }
        }

        private void t13_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t14.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t14.Text && B7.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t14.Text)
            {
                strCompare();
                Blue();
                B7.Visible = false;
                PB7.Visible = true;
                txtCarNumber.Text = t14.Text;
                t14.Text = "14";
            }
            else
            {
                t14.Text = txtCarNumber.Text;
                if (t14.Text == t1.Text || t14.Text == t2.Text || t14.Text == t3.Text
                    || t14.Text == t4.Text || t14.Text == t5.Text || t14.Text == t6.Text
                    || t14.Text == t7.Text || t14.Text == t8.Text || t14.Text == t9.Text
                    || t14.Text == t10.Text || t14.Text == t11.Text || t14.Text == t12.Text
                    || t14.Text == t13.Text || t14.Text == t15.Text || t14.Text == t16.Text
                    || t14.Text == t17.Text || t14.Text == t18.Text || t14.Text == t19.Text
                    || t14.Text == t20.Text || t14.Text == t21.Text || t14.Text == t22.Text
                    || t14.Text == t23.Text || t14.Text == t24.Text || t14.Text == t25.Text
                    || t14.Text == t26.Text || t14.Text == t27.Text || t14.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t14.Text = "14";
                }
                else
                {
                    strCompare();
                    Red();
                    B7.Visible = true;
                    PB7.Visible = false;
                }
            }
        }

        private void t14_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t15.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t15.Text && C1.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t15.Text)
            {
                strCompare();
                Blue();
                C1.Visible = false;
                PC1.Visible = true;
                txtCarNumber.Text = t16.Text;
                t15.Text = "15";
            }
            else
            {
                t15.Text = txtCarNumber.Text;
                if (t15.Text == t1.Text || t15.Text == t2.Text || t15.Text == t3.Text
                    || t15.Text == t4.Text || t15.Text == t5.Text || t15.Text == t6.Text
                    || t15.Text == t7.Text || t15.Text == t8.Text || t15.Text == t9.Text
                    || t15.Text == t10.Text || t15.Text == t11.Text || t15.Text == t12.Text
                    || t15.Text == t13.Text || t15.Text == t14.Text || t15.Text == t16.Text
                    || t15.Text == t17.Text || t15.Text == t18.Text || t15.Text == t19.Text
                    || t15.Text == t20.Text || t15.Text == t21.Text || t15.Text == t22.Text
                    || t15.Text == t23.Text || t15.Text == t24.Text || t15.Text == t25.Text
                    || t15.Text == t26.Text || t15.Text == t27.Text || t15.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t15.Text = "15";
                }
                else
                {
                    strCompare();
                    Red();
                    C1.Visible = true;
                    PC1.Visible = false;
                }
            }
        }

        private void t15_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t16.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t16.Text && C2.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t16.Text)
            {
                strCompare();
                Blue();
                C2.Visible = false;
                PC2.Visible = true;
                txtCarNumber.Text = t16.Text;
                t16.Text = "16";
            }
            else
            {
                t16.Text = txtCarNumber.Text;
                if (t16.Text == t1.Text || t16.Text == t2.Text || t16.Text == t3.Text
                    || t16.Text == t4.Text || t16.Text == t5.Text || t16.Text == t6.Text
                    || t16.Text == t7.Text || t16.Text == t8.Text || t16.Text == t9.Text
                    || t16.Text == t10.Text || t16.Text == t11.Text || t16.Text == t12.Text
                    || t16.Text == t13.Text || t16.Text == t14.Text || t16.Text == t15.Text
                    || t16.Text == t17.Text || t16.Text == t18.Text || t16.Text == t19.Text
                    || t16.Text == t20.Text || t16.Text == t21.Text || t16.Text == t22.Text
                    || t16.Text == t23.Text || t16.Text == t24.Text || t16.Text == t25.Text
                    || t16.Text == t26.Text || t16.Text == t27.Text || t16.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t16.Text = "16";
                }
                else
                {
                    strCompare();
                    Red();
                    C2.Visible = true;
                    PC2.Visible = false;
                }
            }
        }

        private void t16_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t17.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t17.Text && C3.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t17.Text)
            {
                strCompare();
                Blue();
                C3.Visible = false;
                PC3.Visible = true;
                txtCarNumber.Text = t17.Text;
                t17.Text = "17";
            }
            else
            {
                t17.Text = txtCarNumber.Text;
                if (t17.Text == t1.Text || t17.Text == t2.Text || t17.Text == t3.Text
                    || t17.Text == t4.Text || t17.Text == t5.Text || t17.Text == t6.Text
                    || t17.Text == t7.Text || t17.Text == t8.Text || t17.Text == t9.Text
                    || t17.Text == t10.Text || t17.Text == t11.Text || t17.Text == t12.Text
                    || t17.Text == t13.Text || t17.Text == t14.Text || t17.Text == t15.Text
                    || t17.Text == t16.Text || t17.Text == t18.Text || t17.Text == t19.Text
                    || t17.Text == t20.Text || t17.Text == t21.Text || t17.Text == t22.Text
                    || t17.Text == t23.Text || t17.Text == t24.Text || t17.Text == t25.Text
                    || t17.Text == t26.Text || t17.Text == t27.Text || t17.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t17.Text = "17";
                }
                else
                {
                    strCompare();
                    Red();
                    C3.Visible = true;
                    PC3.Visible = false;
                }
            }
        }

        private void t17_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t18.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t18.Text && C4.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t18.Text)
            {
                strCompare();
                Blue();
                C4.Visible = false;
                PC4.Visible = true;
                txtCarNumber.Text = t18.Text;
                t18.Text = "18";
            }
            else
            {
                t18.Text = txtCarNumber.Text;
                if (t18.Text == t1.Text || t18.Text == t2.Text || t18.Text == t3.Text
                    || t18.Text == t4.Text || t18.Text == t5.Text || t18.Text == t6.Text
                    || t18.Text == t7.Text || t18.Text == t8.Text || t18.Text == t9.Text
                    || t18.Text == t10.Text || t18.Text == t11.Text || t18.Text == t12.Text
                    || t18.Text == t13.Text || t18.Text == t14.Text || t18.Text == t15.Text
                    || t18.Text == t16.Text || t18.Text == t17.Text || t18.Text == t19.Text
                    || t18.Text == t20.Text || t18.Text == t21.Text || t18.Text == t22.Text
                    || t18.Text == t23.Text || t18.Text == t24.Text || t18.Text == t25.Text
                    || t18.Text == t26.Text || t18.Text == t27.Text || t18.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t18.Text = "18";
                }
                else
                {
                    strCompare();
                    Red();
                    C4.Visible = true;
                    PC4.Visible = false;
                }
            }
        }

        private void t18_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t19.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t19.Text && C5.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t19.Text)
            {
                strCompare();
                Blue();
                C5.Visible = false;
                PC5.Visible = true;
                txtCarNumber.Text = t19.Text;
                t19.Text = "19";
            }
            else
            {
                t19.Text = txtCarNumber.Text;
                if (t19.Text == t1.Text || t19.Text == t2.Text || t19.Text == t3.Text
                    || t19.Text == t4.Text || t19.Text == t5.Text || t19.Text == t6.Text
                    || t19.Text == t7.Text || t19.Text == t8.Text || t19.Text == t9.Text
                    || t19.Text == t10.Text || t19.Text == t11.Text || t19.Text == t12.Text
                    || t19.Text == t13.Text || t19.Text == t14.Text || t19.Text == t15.Text
                    || t19.Text == t16.Text || t19.Text == t17.Text || t19.Text == t18.Text
                    || t19.Text == t20.Text || t19.Text == t21.Text || t19.Text == t22.Text
                    || t19.Text == t23.Text || t19.Text == t24.Text || t19.Text == t25.Text
                    || t19.Text == t26.Text || t19.Text == t27.Text || t19.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t19.Text = "19";
                }
                else
                {
                    strCompare();
                    Red();
                    C5.Visible = true;
                    PC5.Visible = false;
                }
            }
        }

        private void t19_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t20.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t20.Text && C6.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t20.Text)
            {
                strCompare();
                Blue();
                C6.Visible = false;
                PC6.Visible = true;
                txtCarNumber.Text = t20.Text;
                t20.Text = "20";
            }
            else
            {
                t20.Text = txtCarNumber.Text;
                if (t20.Text == t1.Text || t20.Text == t2.Text || t20.Text == t3.Text
                    || t20.Text == t4.Text || t20.Text == t5.Text || t20.Text == t6.Text
                    || t20.Text == t7.Text || t20.Text == t8.Text || t20.Text == t9.Text
                    || t20.Text == t10.Text || t20.Text == t11.Text || t20.Text == t12.Text
                    || t20.Text == t13.Text || t20.Text == t14.Text || t20.Text == t15.Text
                    || t20.Text == t16.Text || t20.Text == t17.Text || t20.Text == t18.Text
                    || t20.Text == t19.Text || t20.Text == t21.Text || t20.Text == t22.Text
                    || t20.Text == t23.Text || t20.Text == t24.Text || t20.Text == t25.Text
                    || t20.Text == t26.Text || t20.Text == t27.Text || t20.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t20.Text = "20";
                }
                else
                {
                    strCompare();
                    Red();
                    C6.Visible = true;
                    PC6.Visible = false;
                }
            }
        }

        private void t20_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t21.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t21.Text && C7.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t21.Text)
            {
                strCompare();
                Blue();
                C7.Visible = false;
                PC7.Visible = true;
                txtCarNumber.Text = t21.Text;
                t21.Text = "21";
            }
            else
            {
                t21.Text = txtCarNumber.Text;
                if (t21.Text == t1.Text || t21.Text == t2.Text || t21.Text == t3.Text
                    || t21.Text == t4.Text || t21.Text == t5.Text || t21.Text == t6.Text
                    || t21.Text == t7.Text || t21.Text == t8.Text || t21.Text == t9.Text
                    || t21.Text == t10.Text || t21.Text == t11.Text || t21.Text == t12.Text
                    || t21.Text == t13.Text || t21.Text == t14.Text || t21.Text == t15.Text
                    || t21.Text == t16.Text || t21.Text == t17.Text || t21.Text == t18.Text
                    || t21.Text == t19.Text || t21.Text == t20.Text || t21.Text == t22.Text
                    || t21.Text == t23.Text || t21.Text == t24.Text || t21.Text == t25.Text
                    || t21.Text == t26.Text || t21.Text == t27.Text || t21.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t21.Text = "21";
                }
                else
                {
                    strCompare();
                    Red();
                    C7.Visible = true;
                    PC7.Visible = false;
                }
            }
        }

        private void t21_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t22.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t22.Text && D1.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t22.Text)
            {
                strCompare();
                Blue();
                D1.Visible = false;
                PD1.Visible = true;
                txtCarNumber.Text = t22.Text;
                t22.Text = "22";
            }
            else
            {
                t22.Text = txtCarNumber.Text;
                if (t22.Text == t1.Text || t22.Text == t2.Text || t22.Text == t3.Text
                    || t22.Text == t4.Text || t22.Text == t5.Text || t22.Text == t6.Text
                    || t22.Text == t7.Text || t22.Text == t8.Text || t22.Text == t9.Text
                    || t22.Text == t10.Text || t22.Text == t11.Text || t22.Text == t12.Text
                    || t22.Text == t13.Text || t22.Text == t14.Text || t22.Text == t15.Text
                    || t22.Text == t16.Text || t22.Text == t17.Text || t22.Text == t18.Text
                    || t22.Text == t19.Text || t22.Text == t20.Text || t22.Text == t21.Text
                    || t22.Text == t23.Text || t22.Text == t24.Text || t22.Text == t25.Text
                    || t22.Text == t26.Text || t22.Text == t27.Text || t22.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t22.Text = "22";
                }
                else
                {
                    strCompare();
                    Red();
                    D1.Visible = true;
                    PD1.Visible = false;
                }
            }
        }

        private void t22_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t23.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t23.Text && D2.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t23.Text)
            {
                strCompare();
                Blue();
                D2.Visible = false;
                PD2.Visible = true;
                txtCarNumber.Text = t23.Text;
                t23.Text = "23";
            }
            else
            {
                t23.Text = txtCarNumber.Text;
                if (t23.Text == t1.Text || t23.Text == t2.Text || t23.Text == t3.Text
                    || t23.Text == t4.Text || t23.Text == t5.Text || t23.Text == t6.Text
                    || t23.Text == t7.Text || t23.Text == t8.Text || t23.Text == t9.Text
                    || t23.Text == t10.Text || t23.Text == t11.Text || t23.Text == t12.Text
                    || t23.Text == t13.Text || t23.Text == t14.Text || t23.Text == t15.Text
                    || t23.Text == t16.Text || t23.Text == t17.Text || t23.Text == t18.Text
                    || t23.Text == t19.Text || t23.Text == t20.Text || t23.Text == t21.Text
                    || t23.Text == t22.Text || t23.Text == t24.Text || t23.Text == t25.Text
                    || t23.Text == t26.Text || t23.Text == t27.Text || t23.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t23.Text = "23";
                }
                else
                {
                    strCompare();
                    Red();
                    D2.Visible = true;
                    PD2.Visible = false;
                }
            }
        }

        private void t23_MouseClick(object sender, MouseEventArgs e) 
        {
            ReservationState();
            if (resSpot == t24.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t24.Text && D3.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t24.Text)
            {
                strCompare();
                Blue();
                D3.Visible = false;
                PD3.Visible = true;
                txtCarNumber.Text = t24.Text;
                t24.Text = "24";
            }
            else
            {
                t24.Text = txtCarNumber.Text;
                if (t24.Text == t1.Text || t24.Text == t2.Text || t24.Text == t3.Text
                    || t24.Text == t4.Text || t24.Text == t5.Text || t24.Text == t6.Text
                    || t24.Text == t7.Text || t24.Text == t8.Text || t24.Text == t9.Text
                    || t24.Text == t10.Text || t24.Text == t11.Text || t24.Text == t12.Text
                    || t24.Text == t13.Text || t24.Text == t14.Text || t24.Text == t15.Text
                    || t24.Text == t16.Text || t24.Text == t17.Text || t24.Text == t18.Text
                    || t24.Text == t19.Text || t24.Text == t20.Text || t24.Text == t21.Text
                    || t24.Text == t22.Text || t24.Text == t23.Text || t24.Text == t25.Text
                    || t24.Text == t26.Text || t24.Text == t27.Text || t24.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t24.Text = "24";
                }
                else
                {
                    strCompare();
                    Red();
                    D3.Visible = true;
                    PD3.Visible = false;
                }
            }
        }

        private void t24_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t25.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t25.Text && D4.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t25.Text)
            {
                strCompare();
                Blue();
                D4.Visible = false;
                PD4.Visible = true;
                txtCarNumber.Text = t25.Text;
                t25.Text = "25";
            }
            else
            {
                t25.Text = txtCarNumber.Text;
                if (t25.Text == t1.Text || t25.Text == t2.Text || t25.Text == t3.Text
                    || t25.Text == t4.Text || t25.Text == t5.Text || t25.Text == t6.Text
                    || t25.Text == t7.Text || t25.Text == t8.Text || t25.Text == t9.Text
                    || t25.Text == t10.Text || t25.Text == t11.Text || t25.Text == t12.Text
                    || t25.Text == t13.Text || t25.Text == t14.Text || t25.Text == t15.Text
                    || t25.Text == t16.Text || t25.Text == t17.Text || t25.Text == t18.Text
                    || t25.Text == t19.Text || t25.Text == t20.Text || t25.Text == t21.Text
                    || t25.Text == t22.Text || t25.Text == t23.Text || t25.Text == t24.Text
                    || t25.Text == t26.Text || t25.Text == t27.Text || t25.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t25.Text = "25";
                }
                else
                {
                    strCompare();
                    Red();
                    D4.Visible = true;
                    PD4.Visible = false;
                }
            }
        }

        private void t25_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t26.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t26.Text && D5.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t26.Text)
            {
                strCompare();
                Blue();
                D5.Visible = false;
                PD5.Visible = true;
                txtCarNumber.Text = t26.Text;
                t26.Text = "26";
            }
            else
            {
                t26.Text = txtCarNumber.Text;
                if (t26.Text == t1.Text || t26.Text == t2.Text || t26.Text == t3.Text
                    || t26.Text == t4.Text || t26.Text == t5.Text || t26.Text == t6.Text
                    || t26.Text == t7.Text || t26.Text == t8.Text || t26.Text == t9.Text
                    || t26.Text == t10.Text || t26.Text == t11.Text || t26.Text == t12.Text
                    || t26.Text == t13.Text || t26.Text == t14.Text || t26.Text == t15.Text
                    || t26.Text == t16.Text || t26.Text == t17.Text || t26.Text == t18.Text
                    || t26.Text == t19.Text || t26.Text == t20.Text || t26.Text == t21.Text
                    || t26.Text == t22.Text || t26.Text == t23.Text || t26.Text == t24.Text
                    || t26.Text == t25.Text || t26.Text == t27.Text || t26.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t26.Text = "26";
                }
                else
                {
                    strCompare();
                    Red();
                    D5.Visible = true;
                    PD5.Visible = false;
                }
            }
        }

        private void t26_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t27.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t27.Text && D6.Visible == true || txtCarNumber.Text == "") MessageBox.Show("주차가 불가능합니다.");
            else if (txtCarNumber.Text == t27.Text)
            {
                strCompare();
                Blue();
                D6.Visible = false;
                PD6.Visible = true;
                txtCarNumber.Text = t27.Text;
                t27.Text = "27";
            }
            else
            {
                t27.Text = txtCarNumber.Text;
                if (t27.Text == t1.Text || t27.Text == t2.Text || t27.Text == t3.Text
                    || t27.Text == t4.Text || t27.Text == t5.Text || t27.Text == t6.Text
                    || t27.Text == t7.Text || t27.Text == t8.Text || t27.Text == t9.Text
                    || t27.Text == t10.Text || t27.Text == t11.Text || t27.Text == t12.Text
                    || t27.Text == t13.Text || t27.Text == t14.Text || t27.Text == t15.Text
                    || t27.Text == t16.Text || t27.Text == t17.Text || t27.Text == t18.Text
                    || t27.Text == t19.Text || t27.Text == t20.Text || t27.Text == t21.Text
                    || t27.Text == t22.Text || t27.Text == t23.Text || t27.Text == t24.Text
                    || t27.Text == t25.Text || t27.Text == t26.Text || t27.Text == t28.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t27.Text = "27";
                }
                else
                {
                    strCompare();
                    Red();
                    D6.Visible = true;
                    PD6.Visible = false;
                }
            }
        }

        private void t27_MouseClick(object sender, MouseEventArgs e)
        {
            ReservationState();
            if (resSpot == t28.Text)
            {
                MessageBox.Show("예약된 자리입니다.");
                Yellow();
            }
            else if (txtCarNumber.Text != t28.Text && D7.Visible == true || txtCarNumber.Text == "") MessageBox.Show("차량 번호를 입력해주세요.");
            else if (txtCarNumber.Text == t28.Text)
            {
                strCompare();
                Blue();
                D7.Visible = false;
                PD7.Visible = true;
                txtCarNumber.Text = t28.Text;
                t28.Text = "28";
            }
            else
            {
                t28.Text = txtCarNumber.Text;
                if (t28.Text == t1.Text || t28.Text == t2.Text || t28.Text == t3.Text
                    || t28.Text == t4.Text || t28.Text == t5.Text || t28.Text == t6.Text
                    || t28.Text == t7.Text || t28.Text == t8.Text || t28.Text == t9.Text
                    || t28.Text == t10.Text || t28.Text == t11.Text || t28.Text == t12.Text
                    || t28.Text == t13.Text || t28.Text == t14.Text || t28.Text == t15.Text
                    || t28.Text == t16.Text || t28.Text == t17.Text || t28.Text == t18.Text
                    || t28.Text == t19.Text || t28.Text == t20.Text || t28.Text == t21.Text
                    || t28.Text == t22.Text || t28.Text == t23.Text || t28.Text == t24.Text
                    || t28.Text == t25.Text || t28.Text == t26.Text || t28.Text == t27.Text)
                {
                    MessageBox.Show("해당 차량은 이미 주차가 되어있습니다.");
                    t28.Text = "28";
                }
                else
                {
                    strCompare();
                    Red();
                    D7.Visible = true;
                    PD7.Visible = false;
                }
            }
        }

        private void t_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A1.Visible == true && resSpot != t1.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A1.Visible == false && resSpot != t1.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if(A1.Visible == false && resSpot == t1.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t1_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A2.Visible == true && resSpot != t2.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A2.Visible == false && resSpot != t2.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A2.Visible == false && resSpot == t2.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t2_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A3.Visible == true && resSpot != t3.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A3.Visible == false && resSpot != t3.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A3.Visible == false && resSpot == t3.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t3_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A4.Visible == true && resSpot != t4.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A4.Visible == false && resSpot != t4.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A4.Visible == false && resSpot == t4.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t4_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A5.Visible == true && resSpot != t5.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A5.Visible == false && resSpot != t5.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A5.Visible == false && resSpot == t5.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t5_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A6.Visible == true && resSpot != t6.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A6.Visible == false && resSpot != t6.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A6.Visible == false && resSpot == t6.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t6_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (A7.Visible == true && resSpot != t7.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (A7.Visible == false && resSpot != t7.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (A7.Visible == false && resSpot == t7.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t7_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B1.Visible == true && resSpot != t8.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B1.Visible == false && resSpot != t8.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B1.Visible == false && resSpot == t8.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t8_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B2.Visible == true && resSpot != t9.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B2.Visible == false && resSpot != t9.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B2.Visible == false && resSpot == t9.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t9_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B3.Visible == true && resSpot != t10.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B3.Visible == false && resSpot != t10.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B3.Visible == false && resSpot == t10.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t10_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B4.Visible == true && resSpot != t11.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B4.Visible == false && resSpot != t11.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B4.Visible == false && resSpot == t11.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t11_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B5.Visible == true && resSpot != t12.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B5.Visible == false && resSpot != t12.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B5.Visible == false && resSpot == t12.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t12_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B6.Visible == true && resSpot != t13.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B6.Visible == false && resSpot != t13.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B6.Visible == false && resSpot == t13.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t13_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (B7.Visible == true && resSpot != t14.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (B7.Visible == false && resSpot != t14.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (B7.Visible == false && resSpot == t14.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t14_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C1.Visible == true && resSpot != t15.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C1.Visible == false && resSpot != t15.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C1.Visible == false && resSpot == t15.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t15_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C2.Visible == true && resSpot != t16.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C2.Visible == false && resSpot != t16.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C2.Visible == false && resSpot == t16.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t16_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C3.Visible == true && resSpot != t17.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C3.Visible == false && resSpot != t17.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C3.Visible == false && resSpot == t17.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t17_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C4.Visible == true && resSpot != t18.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C4.Visible == false && resSpot != t18.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C4.Visible == false && resSpot == t18.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t18_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C5.Visible == true && resSpot != t19.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C5.Visible == false && resSpot != t19.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C5.Visible == false && resSpot == t19.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t19_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C6.Visible == true && resSpot != t20.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C6.Visible == false && resSpot != t20.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C6.Visible == false && resSpot == t20.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t20_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (C7.Visible == true && resSpot != t21.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (C7.Visible == false && resSpot != t21.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (C7.Visible == false && resSpot == t21.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t21_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D1.Visible == true && resSpot != t22.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D1.Visible == false && resSpot != t22.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D1.Visible == false && resSpot == t22.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t22_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D2.Visible == true && resSpot != t23.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D2.Visible == false && resSpot != t23.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D2.Visible == false && resSpot == t23.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t23_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D3.Visible == true && resSpot != t24.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D3.Visible == false && resSpot != t24.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D3.Visible == false && resSpot == t24.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t24_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D4.Visible == true && resSpot != t25.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D4.Visible == false && resSpot != t25.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D4.Visible == false && resSpot == t25.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t25_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D5.Visible == true && resSpot != t26.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D5.Visible == false && resSpot != t26.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D5.Visible == false && resSpot == t26.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t26_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D6.Visible == true && resSpot != t27.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D6.Visible == false && resSpot != t27.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D6.Visible == false && resSpot == t27.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }

        private void t27_MouseHover(object sender, EventArgs e)
        {
            White();

            ReservationState();

            if (D7.Visible == true && resSpot != t28.Text)
            {
                RedBox.BackColor = Color.Red;
            }
            else if (D7.Visible == false && resSpot != t28.Text)
            {
                BlueBox.BackColor = Color.Blue;
            }
            else if (D7.Visible == false && resSpot == t28.Text)
            {
                YellowBox.BackColor = Color.Yellow;
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCarNumber.Text == "") MessageBox.Show("번호를 입력해주세요");
            else
            {
                RegisterPark register = new RegisterPark();
                register.ShowDialog();
                register.Dispose();
            } 
        }
    }
}
