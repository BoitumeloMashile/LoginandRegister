namespace login_and_Register_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.std_btn = new System.Windows.Forms.Button();
            this.adn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "St.  George  College";
            // 
            // std_btn
            // 
            this.std_btn.BackColor = System.Drawing.Color.DeepPink;
            this.std_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_btn.Location = new System.Drawing.Point(142, 154);
            this.std_btn.Name = "std_btn";
            this.std_btn.Size = new System.Drawing.Size(144, 62);
            this.std_btn.TabIndex = 2;
            this.std_btn.Text = "Students";
            this.std_btn.UseVisualStyleBackColor = false;
            this.std_btn.Click += new System.EventHandler(this.std_btn_Click);
            // 
            // adn_btn
            // 
            this.adn_btn.BackColor = System.Drawing.Color.DeepPink;
            this.adn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adn_btn.Location = new System.Drawing.Point(142, 284);
            this.adn_btn.Name = "adn_btn";
            this.adn_btn.Size = new System.Drawing.Size(144, 64);
            this.adn_btn.TabIndex = 3;
            this.adn_btn.Text = "Admin";
            this.adn_btn.UseVisualStyleBackColor = false;
            this.adn_btn.Click += new System.EventHandler(this.adn_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.adn_btn);
            this.Controls.Add(this.std_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "St George College";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button std_btn;
        private System.Windows.Forms.Button adn_btn;
    }
}