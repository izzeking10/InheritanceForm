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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.lbCanFly = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(289, 36);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(121, 28);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Pirate", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(119, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(141, 42);
            this.name.TabIndex = 1;
            this.name.Text = "Namn";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.BackColor = System.Drawing.Color.Transparent;
            this.lbSpecies.Font = new System.Drawing.Font("Pirate", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecies.Location = new System.Drawing.Point(7, 93);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(59, 30);
            this.lbSpecies.TabIndex = 2;
            this.lbSpecies.Text = "Art";
            this.lbSpecies.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbCanFly
            // 
            this.lbCanFly.AutoSize = true;
            this.lbCanFly.Location = new System.Drawing.Point(66, 496);
            this.lbCanFly.Name = "lbCanFly";
            this.lbCanFly.Size = new System.Drawing.Size(0, 20);
            this.lbCanFly.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cat.jpg");
            this.imageList1.Images.SetKeyName(1, "dog.jpg");
            this.imageList1.Images.SetKeyName(2, "bird.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(72, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 313);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(580, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCanFly);
            this.Controls.Add(this.lbSpecies);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cbNames);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Djur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbCanFly;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

