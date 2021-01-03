using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
///using Bitmap;

namespace ImageOpenerCsharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = new Bitmap.(open.FileName);
            }
            */
        }
    }
}
