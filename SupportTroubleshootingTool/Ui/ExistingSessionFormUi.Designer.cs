﻿namespace SupportTroubleshootingTool.UI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butOpenSeesion = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(131, 184);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(283, 44);
            this.dateTimeTo.TabIndex = 27;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(147, 118);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(289, 44);
            this.dateTimeFrom.TabIndex = 26;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.White;
            this.To.Location = new System.Drawing.Point(13, 182);
            this.To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(65, 36);
            this.To.TabIndex = 25;
            this.To.Text = "To :";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.Transparent;
            this.From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.White;
            this.From.Location = new System.Drawing.Point(13, 118);
            this.From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(108, 36);
            this.From.TabIndex = 24;
            this.From.Text = "From :";
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeFilter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFilter.ForeColor = System.Drawing.Color.White;
            this.DateTimeFilter.Location = new System.Drawing.Point(11, 35);
            this.DateTimeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(384, 43);
            this.DateTimeFilter.TabIndex = 23;
            this.DateTimeFilter.Text = "Date and Time Filter :";
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.butBack.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.White;
            this.butBack.Location = new System.Drawing.Point(19, 24);
            this.butBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(143, 75);
            this.butBack.TabIndex = 22;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click_1);
            // 
            // butCollectAndClose
            // 
            this.butCollectAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butCollectAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCollectAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.butCollectAndClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectAndClose.ForeColor = System.Drawing.Color.White;
            this.butCollectAndClose.Location = new System.Drawing.Point(916, 24);
            this.butCollectAndClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butCollectAndClose.Name = "butCollectAndClose";
            this.butCollectAndClose.Size = new System.Drawing.Size(424, 75);
            this.butCollectAndClose.TabIndex = 21;
            this.butCollectAndClose.Text = "Collect and close session";
            this.butCollectAndClose.UseVisualStyleBackColor = false;
            this.butCollectAndClose.Click += new System.EventHandler(this.butCollectAndClose_Click);
            // 
            // butCollectWithoutClosingSession
            // 
            this.butCollectWithoutClosingSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butCollectWithoutClosingSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCollectWithoutClosingSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.butCollectWithoutClosingSession.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectWithoutClosingSession.ForeColor = System.Drawing.Color.White;
            this.butCollectWithoutClosingSession.Location = new System.Drawing.Point(1351, 24);
            this.butCollectWithoutClosingSession.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butCollectWithoutClosingSession.Name = "butCollectWithoutClosingSession";
            this.butCollectWithoutClosingSession.Size = new System.Drawing.Size(428, 75);
            this.butCollectWithoutClosingSession.TabIndex = 20;
            this.butCollectWithoutClosingSession.Text = "Collect without closing session";
            this.butCollectWithoutClosingSession.UseVisualStyleBackColor = false;
            this.butCollectWithoutClosingSession.Click += new System.EventHandler(this.butCollectWithoutClosingSession_Click);
            // 
            // loadData
            // 
            this.loadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.HideSelection = false;
            this.loadData.Location = new System.Drawing.Point(24, 118);
            this.loadData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(1080, 456);
            this.loadData.TabIndex = 2;
            this.loadData.UseCompatibleStateImageBehavior = false;
            this.loadData.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 43);
            this.label1.TabIndex = 28;
            this.label1.Text = "Session Information:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.DateTimeFilter);
            this.panel2.Controls.Add(this.From);
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.To);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Location = new System.Drawing.Point(33, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 591);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loadData);
            this.panel1.Location = new System.Drawing.Point(680, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 591);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.butOpenSeesion);
            this.panel3.Controls.Add(this.butCollectAndClose);
            this.panel3.Controls.Add(this.butCollectWithoutClosingSession);
            this.panel3.Controls.Add(this.butBack);
            this.panel3.Location = new System.Drawing.Point(33, 636);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1784, 120);
            this.panel3.TabIndex = 30;
            // 
            // butOpenSeesion
            // 
            this.butOpenSeesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butOpenSeesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOpenSeesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.butOpenSeesion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOpenSeesion.ForeColor = System.Drawing.Color.White;
            this.butOpenSeesion.Location = new System.Drawing.Point(397, 24);
            this.butOpenSeesion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butOpenSeesion.Name = "butOpenSeesion";
            this.butOpenSeesion.Size = new System.Drawing.Size(424, 75);
            this.butOpenSeesion.TabIndex = 23;
            this.butOpenSeesion.Text = "Open Seesion Folder";
            this.butOpenSeesion.UseVisualStyleBackColor = false;
            // 
            // ExistingSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1852, 774);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ExistingSessionFormUi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ExistingSessionFormUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butOpenSeesion;
    }
}