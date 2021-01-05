using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOpenerCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void getImage(string location)
        {
            var rand = new Random();
            var files = System.IO.Directory.GetFiles(location, "*", System.IO.SearchOption.AllDirectories);
            var imageChoice = files[rand.Next(files.Length)];
            pictureBox1.ImageLocation = imageChoice;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(1280, 720);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
  
        }
        /*
        private void button1(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 5");
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 1");
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getImage("D:/Refrences/Folder 5");
        }
    }
}
