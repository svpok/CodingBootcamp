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
            this.butCollectData = new System.Windows.Forms.Button();
            this.butCloseSession = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOpenSeesion = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimeTo.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(58, 71);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(188, 26);
            this.dateTimeTo.TabIndex = 1;
            this.dateTimeTo.Value = new System.DateTime(2020, 2, 27, 12, 18, 17, 0);
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged_1);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimeFrom.CustomFormat = "dd/MM/yyy,hh:mm";
            this.dateTimeFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(59, 34);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(187, 26);
            this.dateTimeFrom.TabIndex = 0;
            this.dateTimeFrom.Value = new System.DateTime(2020, 2, 26, 0, 0, 0, 0);
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.White;
            this.To.Location = new System.Drawing.Point(6, 71);
            this.To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(32, 18);
            this.To.TabIndex = 25;
            this.To.Text = "To :";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.Transparent;
            this.From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.White;
            this.From.Location = new System.Drawing.Point(6, 37);
            this.From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(49, 18);
            this.From.TabIndex = 24;
            this.From.Text = "From:";
            // 
            // DateTimeFilter
            // 
            this.DateTimeFilter.AutoSize = true;
            this.DateTimeFilter.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeFilter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeFilter.ForeColor = System.Drawing.Color.White;
            this.DateTimeFilter.Location = new System.Drawing.Point(6, 5);
            this.DateTimeFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateTimeFilter.Name = "DateTimeFilter";
            this.DateTimeFilter.Size = new System.Drawing.Size(188, 22);
            this.DateTimeFilter.TabIndex = 23;
            this.DateTimeFilter.Text = "Select date and time:";
            // 
            // butCollectData
            // 
            this.butCollectData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butCollectData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCollectData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butCollectData.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCollectData.ForeColor = System.Drawing.Color.White;
            this.butCollectData.Location = new System.Drawing.Point(362, 517);
            this.butCollectData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butCollectData.Name = "butCollectData";
            this.butCollectData.Size = new System.Drawing.Size(192, 39);
            this.butCollectData.TabIndex = 3;
            this.butCollectData.Text = "Collect data";
            this.butCollectData.UseVisualStyleBackColor = false;
            this.butCollectData.Click += new System.EventHandler(this.butCollectDataClick);
            // 
            // butCloseSession
            // 
            this.butCloseSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butCloseSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCloseSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butCloseSession.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseSession.ForeColor = System.Drawing.Color.White;
            this.butCloseSession.Location = new System.Drawing.Point(705, 517);
            this.butCloseSession.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butCloseSession.Name = "butCloseSession";
            this.butCloseSession.Size = new System.Drawing.Size(192, 39);
            this.butCloseSession.TabIndex = 4;
            this.butCloseSession.Text = "Close session";
            this.butCloseSession.UseVisualStyleBackColor = false;
            this.butCloseSession.Click += new System.EventHandler(this.butCloseSessionClick);
            // 
            // loadData
            // 
            this.loadData.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.loadData.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.loadData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loadData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.HideSelection = false;
            this.loadData.Location = new System.Drawing.Point(7, 27);
            this.loadData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(621, 473);
            this.loadData.TabIndex = 2;
            this.loadData.TabStop = false;
            this.loadData.UseCompatibleStateImageBehavior = false;
            this.loadData.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Session information:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.DateTimeFilter);
            this.panel2.Controls.Add(this.From);
            this.panel2.Controls.Add(this.dateTimeTo);
            this.panel2.Controls.Add(this.To);
            this.panel2.Controls.Add(this.dateTimeFrom);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 106);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loadData);
            this.panel1.Location = new System.Drawing.Point(270, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 503);
            this.panel1.TabIndex = 30;
            // 
            // butOpenSeesion
            // 
            this.butOpenSeesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.butOpenSeesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOpenSeesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butOpenSeesion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOpenSeesion.ForeColor = System.Drawing.Color.White;
            this.butOpenSeesion.Location = new System.Drawing.Point(13, 517);
            this.butOpenSeesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butOpenSeesion.Name = "butOpenSeesion";
            this.butOpenSeesion.Size = new System.Drawing.Size(192, 39);
            this.butOpenSeesion.TabIndex = 2;
            this.butOpenSeesion.Text = "Open session folder";
            this.butOpenSeesion.UseVisualStyleBackColor = false;
            this.butOpenSeesion.Click += new System.EventHandler(this.butOpenSeesion_Click);
            // 
            // ExistingSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.butOpenSeesion);
            this.Controls.Add(this.butCollectData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butCloseSession);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ExistingSessionFormUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Support troubleshooting tool:session id:";
            this.Load += new System.EventHandler(this.ExistingSessionFormUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCollectData;
        private System.Windows.Forms.Button butCloseSession;
        private System.Windows.Forms.ListView loadData;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label DateTimeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butOpenSeesion;
    }
}
