namespace WindowsFormsApp1
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
            this.Back = new System.Windows.Forms.Button();
            this.CollectAndClose = new System.Windows.Forms.Button();
            this.CollectWithoutClosingSession = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.CollectAndClose);
            this.panel2.Controls.Add(this.CollectWithoutClosingSession);
            this.panel2.Controls.Add(this.Browse);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(2, 515);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 362);
            this.panel2.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(22, 225);
            this.Back.Margin = new System.Windows.Forms.Padding(6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(196, 102);
            this.Back.TabIndex = 22;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CollectAndClose
            // 
            this.CollectAndClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CollectAndClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectAndClose.Location = new System.Drawing.Point(686, 210);
            this.CollectAndClose.Margin = new System.Windows.Forms.Padding(6);
            this.CollectAndClose.Name = "CollectAndClose";
            this.CollectAndClose.Size = new System.Drawing.Size(378, 102);
            this.CollectAndClose.TabIndex = 21;
            this.CollectAndClose.Text = "Collect and close session";
            this.CollectAndClose.UseVisualStyleBackColor = false;
            this.CollectAndClose.Click += new System.EventHandler(this.CollectAndClose_Click);
            // 
            // CollectWithoutClosingSession
            // 
            this.CollectWithoutClosingSession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CollectWithoutClosingSession.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectWithoutClosingSession.Location = new System.Drawing.Point(1146, 210);
            this.CollectWithoutClosingSession.Margin = new System.Windows.Forms.Padding(6);
            this.CollectWithoutClosingSession.Name = "CollectWithoutClosingSession";
            this.CollectWithoutClosingSession.Size = new System.Drawing.Size(430, 102);
            this.CollectWithoutClosingSession.TabIndex = 20;
            this.CollectWithoutClosingSession.Text = "Collect without closing session";
            this.CollectWithoutClosingSession.UseVisualStyleBackColor = false;
            this.CollectWithoutClosingSession.Click += new System.EventHandler(this.CollectWithoutClosingSession_Click);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Browse.Location = new System.Drawing.Point(822, 62);
            this.Browse.Margin = new System.Windows.Forms.Padding(6);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(150, 44);
            this.Browse.TabIndex = 19;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 31);
            this.textBox1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Output Folder:";
            // 
            // loadData
            // 
            this.loadData.HideSelection = false;
            this.loadData.Location = new System.Drawing.Point(2, -2);
            this.loadData.Margin = new System.Windows.Forms.Padding(6);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(1596, 502);
            this.loadData.TabIndex = 2;
            this.loadData.UseCompatibleStateImageBehavior = false;
            this.loadData.View = System.Windows.Forms.View.List;
            this.loadData.SelectedIndexChanged += new System.EventHandler(this.loadData_SelectedIndexChanged);
            // 
            // ExistingSessionFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ExistingSessionFormUi";
            this.Text = "ExistingSessionFormUi";
            this.Load += new System.EventHandler(this.ExistingSessionFormUi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CollectAndClose;
        private System.Windows.Forms.Button CollectWithoutClosingSession;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView loadData;
    }
}