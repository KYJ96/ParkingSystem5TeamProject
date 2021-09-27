
namespace ParkingSystem5Team
{
    partial class Member
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
            this.components = new System.ComponentModel.Container();
            this.tbCarNumber3 = new System.Windows.Forms.TextBox();
            this.tbCarNumber2 = new System.Windows.Forms.TextBox();
            this.tbCharge = new System.Windows.Forms.TextBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbcharge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutCar = new System.Windows.Forms.Button();
            this.btnInCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.나간시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.들어온시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.전화번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.차량번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbOuttime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIntime = new System.Windows.Forms.TextBox();
            this.memberlist = new System.Windows.Forms.ListView();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCarNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCarNumber3
            // 
            this.tbCarNumber3.Enabled = false;
            this.tbCarNumber3.Font = new System.Drawing.Font("굴림", 12F);
            this.tbCarNumber3.Location = new System.Drawing.Point(288, 35);
            this.tbCarNumber3.MaxLength = 4;
            this.tbCarNumber3.Name = "tbCarNumber3";
            this.tbCarNumber3.Size = new System.Drawing.Size(96, 30);
            this.tbCarNumber3.TabIndex = 3;
            // 
            // tbCarNumber2
            // 
            this.tbCarNumber2.Enabled = false;
            this.tbCarNumber2.Font = new System.Drawing.Font("굴림", 12F);
            this.tbCarNumber2.Location = new System.Drawing.Point(223, 35);
            this.tbCarNumber2.MaxLength = 1;
            this.tbCarNumber2.Name = "tbCarNumber2";
            this.tbCarNumber2.Size = new System.Drawing.Size(59, 30);
            this.tbCarNumber2.TabIndex = 2;
            // 
            // tbCharge
            // 
            this.tbCharge.Enabled = false;
            this.tbCharge.Location = new System.Drawing.Point(540, 158);
            this.tbCharge.Name = "tbCharge";
            this.tbCharge.Size = new System.Drawing.Size(248, 25);
            this.tbCharge.TabIndex = 51;
            this.tbCharge.TabStop = false;
            this.tbCharge.Visible = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("굴림", 12F);
            this.lblClock.Location = new System.Drawing.Point(170, 80);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 20);
            this.lblClock.TabIndex = 50;
            this.lblClock.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(820, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbcharge
            // 
            this.lbcharge.AutoSize = true;
            this.lbcharge.Location = new System.Drawing.Point(533, 161);
            this.lbcharge.Name = "lbcharge";
            this.lbcharge.Size = new System.Drawing.Size(0, 15);
            this.lbcharge.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(471, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "금액 :";
            this.label2.Visible = false;
            // 
            // btnOutCar
            // 
            this.btnOutCar.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutCar.Location = new System.Drawing.Point(590, 111);
            this.btnOutCar.Name = "btnOutCar";
            this.btnOutCar.Size = new System.Drawing.Size(140, 38);
            this.btnOutCar.TabIndex = 7;
            this.btnOutCar.Text = "출차";
            this.btnOutCar.UseVisualStyleBackColor = true;
            this.btnOutCar.Click += new System.EventHandler(this.btnOutCar_Click);
            // 
            // btnInCar
            // 
            this.btnInCar.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInCar.Location = new System.Drawing.Point(590, 42);
            this.btnInCar.Name = "btnInCar";
            this.btnInCar.Size = new System.Drawing.Size(140, 30);
            this.btnInCar.TabIndex = 6;
            this.btnInCar.Text = "입차";
            this.btnInCar.UseVisualStyleBackColor = true;
            this.btnInCar.Click += new System.EventHandler(this.btnInCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(437, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "나간 시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(42, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "차량번호";
            // 
            // 나간시간
            // 
            this.나간시간.Text = "나간시간";
            this.나간시간.Width = 225;
            // 
            // 들어온시간
            // 
            this.들어온시간.Text = "들어온시간";
            this.들어온시간.Width = 225;
            // 
            // 전화번호
            // 
            this.전화번호.Text = "전화번호";
            this.전화번호.Width = 225;
            // 
            // 차량번호
            // 
            this.차량번호.Text = "차량번호";
            this.차량번호.Width = 225;
            // 
            // tbOuttime
            // 
            this.tbOuttime.Enabled = false;
            this.tbOuttime.Location = new System.Drawing.Point(539, 80);
            this.tbOuttime.Name = "tbOuttime";
            this.tbOuttime.Size = new System.Drawing.Size(249, 25);
            this.tbOuttime.TabIndex = 46;
            this.tbOuttime.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(418, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "들어온 시간";
            // 
            // tbIntime
            // 
            this.tbIntime.Enabled = false;
            this.tbIntime.Location = new System.Drawing.Point(540, 11);
            this.tbIntime.Name = "tbIntime";
            this.tbIntime.Size = new System.Drawing.Size(249, 25);
            this.tbIntime.TabIndex = 44;
            this.tbIntime.TabStop = false;
            // 
            // memberlist
            // 
            this.memberlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.차량번호,
            this.전화번호,
            this.들어온시간,
            this.나간시간});
            this.memberlist.Font = new System.Drawing.Font("굴림", 12F);
            this.memberlist.FullRowSelect = true;
            this.memberlist.GridLines = true;
            this.memberlist.HideSelection = false;
            this.memberlist.Location = new System.Drawing.Point(12, 190);
            this.memberlist.Name = "memberlist";
            this.memberlist.Size = new System.Drawing.Size(976, 599);
            this.memberlist.TabIndex = 43;
            this.memberlist.UseCompatibleStateImageBehavior = false;
            this.memberlist.View = System.Windows.Forms.View.Details;
            // 
            // tbPhone
            // 
            this.tbPhone.Enabled = false;
            this.tbPhone.Font = new System.Drawing.Font("굴림", 12F);
            this.tbPhone.Location = new System.Drawing.Point(139, 105);
            this.tbPhone.MaxLength = 8;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(245, 30);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.TabStop = false;
            // 
            // tbCarNumber
            // 
            this.tbCarNumber.Enabled = false;
            this.tbCarNumber.Font = new System.Drawing.Font("굴림", 12F);
            this.tbCarNumber.Location = new System.Drawing.Point(139, 35);
            this.tbCarNumber.MaxLength = 3;
            this.tbCarNumber.Name = "tbCarNumber";
            this.tbCarNumber.Size = new System.Drawing.Size(78, 30);
            this.tbCarNumber.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(820, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 92);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.tbCarNumber3);
            this.Controls.Add(this.tbCarNumber2);
            this.Controls.Add(this.tbCharge);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbcharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutCar);
            this.Controls.Add(this.btnInCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOuttime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIntime);
            this.Controls.Add(this.memberlist);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbCarNumber);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCarNumber3;
        private System.Windows.Forms.TextBox tbCarNumber2;
        private System.Windows.Forms.TextBox tbCharge;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbcharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutCar;
        private System.Windows.Forms.Button btnInCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader 나간시간;
        private System.Windows.Forms.ColumnHeader 들어온시간;
        private System.Windows.Forms.ColumnHeader 전화번호;
        private System.Windows.Forms.ColumnHeader 차량번호;
        private System.Windows.Forms.TextBox tbOuttime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIntime;
        private System.Windows.Forms.ListView memberlist;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCarNumber;
        private System.Windows.Forms.Button btnSave;
    }
}