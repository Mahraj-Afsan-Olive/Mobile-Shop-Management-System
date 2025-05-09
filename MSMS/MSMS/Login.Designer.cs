
namespace MSMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.textBox_UN = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.label_UN = new System.Windows.Forms.Label();
            this.button_E = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PW
            // 
            this.textBox_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PW.ForeColor = System.Drawing.Color.Black;
            this.textBox_PW.Location = new System.Drawing.Point(256, 193);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(246, 29);
            this.textBox_PW.TabIndex = 17;
            this.textBox_PW.Text = "Password";
            this.textBox_PW.UseSystemPasswordChar = true;
            this.textBox_PW.MouseEnter += new System.EventHandler(this.textBox_PW_MouseEnter);
            this.textBox_PW.MouseLeave += new System.EventHandler(this.textBox_PW_MouseLeave);
            // 
            // textBox_UN
            // 
            this.textBox_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UN.ForeColor = System.Drawing.Color.Black;
            this.textBox_UN.Location = new System.Drawing.Point(256, 148);
            this.textBox_UN.Name = "textBox_UN";
            this.textBox_UN.Size = new System.Drawing.Size(246, 29);
            this.textBox_UN.TabIndex = 16;
            this.textBox_UN.Text = "User Name";
            this.textBox_UN.MouseEnter += new System.EventHandler(this.textBox_UN_MouseEnter);
            this.textBox_UN.MouseLeave += new System.EventHandler(this.textBox_UN_MouseLeave);
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PW.Location = new System.Drawing.Point(120, 193);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(106, 24);
            this.label_PW.TabIndex = 15;
            this.label_PW.Text = "Password:";
            // 
            // label_UN
            // 
            this.label_UN.AutoSize = true;
            this.label_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UN.Location = new System.Drawing.Point(120, 148);
            this.label_UN.Name = "label_UN";
            this.label_UN.Size = new System.Drawing.Size(111, 24);
            this.label_UN.TabIndex = 14;
            this.label_UN.Text = "Username:";
            // 
            // button_E
            // 
            this.button_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_E.Location = new System.Drawing.Point(76, 324);
            this.button_E.Name = "button_E";
            this.button_E.Size = new System.Drawing.Size(104, 36);
            this.button_E.TabIndex = 20;
            this.button_E.Text = "Exit";
            this.button_E.UseVisualStyleBackColor = true;
            this.button_E.Click += new System.EventHandler(this.button_E_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(290, 273);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(104, 32);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_LogIn
            // 
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.Location = new System.Drawing.Point(400, 273);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(104, 32);
            this.button_LogIn.TabIndex = 18;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(526, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(31, 31);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_E);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_UN);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_UN);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.TextBox textBox_UN;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.Label label_UN;
        private System.Windows.Forms.Button button_E;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

