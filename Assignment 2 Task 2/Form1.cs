using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Task_2
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

 
        private void PictureBox1_Click(object sender, EventArgs e)
        {//Cuboid

        }


        private void Button1_Click(object sender, EventArgs e) //Cuboid tab 1
        {
            try //Looks for any incorrect inputs into the cuboid tab - tab 1
            {
                Double width = double.Parse(WCtextBox1.Text); //Defines the width entered into the textbox on the cuboid tab
                Double height = double.Parse(HCtextBox1.Text); //Defines the height entered into the textbox on the cuboid tab
                Double length = double.Parse(LCtextBox1.Text); //Defines the length entered into the textbox on the cuboid tab
                double volume = width * height * length; //Calculates volume
                double surfacearea = (2 * (length * width)) + (2 * (length * height)) + (2 * (height * width)); //Calculates Surface Area
                VClabel1.Text = "Volume = " + volume.ToString("0.000"); //Outputs volume to 3 decimal places
                SAClabel2.Text = "Surface Area = " + surfacearea.ToString("0.000"); //Outputs surface area to 3 decimal places
            }

            catch //catches the incorrect inputs and runs this code instead of the code in the try section
            { 
                        MessageBox.Show("Error on input"); //Tells the user their input was incorrect and they will need to retype
            }
        }

        private void Button2_Click(object sender, EventArgs e) //Sphere tab 2 equals button
        {
            try //Looks for any incorrect inputs into the sphere tab
            {

                Double radius = double.Parse(RStextBox1.Text); //Defines the radius entered into the textbox on the sphere tab
                double volumeS = (4.0 / 3.0 * (Math.PI * (radius * radius * radius))); //Calculates volume
                double surfaceAS = (4 * (Math.PI * (radius * radius))); //Calculates Surface area
                SphereVol.Text = "Volume = " + volumeS.ToString("0.000"); //Outputs volume to 3 decimal spaces
                SphereSA.Text = "Surface Area = " + surfaceAS.ToString("0.000"); //Outputs surface area to 3 decimal spaces
            }

            catch //catches the incorrect inputs and runs this code instead of the code in the try section
            {
                MessageBox.Show("Error on input"); //Tells the user their input was incorrect and they will need to retype
            }
            
        }


        private void TextBox1_TextChanged(object sender, EventArgs e) //Sphere radius text box. RStextBox1
        {

        }

        private void SphereVol_Click(object sender, EventArgs e) //Sphere volume label
        {

        }

        private void Label4_Click(object sender, EventArgs e) //Sphere surface label (SphereSA)
        {

        }

        private void ConeH_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConeR_TextChanged(object sender, EventArgs e)
        {

        }

        private void VolumeCone_Click(object sender, EventArgs e)
        {

        }

        private void ConeSA_Click(object sender, EventArgs e)
        {

        }

        private void ConeEquals_Click(object sender, EventArgs e)
        {
            try //Looks for any incorrect inputs into the sphere tab
            {

                Double radius = double.Parse(ConeR.Text); //Defines the radius entered into the textbox on the cone tab next to the R
                Double height = double.Parse(ConeH.Text); //Defines the radius entered into the textbot on the cone tab next to the H
                double volumeC = (1.0 / 3.0 * Math.PI * (radius * radius) * height); //Calculates volume
                double surfaceC = (Math.PI * radius *(radius + (Math.Sqrt((height * height) + (radius * radius)))))  ; //Calculates Surface area
                VolumeCone.Text = "Volume = " + volumeC.ToString("0.000"); //Outputs volume to 3 decimal spaces
                ConeSA.Text = "Surface Area = " + surfaceC.ToString("0.000"); //Outputs surface area to 3 decimal spaces
            }

            catch //catches the incorrect inputs and runs this code instead of the code in the try section
            {
                MessageBox.Show("Error on input"); //Tells the user their input was incorrect and they will need to retype
            }
        }
    }
}
