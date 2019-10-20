using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorChecker
{
    public partial class Form1 : Form
    {
        Door door;
        Wardrobe wardrobe;

        public Form1()
        {
            InitializeComponent();
            door = new Door();
            wardrobe = new Wardrobe();
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            try
            {
                door.h = Convert.ToInt32(DoorH.Text);
                door.w = Convert.ToInt32(DoorW.Text);

                wardrobe.h = Convert.ToInt32(wardrobeH.Text);
                wardrobe.w = Convert.ToInt32(wardrobeW.Text);
                wardrobe.l = Convert.ToInt32(wardrobeL.Text);
            }
            catch (Exception)
            {
                RezText.Text = "неправильні дані";
                return;
            }
            if (Check(door, wardrobe) == true)
            {
                RezText.Text = "Шафа пройде у двері";
            }
            else RezText.Text = "Шафа не пройде у двері";

        }

        private bool Check(Door door, Wardrobe wardrobe)
        {
            //Існує 6 можливостей покрутити шафу щоб вона влізла в двері.
            if (door.h >= wardrobe.h && door.w >= wardrobe.w) return true;
            else if (door.h >= wardrobe.h && door.w >= wardrobe.l) return true;
            else if (door.h >= wardrobe.l && door.w >= wardrobe.w) return true;

            else if (door.w >= wardrobe.h && door.h >= wardrobe.w) return true;
            else if (door.w >= wardrobe.h && door.h >= wardrobe.l) return true;
            else if (door.w >= wardrobe.l && door.h >= wardrobe.w) return true;

            else return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void wardrobeW_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoorH_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoorW_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wardrobeW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
