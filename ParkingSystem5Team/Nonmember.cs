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
    public partial class Nonmember : Form
    {
        public string intime, outtime;
        MainParkingSystem mainForm = null;
        public Nonmember()
        {
            InitializeComponent();
            nonmemberlist.FullRowSelect = true;
            LoadData(@"C:\ParkingSystem\NonMember\Nonmember.csv");
        }
                                           

        private void btnInCar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblClock.Text = DateTime.Now.ToString("yy년MM월dd일 HH:mm");
            tbIntime.Text = lblClock.Text;

            if (tbCarNumber.Text == ""||tbCarNumber2.Text ==""||tbCarNumber3.Text == "")
            {
                MessageBox.Show("차량번호를 입력해주세요.");
            }
            else
            {
                string carNumber = tbCarNumber.Text + tbCarNumber2.Text + tbCarNumber3.Text;
                nonmemberlist.Items.Add(new ListViewItem(new string[] { carNumber, tbPhone.Text = "None", tbIntime.Text, "" }));
            }
            tbCarNumber.Clear();
            tbCarNumber2.Clear();
            tbCarNumber3.Clear();
            tbIntime.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            string dirPath = @"C:\ParkingSystem\NonMember";
            Directory.CreateDirectory(dirPath);
            StreamWriter sw = new StreamWriter(new FileStream(dirPath + @"\Nonmember.csv", FileMode.Create)
                , System.Text.Encoding.UTF8);

            string[,] data;
            int nRow = nonmemberlist.Items.Count + 1;
            int nCol = 4;

            data = new string[nRow, nCol]; //리스트 뷰에 있는 column 값 data 행열에 추가
            data[0, 0] = nonmemberlist.Columns[0].Text;
            data[0, 1] = nonmemberlist.Columns[1].Text;
            data[0, 2] = nonmemberlist.Columns[2].Text;
            data[0, 3] = nonmemberlist.Columns[3].Text;
            

            int itemsNumber = 0;
            for (int i = 1; i < nRow; i++) //리스트 뷰에 있는 아이템값 data 행열에 추가
            {
                if (itemsNumber > nRow) break;
                for (int j = 0; j < nCol; j++)
                {
                    data[i, j] = nonmemberlist.Items[itemsNumber].SubItems[j].Text;
                }
                itemsNumber++;
            }

            for (int i = 0; i < nCol; i++) //column 값 엑셀에 추가
            {
                sw.Write(data[0, i] + "\t");


            }
            sw.Write("\n");

            for (int j = 1; j < nRow; j++) //리스트 뷰에 추가된 값들 엑셀에 추가
            {
                for (int i = 0; i < nCol; i++)
                {
                    sw.Write(data[j, i] + "\t");
                }
                sw.Write("\n");
            }
            sw.Close();
        }
        private void LoadData(string fileName)
        {
            
            if (File.Exists(fileName) == false)
            {
                return;
            }
            FileStream fs = File.OpenRead(fileName);
            StreamReader sr = new StreamReader(fs);
            //StreamReader sr = new StreamReader(new FileStream(fs, FileMode.Open), System.Text.Encoding.UTF8);
            while (sr.EndOfStream == false)
            {
                string data = sr.ReadLine();
                if (data == null) { break; }
                string[] sitems = data.Split('\t', '\n');

                nonmemberlist.Items.Add(new ListViewItem(new string[] { sitems[0], sitems[1], sitems[2]
                ,sitems[3]}));

            }
            nonmemberlist.Items.RemoveAt(0);
            sr.Close();
            fs.Close();
        }
        private void Nonmember_Load(object sender, EventArgs e)
        {
            mainForm = (MainParkingSystem)Owner;
            tbCarNumber.Text = mainForm.cn;
            tbCarNumber2.Text = mainForm.cn2;
            tbCarNumber3.Text = mainForm.cn3;
        }

        private void btnOutCar_Click(object sender, EventArgs e)
        {

            lblClock.Text = DateTime.Now.ToString("yy년MM월dd일 HH:mm");
            tbOuttime.Text = lblClock.Text;

            try
            {
                nonmemberlist.SelectedItems[0].SubItems[3].Text = tbOuttime.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("리스트에서 차량을 선택해주세요.");
            }
            tbOuttime.Clear();
        }
        

    }
}
