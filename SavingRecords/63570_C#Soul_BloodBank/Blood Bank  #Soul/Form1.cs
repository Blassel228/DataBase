using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank___Soul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.local_db.Count == 0)
            {
                MessageBox.Show("DB is empty, add some info", "Error");
            }
            else
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
           
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Check if the folder already exists
            if (!Directory.Exists(Data.image_file_path))
            {
                // Create the folder if it doesn't exist
                Directory.CreateDirectory(Data.image_file_path);
            }
            SaveData.db_filling();
        }
    }
}
