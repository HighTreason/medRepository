﻿namespace MED
{
    partial class Med
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
            this.peopleGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.locationUnitComboBox = new System.Windows.Forms.ComboBox();
            this.locationUnitLabel = new System.Windows.Forms.Label();
            this.locationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleGroupBox
            // 
            this.peopleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.peopleGroupBox.Name = "peopleGroupBox";
            this.peopleGroupBox.Size = new System.Drawing.Size(300, 630);
            this.peopleGroupBox.TabIndex = 0;
            this.peopleGroupBox.TabStop = false;
            this.peopleGroupBox.Text = "People";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(336, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.locationUnitLabel);
            this.locationGroupBox.Controls.Add(this.locationUnitComboBox);
            this.locationGroupBox.Location = new System.Drawing.Point(318, 12);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(300, 630);
            this.locationGroupBox.TabIndex = 1;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(624, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "People";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Location = new System.Drawing.Point(624, 12);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(300, 630);
            this.dateGroupBox.TabIndex = 2;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Date && Time";
            // 
            // locationUnitComboBox
            // 
            this.locationUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationUnitComboBox.FormattingEnabled = true;
            this.locationUnitComboBox.Location = new System.Drawing.Point(45, 29);
            this.locationUnitComboBox.Name = "locationUnitComboBox";
            this.locationUnitComboBox.Size = new System.Drawing.Size(199, 21);
            this.locationUnitComboBox.TabIndex = 0;
            // 
            // locationUnitLabel
            // 
            this.locationUnitLabel.AutoSize = true;
            this.locationUnitLabel.Location = new System.Drawing.Point(7, 32);
            this.locationUnitLabel.Name = "locationUnitLabel";
            this.locationUnitLabel.Size = new System.Drawing.Size(32, 13);
            this.locationUnitLabel.TabIndex = 1;
            this.locationUnitLabel.Text = "Unit :";
            // 
            // Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.peopleGroupBox);
            this.Name = "Med";
            this.Text = "Med";
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox peopleGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.Label locationUnitLabel;
        private System.Windows.Forms.ComboBox locationUnitComboBox;
    }
}

