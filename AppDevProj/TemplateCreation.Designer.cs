namespace AppDevProj
{
    partial class TemplateCreation
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
            this.components = new System.ComponentModel.Container();
            this.CollectionCreationDeletionTabControl = new System.Windows.Forms.TabControl();
            this.TemplateCreationTab = new System.Windows.Forms.TabPage();
            this.TemplateCreationButton = new System.Windows.Forms.Button();
            this.CollectibleNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TemplateCreationBackButton = new System.Windows.Forms.Button();
            this.CollectibleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FirstCollcetibleTitleTextField = new System.Windows.Forms.TextBox();
            this.CollectionTitleCreationTextBox = new System.Windows.Forms.TextBox();
            this.CollectibleDescriptionLabel = new System.Windows.Forms.Label();
            this.FirstTitleLabel = new System.Windows.Forms.Label();
            this.CollectibleNumberLabel = new System.Windows.Forms.Label();
            this.TemplateCollectionTitleLabel = new System.Windows.Forms.Label();
            this.TemplateCreationMainLabel = new System.Windows.Forms.Label();
            this.TemplateModificationTab = new System.Windows.Forms.TabPage();
            this.ModifyBackButton = new System.Windows.Forms.Button();
            this.ModifyDoneButton = new System.Windows.Forms.Button();
            this.DeleteDetailsButton = new System.Windows.Forms.Button();
            this.UpdateDetailsButton = new System.Windows.Forms.Button();
            this.CollectionDeletionButton = new System.Windows.Forms.Button();
            this.NewValueLabel = new System.Windows.Forms.Label();
            this.NewValueTextBox = new System.Windows.Forms.TextBox();
            this.CollectionDetailsLabel = new System.Windows.Forms.Label();
            this.CollectionsLabel = new System.Windows.Forms.Label();
            this.ViewOrUpdateLabel = new System.Windows.Forms.Label();
            this.DetailsListBox = new System.Windows.Forms.ListBox();
            this.CollectionUpdateButton = new System.Windows.Forms.Button();
            this.TemplateModificationListBox = new System.Windows.Forms.ListBox();
            this.TemplateModificationLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CollectionCreationDeletionTabControl.SuspendLayout();
            this.TemplateCreationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollectibleNumberNumericUpDown)).BeginInit();
            this.TemplateModificationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CollectionCreationDeletionTabControl
            // 
            this.CollectionCreationDeletionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionCreationDeletionTabControl.Controls.Add(this.TemplateCreationTab);
            this.CollectionCreationDeletionTabControl.Controls.Add(this.TemplateModificationTab);
            this.CollectionCreationDeletionTabControl.Location = new System.Drawing.Point(0, 0);
            this.CollectionCreationDeletionTabControl.Name = "CollectionCreationDeletionTabControl";
            this.CollectionCreationDeletionTabControl.SelectedIndex = 0;
            this.CollectionCreationDeletionTabControl.Size = new System.Drawing.Size(453, 391);
            this.CollectionCreationDeletionTabControl.TabIndex = 0;
            // 
            // TemplateCreationTab
            // 
            this.TemplateCreationTab.Controls.Add(this.TemplateCreationButton);
            this.TemplateCreationTab.Controls.Add(this.CollectibleNumberNumericUpDown);
            this.TemplateCreationTab.Controls.Add(this.TemplateCreationBackButton);
            this.TemplateCreationTab.Controls.Add(this.CollectibleDescriptionTextBox);
            this.TemplateCreationTab.Controls.Add(this.FirstCollcetibleTitleTextField);
            this.TemplateCreationTab.Controls.Add(this.CollectionTitleCreationTextBox);
            this.TemplateCreationTab.Controls.Add(this.CollectibleDescriptionLabel);
            this.TemplateCreationTab.Controls.Add(this.FirstTitleLabel);
            this.TemplateCreationTab.Controls.Add(this.CollectibleNumberLabel);
            this.TemplateCreationTab.Controls.Add(this.TemplateCollectionTitleLabel);
            this.TemplateCreationTab.Controls.Add(this.TemplateCreationMainLabel);
            this.TemplateCreationTab.Location = new System.Drawing.Point(4, 22);
            this.TemplateCreationTab.Name = "TemplateCreationTab";
            this.TemplateCreationTab.Padding = new System.Windows.Forms.Padding(3);
            this.TemplateCreationTab.Size = new System.Drawing.Size(445, 365);
            this.TemplateCreationTab.TabIndex = 0;
            this.TemplateCreationTab.Text = "Create a Collection";
            this.TemplateCreationTab.UseVisualStyleBackColor = true;
            // 
            // TemplateCreationButton
            // 
            this.TemplateCreationButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateCreationButton.Location = new System.Drawing.Point(24, 331);
            this.TemplateCreationButton.Name = "TemplateCreationButton";
            this.TemplateCreationButton.Size = new System.Drawing.Size(187, 23);
            this.TemplateCreationButton.TabIndex = 11;
            this.TemplateCreationButton.Text = "CREATE";
            this.TemplateCreationButton.UseVisualStyleBackColor = true;
            // 
            // CollectibleNumberNumericUpDown
            // 
            this.CollectibleNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "collectibleCount", true));
            this.CollectibleNumberNumericUpDown.Location = new System.Drawing.Point(244, 114);
            this.CollectibleNumberNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CollectibleNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CollectibleNumberNumericUpDown.Name = "CollectibleNumberNumericUpDown";
            this.CollectibleNumberNumericUpDown.Size = new System.Drawing.Size(190, 20);
            this.CollectibleNumberNumericUpDown.TabIndex = 10;
            this.CollectibleNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TemplateCreationBackButton
            // 
            this.TemplateCreationBackButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateCreationBackButton.Location = new System.Drawing.Point(244, 331);
            this.TemplateCreationBackButton.Name = "TemplateCreationBackButton";
            this.TemplateCreationBackButton.Size = new System.Drawing.Size(187, 23);
            this.TemplateCreationBackButton.TabIndex = 9;
            this.TemplateCreationBackButton.Text = "BACK";
            this.TemplateCreationBackButton.UseVisualStyleBackColor = true;
            this.TemplateCreationBackButton.Click += new System.EventHandler(this.TemplateCreationBackButton_Click);
            // 
            // CollectibleDescriptionTextBox
            // 
            this.CollectibleDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "description", true));
            this.CollectibleDescriptionTextBox.Location = new System.Drawing.Point(22, 222);
            this.CollectibleDescriptionTextBox.Multiline = true;
            this.CollectibleDescriptionTextBox.Name = "CollectibleDescriptionTextBox";
            this.CollectibleDescriptionTextBox.Size = new System.Drawing.Size(412, 103);
            this.CollectibleDescriptionTextBox.TabIndex = 8;
            // 
            // FirstCollcetibleTitleTextField
            // 
            this.FirstCollcetibleTitleTextField.Location = new System.Drawing.Point(244, 158);
            this.FirstCollcetibleTitleTextField.Name = "FirstCollcetibleTitleTextField";
            this.FirstCollcetibleTitleTextField.Size = new System.Drawing.Size(190, 20);
            this.FirstCollcetibleTitleTextField.TabIndex = 7;
            // 
            // CollectionTitleCreationTextBox
            // 
            this.CollectionTitleCreationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "collectionTitle", true));
            this.CollectionTitleCreationTextBox.Location = new System.Drawing.Point(244, 78);
            this.CollectionTitleCreationTextBox.Name = "CollectionTitleCreationTextBox";
            this.CollectionTitleCreationTextBox.Size = new System.Drawing.Size(190, 20);
            this.CollectionTitleCreationTextBox.TabIndex = 6;
            // 
            // CollectibleDescriptionLabel
            // 
            this.CollectibleDescriptionLabel.AutoSize = true;
            this.CollectibleDescriptionLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectibleDescriptionLabel.Location = new System.Drawing.Point(18, 196);
            this.CollectibleDescriptionLabel.Name = "CollectibleDescriptionLabel";
            this.CollectibleDescriptionLabel.Size = new System.Drawing.Size(204, 23);
            this.CollectibleDescriptionLabel.TabIndex = 5;
            this.CollectibleDescriptionLabel.Text = "Collection Description:";
            // 
            // FirstTitleLabel
            // 
            this.FirstTitleLabel.AutoSize = true;
            this.FirstTitleLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTitleLabel.Location = new System.Drawing.Point(18, 153);
            this.FirstTitleLabel.Name = "FirstTitleLabel";
            this.FirstTitleLabel.Size = new System.Drawing.Size(150, 23);
            this.FirstTitleLabel.TabIndex = 4;
            this.FirstTitleLabel.Text = "Collectible Type:";
            // 
            // CollectibleNumberLabel
            // 
            this.CollectibleNumberLabel.AutoSize = true;
            this.CollectibleNumberLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectibleNumberLabel.Location = new System.Drawing.Point(18, 114);
            this.CollectibleNumberLabel.Name = "CollectibleNumberLabel";
            this.CollectibleNumberLabel.Size = new System.Drawing.Size(209, 23);
            this.CollectibleNumberLabel.TabIndex = 3;
            this.CollectibleNumberLabel.Text = "Number of Collectibles:";
            // 
            // TemplateCollectionTitleLabel
            // 
            this.TemplateCollectionTitleLabel.AutoSize = true;
            this.TemplateCollectionTitleLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateCollectionTitleLabel.Location = new System.Drawing.Point(18, 76);
            this.TemplateCollectionTitleLabel.Name = "TemplateCollectionTitleLabel";
            this.TemplateCollectionTitleLabel.Size = new System.Drawing.Size(144, 23);
            this.TemplateCollectionTitleLabel.TabIndex = 2;
            this.TemplateCollectionTitleLabel.Text = "Collection Title:";
            // 
            // TemplateCreationMainLabel
            // 
            this.TemplateCreationMainLabel.AutoSize = true;
            this.TemplateCreationMainLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateCreationMainLabel.Location = new System.Drawing.Point(44, 23);
            this.TemplateCreationMainLabel.Name = "TemplateCreationMainLabel";
            this.TemplateCreationMainLabel.Size = new System.Drawing.Size(351, 25);
            this.TemplateCreationMainLabel.TabIndex = 1;
            this.TemplateCreationMainLabel.Text = "Welcome to Template Creation!";
            // 
            // TemplateModificationTab
            // 
            this.TemplateModificationTab.Controls.Add(this.ModifyBackButton);
            this.TemplateModificationTab.Controls.Add(this.ModifyDoneButton);
            this.TemplateModificationTab.Controls.Add(this.DeleteDetailsButton);
            this.TemplateModificationTab.Controls.Add(this.UpdateDetailsButton);
            this.TemplateModificationTab.Controls.Add(this.CollectionDeletionButton);
            this.TemplateModificationTab.Controls.Add(this.NewValueLabel);
            this.TemplateModificationTab.Controls.Add(this.NewValueTextBox);
            this.TemplateModificationTab.Controls.Add(this.CollectionDetailsLabel);
            this.TemplateModificationTab.Controls.Add(this.CollectionsLabel);
            this.TemplateModificationTab.Controls.Add(this.ViewOrUpdateLabel);
            this.TemplateModificationTab.Controls.Add(this.DetailsListBox);
            this.TemplateModificationTab.Controls.Add(this.CollectionUpdateButton);
            this.TemplateModificationTab.Controls.Add(this.TemplateModificationListBox);
            this.TemplateModificationTab.Controls.Add(this.TemplateModificationLabel);
            this.TemplateModificationTab.Location = new System.Drawing.Point(4, 22);
            this.TemplateModificationTab.Name = "TemplateModificationTab";
            this.TemplateModificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.TemplateModificationTab.Size = new System.Drawing.Size(445, 365);
            this.TemplateModificationTab.TabIndex = 1;
            this.TemplateModificationTab.Text = "Modify a Collection";
            this.TemplateModificationTab.UseVisualStyleBackColor = true;
            // 
            // ModifyBackButton
            // 
            this.ModifyBackButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBackButton.Location = new System.Drawing.Point(326, 324);
            this.ModifyBackButton.Name = "ModifyBackButton";
            this.ModifyBackButton.Size = new System.Drawing.Size(108, 23);
            this.ModifyBackButton.TabIndex = 15;
            this.ModifyBackButton.Text = "BACK";
            this.ModifyBackButton.UseVisualStyleBackColor = true;
            this.ModifyBackButton.Click += new System.EventHandler(this.ModifyBackButton_Click);
            // 
            // ModifyDoneButton
            // 
            this.ModifyDoneButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyDoneButton.Location = new System.Drawing.Point(180, 324);
            this.ModifyDoneButton.Name = "ModifyDoneButton";
            this.ModifyDoneButton.Size = new System.Drawing.Size(108, 23);
            this.ModifyDoneButton.TabIndex = 14;
            this.ModifyDoneButton.Text = "DONE";
            this.ModifyDoneButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDetailsButton
            // 
            this.DeleteDetailsButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDetailsButton.Location = new System.Drawing.Point(326, 193);
            this.DeleteDetailsButton.Name = "DeleteDetailsButton";
            this.DeleteDetailsButton.Size = new System.Drawing.Size(108, 23);
            this.DeleteDetailsButton.TabIndex = 13;
            this.DeleteDetailsButton.Text = "DELETE";
            this.DeleteDetailsButton.UseVisualStyleBackColor = true;
            // 
            // UpdateDetailsButton
            // 
            this.UpdateDetailsButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDetailsButton.Location = new System.Drawing.Point(173, 193);
            this.UpdateDetailsButton.Name = "UpdateDetailsButton";
            this.UpdateDetailsButton.Size = new System.Drawing.Size(108, 23);
            this.UpdateDetailsButton.TabIndex = 12;
            this.UpdateDetailsButton.Text = "UPDATE";
            this.UpdateDetailsButton.UseVisualStyleBackColor = true;
            this.UpdateDetailsButton.Click += new System.EventHandler(this.UpdateDetailsButton_Click);
            // 
            // CollectionDeletionButton
            // 
            this.CollectionDeletionButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDeletionButton.Location = new System.Drawing.Point(99, 324);
            this.CollectionDeletionButton.Name = "CollectionDeletionButton";
            this.CollectionDeletionButton.Size = new System.Drawing.Size(75, 23);
            this.CollectionDeletionButton.TabIndex = 11;
            this.CollectionDeletionButton.Text = "DELETE";
            this.CollectionDeletionButton.UseVisualStyleBackColor = true;
            this.CollectionDeletionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewValueLabel
            // 
            this.NewValueLabel.AutoSize = true;
            this.NewValueLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewValueLabel.Location = new System.Drawing.Point(172, 219);
            this.NewValueLabel.Name = "NewValueLabel";
            this.NewValueLabel.Size = new System.Drawing.Size(70, 15);
            this.NewValueLabel.TabIndex = 10;
            this.NewValueLabel.Text = "New Value";
            this.NewValueLabel.Click += new System.EventHandler(this.NewValueLabel_Click);
            // 
            // NewValueTextBox
            // 
            this.NewValueTextBox.Location = new System.Drawing.Point(173, 237);
            this.NewValueTextBox.Multiline = true;
            this.NewValueTextBox.Name = "NewValueTextBox";
            this.NewValueTextBox.Size = new System.Drawing.Size(261, 81);
            this.NewValueTextBox.TabIndex = 9;
            // 
            // CollectionDetailsLabel
            // 
            this.CollectionDetailsLabel.AutoSize = true;
            this.CollectionDetailsLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionDetailsLabel.Location = new System.Drawing.Point(169, 49);
            this.CollectionDetailsLabel.Name = "CollectionDetailsLabel";
            this.CollectionDetailsLabel.Size = new System.Drawing.Size(107, 15);
            this.CollectionDetailsLabel.TabIndex = 8;
            this.CollectionDetailsLabel.Text = "Collection Details";
            // 
            // CollectionsLabel
            // 
            this.CollectionsLabel.AutoSize = true;
            this.CollectionsLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionsLabel.Location = new System.Drawing.Point(18, 46);
            this.CollectionsLabel.Name = "CollectionsLabel";
            this.CollectionsLabel.Size = new System.Drawing.Size(96, 15);
            this.CollectionsLabel.TabIndex = 7;
            this.CollectionsLabel.Text = "Collection View";
            // 
            // ViewOrUpdateLabel
            // 
            this.ViewOrUpdateLabel.AutoSize = true;
            this.ViewOrUpdateLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrUpdateLabel.Location = new System.Drawing.Point(18, 343);
            this.ViewOrUpdateLabel.Name = "ViewOrUpdateLabel";
            this.ViewOrUpdateLabel.Size = new System.Drawing.Size(66, 14);
            this.ViewOrUpdateLabel.TabIndex = 6;
            this.ViewOrUpdateLabel.Text = "^ View too";
            // 
            // DetailsListBox
            // 
            this.DetailsListBox.AccessibleName = "Details List Box";
            this.DetailsListBox.FormattingEnabled = true;
            this.DetailsListBox.Location = new System.Drawing.Point(172, 67);
            this.DetailsListBox.Name = "DetailsListBox";
            this.DetailsListBox.Size = new System.Drawing.Size(252, 121);
            this.DetailsListBox.TabIndex = 5;
            // 
            // CollectionUpdateButton
            // 
            this.CollectionUpdateButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionUpdateButton.Location = new System.Drawing.Point(18, 324);
            this.CollectionUpdateButton.Name = "CollectionUpdateButton";
            this.CollectionUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.CollectionUpdateButton.TabIndex = 4;
            this.CollectionUpdateButton.Text = "UPDATE";
            this.CollectionUpdateButton.UseVisualStyleBackColor = true;
            this.CollectionUpdateButton.Click += new System.EventHandler(this.CollectionUpdateButton_Click);
            // 
            // TemplateModificationListBox
            // 
            this.TemplateModificationListBox.FormattingEnabled = true;
            this.TemplateModificationListBox.Location = new System.Drawing.Point(18, 67);
            this.TemplateModificationListBox.Name = "TemplateModificationListBox";
            this.TemplateModificationListBox.Size = new System.Drawing.Size(148, 251);
            this.TemplateModificationListBox.TabIndex = 3;
            // 
            // TemplateModificationLabel
            // 
            this.TemplateModificationLabel.AutoSize = true;
            this.TemplateModificationLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplateModificationLabel.Location = new System.Drawing.Point(29, 17);
            this.TemplateModificationLabel.Name = "TemplateModificationLabel";
            this.TemplateModificationLabel.Size = new System.Drawing.Size(395, 25);
            this.TemplateModificationLabel.TabIndex = 2;
            this.TemplateModificationLabel.Text = "Welcome to Template Modification!";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LIA_model.collection);
            // 
            // TemplateCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 403);
            this.Controls.Add(this.CollectionCreationDeletionTabControl);
            this.Name = "TemplateCreation";
            this.Text = "TemplateCreation";
            this.CollectionCreationDeletionTabControl.ResumeLayout(false);
            this.TemplateCreationTab.ResumeLayout(false);
            this.TemplateCreationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollectibleNumberNumericUpDown)).EndInit();
            this.TemplateModificationTab.ResumeLayout(false);
            this.TemplateModificationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CollectionCreationDeletionTabControl;
        private System.Windows.Forms.TabPage TemplateCreationTab;
        private System.Windows.Forms.Label TemplateCreationMainLabel;
        private System.Windows.Forms.TabPage TemplateModificationTab;
        private System.Windows.Forms.Label CollectibleNumberLabel;
        private System.Windows.Forms.Label TemplateCollectionTitleLabel;
        private System.Windows.Forms.Button TemplateCreationBackButton;
        private System.Windows.Forms.TextBox CollectibleDescriptionTextBox;
        private System.Windows.Forms.TextBox FirstCollcetibleTitleTextField;
        private System.Windows.Forms.TextBox CollectionTitleCreationTextBox;
        private System.Windows.Forms.Label CollectibleDescriptionLabel;
        private System.Windows.Forms.Label FirstTitleLabel;
        private System.Windows.Forms.NumericUpDown CollectibleNumberNumericUpDown;
        private System.Windows.Forms.Button TemplateCreationButton;
        private System.Windows.Forms.Label TemplateModificationLabel;
        private System.Windows.Forms.ListBox DetailsListBox;
        private System.Windows.Forms.Button CollectionUpdateButton;
        private System.Windows.Forms.ListBox TemplateModificationListBox;
        private System.Windows.Forms.Button CollectionDeletionButton;
        private System.Windows.Forms.Label NewValueLabel;
        private System.Windows.Forms.TextBox NewValueTextBox;
        private System.Windows.Forms.Label CollectionDetailsLabel;
        private System.Windows.Forms.Label CollectionsLabel;
        private System.Windows.Forms.Label ViewOrUpdateLabel;
        private System.Windows.Forms.Button DeleteDetailsButton;
        private System.Windows.Forms.Button UpdateDetailsButton;
        private System.Windows.Forms.Button ModifyBackButton;
        private System.Windows.Forms.Button ModifyDoneButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}