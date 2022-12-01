namespace caruselorizontal
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
            this.elementcarusel1 = new caruselorizontal.elementcarusel();
            this.elementcarusel2 = new caruselorizontal.elementcarusel();
            this.elementcarusel3 = new caruselorizontal.elementcarusel();
            this.elementcarusel4 = new caruselorizontal.elementcarusel();
            this.elementcarusel5 = new caruselorizontal.elementcarusel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elementcarusel1
            // 
            this.elementcarusel1.BackColor = System.Drawing.Color.Red;
            this.elementcarusel1.Location = new System.Drawing.Point(27, 72);
            this.elementcarusel1.Name = "elementcarusel1";
            this.elementcarusel1.Size = new System.Drawing.Size(138, 145);
            this.elementcarusel1.TabIndex = 0;
            // 
            // elementcarusel2
            // 
            this.elementcarusel2.BackColor = System.Drawing.Color.Red;
            this.elementcarusel2.Location = new System.Drawing.Point(171, 72);
            this.elementcarusel2.Name = "elementcarusel2";
            this.elementcarusel2.Size = new System.Drawing.Size(138, 145);
            this.elementcarusel2.TabIndex = 1;
            // 
            // elementcarusel3
            // 
            this.elementcarusel3.BackColor = System.Drawing.Color.Red;
            this.elementcarusel3.Location = new System.Drawing.Point(315, 72);
            this.elementcarusel3.Name = "elementcarusel3";
            this.elementcarusel3.Size = new System.Drawing.Size(138, 145);
            this.elementcarusel3.TabIndex = 2;
            // 
            // elementcarusel4
            // 
            this.elementcarusel4.BackColor = System.Drawing.Color.Red;
            this.elementcarusel4.Location = new System.Drawing.Point(459, 72);
            this.elementcarusel4.Name = "elementcarusel4";
            this.elementcarusel4.Size = new System.Drawing.Size(138, 145);
            this.elementcarusel4.TabIndex = 3;
            // 
            // elementcarusel5
            // 
            this.elementcarusel5.BackColor = System.Drawing.Color.Red;
            this.elementcarusel5.Location = new System.Drawing.Point(603, 72);
            this.elementcarusel5.Name = "elementcarusel5";
            this.elementcarusel5.Size = new System.Drawing.Size(138, 145);
            this.elementcarusel5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elementcarusel5);
            this.Controls.Add(this.elementcarusel4);
            this.Controls.Add(this.elementcarusel3);
            this.Controls.Add(this.elementcarusel2);
            this.Controls.Add(this.elementcarusel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private elementcarusel elementcarusel1;
        private elementcarusel elementcarusel2;
        private elementcarusel elementcarusel3;
        private elementcarusel elementcarusel4;
        private elementcarusel elementcarusel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

