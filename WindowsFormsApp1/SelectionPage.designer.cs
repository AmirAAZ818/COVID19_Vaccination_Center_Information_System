namespace AllForms
{
    partial class SelectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionPage));
            this.addVaccine_Button = new System.Windows.Forms.Button();
            this.addPatient_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVaccine_Button
            // 
            this.addVaccine_Button.BackColor = System.Drawing.SystemColors.Control;
            this.addVaccine_Button.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addVaccine_Button.Location = new System.Drawing.Point(470, 2);
            this.addVaccine_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVaccine_Button.Name = "addVaccine_Button";
            this.addVaccine_Button.Size = new System.Drawing.Size(460, 430);
            this.addVaccine_Button.TabIndex = 1;
            this.addVaccine_Button.Text = "Add new Vaccine";
            this.addVaccine_Button.UseVisualStyleBackColor = false;
            this.addVaccine_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPatient_Button
            // 
            this.addPatient_Button.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addPatient_Button.Location = new System.Drawing.Point(11, 2);
            this.addPatient_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatient_Button.Name = "addPatient_Button";
            this.addPatient_Button.Size = new System.Drawing.Size(454, 430);
            this.addPatient_Button.TabIndex = 2;
            this.addPatient_Button.Text = "Add new Patient ";
            this.addPatient_Button.UseVisualStyleBackColor = true;
            this.addPatient_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 442);
            this.Controls.Add(this.addPatient_Button);
            this.Controls.Add(this.addVaccine_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addVaccine_Button;
        private System.Windows.Forms.Button addPatient_Button;
    }
}

