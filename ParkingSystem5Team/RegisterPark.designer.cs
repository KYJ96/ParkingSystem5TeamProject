
namespace ParkingSystem5Team
{
    partial class RegisterPark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterMember = new System.Windows.Forms.ListView();
            this.CarNumberList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDateList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarNumber3Text = new System.Windows.Forms.TextBox();
            this.CarNumberLabel = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumber1Text = new System.Windows.Forms.ComboBox();
            this.PhoneNumber2Text = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.InsertBT = new System.Windows.Forms.Button();
            this.FixBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.CarNumber1Text = new System.Windows.Forms.TextBox();
            this.CarNumber2Text = new System.Windows.Forms.TextBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePick = new System.Windows.Forms.DateTimePicker();
            this.EndDatePick = new System.Windows.Forms.DateTimePicker();
            this.CancelBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterMember
            // 
            this.RegisterMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarNumberList,
            this.NameList,
            this.PhoneNumberList,
            this.StartDateList,
            this.EndDateList});
            this.RegisterMember.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RegisterMember.FullRowSelect = true;
            this.RegisterMember.GridLines = true;
            this.RegisterMember.HideSelection = false;
            this.RegisterMember.Location = new System.Drawing.Point(16, 163);
            this.RegisterMember.Name = "RegisterMember";
            this.RegisterMember.Size = new System.Drawing.Size(954, 625);
            this.RegisterMember.TabIndex = 0;
            this.RegisterMember.TabStop = false;
            this.RegisterMember.UseCompatibleStateImageBehavior = false;
            this.RegisterMember.View = System.Windows.Forms.View.Details;
            // 
            // CarNumberList
            // 
            this.CarNumberList.Text = "차량 번호";
            this.CarNumberList.Width = 150;
            // 
            // NameList
            // 
            this.NameList.Text = "이름";
            this.NameList.Width = 150;
            // 
            // PhoneNumberList
            // 
            this.PhoneNumberList.Text = "전화 번호";
            this.PhoneNumberList.Width = 150;
            // 
            // StartDateList
            // 
            this.StartDateList.Text = "등록 날짜";
            this.StartDateList.Width = 200;
            // 
            // EndDateList
            // 
            this.EndDateList.Text = "종료 날짜";
            this.EndDateList.Width = 200;
            // 
            // CarNumber3Text
            // 
            this.CarNumber3Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarNumber3Text.Location = new System.Drawing.Point(260, 42);
            this.CarNumber3Text.MaxLength = 4;
            this.CarNumber3Text.Name = "CarNumber3Text";
            this.CarNumber3Text.Size = new System.Drawing.Size(102, 30);
            this.CarNumber3Text.TabIndex = 3;
            // 
            // CarNumberLabel
            // 
            this.CarNumberLabel.AutoSize = true;
            this.CarNumberLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarNumberLabel.Location = new System.Drawing.Point(14, 45);
            this.CarNumberLabel.Name = "CarNumberLabel";
            this.CarNumberLabel.Size = new System.Drawing.Size(96, 20);
            this.CarNumberLabel.TabIndex = 4;
            this.CarNumberLabel.Text = "차량 번호";
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Car.Location = new System.Drawing.Point(12, 9);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(96, 20);
            this.Car.TabIndex = 5;
            this.Car.Text = "차량 등록";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(14, 132);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(96, 20);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "전화 번호";
            // 
            // PhoneNumber1Text
            // 
            this.PhoneNumber1Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNumber1Text.FormattingEnabled = true;
            this.PhoneNumber1Text.Items.AddRange(new object[] {
            "010",
            "011",
            "012",
            "013",
            "014",
            "015",
            "016",
            "017"});
            this.PhoneNumber1Text.Location = new System.Drawing.Point(116, 128);
            this.PhoneNumber1Text.Name = "PhoneNumber1Text";
            this.PhoneNumber1Text.Size = new System.Drawing.Size(67, 28);
            this.PhoneNumber1Text.TabIndex = 5;
            this.PhoneNumber1Text.Text = "010";
            // 
            // PhoneNumber2Text
            // 
            this.PhoneNumber2Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNumber2Text.Location = new System.Drawing.Point(189, 127);
            this.PhoneNumber2Text.MaxLength = 8;
            this.PhoneNumber2Text.Name = "PhoneNumber2Text";
            this.PhoneNumber2Text.Size = new System.Drawing.Size(173, 30);
            this.PhoneNumber2Text.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(14, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "이름";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameText.Location = new System.Drawing.Point(116, 85);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(246, 30);
            this.NameText.TabIndex = 4;
            // 
            // InsertBT
            // 
            this.InsertBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InsertBT.Location = new System.Drawing.Point(737, 24);
            this.InsertBT.Name = "InsertBT";
            this.InsertBT.Size = new System.Drawing.Size(94, 39);
            this.InsertBT.TabIndex = 8;
            this.InsertBT.Text = "등록";
            this.InsertBT.UseVisualStyleBackColor = true;
            this.InsertBT.Click += new System.EventHandler(this.InsertBT_Click);
            // 
            // FixBT
            // 
            this.FixBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FixBT.Location = new System.Drawing.Point(737, 69);
            this.FixBT.Name = "FixBT";
            this.FixBT.Size = new System.Drawing.Size(94, 39);
            this.FixBT.TabIndex = 9;
            this.FixBT.Text = "수정";
            this.FixBT.UseVisualStyleBackColor = true;
            this.FixBT.Click += new System.EventHandler(this.FixBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteBT.Location = new System.Drawing.Point(737, 114);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(94, 39);
            this.DeleteBT.TabIndex = 10;
            this.DeleteBT.Text = "삭제";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // CarNumber1Text
            // 
            this.CarNumber1Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarNumber1Text.Location = new System.Drawing.Point(116, 42);
            this.CarNumber1Text.MaxLength = 3;
            this.CarNumber1Text.Name = "CarNumber1Text";
            this.CarNumber1Text.Size = new System.Drawing.Size(79, 30);
            this.CarNumber1Text.TabIndex = 1;
            // 
            // CarNumber2Text
            // 
            this.CarNumber2Text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarNumber2Text.Location = new System.Drawing.Point(205, 42);
            this.CarNumber2Text.MaxLength = 1;
            this.CarNumber2Text.Name = "CarNumber2Text";
            this.CarNumber2Text.Size = new System.Drawing.Size(42, 30);
            this.CarNumber2Text.TabIndex = 2;
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveBT.Location = new System.Drawing.Point(837, 24);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(133, 62);
            this.SaveBT.TabIndex = 11;
            this.SaveBT.Text = "저장";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndDateLabel.Location = new System.Drawing.Point(397, 95);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(96, 20);
            this.EndDateLabel.TabIndex = 18;
            this.EndDateLabel.Text = "종료 날짜";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDateLabel.Location = new System.Drawing.Point(397, 33);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(96, 20);
            this.StartDateLabel.TabIndex = 19;
            this.StartDateLabel.Text = "등록 날짜";
            // 
            // StartDatePick
            // 
            this.StartDatePick.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDatePick.Checked = false;
            this.StartDatePick.Location = new System.Drawing.Point(401, 61);
            this.StartDatePick.Name = "StartDatePick";
            this.StartDatePick.Size = new System.Drawing.Size(215, 25);
            this.StartDatePick.TabIndex = 7;
            this.StartDatePick.ValueChanged += new System.EventHandler(this.StartDatePick_ValueChanged);
            // 
            // EndDatePick
            // 
            this.EndDatePick.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndDatePick.Enabled = false;
            this.EndDatePick.Location = new System.Drawing.Point(401, 118);
            this.EndDatePick.Name = "EndDatePick";
            this.EndDatePick.Size = new System.Drawing.Size(215, 25);
            this.EndDatePick.TabIndex = 21;
            this.EndDatePick.TabStop = false;
            // 
            // CancelBT
            // 
            this.CancelBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CancelBT.Location = new System.Drawing.Point(837, 95);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(133, 59);
            this.CancelBT.TabIndex = 12;
            this.CancelBT.Text = "닫기";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // RegisterPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.EndDatePick);
            this.Controls.Add(this.StartDatePick);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.CarNumber2Text);
            this.Controls.Add(this.CarNumber1Text);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.FixBT);
            this.Controls.Add(this.InsertBT);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PhoneNumber1Text);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumber2Text);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.CarNumberLabel);
            this.Controls.Add(this.CarNumber3Text);
            this.Controls.Add(this.RegisterMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView RegisterMember;
        private System.Windows.Forms.TextBox CarNumber3Text;
        private System.Windows.Forms.Label CarNumberLabel;
        private System.Windows.Forms.Label Car;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.ComboBox PhoneNumber1Text;
        private System.Windows.Forms.TextBox PhoneNumber2Text;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button InsertBT;
        private System.Windows.Forms.Button FixBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.TextBox CarNumber1Text;
        private System.Windows.Forms.TextBox CarNumber2Text;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePick;
        private System.Windows.Forms.DateTimePicker EndDatePick;
        private System.Windows.Forms.ColumnHeader CarNumberList;
        private System.Windows.Forms.ColumnHeader NameList;
        private System.Windows.Forms.ColumnHeader PhoneNumberList;
        private System.Windows.Forms.ColumnHeader StartDateList;
        private System.Windows.Forms.ColumnHeader EndDateList;
        private System.Windows.Forms.Button CancelBT;
    }
}