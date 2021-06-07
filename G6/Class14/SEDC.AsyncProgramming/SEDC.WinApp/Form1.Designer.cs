
namespace SEDC.WinApp
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
            System.Windows.Forms.Button asyncBtn;
            this.syncBtn = new System.Windows.Forms.Button();
            this.checkMessageBtn = new System.Windows.Forms.Button();
            this.checkMessageLbl = new System.Windows.Forms.Label();
            this.infoMessageLbl = new System.Windows.Forms.Label();
            asyncBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asyncBtn
            // 
            asyncBtn.BackColor = System.Drawing.Color.LimeGreen;
            asyncBtn.Location = new System.Drawing.Point(162, 253);
            asyncBtn.Name = "asyncBtn";
            asyncBtn.Size = new System.Drawing.Size(164, 59);
            asyncBtn.TabIndex = 0;
            asyncBtn.Text = "Async Work";
            asyncBtn.UseVisualStyleBackColor = false;
            asyncBtn.Click += new System.EventHandler(this.asyncBtn_Click);
            // 
            // syncBtn
            // 
            this.syncBtn.BackColor = System.Drawing.Color.Tomato;
            this.syncBtn.Location = new System.Drawing.Point(455, 253);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(164, 59);
            this.syncBtn.TabIndex = 1;
            this.syncBtn.Text = "Sync Work";
            this.syncBtn.UseVisualStyleBackColor = false;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // checkMessageBtn
            // 
            this.checkMessageBtn.Location = new System.Drawing.Point(322, 160);
            this.checkMessageBtn.Name = "checkMessageBtn";
            this.checkMessageBtn.Size = new System.Drawing.Size(131, 23);
            this.checkMessageBtn.TabIndex = 2;
            this.checkMessageBtn.Text = "Check for message";
            this.checkMessageBtn.UseVisualStyleBackColor = true;
            this.checkMessageBtn.Click += new System.EventHandler(this.checkMessageBtn_Click);
            // 
            // checkMessageLbl
            // 
            this.checkMessageLbl.AutoSize = true;
            this.checkMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMessageLbl.Location = new System.Drawing.Point(355, 202);
            this.checkMessageLbl.Name = "checkMessageLbl";
            this.checkMessageLbl.Size = new System.Drawing.Size(0, 25);
            this.checkMessageLbl.TabIndex = 3;
            // 
            // infoMessageLbl
            // 
            this.infoMessageLbl.AutoSize = true;
            this.infoMessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMessageLbl.Location = new System.Drawing.Point(318, 349);
            this.infoMessageLbl.Name = "infoMessageLbl";
            this.infoMessageLbl.Size = new System.Drawing.Size(145, 24);
            this.infoMessageLbl.TabIndex = 4;
            this.infoMessageLbl.Text = "Work not started";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 412);
            this.Controls.Add(this.infoMessageLbl);
            this.Controls.Add(this.checkMessageLbl);
            this.Controls.Add(this.checkMessageBtn);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(asyncBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.Button checkMessageBtn;
        private System.Windows.Forms.Label checkMessageLbl;
        private System.Windows.Forms.Label infoMessageLbl;
    }
}

