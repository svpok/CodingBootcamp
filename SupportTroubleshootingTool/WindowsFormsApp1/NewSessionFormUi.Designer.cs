﻿namespace WindowsFormsApp1
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
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.DateTimeFilter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.From = new System.Windows.Forms.Label();
            this.comboboxWorkflows = new System.Windows.Forms.ComboBox();
            this.Workflow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butWarning = new System.Windows.Forms.RadioButton();
            this.butInformation = new System.Windows.Forms.RadioButton();
            this.butCurrent = new System.Windows.Forms.RadioButton();
            this.LogsLevel = new System.Windows.Forms.Label();
            this.butError = new System.Windows.Forms.RadioButton();
            this.panelLogsLevel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelEvAndFile = new System.Windows.Forms.Panel();
            this.BoxLogs = new System.Windows.Forms.GroupBox();
            this.butStart = new System.Windows.Forms.Button();
            this.ListTraces = new System.Windows.Forms.CheckedListBox();
            this.butReset = new System.Windows.Forms.Button();
            this.ListFiles = new System.Windows.Forms.CheckedListBox();
            this.Traces = new System.Windows.Forms.Label();
            this.ListEv = new System.Windows.Forms.CheckedListBox();
            this.EventViewerLogs = new System.Windows.Forms.Label();
            this.FilesLogs = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogsLevel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelEvAndFile.SuspendLayout();
            this.BoxLogs.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(151, 134);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(265, 31);
            this.dateTimeTo.TabIndex = 4;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(151, 86);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(265, 31);
            this.dateTimeFrom.TabIndex = 3;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(39, 134);
            this.To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(49, 25);
            this.To.TabIndex = 2;
            this.To.Text = "To :";
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFilter.Location = new System.Drawing.Point(24, 22);
            this.DateTimeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(280, 37);
            this.DateTimeFilter.TabIndex = 0;
            this.DateTimeFilter.Text = "Date Time Filter :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.To);
            this.panel2.Controls.Add(this.From);
            this.panel2.Controls.Add(this.DateTimeFilter);
            this.panel2.Location = new System.Drawing.Point(4, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 175);
            this.panel2.TabIndex = 8;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(39, 86);
            this.From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(73, 25);
            this.From.TabIndex = 1;
            this.From.Text = "From :";
            // 
            // comboboxWorkflows
            // 
            this.comboboxWorkflows.FormattingEnabled = true;
            this.comboboxWorkflows.Location = new System.Drawing.Point(192, 21);
            this.comboboxWorkflows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboboxWorkflows.Name = "comboboxWorkflows";
            this.comboboxWorkflows.Size = new System.Drawing.Size(356, 33);
            this.comboboxWorkflows.TabIndex = 1;
            this.comboboxWorkflows.SelectedIndexChanged += new System.EventHandler(this.comboboxWorkflows_SelectedValueChanged);
            // 
            // Workflow
            // 
            this.Workflow.AutoSize = true;
            this.Workflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workflow.Location = new System.Drawing.Point(17, 16);
            this.Workflow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Workflow.Name = "Workflow";
            this.Workflow.Size = new System.Drawing.Size(168, 37);
            this.Workflow.TabIndex = 0;
            this.Workflow.Text = "Workflow :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboboxWorkflows);
            this.panel1.Controls.Add(this.Workflow);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 70);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.60656F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.39344F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 338);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // butWarning
            // 
            this.butWarning.AutoSize = true;
            this.butWarning.Location = new System.Drawing.Point(31, 138);
            this.butWarning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butWarning.Name = "butWarning";
            this.butWarning.Size = new System.Drawing.Size(123, 29);
            this.butWarning.TabIndex = 3;
            this.butWarning.TabStop = true;
            this.butWarning.Text = "Warning";
            this.butWarning.UseVisualStyleBackColor = true;
            // 
            // butInformation
            // 
            this.butInformation.AutoSize = true;
            this.butInformation.Location = new System.Drawing.Point(28, 90);
            this.butInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInformation.Name = "butInformation";
            this.butInformation.Size = new System.Drawing.Size(149, 29);
            this.butInformation.TabIndex = 2;
            this.butInformation.TabStop = true;
            this.butInformation.Text = "Information";
            this.butInformation.UseVisualStyleBackColor = true;
            // 
            // butCurrent
            // 
            this.butCurrent.AutoSize = true;
            this.butCurrent.Checked = true;
            this.butCurrent.Location = new System.Drawing.Point(28, 34);
            this.butCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCurrent.Name = "butCurrent";
            this.butCurrent.Size = new System.Drawing.Size(114, 29);
            this.butCurrent.TabIndex = 1;
            this.butCurrent.TabStop = true;
            this.butCurrent.Text = "Current";
            this.butCurrent.UseVisualStyleBackColor = true;
            // 
            // LogsLevel
            // 
            this.LogsLevel.AutoSize = true;
            this.LogsLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsLevel.Location = new System.Drawing.Point(4, 0);
            this.LogsLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogsLevel.Name = "LogsLevel";
            this.LogsLevel.Size = new System.Drawing.Size(200, 37);
            this.LogsLevel.TabIndex = 0;
            this.LogsLevel.Text = "Logs Level :";
            // 
            // butError
            // 
            this.butError.AutoSize = true;
            this.butError.Location = new System.Drawing.Point(35, 194);
            this.butError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(90, 29);
            this.butError.TabIndex = 4;
            this.butError.TabStop = true;
            this.butError.Text = "Error";
            this.butError.UseVisualStyleBackColor = true;
            // 
            // panelLogsLevel
            // 
            this.panelLogsLevel.Controls.Add(this.butError);
            this.panelLogsLevel.Controls.Add(this.butWarning);
            this.panelLogsLevel.Controls.Add(this.butInformation);
            this.panelLogsLevel.Controls.Add(this.butCurrent);
            this.panelLogsLevel.Location = new System.Drawing.Point(4, 70);
            this.panelLogsLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogsLevel.Name = "panelLogsLevel";
            this.panelLogsLevel.Size = new System.Drawing.Size(263, 247);
            this.panelLogsLevel.TabIndex = 9;
            
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LogsLevel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelLogsLevel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(623, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.41177F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 321);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panelEvAndFile
            // 
            this.panelEvAndFile.Controls.Add(this.BoxLogs);
            this.panelEvAndFile.Location = new System.Drawing.Point(4, 4);
            this.panelEvAndFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEvAndFile.Name = "panelEvAndFile";
            this.panelEvAndFile.Size = new System.Drawing.Size(1220, 489);
            this.panelEvAndFile.TabIndex = 10;
            // 
            // BoxLogs
            // 
            this.BoxLogs.Controls.Add(this.butStart);
            this.BoxLogs.Controls.Add(this.ListTraces);
            this.BoxLogs.Controls.Add(this.butReset);
            this.BoxLogs.Controls.Add(this.ListFiles);
            this.BoxLogs.Controls.Add(this.Traces);
            this.BoxLogs.Controls.Add(this.ListEv);
            this.BoxLogs.Controls.Add(this.EventViewerLogs);
            this.BoxLogs.Controls.Add(this.FilesLogs);
            this.BoxLogs.Location = new System.Drawing.Point(20, 19);
            this.BoxLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxLogs.Name = "BoxLogs";
            this.BoxLogs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxLogs.Size = new System.Drawing.Size(1181, 461);
            this.BoxLogs.TabIndex = 16;
            this.BoxLogs.TabStop = false;
            this.BoxLogs.Enter += new System.EventHandler(this.BoxLogs_Enter);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(280, 368);
            this.butStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(212, 75);
            this.butStart.TabIndex = 7;
            this.butStart.Text = "Start Session";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click_2);
            // 
            // ListTraces
            // 
            this.ListTraces.FormattingEnabled = true;
            this.ListTraces.Location = new System.Drawing.Point(835, 84);
            this.ListTraces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListTraces.Name = "ListTraces";
            this.ListTraces.Size = new System.Drawing.Size(315, 228);
            this.ListTraces.TabIndex = 17;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(25, 368);
            this.butReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(228, 75);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "Reset To Default";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click_1);
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(424, 84);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(323, 228);
            this.ListFiles.TabIndex = 16;
            // 
            // Traces
            // 
            this.Traces.AutoSize = true;
            this.Traces.Location = new System.Drawing.Point(860, 44);
            this.Traces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Traces.Name = "Traces";
            this.Traces.Size = new System.Drawing.Size(90, 25);
            this.Traces.TabIndex = 0;
            this.Traces.Text = "Traces :";
            // 
            // ListEv
            // 
            this.ListEv.FormattingEnabled = true;
            this.ListEv.Location = new System.Drawing.Point(25, 84);
            this.ListEv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListEv.Name = "ListEv";
            this.ListEv.Size = new System.Drawing.Size(316, 228);
            this.ListEv.TabIndex = 0;
            // 
            // EventViewerLogs
            // 
            this.EventViewerLogs.AutoSize = true;
            this.EventViewerLogs.Location = new System.Drawing.Point(31, 44);
            this.EventViewerLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventViewerLogs.Name = "EventViewerLogs";
            this.EventViewerLogs.Size = new System.Drawing.Size(203, 25);
            this.EventViewerLogs.TabIndex = 0;
            this.EventViewerLogs.Text = "Event Viewer Logs :";
            // 
            // FilesLogs
            // 
            this.FilesLogs.AutoSize = true;
            this.FilesLogs.Location = new System.Drawing.Point(441, 44);
            this.FilesLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilesLogs.Name = "FilesLogs";
            this.FilesLogs.Size = new System.Drawing.Size(123, 25);
            this.FilesLogs.TabIndex = 1;
            this.FilesLogs.Text = "Files Logs :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelEvAndFile, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 364);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.42365F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1239, 506);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // NewSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1281, 886);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewSessionFormUi";
            this.Text = "Support Troubleshooting Tool";
            this.Load += new System.EventHandler(this.NewSessionFormUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLogsLevel.ResumeLayout(false);
            this.panelLogsLevel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelEvAndFile.ResumeLayout(false);
            this.BoxLogs.ResumeLayout(false);
            this.BoxLogs.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label DateTimeFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.ComboBox comboboxWorkflows;
        private System.Windows.Forms.Label Workflow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton butWarning;
        private System.Windows.Forms.RadioButton butInformation;
        private System.Windows.Forms.RadioButton butCurrent;
        private System.Windows.Forms.Label LogsLevel;
        private System.Windows.Forms.RadioButton butError;
        private System.Windows.Forms.Panel panelLogsLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelEvAndFile;
        private System.Windows.Forms.GroupBox BoxLogs;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.CheckedListBox ListTraces;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.CheckedListBox ListFiles;
        private System.Windows.Forms.Label Traces;
        private System.Windows.Forms.CheckedListBox ListEv;
        private System.Windows.Forms.Label EventViewerLogs;
        private System.Windows.Forms.Label FilesLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}