namespace AppDevProj
{
    partial class QuickView
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
            this.QuickviewTitleLabel = new System.Windows.Forms.Label();
            this.QuickViewCollectionsListBox = new System.Windows.Forms.ListBox();
            this.QuickviewCollectionListView = new System.Windows.Forms.ListView();
            this.QuickviewDisplayButton = new System.Windows.Forms.Button();
            this.QuickviewBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuickviewTitleLabel
            // 
            this.QuickviewTitleLabel.AutoSize = true;
            this.QuickviewTitleLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickviewTitleLabel.Location = new System.Drawing.Point(70, 18);
            this.QuickviewTitleLabel.Name = "QuickviewTitleLabel";
            this.QuickviewTitleLabel.Size = new System.Drawing.Size(323, 25);
            this.QuickviewTitleLabel.TabIndex = 0;
            this.QuickviewTitleLabel.Text = "Welcome to the QUICKVIEW";
            // 
            // QuickViewCollectionsListBox
            // 
            this.QuickViewCollectionsListBox.FormattingEnabled = true;
            this.QuickViewCollectionsListBox.Location = new System.Drawing.Point(13, 53);
            this.QuickViewCollectionsListBox.Name = "QuickViewCollectionsListBox";
            this.QuickViewCollectionsListBox.Size = new System.Drawing.Size(155, 342);
            this.QuickViewCollectionsListBox.TabIndex = 1;
            // 
            // QuickviewCollectionListView
            // 
            this.QuickviewCollectionListView.HideSelection = false;
            this.QuickviewCollectionListView.Location = new System.Drawing.Point(186, 53);
            this.QuickviewCollectionListView.Name = "QuickviewCollectionListView";
            this.QuickviewCollectionListView.Size = new System.Drawing.Size(247, 296);
            this.QuickviewCollectionListView.TabIndex = 2;
            this.QuickviewCollectionListView.UseCompatibleStateImageBehavior = false;
            // 
            // QuickviewDisplayButton
            // 
            this.QuickviewDisplayButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickviewDisplayButton.Location = new System.Drawing.Point(186, 356);
            this.QuickviewDisplayButton.Name = "QuickviewDisplayButton";
            this.QuickviewDisplayButton.Size = new System.Drawing.Size(113, 39);
            this.QuickviewDisplayButton.TabIndex = 3;
            this.QuickviewDisplayButton.Text = "DISPLAY";
            this.QuickviewDisplayButton.UseVisualStyleBackColor = true;
            // 
            // QuickviewBackButton
            // 
            this.QuickviewBackButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickviewBackButton.Location = new System.Drawing.Point(320, 355);
            this.QuickviewBackButton.Name = "QuickviewBackButton";
            this.QuickviewBackButton.Size = new System.Drawing.Size(113, 39);
            this.QuickviewBackButton.TabIndex = 4;
            this.QuickviewBackButton.Text = "BACK";
            this.QuickviewBackButton.UseVisualStyleBackColor = true;
            this.QuickviewBackButton.Click += new System.EventHandler(this.QuickviewBackButton_Click);
            // 
            // QuickView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 416);
            this.Controls.Add(this.QuickviewBackButton);
            this.Controls.Add(this.QuickviewDisplayButton);
            this.Controls.Add(this.QuickviewCollectionListView);
            this.Controls.Add(this.QuickViewCollectionsListBox);
            this.Controls.Add(this.QuickviewTitleLabel);
            this.Name = "QuickView";
            this.Text = "QuickView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuickviewTitleLabel;
        private System.Windows.Forms.ListBox QuickViewCollectionsListBox;
        private System.Windows.Forms.ListView QuickviewCollectionListView;
        private System.Windows.Forms.Button QuickviewDisplayButton;
        private System.Windows.Forms.Button QuickviewBackButton;
    }
}