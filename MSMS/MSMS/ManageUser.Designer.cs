
namespace MSMS
{
    partial class ManageUser
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
            this.label_PW = new System.Windows.Forms.Label();
            this.label_UN = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PW.Location = new System.Drawing.Point(333, 283);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(106, 24);
            this.label_PW.TabIndex = 17;
            this.label_PW.Text = "Password:";
            // 
            // label_UN
            // 
            this.label_UN.AutoSize = true;
            this.label_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UN.Location = new System.Drawing.Point(333, 169);
            this.label_UN.Name = "label_UN";
            this.label_UN.Size = new System.Drawing.Size(111, 24);
            this.label_UN.TabIndex = 16;
            this.label_UN.Text = "Username:";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(287, 206);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(191, 20);
            this.textUsername.TabIndex = 18;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(287, 319);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(191, 20);
            this.textPassword.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(274, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 32);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(384, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 32);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_UN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.Label label_UN;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
    }
}