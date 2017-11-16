namespace NotificationsUISample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.titlesComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this._sampleTitlesDataset = new NotificationsUISample.TitlesDataset();
            this.availabilityGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonPanel = new System.Windows.Forms.Panel();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.onServiceLabel = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sampleTitlesDataset)).BeginInit();
            this.availabilityGroupBox.SuspendLayout();
            this.seasonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notify me when";
            // 
            // titlesComboBox
            // 
            this.titlesComboBox.FormattingEnabled = true;
            this.titlesComboBox.Location = new System.Drawing.Point(204, 31);
            this.titlesComboBox.Name = "titlesComboBox";
            this.titlesComboBox.Size = new System.Drawing.Size(305, 33);
            this.titlesComboBox.TabIndex = 1;
            this.titlesComboBox.Text = "Select a Title";
            this.titlesComboBox.SelectedIndexChanged += new System.EventHandler(this.titlesComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "for";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(192, 67);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(305, 33);
            this.typeComboBox.TabIndex = 3;
            // 
            // _sampleTitlesDataset
            // 
            this._sampleTitlesDataset.DataSetName = "TitlesDataset";
            this._sampleTitlesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availabilityGroupBox
            // 
            this.availabilityGroupBox.Controls.Add(this.serviceComboBox);
            this.availabilityGroupBox.Controls.Add(this.onServiceLabel);
            this.availabilityGroupBox.Controls.Add(this.label2);
            this.availabilityGroupBox.Controls.Add(this.typeComboBox);
            this.availabilityGroupBox.Location = new System.Drawing.Point(12, 86);
            this.availabilityGroupBox.Name = "availabilityGroupBox";
            this.availabilityGroupBox.Size = new System.Drawing.Size(912, 128);
            this.availabilityGroupBox.TabIndex = 4;
            this.availabilityGroupBox.TabStop = false;
            this.availabilityGroupBox.Visible = false;
            // 
            // seasonPanel
            // 
            this.seasonPanel.Controls.Add(this.seasonLabel);
            this.seasonPanel.Controls.Add(this.seasonComboBox);
            this.seasonPanel.Location = new System.Drawing.Point(516, 12);
            this.seasonPanel.Name = "seasonPanel";
            this.seasonPanel.Size = new System.Drawing.Size(408, 68);
            this.seasonPanel.TabIndex = 5;
            this.seasonPanel.Visible = false;
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(95, 16);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(186, 33);
            this.seasonComboBox.TabIndex = 0;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Location = new System.Drawing.Point(4, 19);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(85, 25);
            this.seasonLabel.TabIndex = 1;
            this.seasonLabel.Text = "Season";
            // 
            // onServiceLabel
            // 
            this.onServiceLabel.AutoSize = true;
            this.onServiceLabel.Location = new System.Drawing.Point(149, 31);
            this.onServiceLabel.Name = "onServiceLabel";
            this.onServiceLabel.Size = new System.Drawing.Size(36, 25);
            this.onServiceLabel.TabIndex = 4;
            this.onServiceLabel.Text = "on";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(192, 28);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(305, 33);
            this.serviceComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 580);
            this.Controls.Add(this.seasonPanel);
            this.Controls.Add(this.availabilityGroupBox);
            this.Controls.Add(this.titlesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Create a Notification Rule";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sampleTitlesDataset)).EndInit();
            this.availabilityGroupBox.ResumeLayout(false);
            this.availabilityGroupBox.PerformLayout();
            this.seasonPanel.ResumeLayout(false);
            this.seasonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox titlesComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private TitlesDataset _sampleTitlesDataset;
        private System.Windows.Forms.GroupBox availabilityGroupBox;
        private System.Windows.Forms.Panel seasonPanel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label onServiceLabel;
    }
}

