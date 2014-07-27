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
            this.SuspendLayout();
            // 
            // peopleGroupBox
            // 
            this.peopleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.peopleGroupBox.Name = "peopleGroupBox";
            this.peopleGroupBox.Size = new System.Drawing.Size(300, 538);
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
            // Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.peopleGroupBox);
            this.Name = "Med";
            this.Text = "Med";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox peopleGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

