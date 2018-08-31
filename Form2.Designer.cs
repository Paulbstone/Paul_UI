namespace howto_shaped_button
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.display_criticality = new System.Windows.Forms.Label();
            this.display_age = new System.Windows.Forms.Label();
            this.display_gender = new System.Windows.Forms.Label();
            this.display_circulation = new System.Windows.Forms.Label();
            this.display_haemorrage = new System.Windows.Forms.Label();
            this.display_airway = new System.Windows.Forms.Label();
            this.display_breathing = new System.Windows.Forms.Label();
            this.display_consciousness = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.display_medication = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Injury_description = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criticality:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Circulation:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Airway:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Haemorrage:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // display_criticality
            // 
            this.display_criticality.BackColor = System.Drawing.Color.White;
            this.display_criticality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_criticality.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_criticality.Location = new System.Drawing.Point(385, 203);
            this.display_criticality.Name = "display_criticality";
            this.display_criticality.Size = new System.Drawing.Size(953, 40);
            this.display_criticality.TabIndex = 5;
            this.display_criticality.Text = "label6";
            this.display_criticality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display_criticality.TextChanged += new System.EventHandler(this.display_criticality_TextChanged);
            // 
            // display_age
            // 
            this.display_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_age.Location = new System.Drawing.Point(407, 17);
            this.display_age.Name = "display_age";
            this.display_age.Size = new System.Drawing.Size(160, 40);
            this.display_age.TabIndex = 6;
            this.display_age.Text = "AGE";
            this.display_age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display_age.Click += new System.EventHandler(this.label7_Click);
            // 
            // display_gender
            // 
            this.display_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_gender.Location = new System.Drawing.Point(623, 17);
            this.display_gender.Name = "display_gender";
            this.display_gender.Size = new System.Drawing.Size(160, 40);
            this.display_gender.TabIndex = 7;
            this.display_gender.Text = "GENDER";
            this.display_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display_gender.Click += new System.EventHandler(this.label8_Click);
            // 
            // display_circulation
            // 
            this.display_circulation.BackColor = System.Drawing.Color.White;
            this.display_circulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_circulation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_circulation.Location = new System.Drawing.Point(385, 263);
            this.display_circulation.Name = "display_circulation";
            this.display_circulation.Size = new System.Drawing.Size(953, 40);
            this.display_circulation.TabIndex = 8;
            this.display_circulation.Text = "label9";
            this.display_circulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // display_haemorrage
            // 
            this.display_haemorrage.BackColor = System.Drawing.Color.White;
            this.display_haemorrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_haemorrage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_haemorrage.Location = new System.Drawing.Point(385, 323);
            this.display_haemorrage.Name = "display_haemorrage";
            this.display_haemorrage.Size = new System.Drawing.Size(953, 40);
            this.display_haemorrage.TabIndex = 9;
            this.display_haemorrage.Text = "label10";
            this.display_haemorrage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // display_airway
            // 
            this.display_airway.BackColor = System.Drawing.Color.White;
            this.display_airway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_airway.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_airway.Location = new System.Drawing.Point(385, 383);
            this.display_airway.Name = "display_airway";
            this.display_airway.Size = new System.Drawing.Size(953, 40);
            this.display_airway.TabIndex = 10;
            this.display_airway.Text = "label11";
            this.display_airway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // display_breathing
            // 
            this.display_breathing.BackColor = System.Drawing.Color.White;
            this.display_breathing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_breathing.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_breathing.Location = new System.Drawing.Point(385, 503);
            this.display_breathing.Name = "display_breathing";
            this.display_breathing.Size = new System.Drawing.Size(953, 40);
            this.display_breathing.TabIndex = 14;
            this.display_breathing.Text = "label12";
            this.display_breathing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // display_consciousness
            // 
            this.display_consciousness.BackColor = System.Drawing.Color.White;
            this.display_consciousness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_consciousness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_consciousness.Location = new System.Drawing.Point(385, 443);
            this.display_consciousness.Name = "display_consciousness";
            this.display_consciousness.Size = new System.Drawing.Size(953, 40);
            this.display_consciousness.TabIndex = 13;
            this.display_consciousness.Text = "label13";
            this.display_consciousness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(143, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 40);
            this.label14.TabIndex = 12;
            this.label14.Text = "Breathing:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(111, 443);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(254, 40);
            this.label15.TabIndex = 11;
            this.label15.Text = "Consciousness:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // display_medication
            // 
            this.display_medication.BackColor = System.Drawing.Color.White;
            this.display_medication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_medication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display_medication.Location = new System.Drawing.Point(385, 563);
            this.display_medication.Name = "display_medication";
            this.display_medication.Size = new System.Drawing.Size(953, 40);
            this.display_medication.TabIndex = 16;
            this.display_medication.Text = "label13";
            this.display_medication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 40);
            this.label7.TabIndex = 15;
            this.label7.Text = "Medication:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Injury_description
            // 
            this.Injury_description.BackColor = System.Drawing.Color.White;
            this.Injury_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Injury_description.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Injury_description.Location = new System.Drawing.Point(385, 80);
            this.Injury_description.Name = "Injury_description";
            this.Injury_description.Size = new System.Drawing.Size(953, 100);
            this.Injury_description.TabIndex = 17;
            this.Injury_description.Text = "label6";
            this.Injury_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Injury_description.Click += new System.EventHandler(this.Injury_description_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 40);
            this.label8.TabIndex = 18;
            this.label8.Text = "Injury:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 881);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Injury_description);
            this.Controls.Add(this.display_medication);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.display_breathing);
            this.Controls.Add(this.display_consciousness);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.display_airway);
            this.Controls.Add(this.display_haemorrage);
            this.Controls.Add(this.display_circulation);
            this.Controls.Add(this.display_gender);
            this.Controls.Add(this.display_age);
            this.Controls.Add(this.display_criticality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label display_criticality;
        private System.Windows.Forms.Label display_age;
        private System.Windows.Forms.Label display_gender;
        private System.Windows.Forms.Label display_circulation;
        private System.Windows.Forms.Label display_haemorrage;
        private System.Windows.Forms.Label display_airway;
        private System.Windows.Forms.Label display_breathing;
        private System.Windows.Forms.Label display_consciousness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label display_medication;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Injury_description;
        private System.Windows.Forms.Label label8;
    }
}