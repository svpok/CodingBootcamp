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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelEvAndFile = new System.Windows.Forms.Panel();
            this.EventViewerLogs = new System.Windows.Forms.Label();
            this.ListEv = new System.Windows.Forms.CheckedListBox();
            this.ListTraces = new System.Windows.Forms.CheckedListBox();
            this.FilesLogs = new System.Windows.Forms.Label();
            this.Traces = new System.Windows.Forms.Label();
            this.butAll = new System.Windows.Forms.Button();
            this.ListFiles = new System.Windows.Forms.CheckedListBox();
            this.butStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogsLevel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelEvAndFile.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboboxWorkflows
            // 
            this.comboboxWorkflows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.comboboxWorkflows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxWorkflows.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxWorkflows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboboxWorkflows.FormattingEnabled = true;

            this.comboboxWorkflows.Location = new System.Drawing.Point(4, 104);
            this.comboboxWorkflows.Margin = new System.Windows.Forms.Padding(4);

            this.comboboxWorkflows.Name = "comboboxWorkflows";
            this.comboboxWorkflows.Size = new System.Drawing.Size(604, 51);
            this.comboboxWorkflows.TabIndex = 1;
            this.comboboxWorkflows.SelectedIndexChanged += new System.EventHandler(this.comboboxWorkflows_SelectedValueChanged);
            // 
            // Workflow
            // 
            this.Workflow.AutoSize = true;
            this.Workflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Workflow.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workflow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Workflow.Location = new System.Drawing.Point(4, 14);
            this.Workflow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Workflow.Name = "Workflow";
            this.Workflow.Size = new System.Drawing.Size(223, 49);
            this.Workflow.TabIndex = 0;
            this.Workflow.Text = "Workflow :";
            this.Workflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.Workflow);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 69);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboboxWorkflows, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 194);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.60656F));

            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 624F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 724);

            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // butWarning
            // 
            this.butWarning.AutoSize = true;
            this.butWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.butWarning.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butWarning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butWarning.Location = new System.Drawing.Point(17, 300);
            this.butWarning.Margin = new System.Windows.Forms.Padding(4);
            this.butWarning.Name = "butWarning";
            this.butWarning.Size = new System.Drawing.Size(193, 47);
            this.butWarning.TabIndex = 3;
            this.butWarning.TabStop = true;
            this.butWarning.Text = "Warning";
            this.butWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butWarning.UseVisualStyleBackColor = false;
            // 
            // butInformation
            // 
            this.butInformation.AutoSize = true;
            this.butInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.butInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butInformation.Location = new System.Drawing.Point(17, 192);
            this.butInformation.Margin = new System.Windows.Forms.Padding(4);
            this.butInformation.Name = "butInformation";
            this.butInformation.Size = new System.Drawing.Size(243, 47);
            this.butInformation.TabIndex = 2;
            this.butInformation.TabStop = true;
            this.butInformation.Text = "Information";
            this.butInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butInformation.UseVisualStyleBackColor = false;
            // 
            // butCurrent
            // 
            this.butCurrent.AutoSize = true;
            this.butCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.butCurrent.Checked = true;
            this.butCurrent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butCurrent.Location = new System.Drawing.Point(17, 84);
            this.butCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.butCurrent.Name = "butCurrent";
            this.butCurrent.Size = new System.Drawing.Size(176, 47);
            this.butCurrent.TabIndex = 1;
            this.butCurrent.TabStop = true;
            this.butCurrent.Text = "Current";
            this.butCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butCurrent.UseVisualStyleBackColor = false;
            // 
            // LogsLevel
            // 
            this.LogsLevel.AutoSize = true;
            this.LogsLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.LogsLevel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogsLevel.Location = new System.Drawing.Point(-3, 14);
            this.LogsLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogsLevel.Name = "LogsLevel";
            this.LogsLevel.Size = new System.Drawing.Size(257, 49);
            this.LogsLevel.TabIndex = 0;
            this.LogsLevel.Text = "Logs Level :";
            this.LogsLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butError
            // 
            this.butError.AutoSize = true;
            this.butError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.butError.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butError.Location = new System.Drawing.Point(17, 406);
            this.butError.Margin = new System.Windows.Forms.Padding(4);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(135, 47);
            this.butError.TabIndex = 4;
            this.butError.TabStop = true;
            this.butError.Text = "Error";
            this.butError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butError.UseVisualStyleBackColor = false;
            // 
            // panelLogsLevel
            // 
            this.panelLogsLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panelLogsLevel.Controls.Add(this.butError);
            this.panelLogsLevel.Controls.Add(this.butWarning);
            this.panelLogsLevel.Controls.Add(this.butInformation);
            this.panelLogsLevel.Controls.Add(this.butCurrent);
            this.panelLogsLevel.ForeColor = System.Drawing.SystemColors.Desktop;

            this.panelLogsLevel.Location = new System.Drawing.Point(4, 90);
            this.panelLogsLevel.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogsLevel.Name = "panelLogsLevel";
            this.panelLogsLevel.Size = new System.Drawing.Size(297, 565);

            this.panelLogsLevel.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelLogsLevel, 0, 1);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.Desktop;

            this.tableLayoutPanel2.Location = new System.Drawing.Point(2063, 190);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);

            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9171F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0829F));

            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 1026);

            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LogsLevel);
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 62);
            this.panel7.TabIndex = 1;
            // 
            // panelEvAndFile
            // 
            this.panelEvAndFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelEvAndFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEvAndFile.Controls.Add(this.EventViewerLogs);
            this.panelEvAndFile.Controls.Add(this.ListEv);
            this.panelEvAndFile.Controls.Add(this.ListTraces);
            this.panelEvAndFile.Controls.Add(this.FilesLogs);
            this.panelEvAndFile.Controls.Add(this.Traces);
            this.panelEvAndFile.Controls.Add(this.butAll);
            this.panelEvAndFile.Controls.Add(this.ListFiles);
            this.panelEvAndFile.ForeColor = System.Drawing.Color.White;
            this.panelEvAndFile.Location = new System.Drawing.Point(4, 4);
            this.panelEvAndFile.Margin = new System.Windows.Forms.Padding(4);
            this.panelEvAndFile.Name = "panelEvAndFile";

            this.panelEvAndFile.Size = new System.Drawing.Size(1073, 1026);

            this.panelEvAndFile.TabIndex = 10;
            this.panelEvAndFile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEvAndFile_Paint);
            // 
            // EventViewerLogs
            // 
            this.EventViewerLogs.AutoSize = true;
            this.EventViewerLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.EventViewerLogs.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventViewerLogs.ForeColor = System.Drawing.Color.White;

            this.EventViewerLogs.Location = new System.Drawing.Point(28, 61);
            this.EventViewerLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.EventViewerLogs.Name = "EventViewerLogs";
            this.EventViewerLogs.Size = new System.Drawing.Size(354, 43);
            this.EventViewerLogs.TabIndex = 0;
            this.EventViewerLogs.Text = "Event Viewer Logs :";
            // 
            // ListEv
            // 
            this.ListEv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ListEv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListEv.ForeColor = System.Drawing.Color.Gainsboro;
            this.ListEv.FormattingEnabled = true;


            this.ListEv.Location = new System.Drawing.Point(28, 109);
            this.ListEv.Margin = new System.Windows.Forms.Padding(4);
            this.ListEv.Name = "ListEv";
            this.ListEv.Size = new System.Drawing.Size(1343, 250);
            this.ListEv.TabIndex = 0;
            // 
            // ListTraces
            // 
            this.ListTraces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ListTraces.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTraces.ForeColor = System.Drawing.Color.Gainsboro;
            this.ListTraces.FormattingEnabled = true;

            this.ListTraces.Location = new System.Drawing.Point(28, 849);
            this.ListTraces.Margin = new System.Windows.Forms.Padding(4);

            this.ListTraces.Name = "ListTraces";
            this.ListTraces.Size = new System.Drawing.Size(1343, 250);
            this.ListTraces.TabIndex = 17;
            // 
            // FilesLogs
            // 
            this.FilesLogs.AutoSize = true;
            this.FilesLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.FilesLogs.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesLogs.ForeColor = System.Drawing.Color.White;

            this.FilesLogs.Location = new System.Drawing.Point(28, 445);
            this.FilesLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.FilesLogs.Name = "FilesLogs";
            this.FilesLogs.Size = new System.Drawing.Size(214, 43);
            this.FilesLogs.TabIndex = 1;
            this.FilesLogs.Text = "Files Logs :";
            // 
            // Traces
            // 
            this.Traces.AutoSize = true;
            this.Traces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Traces.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traces.ForeColor = System.Drawing.Color.White;

            this.Traces.Location = new System.Drawing.Point(28, 804);
            this.Traces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.Traces.Name = "Traces";
            this.Traces.Size = new System.Drawing.Size(155, 43);
            this.Traces.TabIndex = 0;
            this.Traces.Text = "Traces :";
            // 
            // butAll
            // 
            this.butAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butAll.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAll.ForeColor = System.Drawing.Color.White;
            this.butAll.Location = new System.Drawing.Point(27, 15);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(183, 60);
            this.butAll.TabIndex = 6;
            this.butAll.Text = "Choose them all";
            this.butAll.UseVisualStyleBackColor = false;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // ListFiles
            // 
            this.ListFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ListFiles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.ListFiles.FormattingEnabled = true;


            this.ListFiles.Location = new System.Drawing.Point(20, 490);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(4);

            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(1351, 250);
            this.ListFiles.TabIndex = 16;
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.ForeColor = System.Drawing.Color.White;

            this.butStart.Name = "butStart";

            this.butStart.Location = new System.Drawing.Point(2095, 1255);
            this.butStart.Margin = new System.Windows.Forms.Padding(4);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(228, 75);

            this.butStart.TabIndex = 7;
            this.butStart.Text = "Start Session";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click_2);
            // 



            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelEvAndFile, 0, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(641, 190);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.42365F));

            this.tableLayoutPanel3.Size = new System.Drawing.Size(1415, 1165);

            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";

            this.panel2.Size = new System.Drawing.Size(2412, 168);

            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(756, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Support Troubleshooting Tool";
            // 
            // NewSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;


            this.ClientSize = new System.Drawing.Size(2456, 1379);

            this.Controls.Add(this.butStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewSessionFormUi";
            this.Text = "Support Troubleshooting Tool";
            this.Load += new System.EventHandler(this.NewSessionFormUi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLogsLevel.ResumeLayout(false);
            this.panelLogsLevel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelEvAndFile.ResumeLayout(false);
            this.panelEvAndFile.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.CheckedListBox ListTraces;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.CheckedListBox ListFiles;
        private System.Windows.Forms.Label Traces;
        private System.Windows.Forms.CheckedListBox ListEv;
        private System.Windows.Forms.Label EventViewerLogs;
        private System.Windows.Forms.Label FilesLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
    }
}