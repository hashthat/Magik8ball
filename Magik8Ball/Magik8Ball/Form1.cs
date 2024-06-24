using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// https://www.vecteezy.com/vector-art/87501-magic-8-ball-vector-pack
namespace Magik8Ball
{
    // Naturally created with the form from creating the button and the App in WinForm
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Button object was created and the object was added to the main script.
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 15); // Generates a random number between 1 and 15

            switch (randomNumber)
            {
                // the case statement sorts through the local files which display the image of the 8ball for the answer to the question
                case 1:
                    pictureBox1.Image = Properties.Resources._00_magic_8_ball_vector_pack;
                    break; // break is needed to break the sift to go on to the next picture in the file.
                case 2:
                    pictureBox1.Image = Properties.Resources._01_magic_8_ball_vector_pack;
                    break; // the pictureBox1 is the properties tab to the right as the code is locating the image
                case 3:
                    pictureBox1.Image = Properties.Resources._02_magic_8_ball_vector_pack;
                    break; // the Image is found in the Resources, and then each picturebox1 element is expressed as the photo is used and found by the random number generator.
                case 4:
                    pictureBox1.Image = Properties.Resources._03_magic_8_ball_vector_pack;
                    break; // All the cases are the same in form, the images and the image numbers are different. but it works!
                case 5:
                    pictureBox1.Image = Properties.Resources._04_magic_8_ball_vector_pack;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._05_magic_8_ball_vector_pack;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._06_magic_8_ball_vector_pack;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._07_magic_8_ball_vector_pack;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._08_magic_8_ball_vector_pack;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._09_magic_8_ball_vector_pack;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._10_magic_8_ball_vector_pack;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources._11_magic_8_ball_vector_pack;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources._12_magic_8_ball_vector_pack;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources._13_magic_8_ball_vector_pack;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources._14_magic_8_ball_vector_pack;
                    break;


            }
        }
    }
}
