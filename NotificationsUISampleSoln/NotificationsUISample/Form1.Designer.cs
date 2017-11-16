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
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.onServiceLabel = new System.Windows.Forms.Label();
            this.seasonPanel = new System.Windows.Forms.Panel();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.eventGroupBox = new System.Windows.Forms.GroupBox();
            this.eventsComboBox = new System.Windows.Forms.ComboBox();
            this.comparedToGroupBox = new System.Windows.Forms.GroupBox();
            this.secondServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondTypeComboBox = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sampleTitlesDataset)).BeginInit();
            this.availabilityGroupBox.SuspendLayout();
            this.seasonPanel.SuspendLayout();
            this.eventGroupBox.SuspendLayout();
            this.comparedToGroupBox.SuspendLayout();
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
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // _sampleTitlesDataset
            // 
            this._sampleTitlesDataset.DataSetName = "TitlesDataset";
            this._sampleTitlesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availabilityGroupBox
            // 
            this.availabilityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availabilityGroupBox.Controls.Add(this.serviceComboBox);
            this.availabilityGroupBox.Controls.Add(this.onServiceLabel);
            this.availabilityGroupBox.Controls.Add(this.label2);
            this.availabilityGroupBox.Controls.Add(this.typeComboBox);
            this.availabilityGroupBox.Enabled = false;
            this.availabilityGroupBox.Location = new System.Drawing.Point(12, 86);
            this.availabilityGroupBox.Name = "availabilityGroupBox";
            this.availabilityGroupBox.Size = new System.Drawing.Size(912, 128);
            this.availabilityGroupBox.TabIndex = 3;
            this.availabilityGroupBox.TabStop = false;
            this.availabilityGroupBox.Text = "Availability";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(192, 28);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(305, 33);
            this.serviceComboBox.TabIndex = 1;
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // onServiceLabel
            // 
            this.onServiceLabel.AutoSize = true;
            this.onServiceLabel.Location = new System.Drawing.Point(149, 31);
            this.onServiceLabel.Name = "onServiceLabel";
            this.onServiceLabel.Size = new System.Drawing.Size(36, 25);
            this.onServiceLabel.TabIndex = 0;
            this.onServiceLabel.Text = "on";
            // 
            // seasonPanel
            // 
            this.seasonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonPanel.Controls.Add(this.seasonLabel);
            this.seasonPanel.Controls.Add(this.seasonComboBox);
            this.seasonPanel.Enabled = false;
            this.seasonPanel.Location = new System.Drawing.Point(516, 12);
            this.seasonPanel.Name = "seasonPanel";
            this.seasonPanel.Size = new System.Drawing.Size(408, 68);
            this.seasonPanel.TabIndex = 2;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Location = new System.Drawing.Point(4, 19);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(85, 25);
            this.seasonLabel.TabIndex = 0;
            this.seasonLabel.Text = "Season";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(95, 16);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(186, 33);
            this.seasonComboBox.TabIndex = 1;
            this.seasonComboBox.SelectedIndexChanged += new System.EventHandler(this.seasonComboBox_SelectedIndexChanged);
            // 
            // eventGroupBox
            // 
            this.eventGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventGroupBox.Controls.Add(this.eventsComboBox);
            this.eventGroupBox.Enabled = false;
            this.eventGroupBox.Location = new System.Drawing.Point(12, 220);
            this.eventGroupBox.Name = "eventGroupBox";
            this.eventGroupBox.Size = new System.Drawing.Size(912, 86);
            this.eventGroupBox.TabIndex = 4;
            this.eventGroupBox.TabStop = false;
            this.eventGroupBox.Text = "Event";
            // 
            // eventsComboBox
            // 
            this.eventsComboBox.FormattingEnabled = true;
            this.eventsComboBox.Location = new System.Drawing.Point(192, 31);
            this.eventsComboBox.Name = "eventsComboBox";
            this.eventsComboBox.Size = new System.Drawing.Size(305, 33);
            this.eventsComboBox.TabIndex = 0;
            this.eventsComboBox.SelectedIndexChanged += new System.EventHandler(this.eventsComboBox_SelectedIndexChanged);
            // 
            // comparedToGroupBox
            // 
            this.comparedToGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comparedToGroupBox.Controls.Add(this.secondServiceComboBox);
            this.comparedToGroupBox.Controls.Add(this.label3);
            this.comparedToGroupBox.Controls.Add(this.label4);
            this.comparedToGroupBox.Controls.Add(this.secondTypeComboBox);
            this.comparedToGroupBox.Enabled = false;
            this.comparedToGroupBox.Location = new System.Drawing.Point(12, 312);
            this.comparedToGroupBox.Name = "comparedToGroupBox";
            this.comparedToGroupBox.Size = new System.Drawing.Size(912, 128);
            this.comparedToGroupBox.TabIndex = 5;
            this.comparedToGroupBox.TabStop = false;
            this.comparedToGroupBox.Text = "Compared to";
            // 
            // secondServiceComboBox
            // 
            this.secondServiceComboBox.FormattingEnabled = true;
            this.secondServiceComboBox.Location = new System.Drawing.Point(192, 28);
            this.secondServiceComboBox.Name = "secondServiceComboBox";
            this.secondServiceComboBox.Size = new System.Drawing.Size(305, 33);
            this.secondServiceComboBox.TabIndex = 1;
            this.secondServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.secondServiceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "on";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "for";
            // 
            // secondTypeComboBox
            // 
            this.secondTypeComboBox.FormattingEnabled = true;
            this.secondTypeComboBox.Location = new System.Drawing.Point(192, 67);
            this.secondTypeComboBox.Name = "secondTypeComboBox";
            this.secondTypeComboBox.Size = new System.Drawing.Size(305, 33);
            this.secondTypeComboBox.TabIndex = 3;
            this.secondTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.secondTypeComboBox_SelectedIndexChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 446);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(912, 76);
            this.resultTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 580);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.comparedToGroupBox);
            this.Controls.Add(this.eventGroupBox);
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
            this.eventGroupBox.ResumeLayout(false);
            this.comparedToGroupBox.ResumeLayout(false);
            this.comparedToGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox eventGroupBox;
        private System.Windows.Forms.ComboBox eventsComboBox;
        private System.Windows.Forms.GroupBox comparedToGroupBox;
        private System.Windows.Forms.ComboBox secondServiceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox secondTypeComboBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

