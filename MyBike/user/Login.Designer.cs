namespace MyBike.user
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
            buttonLogin = new Button();
            labelUsername = new Label();
            textBoxUserName = new TextBox();
            groupBoxUserInfo = new GroupBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            groupBoxUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(372, 190);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(92, 41);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // labelUsername
            // 
            labelUsername.BorderStyle = BorderStyle.FixedSingle;
            labelUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Image = Properties.Resources.lianhao_qu_l4HAkTlJQP0_unsplash;
            labelUsername.Location = new Point(15, 28);
            labelUsername.Margin = new Padding(2, 0, 2, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(108, 30);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(159, 34);
            textBoxUserName.Margin = new Padding(2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(106, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // groupBoxUserInfo
            // 
            groupBoxUserInfo.BackColor = SystemColors.Control;
            groupBoxUserInfo.Controls.Add(textBoxPassword);
            groupBoxUserInfo.Controls.Add(label1);
            groupBoxUserInfo.Controls.Add(labelUsername);
            groupBoxUserInfo.Controls.Add(textBoxUserName);
            groupBoxUserInfo.Location = new Point(24, 34);
            groupBoxUserInfo.Margin = new Padding(2);
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Padding = new Padding(2);
            groupBoxUserInfo.Size = new Size(320, 145);
            groupBoxUserInfo.TabIndex = 3;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "User Information";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(159, 83);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(106, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.lianhao_qu_l4HAkTlJQP0_unsplash;
            label1.Location = new Point(15, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 3;
            label1.Text = "Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(577, 286);
            Controls.Add(groupBoxUserInfo);
            Controls.Add(buttonLogin);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            groupBoxUserInfo.ResumeLayout(false);
            groupBoxUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private Label labelUsername;
        private TextBox textBoxUserName;
        private GroupBox groupBoxUserInfo;
        private TextBox textBoxPassword;
        private Label label1;
    }
}