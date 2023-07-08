using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank___Soul
{
    public partial class Form3 : Form
    {
        static string local_path = Data.image_file_path;
        public Form3()
        {
            InitializeComponent();

            avatarBox.Image = Properties.Resources.user1;

            dateInfo.Text = DateTime.Now.ToString();
        }

        private void dateInfo_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            Data.image = avatarBox.Image;
            Data.ID = IdGeneration.idGenerator();

            //index will be used as name for picture and as pointer 
            //adding info to the list that will be recorded
            list.Add(Data.ID);
            list.Add(nameBox.Text);
            list.Add(surnameBox.Text);
            list.Add(socialIDbox.Text);
            list.Add(phoneBox.Text);
            list.Add(emailBox.Text);
            list.Add(bloodBox.Text);
            list.Add(dateInfo.Text);
            

            Data.ID = "";
            //adding picture with a proper name to the folder 
            
             if (avatarBox.Image != null)
             {
                local_path = Data.image_file_path;
                Data.extension = Path.GetExtension(Data.picture_name); //getting extension of the file
              
                Data.image.Tag = Data.picture_name;                    //assigning this name 
                local_path = Path.Combine(local_path, Data.picture_name);
                Data.image.Save(local_path, System.Drawing.Imaging.ImageFormat.Jpeg);                           //saving the picture
             }
            
            list.Add(Data.picture_name); //adding picture 
            SaveData.CreateList(list);

            //cleaning textBoxes and Image, again it is a long way but Controls does not work for some reason
            //maybe I do something wrong dunno
            nameBox.Text = "";
            surnameBox.Text = "";
            socialIDbox.Text = "";
            phoneBox.Text = string.Empty;
            emailBox.Text = string.Empty;
            bloodBox.Text = string.Empty;
            dateInfo.Text = string.Empty;

            avatarBox.Image = Properties.Resources.user1;
            Data.picture_name = string.Empty;

            MessageBox.Show("Record was saved!", "Saved");
            dateInfo.Text = DateTime.Now.ToString(); //adding new time 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //the most painful part, I have been thinking about this logic for a while, not sure if it is going to work though

            using (OpenFileDialog ofd = new OpenFileDialog())
            { 
                    ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*) ";
                    string selectedFile = ofd.FileName;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            avatarBox.Image = new Bitmap(ofd.FileName);
                            //Data.picture_name = ofd.FileName;               //assigning to the veriable name of the picture
                            Data.image = avatarBox.Image;
                        }

                        catch
                        {
                            MessageBox.Show("This type of file is not supported", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }   
        }
        private void avatarBox_Click(object sender, EventArgs e)
        {

        }
    }
}
