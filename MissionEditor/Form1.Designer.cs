namespace MissionEditor
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
            this.openButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.campaignName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampaignEditor = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.missionList = new System.Windows.Forms.ListBox();
            this.addMission = new System.Windows.Forms.Button();
            this.systemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplication = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.term0Upper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.term1Lower = new System.Windows.Forms.NumericUpDown();
            this.term1Upper = new System.Windows.Forms.NumericUpDown();
            this.term0Lower = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lightyearInput = new System.Windows.Forms.NumericUpDown();
            this.numberOfProblems = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.briefingText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.discoveryText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.systemDataText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CampaignEditor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.term0Upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.term1Lower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.term1Upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.term0Lower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightyearInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProblems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 41);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(109, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(109, 23);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // campaignName
            // 
            this.campaignName.Enabled = false;
            this.campaignName.Location = new System.Drawing.Point(254, 28);
            this.campaignName.Name = "campaignName";
            this.campaignName.Size = new System.Drawing.Size(159, 20);
            this.campaignName.TabIndex = 3;
            this.campaignName.TextChanged += new System.EventHandler(this.campaignName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campaign Name";
            // 
            // CampaignEditor
            // 
            this.CampaignEditor.Controls.Add(this.label10);
            this.CampaignEditor.Controls.Add(this.systemDataText);
            this.CampaignEditor.Controls.Add(this.label22);
            this.CampaignEditor.Controls.Add(this.discoveryText);
            this.CampaignEditor.Controls.Add(this.label9);
            this.CampaignEditor.Controls.Add(this.briefingText);
            this.CampaignEditor.Controls.Add(this.label8);
            this.CampaignEditor.Controls.Add(this.numericUpDown1);
            this.CampaignEditor.Controls.Add(this.label23);
            this.CampaignEditor.Controls.Add(this.numberOfProblems);
            this.CampaignEditor.Controls.Add(this.label7);
            this.CampaignEditor.Controls.Add(this.lightyearInput);
            this.CampaignEditor.Controls.Add(this.label6);
            this.CampaignEditor.Controls.Add(this.label5);
            this.CampaignEditor.Controls.Add(this.label4);
            this.CampaignEditor.Controls.Add(this.term0Lower);
            this.CampaignEditor.Controls.Add(this.term1Upper);
            this.CampaignEditor.Controls.Add(this.term1Lower);
            this.CampaignEditor.Controls.Add(this.label3);
            this.CampaignEditor.Controls.Add(this.term0Upper);
            this.CampaignEditor.Controls.Add(this.groupBox1);
            this.CampaignEditor.Controls.Add(this.label2);
            this.CampaignEditor.Controls.Add(this.systemName);
            this.CampaignEditor.Enabled = false;
            this.CampaignEditor.Location = new System.Drawing.Point(254, 54);
            this.CampaignEditor.Name = "CampaignEditor";
            this.CampaignEditor.Size = new System.Drawing.Size(775, 573);
            this.CampaignEditor.TabIndex = 5;
            this.CampaignEditor.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 70);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // missionList
            // 
            this.missionList.FormattingEnabled = true;
            this.missionList.Location = new System.Drawing.Point(127, 12);
            this.missionList.Name = "missionList";
            this.missionList.Size = new System.Drawing.Size(118, 615);
            this.missionList.TabIndex = 7;
            this.missionList.Click += new System.EventHandler(this.missionList_Click);
            // 
            // addMission
            // 
            this.addMission.Location = new System.Drawing.Point(12, 99);
            this.addMission.Name = "addMission";
            this.addMission.Size = new System.Drawing.Size(109, 23);
            this.addMission.TabIndex = 8;
            this.addMission.Text = "Add Mission";
            this.addMission.UseVisualStyleBackColor = true;
            this.addMission.Click += new System.EventHandler(this.addMission_Click);
            // 
            // systemName
            // 
            this.systemName.Location = new System.Drawing.Point(0, 32);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(159, 20);
            this.systemName.TabIndex = 5;
            this.systemName.TextChanged += new System.EventHandler(this.systemName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "System Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 128);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete Mission";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(3, 16);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAddition.TabIndex = 8;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "+";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            this.radioButtonAddition.CheckedChanged += new System.EventHandler(this.radioButtonAddition_CheckedChanged);
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Location = new System.Drawing.Point(40, 16);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSubtraction.TabIndex = 9;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "-";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            this.radioButtonSubtraction.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMultiplication
            // 
            this.radioButtonMultiplication.AutoSize = true;
            this.radioButtonMultiplication.Location = new System.Drawing.Point(74, 16);
            this.radioButtonMultiplication.Name = "radioButtonMultiplication";
            this.radioButtonMultiplication.Size = new System.Drawing.Size(29, 17);
            this.radioButtonMultiplication.TabIndex = 10;
            this.radioButtonMultiplication.TabStop = true;
            this.radioButtonMultiplication.Text = "*";
            this.radioButtonMultiplication.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(109, 16);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDivision.TabIndex = 11;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "/";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAddition);
            this.groupBox1.Controls.Add(this.radioButtonDivision);
            this.groupBox1.Controls.Add(this.radioButtonSubtraction);
            this.groupBox1.Controls.Add(this.radioButtonMultiplication);
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 39);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Math Operator";
            // 
            // term0Upper
            // 
            this.term0Upper.Location = new System.Drawing.Point(0, 159);
            this.term0Upper.Name = "term0Upper";
            this.term0Upper.Size = new System.Drawing.Size(120, 20);
            this.term0Upper.TabIndex = 13;
            this.term0Upper.ValueChanged += new System.EventHandler(this.term0Upper_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Term Upper Bound";
            // 
            // term1Lower
            // 
            this.term1Lower.Location = new System.Drawing.Point(0, 276);
            this.term1Lower.Name = "term1Lower";
            this.term1Lower.Size = new System.Drawing.Size(120, 20);
            this.term1Lower.TabIndex = 15;
            this.term1Lower.ValueChanged += new System.EventHandler(this.term1Lower_ValueChanged);
            // 
            // term1Upper
            // 
            this.term1Upper.Location = new System.Drawing.Point(0, 237);
            this.term1Upper.Name = "term1Upper";
            this.term1Upper.Size = new System.Drawing.Size(120, 20);
            this.term1Upper.TabIndex = 16;
            this.term1Upper.ValueChanged += new System.EventHandler(this.term1Upper_ValueChanged);
            // 
            // term0Lower
            // 
            this.term0Lower.Location = new System.Drawing.Point(0, 198);
            this.term0Lower.Name = "term0Lower";
            this.term0Lower.Size = new System.Drawing.Size(120, 20);
            this.term0Lower.TabIndex = 17;
            this.term0Lower.ValueChanged += new System.EventHandler(this.term0Lower_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Second Term Lower Bound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Second Term Upper Bound";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "First Term Lower Bound";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lightyears from Earth";
            // 
            // lightyearInput
            // 
            this.lightyearInput.DecimalPlaces = 2;
            this.lightyearInput.Enabled = false;
            this.lightyearInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lightyearInput.Location = new System.Drawing.Point(176, 33);
            this.lightyearInput.Name = "lightyearInput";
            this.lightyearInput.Size = new System.Drawing.Size(120, 20);
            this.lightyearInput.TabIndex = 11;
            this.lightyearInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numberOfProblems
            // 
            this.numberOfProblems.Location = new System.Drawing.Point(0, 120);
            this.numberOfProblems.Name = "numberOfProblems";
            this.numberOfProblems.Size = new System.Drawing.Size(120, 20);
            this.numberOfProblems.TabIndex = 21;
            this.numberOfProblems.ValueChanged += new System.EventHandler(this.numberOfProblems_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(-3, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Number of Problems";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Number of Stars";
            // 
            // briefingText
            // 
            this.briefingText.Location = new System.Drawing.Point(186, 97);
            this.briefingText.Multiline = true;
            this.briefingText.Name = "briefingText";
            this.briefingText.Size = new System.Drawing.Size(236, 120);
            this.briefingText.TabIndex = 25;
            this.briefingText.TextChanged += new System.EventHandler(this.briefingText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Briefing Text";
            // 
            // discoveryText
            // 
            this.discoveryText.Location = new System.Drawing.Point(185, 257);
            this.discoveryText.Multiline = true;
            this.discoveryText.Name = "discoveryText";
            this.discoveryText.Size = new System.Drawing.Size(237, 123);
            this.discoveryText.TabIndex = 27;
            this.discoveryText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(186, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Discovery Text";
            // 
            // systemDataText
            // 
            this.systemDataText.Location = new System.Drawing.Point(185, 412);
            this.systemDataText.Multiline = true;
            this.systemDataText.Name = "systemDataText";
            this.systemDataText.Size = new System.Drawing.Size(237, 113);
            this.systemDataText.TabIndex = 29;
            this.systemDataText.TextChanged += new System.EventHandler(this.systemDataText_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "System Data Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 646);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addMission);
            this.Controls.Add(this.campaignName);
            this.Controls.Add(this.missionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.CampaignEditor);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CampaignEditor.ResumeLayout(false);
            this.CampaignEditor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.term0Upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.term1Lower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.term1Upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.term0Lower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightyearInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProblems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox campaignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CampaignEditor;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox missionList;
        private System.Windows.Forms.Button addMission;
        private System.Windows.Forms.TextBox systemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonMultiplication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown term0Lower;
        private System.Windows.Forms.NumericUpDown term1Upper;
        private System.Windows.Forms.NumericUpDown term1Lower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown term0Upper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lightyearInput;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numberOfProblems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox briefingText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox discoveryText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox systemDataText;
    }
}

