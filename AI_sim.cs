using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;

namespace howto_shaped_button
{

    

    public partial class AI_sim : Form
    {

        public static DateTime starttime;

        // *****************************************************
        // link to Uttam Model start conditions for these values 
        // *****************************************************
        #region Start values for model variables

        public static string var_age = "25";
        public static string var_gender = "male";
        public static string var_hem = "2";
        public static string var_air =  "0";
        public static string var_conc = "1";
        public static string var_breath = "0";
        public static string var_circ = "0";
        public static string var_injury = "Gunshot wound";
        public static string var_injury_location = "lower left leg";
        // public static time Sim_start_time = 0;


        #endregion

        public AI_sim()
        {
            InitializeComponent();
        }

        private void AI_sim_Load(object sender, EventArgs e)
        {
            sim_age_label.Text = var_age;
            sim_gender_label.Text = var_gender;
            sim_inthem_box.Text = var_hem;
            sim_intcirc_box.Text = var_circ;
            sim_intair_box.Text = var_air;
            sim_intbreath_box.Text = var_breath;
            sim_intconc_box.Text = var_conc;
            sim_injury_location_label.Text = var_injury_location;
            sim_injury_type_label.Text = var_injury;

        }




        //button click events
        #region button events        

        private void AI_patient_transfer_button_Click(object sender, EventArgs e)
        {
            starttime = DateTime.Now;
            var inputform_click = new howto_shaped_button.inputform();
            inputform_click.Show();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sim_age_label_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
