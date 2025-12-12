namespace AppDevProj
{
    partial class LogInForm
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
            this.RegisterLoginTabControl = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.ContinueAsGuestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.ContinueAsGuestLinkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordRegisterLabel = new System.Windows.Forms.Label();
            this.RegisterUsernameLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PasswordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.RegisterUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterLoginTabControl.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.RegisterTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterLoginTabControl
            // 
            this.RegisterLoginTabControl.Controls.Add(this.LoginTab);
            this.RegisterLoginTabControl.Controls.Add(this.RegisterTab);
            this.RegisterLoginTabControl.Location = new System.Drawing.Point(0, 0);
            this.RegisterLoginTabControl.Name = "RegisterLoginTabControl";
            this.RegisterLoginTabControl.SelectedIndex = 0;
            this.RegisterLoginTabControl.Size = new System.Drawing.Size(400, 328);
            this.RegisterLoginTabControl.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.ThemeComboBox);
            this.LoginTab.Controls.Add(this.LanguageComboBox);
            this.LoginTab.Controls.Add(this.ContinueAsGuestLinkLabel);
            this.LoginTab.Controls.Add(this.LoginButton);
            this.LoginTab.Controls.Add(this.PasswordLabel);
            this.LoginTab.Controls.Add(this.UsernameLabel);
            this.LoginTab.Controls.Add(this.LoginLabel);
            this.LoginTab.Controls.Add(this.PasswordTextBox);
            this.LoginTab.Controls.Add(this.UsernameTextBox);
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(392, 302);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DisplayMember = "English";
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "English",
            "Francais",
            "Espanol"});
            this.LanguageComboBox.Location = new System.Drawing.Point(306, 7);
            this.LanguageComboBox.MaxDropDownItems = 3;
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(77, 21);
            this.LanguageComboBox.TabIndex = 7;
            this.LanguageComboBox.ValueMember = "English";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // ContinueAsGuestLinkLabel
            // 
            this.ContinueAsGuestLinkLabel.AutoSize = true;
            this.ContinueAsGuestLinkLabel.Location = new System.Drawing.Point(110, 251);
            this.ContinueAsGuestLinkLabel.Name = "ContinueAsGuestLinkLabel";
            this.ContinueAsGuestLinkLabel.Size = new System.Drawing.Size(176, 13);
            this.ContinueAsGuestLinkLabel.TabIndex = 6;
            this.ContinueAsGuestLinkLabel.TabStop = true;
            this.ContinueAsGuestLinkLabel.Text = "Don\'t feel like it? Continue as guest!";
            this.ContinueAsGuestLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContinueAsGuestLinkLabel_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(125, 211);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(145, 25);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(62, 148);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 18);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(62, 90);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(86, 18);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(105, 27);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(152, 43);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "LOGIN";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(62, 169);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(275, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(62, 109);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(275, 20);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.ContinueAsGuestLinkLabelRegister);
            this.RegisterTab.Controls.Add(this.RegisterButton);
            this.RegisterTab.Controls.Add(this.PasswordRegisterLabel);
            this.RegisterTab.Controls.Add(this.RegisterUsernameLabel);
            this.RegisterTab.Controls.Add(this.RegisterLabel);
            this.RegisterTab.Controls.Add(this.PasswordRegisterTextBox);
            this.RegisterTab.Controls.Add(this.RegisterUsernameTextBox);
            this.RegisterTab.Location = new System.Drawing.Point(4, 22);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTab.Size = new System.Drawing.Size(392, 302);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // ContinueAsGuestLinkLabelRegister
            // 
            this.ContinueAsGuestLinkLabelRegister.AutoSize = true;
            this.ContinueAsGuestLinkLabelRegister.Location = new System.Drawing.Point(107, 257);
            this.ContinueAsGuestLinkLabelRegister.Name = "ContinueAsGuestLinkLabelRegister";
            this.ContinueAsGuestLinkLabelRegister.Size = new System.Drawing.Size(176, 13);
            this.ContinueAsGuestLinkLabelRegister.TabIndex = 13;
            this.ContinueAsGuestLinkLabelRegister.TabStop = true;
            this.ContinueAsGuestLinkLabelRegister.Text = "Don\'t feel like it? Continue as guest!";
            this.ContinueAsGuestLinkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContinueAsGuestLinkLabelRegister_LinkClicked);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(122, 217);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(145, 25);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // PasswordRegisterLabel
            // 
            this.PasswordRegisterLabel.AutoSize = true;
            this.PasswordRegisterLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegisterLabel.Location = new System.Drawing.Point(59, 154);
            this.PasswordRegisterLabel.Name = "PasswordRegisterLabel";
            this.PasswordRegisterLabel.Size = new System.Drawing.Size(81, 18);
            this.PasswordRegisterLabel.TabIndex = 11;
            this.PasswordRegisterLabel.Text = "Password:";
            // 
            // RegisterUsernameLabel
            // 
            this.RegisterUsernameLabel.AutoSize = true;
            this.RegisterUsernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUsernameLabel.Location = new System.Drawing.Point(59, 96);
            this.RegisterUsernameLabel.Name = "RegisterUsernameLabel";
            this.RegisterUsernameLabel.Size = new System.Drawing.Size(86, 18);
            this.RegisterUsernameLabel.TabIndex = 10;
            this.RegisterUsernameLabel.Text = "Username:";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(80, 31);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(229, 43);
            this.RegisterLabel.TabIndex = 9;
            this.RegisterLabel.Text = "REGISTER";
            // 
            // PasswordRegisterTextBox
            // 
            this.PasswordRegisterTextBox.Location = new System.Drawing.Point(59, 175);
            this.PasswordRegisterTextBox.Name = "PasswordRegisterTextBox";
            this.PasswordRegisterTextBox.Size = new System.Drawing.Size(275, 20);
            this.PasswordRegisterTextBox.TabIndex = 8;
            this.PasswordRegisterTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterUsernameTextBox
            // 
            this.RegisterUsernameTextBox.Location = new System.Drawing.Point(59, 115);
            this.RegisterUsernameTextBox.Name = "RegisterUsernameTextBox";
            this.RegisterUsernameTextBox.Size = new System.Drawing.Size(275, 20);
            this.RegisterUsernameTextBox.TabIndex = 7;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Light Theme",
            "Dark Theme"});
            this.ThemeComboBox.Location = new System.Drawing.Point(4, 6);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThemeComboBox.TabIndex = 8;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 328);
            this.Controls.Add(this.RegisterLoginTabControl);
            this.Name = "LogInForm";
            this.Text = "LogIn Menu";
            this.RegisterLoginTabControl.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.RegisterTab.ResumeLayout(false);
            this.RegisterTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RegisterLoginTabControl;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel ContinueAsGuestLinkLabel;
        private System.Windows.Forms.LinkLabel ContinueAsGuestLinkLabelRegister;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PasswordRegisterLabel;
        private System.Windows.Forms.Label RegisterUsernameLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox PasswordRegisterTextBox;
        private System.Windows.Forms.TextBox RegisterUsernameTextBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.ComboBox ThemeComboBox;
    }
}

