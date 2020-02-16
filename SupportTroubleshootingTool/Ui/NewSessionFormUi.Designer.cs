namespace SupportTroubleshootingTool.UI
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
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogsLevel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelEvAndFile.SuspendLayout();
            this.BoxLogs.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboboxWorkflows
            // 
            this.comboboxWorkflows.FormattingEnabled = true;
            this.comboboxWorkflows.Location = new System.Drawing.Point(96, 11);
            this.comboboxWorkflows.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxWorkflows.Name = "comboboxWorkflows";
            this.comboboxWorkflows.Size = new System.Drawing.Size(180, 21);
            this.comboboxWorkflows.TabIndex = 1;
            this.comboboxWorkflows.SelectedIndexChanged += new System.EventHandler(this.comboboxWorkflows_SelectedValueChanged);
            // 
            // Workflow
            // 
            this.Workflow.AutoSize = true;
            this.Workflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workflow.Location = new System.Drawing.Point(8, 8);
            this.Workflow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Workflow.Name = "Workflow";
            this.Workflow.Size = new System.Drawing.Size(82, 20);
            this.Workflow.TabIndex = 0;
            this.Workflow.Text = "Workflow :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboboxWorkflows);
            this.panel1.Controls.Add(this.Workflow);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 36);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.60656F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 42);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // butWarning
            // 
            this.butWarning.AutoSize = true;
            this.butWarning.Location = new System.Drawing.Point(16, 72);
            this.butWarning.Margin = new System.Windows.Forms.Padding(2);
            this.butWarning.Name = "butWarning";
            this.butWarning.Size = new System.Drawing.Size(65, 17);
            this.butWarning.TabIndex = 3;
            this.butWarning.TabStop = true;
            this.butWarning.Text = "Warning";
            this.butWarning.UseVisualStyleBackColor = true;
            // 
            // butInformation
            // 
            this.butInformation.AutoSize = true;
            this.butInformation.Location = new System.Drawing.Point(14, 47);
            this.butInformation.Margin = new System.Windows.Forms.Padding(2);
            this.butInformation.Name = "butInformation";
            this.butInformation.Size = new System.Drawing.Size(77, 17);
            this.butInformation.TabIndex = 2;
            this.butInformation.TabStop = true;
            this.butInformation.Text = "Information";
            this.butInformation.UseVisualStyleBackColor = true;
            // 
            // butCurrent
            // 
            this.butCurrent.AutoSize = true;
            this.butCurrent.Checked = true;
            this.butCurrent.Location = new System.Drawing.Point(14, 18);
            this.butCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.butCurrent.Name = "butCurrent";
            this.butCurrent.Size = new System.Drawing.Size(59, 17);
            this.butCurrent.TabIndex = 1;
            this.butCurrent.TabStop = true;
            this.butCurrent.Text = "Current";
            this.butCurrent.UseVisualStyleBackColor = true;
            // 
            // LogsLevel
            // 
            this.LogsLevel.AutoSize = true;
            this.LogsLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsLevel.Location = new System.Drawing.Point(2, 0);
            this.LogsLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogsLevel.Name = "LogsLevel";
            this.LogsLevel.Size = new System.Drawing.Size(105, 20);
            this.LogsLevel.TabIndex = 0;
            this.LogsLevel.Text = "Logs Level :";
            // 
            // butError
            // 
            this.butError.AutoSize = true;
            this.butError.Location = new System.Drawing.Point(18, 101);
            this.butError.Margin = new System.Windows.Forms.Padding(2);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(47, 17);
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
            this.panelLogsLevel.Location = new System.Drawing.Point(2, 38);
            this.panelLogsLevel.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogsLevel.Name = "panelLogsLevel";
            this.panelLogsLevel.Size = new System.Drawing.Size(132, 128);
            this.panelLogsLevel.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LogsLevel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelLogsLevel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 70);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.41177F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 177);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panelEvAndFile
            // 
            this.panelEvAndFile.Controls.Add(this.BoxLogs);
            this.panelEvAndFile.Location = new System.Drawing.Point(2, 2);
            this.panelEvAndFile.Margin = new System.Windows.Forms.Padding(2);
            this.panelEvAndFile.Name = "panelEvAndFile";
            this.panelEvAndFile.Size = new System.Drawing.Size(610, 254);
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
            this.BoxLogs.Location = new System.Drawing.Point(10, 10);
            this.BoxLogs.Margin = new System.Windows.Forms.Padding(2);
            this.BoxLogs.Name = "BoxLogs";
            this.BoxLogs.Padding = new System.Windows.Forms.Padding(2);
            this.BoxLogs.Size = new System.Drawing.Size(590, 240);
            this.BoxLogs.TabIndex = 16;
            this.BoxLogs.TabStop = false;
          
            this.butStart.Location = new System.Drawing.Point(140, 191);
            this.butStart.Margin = new System.Windows.Forms.Padding(2);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(106, 39);
            this.butStart.TabIndex = 7;
            this.butStart.Text = "Start Session";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click_2);
            // 
            // ListTraces
            // 
            this.ListTraces.FormattingEnabled = true;
            this.ListTraces.Location = new System.Drawing.Point(418, 44);
            this.ListTraces.Margin = new System.Windows.Forms.Padding(2);
            this.ListTraces.Name = "ListTraces";
            this.ListTraces.Size = new System.Drawing.Size(160, 109);
            this.ListTraces.TabIndex = 17;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(12, 191);
            this.butReset.Margin = new System.Windows.Forms.Padding(2);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(114, 39);
            this.butReset.TabIndex = 6;
            this.butReset.Text = "Reset To Default";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click_1);
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.Location = new System.Drawing.Point(212, 44);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(2);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(164, 109);
            this.ListFiles.TabIndex = 16;
            // 
            // Traces
            // 
            this.Traces.AutoSize = true;
            this.Traces.Location = new System.Drawing.Point(430, 23);
            this.Traces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Traces.Name = "Traces";
            this.Traces.Size = new System.Drawing.Size(46, 13);
            this.Traces.TabIndex = 0;
            this.Traces.Text = "Traces :";
            // 
            // ListEv
            // 
            this.ListEv.FormattingEnabled = true;
            this.ListEv.Location = new System.Drawing.Point(12, 44);
            this.ListEv.Margin = new System.Windows.Forms.Padding(2);
            this.ListEv.Name = "ListEv";
            this.ListEv.Size = new System.Drawing.Size(160, 109);
            this.ListEv.TabIndex = 0;
            // 
            // EventViewerLogs
            // 
            this.EventViewerLogs.AutoSize = true;
            this.EventViewerLogs.Location = new System.Drawing.Point(16, 23);
            this.EventViewerLogs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventViewerLogs.Name = "EventViewerLogs";
            this.EventViewerLogs.Size = new System.Drawing.Size(102, 13);
            this.EventViewerLogs.TabIndex = 0;
            this.EventViewerLogs.Text = "Event Viewer Logs :";
            // 
            // FilesLogs
            // 
            this.FilesLogs.AutoSize = true;
            this.FilesLogs.Location = new System.Drawing.Point(220, 23);
            this.FilesLogs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilesLogs.Name = "FilesLogs";
            this.FilesLogs.Size = new System.Drawing.Size(60, 13);
            this.FilesLogs.TabIndex = 1;
            this.FilesLogs.Text = "Files Logs :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelEvAndFile, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 263);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.42365F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 263);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // NewSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewSessionFormUi";
            this.Text = "Support Troubleshooting Tool";
            this.Load += new System.EventHandler(this.NewSessionFormUi_Load);
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