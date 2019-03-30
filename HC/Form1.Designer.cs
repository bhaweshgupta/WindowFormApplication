namespace HC
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
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbDBout = new System.Windows.Forms.Label();
            this.lbURLOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(83, 45);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(267, 22);
            this.tbDatabase.TabIndex = 0;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(83, 101);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(267, 22);
            this.tbURL.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "check DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "check URL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Location = new System.Drawing.Point(12, 51);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(69, 17);
            this.lbDatabase.TabIndex = 4;
            this.lbDatabase.Text = "Database";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(35, 106);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(36, 17);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL";
            // 
            // lbDBout
            // 
            this.lbDBout.AutoSize = true;
            this.lbDBout.Location = new System.Drawing.Point(512, 45);
            this.lbDBout.Name = "lbDBout";
            this.lbDBout.Size = new System.Drawing.Size(46, 17);
            this.lbDBout.TabIndex = 6;
            this.lbDBout.Text = "label1";
            // 
            // lbURLOut
            // 
            this.lbURLOut.AutoSize = true;
            this.lbURLOut.Location = new System.Drawing.Point(512, 106);
            this.lbURLOut.Name = "lbURLOut";
            this.lbURLOut.Size = new System.Drawing.Size(46, 17);
            this.lbURLOut.TabIndex = 7;
            this.lbURLOut.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 228);
            this.Controls.Add(this.lbURLOut);
            this.Controls.Add(this.lbDBout);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbDBout;
        private System.Windows.Forms.Label lbURLOut;
    }
}

