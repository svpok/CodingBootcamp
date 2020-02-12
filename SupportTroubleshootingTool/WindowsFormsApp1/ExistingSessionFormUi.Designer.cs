namespace SupportTroubleshootingTool.UI
{
    partial class ExistingSessionFormUi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.DateTimeFilter = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butCollectAndClose = new System.Windows.Forms.Button();
            this.butCollectWithoutClosingSession = new System.Windows.Forms.Button();
            this.butBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Controls.Add(this.To);
            this.panel2.Controls.Add(this.From);
            this.panel2.Controls.Add(this.DateTimeFilter);
            this.panel2.Controls.Add(this.butBack);
            this.panel2.Controls.Add(this.butCollectAndClose);
            this.panel2.Controls.Add(this.butCollectWithoutClosingSession);
            this.panel2.Controls.Add(this.butBrowse);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(1, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 232);
            this.panel2.TabIndex = 1;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(57, 89);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(134, 20);
            this.dateTimeTo.TabIndex = 27;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(59, 64);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFrom.TabIndex = 26;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(18, 89);
            this.To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(30, 13);
            this.To.TabIndex = 25;
            this.To.Text = "To :";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(18, 64);
            this.From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(42, 13);
            this.From.TabIndex = 24;
            this.From.Text = "From :";
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFilter.Location = new System.Drawing.Point(10, 35);
            this.DateTimeFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(182, 20);
            this.DateTimeFilter.TabIndex = 23;
            this.DateTimeFilter.Text = "Date and Time Filter :";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butBack.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.Location = new System.Drawing.Point(6, 189);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(95, 41);
            this.butBack.TabIndex = 22;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click_1);
            // 
            // butCollectAndClose
            // 
            this.butCollectAndClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCollectAndClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectAndClose.Location = new System.Drawing.Point(322, 180);
            this.butCollectAndClose.Name = "butCollectAndClose";
            this.butCollectAndClose.Size = new System.Drawing.Size(104, 48);
            this.butCollectAndClose.TabIndex = 21;
            this.butCollectAndClose.Text = "Collect and close session";
            this.butCollectAndClose.UseVisualStyleBackColor = false;
            this.butCollectAndClose.Click += new System.EventHandler(this.butCollectAndClose_Click);
            // 
            // butCollectWithoutClosingSession
            // 
            this.butCollectWithoutClosingSession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butCollectWithoutClosingSession.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectWithoutClosingSession.Location = new System.Drawing.Point(463, 179);
            this.butCollectWithoutClosingSession.Name = "butCollectWithoutClosingSession";
            this.butCollectWithoutClosingSession.Size = new System.Drawing.Size(125, 45);
            this.butCollectWithoutClosingSession.TabIndex = 20;
            this.butCollectWithoutClosingSession.Text = "Collect without closing session";
            this.butCollectWithoutClosingSession.UseVisualStyleBackColor = false;
            this.butCollectWithoutClosingSession.Click += new System.EventHandler(this.butCollectWithoutClosingSession_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butBrowse.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butBrowse.Location = new System.Drawing.Point(359, 130);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(102, 29);
            this.butBrowse.TabIndex = 19;
            this.butBrowse.Text = "Browse...";
            this.butBrowse.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 18;
          
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Output Folder:";
            // 
            // loadData
            // 
            this.loadData.HideSelection = false;
            this.loadData.Location = new System.Drawing.Point(-2, 12);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(653, 245);
            this.loadData.TabIndex = 2;
            this.loadData.UseCompatibleStateImageBehavior = false;
            this.loadData.View = System.Windows.Forms.View.List;
            // 
            // ExistingSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 481);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.panel2);
            this.Name = "ExistingSessionFormUi";
            this.Text = "ExistingSessionFormUi";
            this.Load += new System.EventHandler(this.ExistingSessionFormUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butCollectAndClose;
        private System.Windows.Forms.Button butCollectWithoutClosingSession;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView loadData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label DateTimeFilter;
    }
}