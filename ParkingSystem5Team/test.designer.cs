
namespace ParkingSystem5Team
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbcarnum = new System.Windows.Forms.TextBox();
            this.tbcarnum3 = new System.Windows.Forms.TextBox();
            this.tbcarnum2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F);
            this.button1.Location = new System.Drawing.Point(122, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "등록 입출차";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 12F);
            this.button2.Location = new System.Drawing.Point(288, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "미등록 입출차";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbcarnum
            // 
            this.tbcarnum.Font = new System.Drawing.Font("굴림", 12F);
            this.tbcarnum.Location = new System.Drawing.Point(104, 202);
            this.tbcarnum.MaxLength = 3;
            this.tbcarnum.Name = "tbcarnum";
            this.tbcarnum.Size = new System.Drawing.Size(66, 30);
            this.tbcarnum.TabIndex = 2;
            // 
            // tbcarnum3
            // 
            this.tbcarnum3.Font = new System.Drawing.Font("굴림", 12F);
            this.tbcarnum3.Location = new System.Drawing.Point(228, 202);
            this.tbcarnum3.MaxLength = 4;
            this.tbcarnum3.Name = "tbcarnum3";
            this.tbcarnum3.Size = new System.Drawing.Size(101, 30);
            this.tbcarnum3.TabIndex = 3;
            // 
            // tbcarnum2
            // 
            this.tbcarnum2.Font = new System.Drawing.Font("굴림", 12F);
            this.tbcarnum2.Location = new System.Drawing.Point(176, 202);
            this.tbcarnum2.MaxLength = 1;
            this.tbcarnum2.Name = "tbcarnum2";
            this.tbcarnum2.Size = new System.Drawing.Size(46, 30);
            this.tbcarnum2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 12F);
            this.button3.Location = new System.Drawing.Point(452, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 107);
            this.button3.TabIndex = 5;
            this.button3.Text = "차량 등록";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 12F);
            this.button4.Location = new System.Drawing.Point(607, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 107);
            this.button4.TabIndex = 6;
            this.button4.Text = "예약";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbcarnum2);
            this.Controls.Add(this.tbcarnum3);
            this.Controls.Add(this.tbcarnum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbcarnum;
        private System.Windows.Forms.TextBox tbcarnum3;
        private System.Windows.Forms.TextBox tbcarnum2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}