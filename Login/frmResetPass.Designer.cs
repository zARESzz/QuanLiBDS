namespace Login
{
    partial class frmResetPass
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGuiEmail = new Main.Custom.CtButton();
            this.ctButton1 = new Main.Custom.CtButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 201);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnGuiEmail
            // 
            this.btnGuiEmail.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuiEmail.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuiEmail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuiEmail.BorderRadius = 0;
            this.btnGuiEmail.BorderSize = 0;
            this.btnGuiEmail.FlatAppearance.BorderSize = 0;
            this.btnGuiEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiEmail.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiEmail.ForeColor = System.Drawing.Color.White;
            this.btnGuiEmail.Location = new System.Drawing.Point(41, 259);
            this.btnGuiEmail.Name = "btnGuiEmail";
            this.btnGuiEmail.Size = new System.Drawing.Size(426, 76);
            this.btnGuiEmail.TabIndex = 2;
            this.btnGuiEmail.Text = "Reset Password";
            this.btnGuiEmail.TextColor = System.Drawing.Color.White;
            this.btnGuiEmail.UseVisualStyleBackColor = false;
            this.btnGuiEmail.Click += new System.EventHandler(this.btnGuiEmail_Click);
            this.btnGuiEmail.MouseLeave += new System.EventHandler(this.btnGuiEmail_MouseLeave);
            this.btnGuiEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuiEmail_MouseMove);
            // 
            // ctButton1
            // 
            this.ctButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctButton1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ctButton1.BorderColor = System.Drawing.Color.Crimson;
            this.ctButton1.BorderRadius = 20;
            this.ctButton1.BorderSize = 0;
            this.ctButton1.FlatAppearance.BorderSize = 0;
            this.ctButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.ctButton1.Location = new System.Drawing.Point(182, 359);
            this.ctButton1.Name = "ctButton1";
            this.ctButton1.Size = new System.Drawing.Size(150, 31);
            this.ctButton1.TabIndex = 3;
            this.ctButton1.Text = "Cancel ";
            this.ctButton1.TextColor = System.Drawing.Color.DarkGray;
            this.ctButton1.UseVisualStyleBackColor = false;
            this.ctButton1.Click += new System.EventHandler(this.ctButton1_Click);
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Login.Properties.Resources.Resetpass;
            this.ClientSize = new System.Drawing.Size(506, 429);
            this.Controls.Add(this.ctButton1);
            this.Controls.Add(this.btnGuiEmail);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private Main.Custom.CtButton btnGuiEmail;
        private Main.Custom.CtButton ctButton1;
    }
}