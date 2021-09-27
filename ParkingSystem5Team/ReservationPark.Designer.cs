
namespace ParkingSystem5Team
{
    partial class reservation
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            this.CarNum = new System.Windows.Forms.TextBox();
            this.CarNumlb = new System.Windows.Forms.Label();
            this.ReservationSpotNumlb = new System.Windows.Forms.Label();
            this.ReservationSpotNum = new System.Windows.Forms.TextBox();
            this.ResrvationBtn = new System.Windows.Forms.Button();
            this.NowTimelb = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.TextBox();
            this.ReservationTime = new System.Windows.Forms.TextBox();
            this.ReservationTimelb = new System.Windows.Forms.Label();
            this.EndTimelb = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.CarInbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // CarNum
            // 
            this.CarNum.Enabled = false;
            this.CarNum.Font = new System.Drawing.Font("굴림", 12F);
            this.CarNum.Location = new System.Drawing.Point(124, 29);
            this.CarNum.Name = "CarNum";
            this.CarNum.Size = new System.Drawing.Size(183, 30);
            this.CarNum.TabIndex = 0;
            // 
            // CarNumlb
            // 
            this.CarNumlb.AutoSize = true;
            this.CarNumlb.Font = new System.Drawing.Font("굴림", 12F);
            this.CarNumlb.Location = new System.Drawing.Point(22, 32);
            this.CarNumlb.Name = "CarNumlb";
            this.CarNumlb.Size = new System.Drawing.Size(96, 20);
            this.CarNumlb.TabIndex = 1;
            this.CarNumlb.Text = "차량 번호";
            // 
            // ReservationSpotNumlb
            // 
            this.ReservationSpotNumlb.AutoSize = true;
            this.ReservationSpotNumlb.Font = new System.Drawing.Font("굴림", 12F);
            this.ReservationSpotNumlb.Location = new System.Drawing.Point(22, 90);
            this.ReservationSpotNumlb.Name = "ReservationSpotNumlb";
            this.ReservationSpotNumlb.Size = new System.Drawing.Size(96, 20);
            this.ReservationSpotNumlb.TabIndex = 2;
            this.ReservationSpotNumlb.Text = "예약 좌석";
            // 
            // ReservationSpotNum
            // 
            this.ReservationSpotNum.Font = new System.Drawing.Font("굴림", 12F);
            this.ReservationSpotNum.Location = new System.Drawing.Point(124, 87);
            this.ReservationSpotNum.Name = "ReservationSpotNum";
            this.ReservationSpotNum.Size = new System.Drawing.Size(183, 30);
            this.ReservationSpotNum.TabIndex = 2;
            // 
            // ResrvationBtn
            // 
            this.ResrvationBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResrvationBtn.Location = new System.Drawing.Point(26, 303);
            this.ResrvationBtn.Name = "ResrvationBtn";
            this.ResrvationBtn.Size = new System.Drawing.Size(281, 56);
            this.ResrvationBtn.TabIndex = 7;
            this.ResrvationBtn.Text = "예약";
            this.ResrvationBtn.UseVisualStyleBackColor = true;
            this.ResrvationBtn.Click += new System.EventHandler(this.ResrvationBtn_Click);
            // 
            // NowTimelb
            // 
            this.NowTimelb.AutoSize = true;
            this.NowTimelb.Font = new System.Drawing.Font("굴림", 12F);
            this.NowTimelb.Location = new System.Drawing.Point(24, 144);
            this.NowTimelb.Name = "NowTimelb";
            this.NowTimelb.Size = new System.Drawing.Size(96, 20);
            this.NowTimelb.TabIndex = 5;
            this.NowTimelb.Text = "현재 시간";
            // 
            // NowTime
            // 
            this.NowTime.Enabled = false;
            this.NowTime.Font = new System.Drawing.Font("굴림", 12F);
            this.NowTime.Location = new System.Drawing.Point(126, 141);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(183, 30);
            this.NowTime.TabIndex = 4;
            // 
            // ReservationTime
            // 
            this.ReservationTime.Font = new System.Drawing.Font("굴림", 12F);
            this.ReservationTime.Location = new System.Drawing.Point(126, 194);
            this.ReservationTime.Name = "ReservationTime";
            this.ReservationTime.Size = new System.Drawing.Size(183, 30);
            this.ReservationTime.TabIndex = 5;
            // 
            // ReservationTimelb
            // 
            this.ReservationTimelb.AutoSize = true;
            this.ReservationTimelb.Font = new System.Drawing.Font("굴림", 12F);
            this.ReservationTimelb.Location = new System.Drawing.Point(22, 197);
            this.ReservationTimelb.Name = "ReservationTimelb";
            this.ReservationTimelb.Size = new System.Drawing.Size(96, 20);
            this.ReservationTimelb.TabIndex = 8;
            this.ReservationTimelb.Text = "예약 시간";
            // 
            // EndTimelb
            // 
            this.EndTimelb.AutoSize = true;
            this.EndTimelb.Font = new System.Drawing.Font("굴림", 12F);
            this.EndTimelb.Location = new System.Drawing.Point(22, 252);
            this.EndTimelb.Name = "EndTimelb";
            this.EndTimelb.Size = new System.Drawing.Size(96, 20);
            this.EndTimelb.TabIndex = 9;
            this.EndTimelb.Text = "종료 시간";
            // 
            // EndTime
            // 
            this.EndTime.Enabled = false;
            this.EndTime.Font = new System.Drawing.Font("굴림", 12F);
            this.EndTime.Location = new System.Drawing.Point(124, 249);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(183, 30);
            this.EndTime.TabIndex = 6;
            // 
            // CarInbtn
            // 
            this.CarInbtn.Enabled = false;
            this.CarInbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CarInbtn.Location = new System.Drawing.Point(28, 365);
            this.CarInbtn.Name = "CarInbtn";
            this.CarInbtn.Size = new System.Drawing.Size(281, 56);
            this.CarInbtn.TabIndex = 3;
            this.CarInbtn.Text = "차량 주차";
            this.CarInbtn.UseVisualStyleBackColor = true;
            this.CarInbtn.Click += new System.EventHandler(this.CarInbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "주차 좌석 예약";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.CarInbtn);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.EndTimelb);
            this.Controls.Add(this.ReservationTimelb);
            this.Controls.Add(this.ReservationTime);
            this.Controls.Add(this.NowTime);
            this.Controls.Add(this.NowTimelb);
            this.Controls.Add(this.ResrvationBtn);
            this.Controls.Add(this.ReservationSpotNum);
            this.Controls.Add(this.ReservationSpotNumlb);
            this.Controls.Add(this.CarNumlb);
            this.Controls.Add(this.CarNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주차 좌석 예약";
            this.Load += new System.EventHandler(this.reservation_Load);
            this.Resize += new System.EventHandler(this.reservation_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarNum;
        private System.Windows.Forms.Label CarNumlb;
        private System.Windows.Forms.Label ReservationSpotNumlb;
        private System.Windows.Forms.TextBox ReservationSpotNum;
        private System.Windows.Forms.Button ResrvationBtn;
        private System.Windows.Forms.Label NowTimelb;
        private System.Windows.Forms.TextBox NowTime;
        private System.Windows.Forms.TextBox ReservationTime;
        private System.Windows.Forms.Label ReservationTimelb;
        private System.Windows.Forms.Label EndTimelb;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.Button CarInbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

