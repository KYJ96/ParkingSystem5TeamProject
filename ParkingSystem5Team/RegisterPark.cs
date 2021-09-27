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
    public partial class RegisterPark : Form
    {
        public RegisterPark()
        {
            InitializeComponent();
            EndDatePick.Value = StartDatePick.Value.AddMonths(1);
            LoadData(@"C:\ParkingSystem\Register\Register.csv");
        }
        
        private void InsertBT_Click(object sender, EventArgs e) //차량 등록
        {
            string CarNumber = CarNumber1Text.Text + CarNumber2Text.Text + CarNumber3Text.Text;
            //startdatePick 에서 30일 후 enddatePick

            if (CarNumber1Text.Text == "" || CarNumber2Text.Text == "" || CarNumber3Text.Text == "" 
                || NameText.Text == "" || PhoneNumber2Text.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
            }
            else
            {
                RegisterMember.Items.Add(new ListViewItem(new string[] {CarNumber, NameText.Text,
                    PhoneNumber1Text.Text+PhoneNumber2Text.Text, StartDatePick.Text, EndDatePick.Text}));
                CarNumber1Text.Clear();
                CarNumber2Text.Clear();
                CarNumber3Text.Clear();
                NameText.Clear();
                PhoneNumber2Text.Clear();
            }
        }

        private void FixBT_Click(object sender, EventArgs e) //등록된 차량 수정
        {
            if (CarNumber1Text.Text == "" || CarNumber2Text.Text == "" || CarNumber3Text.Text == ""
                || PhoneNumber2Text.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
            }
            try
            {
                RegisterMember.SelectedItems[0].SubItems[0].Text = CarNumber1Text.Text + CarNumber2Text.Text + CarNumber3Text.Text; //차량 번호 수정
                RegisterMember.SelectedItems[0].SubItems[2].Text = PhoneNumber1Text.Text + PhoneNumber2Text.Text; //핸드폰 번호 수정
            }
            catch (Exception)
            {
                MessageBox.Show("수정 할 항목을 다시 확인해 주세요.");
            }
            finally
            {
                CarNumber1Text.Clear();
                CarNumber2Text.Clear();
                CarNumber3Text.Clear();
                PhoneNumber2Text.Clear();
            }
        }

        private void DeleteBT_Click(object sender, EventArgs e) //등록된 차량 삭제
        {
            try
            {
                int index = RegisterMember.FocusedItem.Index;
                RegisterMember.Items.RemoveAt(index);
            }
            catch (Exception)
            {
                MessageBox.Show("삭제할 항목을 다시 확인해 주세요.");
            }
        }

        private void StartDatePick_ValueChanged(object sender, EventArgs e) //월정액 한 달씩 계산
        {
            EndDatePick.Value = StartDatePick.Value.AddMonths(1);
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string dirPath = @"C:\ParkingSystem\Register";
            Directory.CreateDirectory(dirPath);
            StreamWriter sw = new StreamWriter(new FileStream(dirPath + @"\Register.csv", FileMode.Create)
                ,System.Text.Encoding.UTF8);
            
            string[,] data;
            int nRow = RegisterMember.Items.Count + 1;
            int nCol = 5;

            data = new string[nRow, nCol]; //리스트 뷰에 있는 column 값 data 행열에 추가
            data[0, 0] = RegisterMember.Columns[0].Text;
            data[0, 1] = RegisterMember.Columns[1].Text;
            data[0, 2] = RegisterMember.Columns[2].Text;
            data[0, 3] = RegisterMember.Columns[3].Text;
            data[0, 4] = RegisterMember.Columns[4].Text;

            int itemsNumber = 0;
            for(int i = 1; i < nRow; i++) //리스트 뷰에 있는 아이템값 data 행열에 추가
            {
                if (itemsNumber > nRow) break;
                for (int j = 0; j < nCol; j++)
                {
                    data[i, j] = RegisterMember.Items[itemsNumber].SubItems[j].Text;
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
                for(int i = 0; i<nCol; i++)
                {
                    sw.Write(data[j, i] + "\t");
                }
                sw.Write("\n");
            }
            sw.Close();

        }

        private void LoadData(string fileName)
        {
            int nCol = RegisterMember.Columns.Count;
            int nRow = RegisterMember.Items.Count;
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
                string[] sitems = data.Split('\t','\n');

                RegisterMember.Items.Add(new ListViewItem(new string[] { sitems[0], sitems[1], sitems[2]
                ,sitems[3],sitems[4]}));
                
            }
            RegisterMember.Items.RemoveAt(0);
            sr.Close();
            fs.Close();
        }
        
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
