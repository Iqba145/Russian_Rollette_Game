using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Rollette_Game
{
    public partial class RRGame : Form
    {
        public details obj_Details = new details();
        public Random rd = new Random();
        int shoot = 0;

        public RRGame()
        {
            InitializeComponent();
            //loading the sound generated button 
            obj_Details.fire = rd.Next(1, 7);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // starting the game of the fire with giving the instruction 
            //MessageBox.Show("You have only 2 bullet to fire ");
            //display the frst image which is empty
            pbArea.Image = Properties.Resources.k1;
            // enable the rest button to fire 
            Btn_Load.Enabled = true;
            Btn_Start.Enabled = false;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            String img = obj_Details.load();
            pbArea.Image = Properties.Resources.k2;
            // enable the rest button to fire 
            btn_Spin.Enabled = true;
            Btn_Load.Enabled = false;
        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            String img = obj_Details.spin();
            pbArea.Image = Properties.Resources.k3;
            // enable the rest button to fire 
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;
            btn_Spin.Enabled = false;

        }


        

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            String img = obj_Details.shoot();
            pbArea.Image = Properties.Resources.k4;
            // enable the rest button to fire 

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sound);
            player.Play();


            // code to fire  
            obj_Details.trigger++;
            shoot++;
            if (obj_Details.trigger == 4)
            {
                    MessageBox.Show("You are still alive ");
                    btn_Shoot.Enabled = false;
                    btn_Reload.Enabled = true;
                    btn_ShootAway.Enabled = false;

            } else if (shoot == obj_Details.fire) {
                MessageBox.Show("You are dead Now and you loose the game ");
                btn_ShootAway.Enabled = false;
                btn_Shoot.Enabled = false;
                btn_Reload.Enabled = true;


            }
            else {
                // empty sound 
                MessageBox.Show("Retry Once again ");
                
            }

        }
        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sound);
            player.Play();
            obj_Details.nxtcount++;
            shoot++;
            if (shoot == obj_Details.fire)
            {
                MessageBox.Show("you survived ");
                btn_ShootAway.Enabled = false;
                btn_Shoot.Enabled = false;
                btn_Reload.Enabled = true;

            }
            else if (obj_Details.nxtcount == 2)
            {
                MessageBox.Show("Player is going to die and game is over now ");
                btn_ShootAway.Enabled = false;
                btn_Shoot.Enabled = false;
                btn_Reload.Enabled = true;

            }

            else
            {
                MessageBox.Show("you missed a chance");
            }
        }
        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            //code to reload the game 
            btn_Reload.Enabled = false;
            Btn_Start.Enabled = true;

            pbArea.Image = Properties.Resources.k1;

            obj_Details.fire = rd.Next(1, 7);
            obj_Details.chance = 0;
            obj_Details.trigger = 0;

            obj_Details.nxtcount = 0;

        }

       
    }
}
