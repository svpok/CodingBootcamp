namespace WindowsFormsApp1
{
    partial class NewSessionFormUi
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
            this.butStart = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.checkBoxTraces = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTraces = new System.Windows.Forms.Panel();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.checkBoxEv = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butError = new System.Windows.Forms.RadioButton();
            this.butWarning = new System.Windows.Forms.RadioButton();
            this.butInformation = new System.Windows.Forms.RadioButton();
            this.butCurrent = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelLogsLevel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEvAndFile = new System.Windows.Forms.Panel();
            this.panelTraces.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelLogsLevel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEvAndFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(233, 0);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(134, 49);
            this.butStart.TabIndex = 7;
            this.butStart.Text = "Stard Session";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(3, 3);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(171, 45);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "Reset To Defaulf";
            this.butReset.UseVisualStyleBackColor = true;
            // 
            // checkBoxTraces
            // 
            this.checkBoxTraces.AutoSize = true;
            this.checkBoxTraces.Location = new System.Drawing.Point(23, 53);
            this.checkBoxTraces.Name = "checkBoxTraces";
            this.checkBoxTraces.Size = new System.Drawing.Size(22, 21);
            this.checkBoxTraces.TabIndex = 3;
            this.checkBoxTraces.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Traces :";
            // 
            // panelTraces
            // 
            this.panelTraces.Controls.Add(this.checkBoxTraces);
            this.panelTraces.Controls.Add(this.label8);
            this.panelTraces.Location = new System.Drawing.Point(7, 716);
            this.panelTraces.Name = "panelTraces";
            this.panelTraces.Size = new System.Drawing.Size(430, 100);
            this.panelTraces.TabIndex = 11;
            // 
            // checkBoxFile
            // 
            this.checkBoxFile.AutoSize = true;
            this.checkBoxFile.Location = new System.Drawing.Point(23, 159);
            this.checkBoxFile.Name = "checkBoxFile";
            this.checkBoxFile.Size = new System.Drawing.Size(22, 21);
            this.checkBoxFile.TabIndex = 4;
            this.checkBoxFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxEv
            // 
            this.checkBoxEv.AutoSize = true;
            this.checkBoxEv.Location = new System.Drawing.Point(23, 58);
            this.checkBoxEv.Name = "checkBoxEv";
            this.checkBoxEv.Size = new System.Drawing.Size(22, 21);
            this.checkBoxEv.TabIndex = 2;
            this.checkBoxEv.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "File Logs :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Event Viewer Logs :";
            // 
            // butError
            // 
            this.butError.AutoSize = true;
            this.butError.Location = new System.Drawing.Point(33, 163);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(69, 24);
            this.butError.TabIndex = 4;
            this.butError.TabStop = true;
            this.butError.Text = "Error";
            this.butError.UseVisualStyleBackColor = true;
            // 
            // butWarning
            // 
            this.butWarning.AutoSize = true;
            this.butWarning.Location = new System.Drawing.Point(33, 124);
            this.butWarning.Name = "butWarning";
            this.butWarning.Size = new System.Drawing.Size(93, 24);
            this.butWarning.TabIndex = 3;
            this.butWarning.TabStop = true;
            this.butWarning.Text = "Warning";
            this.butWarning.UseVisualStyleBackColor = true;
            // 
            // butInformation
            // 
            this.butInformation.AutoSize = true;
            this.butInformation.Location = new System.Drawing.Point(33, 94);
            this.butInformation.Name = "butInformation";
            this.butInformation.Size = new System.Drawing.Size(115, 24);
            this.butInformation.TabIndex = 2;
            this.butInformation.TabStop = true;
            this.butInformation.Text = "Information";
            this.butInformation.UseVisualStyleBackColor = true;
            // 
            // butCurrent
            // 
            this.butCurrent.AutoSize = true;
            this.butCurrent.Location = new System.Drawing.Point(33, 64);
            this.butCurrent.Name = "butCurrent";
            this.butCurrent.Size = new System.Drawing.Size(87, 24);
            this.butCurrent.TabIndex = 1;
            this.butCurrent.TabStop = true;
            this.butCurrent.Text = "Current";
            this.butCurrent.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.butStart);
            this.panel6.Controls.Add(this.butReset);
            this.panel6.Location = new System.Drawing.Point(7, 851);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 49);
            this.panel6.TabIndex = 12;
            // 
            // panelLogsLevel
            // 
            this.panelLogsLevel.Controls.Add(this.butError);
            this.panelLogsLevel.Controls.Add(this.butWarning);
            this.panelLogsLevel.Controls.Add(this.butInformation);
            this.panelLogsLevel.Controls.Add(this.butCurrent);
            this.panelLogsLevel.Controls.Add(this.label5);
            this.panelLogsLevel.Location = new System.Drawing.Point(7, 254);
            this.panelLogsLevel.Name = "panelLogsLevel";
            this.panelLogsLevel.Size = new System.Drawing.Size(430, 204);
            this.panelLogsLevel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Logs Level :";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(113, 107);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimeTo.TabIndex = 4;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(113, 69);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimeFrom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "TO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Time Filter :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 140);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 56);
            this.panel1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workflow :";
            // 
            // panelEvAndFile
            // 
            this.panelEvAndFile.Controls.Add(this.checkBoxFile);
            this.panelEvAndFile.Controls.Add(this.checkBoxEv);
            this.panelEvAndFile.Controls.Add(this.label7);
            this.panelEvAndFile.Controls.Add(this.label6);
            this.panelEvAndFile.Location = new System.Drawing.Point(7, 486);
            this.panelEvAndFile.Name = "panelEvAndFile";
            this.panelEvAndFile.Size = new System.Drawing.Size(430, 212);
            this.panelEvAndFile.TabIndex = 10;
            // 
            // NewSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 911);
            this.Controls.Add(this.panelTraces);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelLogsLevel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEvAndFile);
            this.Name = "NewSessionFormUi";
            this.Text = "Support Troubleshooting Tool";
            this.panelTraces.ResumeLayout(false);
            this.panelTraces.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelLogsLevel.ResumeLayout(false);
            this.panelLogsLevel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEvAndFile.ResumeLayout(false);
            this.panelEvAndFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.CheckBox checkBoxTraces;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelTraces;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.CheckBox checkBoxEv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton butError;
        private System.Windows.Forms.RadioButton butWarning;
        private System.Windows.Forms.RadioButton butInformation;
        private System.Windows.Forms.RadioButton butCurrent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelLogsLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEvAndFile;
    }
}