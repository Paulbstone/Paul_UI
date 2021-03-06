﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace howto_shaped_button
{
    public partial class Output : Form
    {
        #region Variables defined in this form
        public static TimeSpan simtime;

        string conf_age = "age?";
        string conf_hem = "bleed?";
        string conf_airway = "air?";
        string conf_breath = "breath?";
        string conf_crit = "criticality?";
        string conf_gender = "gender?";
        string conf_consc = "conscious?";
        string conf_heart = "circulation?";
        string conf_medication = "medication?";
        string injury_location = "injuries to ";
        string injury_type_f2 = "injury type?";
        string injury_type_and_location = "type and location?";
        public static int injury_count = 0;
        public static int crit_count = 0;
        public static int patient_condition_check;

        #endregion
        public Output()
        {
            InitializeComponent();
        }




        private void display_criticality_TextChanged(object sender, EventArgs e)
        {

        }

        // UNUSED EVENTS
        #region Unused click events
        private void Actual_status_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

#endregion

        public void Output_Load(object sender, EventArgs e)
        {
            TimeSpan simtime = inputform.endtime - AI_sim.starttime;

            #region calculate time taken in transfer of care 
            int simtime_seconds = simtime.Seconds;
            int simtime_minutes = simtime.Minutes;
            int simtime_minsecs = simtime_minutes * 60;
            int total_seconds = simtime_minsecs + simtime_seconds;
            string simtime_text = total_seconds.ToString();
            Output_transfer_time.Text = simtime_text;
            #endregion

            #region fill out the transferred data boxes with info from ToC input form

            Output_transferred_patient_age.Text = conf_age;
            Output_transferred_patient_gender.Text = conf_gender;
            Output_transferred_patient_haemorrhage.Text = conf_hem;
            Output_transferred_patient_breathing.Text = conf_breath;
            Output_transferred_patient_consciousness.Text = conf_consc;
            Output_transferred_patient_injury_type.Text = injury_type_f2;
            Output_transferred_patient_airway.Text = conf_airway;
            Output_transferred_patient_criticality.Text = conf_crit;
            Output_transferred_patient_injury_location.Text = injury_location;

            #endregion

            #region set patient condition strings based on the radiobuttons in form 1
            #region set age string 
            if (inputform.var_age == 0)
            {
                conf_age = "infant";
            }
            else if (inputform.var_age == 1)
            {
                conf_age = "child";
            }
            else if (inputform.var_age == 2)
            {
                conf_age = "adult";
            }
            else
            {
                conf_age = "geriatric";
            }
            #endregion

            #region set gender string 
            if (inputform.var_gender == 0)
            {
                conf_gender = "Male";
            }
            else if (inputform.var_gender == 1)
            {
                conf_gender = "Female";
            }

            #endregion

            #region set airway string 
            if (inputform.var_airways == 0)
            {
                conf_airway = "airway clear";
            }
            else if (inputform.var_airways == 1)
            {
                conf_airway = "airway partially blocked";
            }
            else if (inputform.var_airways == 2)
            {
                conf_airway = "airway blocked";
            }
            else if (inputform.var_airways == 3)
            {
                conf_airway = "airway was blocked but now clear";
            }
            #endregion

            #region set haemorrage string 
            if (inputform.var_hemorrage == 0)
            {
                conf_hem = "no bleeding";
            }
            else if (inputform.var_hemorrage == 1)
            {
                conf_hem = "some bleeding";
            }
            else if (inputform.var_hemorrage == 2)
            {
                conf_hem = "iheavy bleeding";
                crit_count = crit_count + 1;
            }
            else if (inputform.var_hemorrage == 3)
            {
                conf_hem = "bleeding stopped with tourniquet";
            }
            #endregion

            #region set circulation string 
            if (inputform.var_circulation == 0)
            {
                conf_heart = "no heart or circulation problem";
            }
            else if (inputform.var_hemorrage == 1)
            {
                conf_heart = "weak or irregular pulse or heartbeat";
            }
            else if (inputform.var_hemorrage == 2)
            {
                conf_heart = "in cardiac arrest";
                crit_count = crit_count + 1;
            }
            else if (inputform.var_hemorrage == 3)
            {
                conf_heart = "previously in cardiac arrest but now normal";
            }
            #endregion

            #region set criticality string 
            if (inputform.var_criticality == 0)
            {
                conf_crit = "routine";
            }
            else if (inputform.var_criticality == 1)
            {
                conf_crit = "priority";
            }
            else if (inputform.var_criticality == 2)
            {
                conf_crit = "critical";
            }

            #endregion

            #region set consciousness string 
            if (inputform.var_circulation == 0)
            {
                conf_consc = "fully conscious";
            }
            else if (inputform.var_circulation == 1)
            {
                conf_consc = "partially conscious";
            }
            else if (inputform.var_circulation == 2)
            {
                conf_consc = "unconscious";
                crit_count = crit_count + 1;
            }
            else if (inputform.var_circulation == 3)
            {
                conf_consc = "previously unconscious but revived";
            }
            #endregion

            #region set breathing string 
            if (inputform.var_breathing == 0)
            {
                conf_breath = "no breathing problem";
            }
            else if (inputform.var_breathing == 1)
            {
                conf_breath = "weak or irregular breathing";
            }
            else if (inputform.var_breathing == 2)
            {
                conf_breath = "not breathing";
                crit_count = crit_count + 1;
            }
            else if (inputform.var_breathing == 3)
            {
                conf_breath = "previously not breathing but now normal";
            }
            #endregion

            #region set medication string 
            if (inputform.var_medication == 0)
            {
                conf_medication = "no medication";
            }
            else if (inputform.var_medication == 1)
            {
                conf_medication = "fluids given";
            }
            else if (inputform.var_medication == 2)
            {
                conf_medication = "adrenaline given";
            }
            else if (inputform.var_medication == 3)
            {
                conf_medication = "morphine given";
            }
            #endregion
            #endregion

            #region injury location strings for description - front of body

            if (inputform.torso_on == true)
            {
                injury_location = injury_location + "front of torso ";
                injury_count = injury_count + 1;
            }
            if (inputform.head_on == true)
            {
                injury_location = injury_location + "front of head ";
                injury_count = injury_count + 1;
            }
            if (inputform.ms_on == true)
            {
                injury_location = injury_location + "front midsection ";
                injury_count = injury_count + 1;
            }
            if (inputform.leftleg_on == true)
            {
                injury_location = injury_location + "front of upper left leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.rightleg_on == true)
            {
                injury_location = injury_location + "front of upper right leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.rightlowleg_on == true)
            {
                injury_location = injury_location + "front of lower right leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.leftlowleg_on == true)
            {
                injury_location = injury_location + "front of lower left leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.leftarm_on == true)
            {
                injury_location = injury_location + "front of upper left arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.rightarm_on == true)
            {
                injury_location = injury_location + "front of upper right arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.rightlowarm_on == true)
            {
                injury_location = injury_location + "front of lower right arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.leftlowarm_on == true)
            {
                injury_location = injury_location + "front of lower left arm ";
                injury_count = injury_count + 1;
            }


            #endregion

            #region injury location strings for description - back of body

            if (inputform.backtorso_on == true)
            {
                injury_location = injury_location + "back of torso ";
                injury_count = injury_count + 1;
            }
            if (inputform.backhead_on == true)
            {
                injury_location = injury_location + "back of head ";
                injury_count = injury_count + 1;
            }
            if (inputform.backms_on == true)
            {
                injury_location = injury_location + "back midsection ";
                injury_count = injury_count + 1;
            }
            if (inputform.backleftleg_on == true)
            {
                injury_location = injury_location + "back of upper left leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.backrightleg_on == true)
            {
                injury_location = injury_location + "back of upper right leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.backrightlowleg_on == true)
            {
                injury_location = injury_location + "back of lower right leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.backleftlowleg_on == true)
            {
                injury_location = injury_location + "back of lower left leg ";
                injury_count = injury_count + 1;
            }
            if (inputform.backleftarm_on == true)
            {
                injury_location = injury_location + "back of upper left arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.backrightarm_on == true)
            {
                injury_location = injury_location + "back of upper right arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.backrightlowarm_on == true)
            {
                injury_location = injury_location + "back of lower right arm ";
                injury_count = injury_count + 1;
            }
            if (inputform.backleftlowarm_on == true)
            {
                injury_location = injury_location + "back of lower left arm ";
                injury_count = injury_count + 1;
            }


            #endregion

            #region check to see if injury type or location given
            if (inputform.var_injury_type == "")
            {
                injury_type_f2 = "no injury type given, please add, the injury was sustained to the ";
            }
            else
            {
                injury_type_f2 = inputform.var_injury_type + " ";
            }

            if (injury_location == "injuries to")
            {
                injury_location = "no injury location given, please close this form and select on the previous form";
            }
            else
            {
                injury_location = injury_location + "of the patient";
            }
            #endregion

            injury_type_and_location = injury_type_f2 + injury_location;

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            #region AI voice feedback if criticalities don't match
            /// #region messagebox and voice feedback for potential errors in TOC information
            if (conf_crit == "routine" && crit_count > 0.5 && patient_condition_check == 0)
            {
                MessageBox.Show("patient condition is identified as routine but at least one characteristic was critical in nature, please confirm patient condition status");
                synth.Speak("patient condition is identified as routine but at least one characteristic was critical in nature, please confirm patient condition status");
                patient_condition_check = 1;
            }

            if (conf_crit == "priority" && crit_count > 1.5 && patient_condition_check == 0)
            {
                MessageBox.Show("patient condition is identified as routine but at least one characteristic was critical in nature, please confirm patient condition status");
                synth.Speak("patient condition is identified as routine but at least one characteristic was critical in nature, please confirm patient condition status");
                patient_condition_check = 1;
            }
            #endregion
        }
        #region change color of the transferred criticaliyt rating
        private void Output_transferred_patient_criticality_TextChanged(object sender, EventArgs e)
        {
            if (conf_crit == "critical")
            {
                Output_transferred_patient_criticality.ForeColor = Color.Red;
            }
            if (conf_crit == "priority")
            {
                Output_transferred_patient_criticality.ForeColor = Color.Orange;
            }
            if (conf_crit == "routine")
            {
                Output_transferred_patient_criticality.ForeColor = Color.Green;
            }
        }
        #endregion
    }
}

