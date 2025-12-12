namespace AppDevProj
{
    partial class Template
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
            this.PremadeTemplateButton = new System.Windows.Forms.Button();
            this.TemplatesLabel = new System.Windows.Forms.Label();
            this.CreateTemplateButton = new System.Windows.Forms.Button();
            this.BackButtonTemplates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PremadeTemplateButton
            // 
            this.PremadeTemplateButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremadeTemplateButton.Location = new System.Drawing.Point(65, 98);
            this.PremadeTemplateButton.Name = "PremadeTemplateButton";
            this.PremadeTemplateButton.Size = new System.Drawing.Size(213, 32);
            this.PremadeTemplateButton.TabIndex = 0;
            this.PremadeTemplateButton.Text = "PREMADE COLLECTIONS";
            this.PremadeTemplateButton.UseVisualStyleBackColor = true;
            // 
            // TemplatesLabel
            // 
            this.TemplatesLabel.AutoSize = true;
            this.TemplatesLabel.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplatesLabel.Location = new System.Drawing.Point(37, 31);
            this.TemplatesLabel.Name = "TemplatesLabel";
            this.TemplatesLabel.Size = new System.Drawing.Size(264, 41);
            this.TemplatesLabel.TabIndex = 1;
            this.TemplatesLabel.Text = "TEMPLATES!";
            // 
            // CreateTemplateButton
            // 
            this.CreateTemplateButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTemplateButton.Location = new System.Drawing.Point(65, 156);
            this.CreateTemplateButton.Name = "CreateTemplateButton";
            this.CreateTemplateButton.Size = new System.Drawing.Size(213, 32);
            this.CreateTemplateButton.TabIndex = 2;
            this.CreateTemplateButton.Text = "CREATE YOUR OWN";
            this.CreateTemplateButton.UseVisualStyleBackColor = true;
            this.CreateTemplateButton.Click += new System.EventHandler(this.CreateTemplateButton_Click);
            // 
            // BackButtonTemplates
            // 
            this.BackButtonTemplates.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonTemplates.Location = new System.Drawing.Point(65, 212);
            this.BackButtonTemplates.Name = "BackButtonTemplates";
            this.BackButtonTemplates.Size = new System.Drawing.Size(213, 32);
            this.BackButtonTemplates.TabIndex = 3;
            this.BackButtonTemplates.Text = "BACK TO MAIN";
            this.BackButtonTemplates.UseVisualStyleBackColor = true;
            this.BackButtonTemplates.Click += new System.EventHandler(this.BackButtonTemplates_Click);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.BackButtonTemplates);
            this.Controls.Add(this.CreateTemplateButton);
            this.Controls.Add(this.TemplatesLabel);
            this.Controls.Add(this.PremadeTemplateButton);
            this.Name = "Template";
            this.Text = "Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PremadeTemplateButton;
        private System.Windows.Forms.Label TemplatesLabel;
        private System.Windows.Forms.Button CreateTemplateButton;
        private System.Windows.Forms.Button BackButtonTemplates;
    }
}