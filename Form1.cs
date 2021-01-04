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

        private void Form1_Load(object sender, EventArgs e)
        {
        
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var files = System.IO.Directory.GetFiles("D://Refrences/Folder 1","*.jpg");
            var imageChoice = files[rand.Next(files.Length)];
            pictureBox1.ImageLocation = imageChoice;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(1280, 720);   
        }
    }
}
