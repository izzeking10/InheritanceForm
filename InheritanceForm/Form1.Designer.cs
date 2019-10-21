namespace InheritanceForm
{
    partial class Form1
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
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.lbCanFly = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(123, 33);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(121, 28);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(66, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Namn";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(66, 93);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(30, 20);
            this.lbSpecies.TabIndex = 2;
            this.lbSpecies.Text = "Art";
            this.lbSpecies.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbCanFly
            // 
            this.lbCanFly.AutoSize = true;
            this.lbCanFly.Location = new System.Drawing.Point(66, 347);
            this.lbCanFly.Name = "lbCanFly";
            this.lbCanFly.Size = new System.Drawing.Size(0, 20);
            this.lbCanFly.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCanFly);
            this.Controls.Add(this.lbSpecies);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbCanFly;
    }
}

