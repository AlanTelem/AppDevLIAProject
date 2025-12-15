namespace AppDevProj
{
    partial class MainMenuForm
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
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.TemplateButton = new System.Windows.Forms.Button();
            this.ExitButtonMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLabel.Location = new System.Drawing.Point(91, 40);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(254, 41);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "MAIN MENU";
            // 
            // OverviewButton
            // 
            this.OverviewButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewButton.Location = new System.Drawing.Point(117, 112);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(195, 27);
            this.OverviewButton.TabIndex = 1;
            this.OverviewButton.Text = "COLLECTIONS";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsButton.Location = new System.Drawing.Point(117, 157);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(195, 27);
            this.FriendsButton.TabIndex = 3;
            this.FriendsButton.Text = "FRIENDS";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // TemplateButton
            // 
            this.TemplateButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateButton.Location = new System.Drawing.Point(117, 204);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(195, 27);
            this.TemplateButton.TabIndex = 4;
            this.TemplateButton.Text = "TEMPLATES";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // ExitButtonMainMenu
            // 
            this.ExitButtonMainMenu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonMainMenu.Location = new System.Drawing.Point(117, 250);
            this.ExitButtonMainMenu.Name = "ExitButtonMainMenu";
            this.ExitButtonMainMenu.Size = new System.Drawing.Size(195, 27);
            this.ExitButtonMainMenu.TabIndex = 5;
            this.ExitButtonMainMenu.Text = "EXIT";
            this.ExitButtonMainMenu.UseVisualStyleBackColor = true;
            this.ExitButtonMainMenu.Click += new System.EventHandler(this.ExitButtonMainMenu_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.ExitButtonMainMenu);
            this.Controls.Add(this.TemplateButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.OverviewButton);
            this.Controls.Add(this.MainMenuLabel);
            this.MaximumSize = new System.Drawing.Size(446, 329);
            this.MinimumSize = new System.Drawing.Size(446, 329);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuLabel;
        private System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button TemplateButton;
        private System.Windows.Forms.Button ExitButtonMainMenu;
    }
}