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
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.DateTimeFilter = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butCollectAndClose = new System.Windows.Forms.Button();
            this.butCollectWithoutClosingSession = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(45, 93);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(134, 20);
            this.dateTimeTo.TabIndex = 27;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(48, 69);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(134, 20);
            this.dateTimeFrom.TabIndex = 26;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.Black;
            this.To.Location = new System.Drawing.Point(11, 93);
            this.To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(30, 13);
            this.To.TabIndex = 25;
            this.To.Text = "To :";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.Transparent;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.Black;
            this.From.Location = new System.Drawing.Point(7, 69);
            this.From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(42, 13);
            this.From.TabIndex = 24;
            this.From.Text = "From :";
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFilter.ForeColor = System.Drawing.Color.Black;
            this.DateTimeFilter.Location = new System.Drawing.Point(4, 41);
            this.DateTimeFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(182, 20);
            this.DateTimeFilter.TabIndex = 23;
            this.DateTimeFilter.Text = "Date and Time Filter :";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.butBack.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.Black;
            this.butBack.Location = new System.Drawing.Point(10, 341);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(95, 41);
            this.butBack.TabIndex = 22;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click_1);
            // 
            // butCollectAndClose
            // 
            this.butCollectAndClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butCollectAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCollectAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.butCollectAndClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectAndClose.ForeColor = System.Drawing.Color.Black;
            this.butCollectAndClose.Location = new System.Drawing.Point(258, 340);
            this.butCollectAndClose.Name = "butCollectAndClose";
            this.butCollectAndClose.Size = new System.Drawing.Size(181, 39);
            this.butCollectAndClose.TabIndex = 21;
            this.butCollectAndClose.Text = "Collect and close session";
            this.butCollectAndClose.UseVisualStyleBackColor = false;
            this.butCollectAndClose.Click += new System.EventHandler(this.butCollectAndClose_Click);
            // 
            // butCollectWithoutClosingSession
            // 
            this.butCollectWithoutClosingSession.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butCollectWithoutClosingSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCollectWithoutClosingSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.butCollectWithoutClosingSession.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectWithoutClosingSession.ForeColor = System.Drawing.Color.Black;
            this.butCollectWithoutClosingSession.Location = new System.Drawing.Point(472, 341);
            this.butCollectWithoutClosingSession.Name = "butCollectWithoutClosingSession";
            this.butCollectWithoutClosingSession.Size = new System.Drawing.Size(214, 39);
            this.butCollectWithoutClosingSession.TabIndex = 20;
            this.butCollectWithoutClosingSession.Text = "Collect without closing session";
            this.butCollectWithoutClosingSession.UseVisualStyleBackColor = false;
            this.butCollectWithoutClosingSession.Click += new System.EventHandler(this.butCollectWithoutClosingSession_Click);
            // 
            // loadData
            // 
            this.loadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadData.HideSelection = false;
            this.loadData.Location = new System.Drawing.Point(197, 29);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(454, 239);
            this.loadData.TabIndex = 2;
            this.loadData.UseCompatibleStateImageBehavior = false;
            this.loadData.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Session Information:";
            // 
            // ExistingSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(698, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.From);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.butCollectWithoutClosingSession);
            this.Controls.Add(this.butCollectAndClose);
            this.Controls.Add(this.DateTimeFilter);
            this.Controls.Add(this.butBack);
            this.Name = "ExistingSessionFormUi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ExistingSessionFormUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butCollectAndClose;
        private System.Windows.Forms.Button butCollectWithoutClosingSession;
        private System.Windows.Forms.ListView loadData;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label DateTimeFilter;
        private System.Windows.Forms.Label label1;
    }
}