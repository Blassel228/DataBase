using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank___Soul
{
    public partial class Form2 : Form
    {
        int i = 0;
        Image image = null;

        public Form2()
        {
            InitializeComponent();
          
        }
        private void refresh()
        {
             if (i + 1 == Data.local_db.Count)
                { scrollRightButton.Enabled = false; }
            if (i + 1 == 1)
            { scrollLeftButton.Enabled = false; }

            if (secondindicator.Text == "1")
            {
                scrollRightButton.Enabled = false;
                scrollLeftButton.Enabled = false;
            }

      
                firstindicator.Text = (i + 1).ToString();
            idInfo.Text = Data.local_db[i][0];
            nameInfo.Text = Data.local_db[i][1];
            surnameInfo.Text = Data.local_db[i][2];
            socialIDinfo.Text = Data.local_db[i][3];
            phoneNumberInfo.Text = Data.local_db[i][4];
            emailInfo.Text = Data.local_db[i][5];
            bloodTypeInfo.Text = Data.local_db[i][6];
            donationInfo.Text = Data.local_db[i][7];
            image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Data.image_file_path, Data.local_db[i][8]));
            pictureBox.Image = image;
        }
        private void scroll(string buttonName)
        {
           
            scrollRightButton.Enabled = true;
            if (Data.local_db[i][8]!="")
            {
                image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Data.image_file_path,  Data.local_db[i][8]));
                pictureBox.Image = image;
                pictureBox.Refresh();
            }
            else
            {
                pictureBox.Image = Properties.Resources.user1;
            }
           
            if (buttonName == scrollLeftButton.Name)
            {
                if (Convert.ToInt32(firstindicator.Text) == 1)
                {

                    scrollLeftButton.Enabled = false;
                }
            }

            else if(buttonName == scrollRightButton.Name) 
            {
                deleteButton.Enabled = true;
                scrollLeftButton.Enabled = true;
                if (Convert.ToInt32(firstindicator.Text) == Data.local_db.Count)
                {

                    scrollRightButton.Enabled = false;
                }
            }
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            scroll(scrollLeftButton.Name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to delete", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    int j = 0;
                    if (firstindicator.Text != secondindicator.Text)
                    { j = i + 1; }
                    else { j = 0; }

        

                    Data.local_db.RemoveAt(i);
                    

                    secondindicator.Text = Data.local_db.Count.ToString();

                    using (StreamWriter sr = new StreamWriter(Data.file))
                    {
                        foreach (List<string> list in Data.local_db)
                        {
                            sr.WriteLine(string.Join(";", list));
                        }
                    }


                    if (secondindicator.Text == "1")
                    {
                        scrollRightButton.Enabled = false;
                        scrollLeftButton.Enabled = false;
                    }
                    i--;

                    if (j > i)
                    {
                        i++;
                        scroll(scrollRightButton.Name);
                    }
                    refresh();

                }
                catch
                {

                    secondindicator.Text = Data.local_db.Count.ToString();
                    firstindicator.Text = Data.local_db.Count.ToString();
                    using (StreamWriter sr = new StreamWriter(Data.file))
                    {
                        foreach (List<string> list in Data.local_db)
                        {
                            sr.WriteLine(string.Join(";", list));
                        }
                    }

                    deleteButton.Enabled = false;
                    scrollRightButton.Enabled = false;
                    scrollLeftButton.Enabled = false;
                    idInfo.Text = string.Empty;
                    nameInfo.Text = string.Empty;
                    surnameInfo.Text = string.Empty;
                    socialIDinfo.Text = string.Empty;
                    phoneNumberInfo.Text = string.Empty;
                    emailInfo.Text = string.Empty;
                    bloodTypeInfo.Text = string.Empty;
                    donationInfo.Text = string.Empty;
                    pictureBox.Image = Properties.Resources.user1;


                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Application.Restart();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            secondindicator.Text = Data.local_db.Count.ToString();
            firstindicator.Text = Convert.ToString(i + 1);

            scroll(scrollLeftButton.Name);

            if (secondindicator.Text == "1")
            {
 
                scrollRightButton.Enabled = false;
            }
            if (Convert.ToInt32(secondindicator.Text)==1)
            {
                scrollRightButton.Enabled = false;
            }
            scrollLeftButton.Enabled = false;
            //again for some reason Controls does not work as I want so...
        }

        private void idInfo_Click(object sender, EventArgs e)
        {

        }

        private void nameInfo_Click(object sender, EventArgs e)
        {

        }

        private void scrollRightButton_Click(object sender, EventArgs e)
        {
            i++;
            scroll(scrollRightButton.Name);
        }

        private void numberRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
