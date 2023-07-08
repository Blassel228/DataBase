namespace Blood_Bank___Soul
{
    partial class Form2
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
            System.Windows.Forms.Label label9;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondindicator = new System.Windows.Forms.Label();
            this.firstindicator = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.donationInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bloodTypeInfo = new System.Windows.Forms.Label();
            this.emailInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberInfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.socialIDinfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surnameInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrollRightButton = new System.Windows.Forms.Button();
            this.scrollLeftButton = new System.Windows.Forms.Button();
            this.numberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(25, 299);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(103, 20);
            label9.TabIndex = 19;
            label9.Text = "Blood Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Records";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondindicator);
            this.groupBox1.Controls.Add(this.firstindicator);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.donationInfo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.bloodTypeInfo);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.emailInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phoneNumberInfo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.socialIDinfo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.surnameInfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scrollRightButton);
            this.groupBox1.Controls.Add(this.scrollLeftButton);
            this.groupBox1.Controls.Add(this.numberRecords);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // secondindicator
            // 
            this.secondindicator.AutoSize = true;
            this.secondindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondindicator.Location = new System.Drawing.Point(347, 25);
            this.secondindicator.Name = "secondindicator";
            this.secondindicator.Size = new System.Drawing.Size(24, 25);
            this.secondindicator.TabIndex = 24;
            this.secondindicator.Text = "0";
            // 
            // firstindicator
            // 
            this.firstindicator.AutoSize = true;
            this.firstindicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstindicator.Location = new System.Drawing.Point(293, 25);
            this.firstindicator.Name = "firstindicator";
            this.firstindicator.Size = new System.Drawing.Size(24, 25);
            this.firstindicator.TabIndex = 23;
            this.firstindicator.Text = "0";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Image = global::Blood_Bank___Soul.Properties.Resources.user1;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(404, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(285, 291);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // donationInfo
            // 
            this.donationInfo.AutoSize = true;
            this.donationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.donationInfo.Location = new System.Drawing.Point(177, 337);
            this.donationInfo.Name = "donationInfo";
            this.donationInfo.Size = new System.Drawing.Size(19, 20);
            this.donationInfo.TabIndex = 22;
            this.donationInfo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Donation Date";
            // 
            // bloodTypeInfo
            // 
            this.bloodTypeInfo.AutoSize = true;
            this.bloodTypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bloodTypeInfo.Location = new System.Drawing.Point(151, 299);
            this.bloodTypeInfo.Name = "bloodTypeInfo";
            this.bloodTypeInfo.Size = new System.Drawing.Size(19, 20);
            this.bloodTypeInfo.TabIndex = 20;
            this.bloodTypeInfo.Text = "0";
            // 
            // emailInfo
            // 
            this.emailInfo.AutoSize = true;
            this.emailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailInfo.Location = new System.Drawing.Point(90, 264);
            this.emailInfo.Name = "emailInfo";
            this.emailInfo.Size = new System.Drawing.Size(19, 20);
            this.emailInfo.TabIndex = 18;
            this.emailInfo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // phoneNumberInfo
            // 
            this.phoneNumberInfo.AutoSize = true;
            this.phoneNumberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberInfo.Location = new System.Drawing.Point(177, 229);
            this.phoneNumberInfo.Name = "phoneNumberInfo";
            this.phoneNumberInfo.Size = new System.Drawing.Size(19, 20);
            this.phoneNumberInfo.TabIndex = 16;
            this.phoneNumberInfo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone Number";
            // 
            // socialIDinfo
            // 
            this.socialIDinfo.AutoSize = true;
            this.socialIDinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socialIDinfo.Location = new System.Drawing.Point(115, 196);
            this.socialIDinfo.Name = "socialIDinfo";
            this.socialIDinfo.Size = new System.Drawing.Size(19, 20);
            this.socialIDinfo.TabIndex = 14;
            this.socialIDinfo.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "social ID";
            // 
            // surnameInfo
            // 
            this.surnameInfo.AutoSize = true;
            this.surnameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameInfo.Location = new System.Drawing.Point(115, 161);
            this.surnameInfo.Name = "surnameInfo";
            this.surnameInfo.Size = new System.Drawing.Size(19, 20);
            this.surnameInfo.TabIndex = 12;
            this.surnameInfo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Surname";
            // 
            // nameInfo
            // 
            this.nameInfo.AutoSize = true;
            this.nameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInfo.Location = new System.Drawing.Point(90, 131);
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(19, 20);
            this.nameInfo.TabIndex = 10;
            this.nameInfo.Text = "0";
            this.nameInfo.Click += new System.EventHandler(this.nameInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // idInfo
            // 
            this.idInfo.AutoSize = true;
            this.idInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idInfo.Location = new System.Drawing.Point(62, 96);
            this.idInfo.Name = "idInfo";
            this.idInfo.Size = new System.Drawing.Size(19, 20);
            this.idInfo.TabIndex = 8;
            this.idInfo.Text = "0";
            this.idInfo.Click += new System.EventHandler(this.idInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // scrollRightButton
            // 
            this.scrollRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollRightButton.Location = new System.Drawing.Point(633, 14);
            this.scrollRightButton.Name = "scrollRightButton";
            this.scrollRightButton.Size = new System.Drawing.Size(75, 46);
            this.scrollRightButton.TabIndex = 3;
            this.scrollRightButton.Text = ">>";
            this.scrollRightButton.UseVisualStyleBackColor = true;
            this.scrollRightButton.Click += new System.EventHandler(this.scrollRightButton_Click);
            // 
            // scrollLeftButton
            // 
            this.scrollLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollLeftButton.Location = new System.Drawing.Point(9, 14);
            this.scrollLeftButton.Name = "scrollLeftButton";
            this.scrollLeftButton.Size = new System.Drawing.Size(75, 46);
            this.scrollLeftButton.TabIndex = 2;
            this.scrollLeftButton.Text = "<<";
            this.scrollLeftButton.UseVisualStyleBackColor = true;
            this.scrollLeftButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberRecords
            // 
            this.numberRecords.AutoSize = true;
            this.numberRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRecords.Location = new System.Drawing.Point(308, 22);
            this.numberRecords.Name = "numberRecords";
            this.numberRecords.Size = new System.Drawing.Size(49, 29);
            this.numberRecords.TabIndex = 1;
            this.numberRecords.Text = " of ";
            this.numberRecords.Click += new System.EventHandler(this.numberRecords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Record";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(40, 467);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(205, 46);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(550, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Back to the main menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(544, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 31);
            this.label11.TabIndex = 7;
            this.label11.Text = "Made by:C#Soul";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scrollRightButton;
        private System.Windows.Forms.Button scrollLeftButton;
        private System.Windows.Forms.Label numberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label donationInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bloodTypeInfo;
        private System.Windows.Forms.Label emailInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label phoneNumberInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label socialIDinfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label surnameInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label secondindicator;
        private System.Windows.Forms.Label firstindicator;
        private System.Windows.Forms.Label label11;
    }
}