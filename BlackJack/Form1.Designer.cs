namespace BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hitbutton = new System.Windows.Forms.Button();
            this.Standbutton = new System.Windows.Forms.Button();
            this.Splitbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.DealerBox = new System.Windows.Forms.ListBox();
            this.PlayerBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // Hitbutton
            // 
            this.Hitbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Hitbutton.Location = new System.Drawing.Point(129, 360);
            this.Hitbutton.Name = "Hitbutton";
            this.Hitbutton.Size = new System.Drawing.Size(83, 59);
            this.Hitbutton.TabIndex = 0;
            this.Hitbutton.Text = "Hit";
            this.Hitbutton.UseVisualStyleBackColor = true;
            this.Hitbutton.Click += new System.EventHandler(this.Hitbutton_Click);
            // 
            // Standbutton
            // 
            this.Standbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.Standbutton.Location = new System.Drawing.Point(218, 360);
            this.Standbutton.Name = "Standbutton";
            this.Standbutton.Size = new System.Drawing.Size(82, 59);
            this.Standbutton.TabIndex = 1;
            this.Standbutton.Text = "Stand";
            this.Standbutton.UseVisualStyleBackColor = true;
            this.Standbutton.Click += new System.EventHandler(this.Standbutton_Click);
            // 
            // Splitbutton
            // 
            this.Splitbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Splitbutton.Location = new System.Drawing.Point(40, 360);
            this.Splitbutton.Name = "Splitbutton";
            this.Splitbutton.Size = new System.Drawing.Size(83, 59);
            this.Splitbutton.TabIndex = 2;
            this.Splitbutton.Text = "Deal";
            this.Splitbutton.UseVisualStyleBackColor = true;
            this.Splitbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(166, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 132);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(298, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 132);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.Location = new System.Drawing.Point(546, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 132);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox7.Location = new System.Drawing.Point(166, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(91, 132);
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox8.Location = new System.Drawing.Point(298, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(91, 132);
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox10.Location = new System.Drawing.Point(546, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(91, 132);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox11.Location = new System.Drawing.Point(673, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(91, 132);
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox12.Location = new System.Drawing.Point(673, 208);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(91, 132);
            this.pictureBox12.TabIndex = 17;
            this.pictureBox12.TabStop = false;
            // 
            // DealerBox
            // 
            this.DealerBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerBox.FormattingEnabled = true;
            this.DealerBox.ItemHeight = 22;
            this.DealerBox.Location = new System.Drawing.Point(83, 12);
            this.DealerBox.Name = "DealerBox";
            this.DealerBox.Size = new System.Drawing.Size(349, 158);
            this.DealerBox.TabIndex = 18;
            // 
            // PlayerBox
            // 
            this.PlayerBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.ItemHeight = 22;
            this.PlayerBox.Location = new System.Drawing.Point(83, 182);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(349, 158);
            this.PlayerBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.label1.Location = new System.Drawing.Point(309, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dealer Stands on 17 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(309, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Closest to 21 Wins    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.DealerBox);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Splitbutton);
            this.Controls.Add(this.Standbutton);
            this.Controls.Add(this.Hitbutton);
            this.Name = "Form1";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hitbutton;
        private System.Windows.Forms.Button Standbutton;
        private System.Windows.Forms.Button Splitbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.ListBox DealerBox;
        private System.Windows.Forms.ListBox PlayerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

