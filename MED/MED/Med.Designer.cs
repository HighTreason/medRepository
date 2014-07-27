namespace MED
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
            // Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.peopleGroupBox);
            this.Name = "Med";
            this.Text = "Med";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox peopleGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

