namespace WindowsFormsApp2
{
    partial class LanguageChoice
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
            this.UkrBtn = new System.Windows.Forms.Button();
            this.EngBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UkrBtn
            // 
            this.UkrBtn.Location = new System.Drawing.Point(80, 115);
            this.UkrBtn.Name = "UkrBtn";
            this.UkrBtn.Size = new System.Drawing.Size(75, 29);
            this.UkrBtn.TabIndex = 0;
            this.UkrBtn.Text = "Українська";
            this.UkrBtn.UseVisualStyleBackColor = true;
            this.UkrBtn.Click += new System.EventHandler(this.UkrBtn_Click);
            // 
            // EngBtn
            // 
            this.EngBtn.Location = new System.Drawing.Point(179, 115);
            this.EngBtn.Name = "EngBtn";
            this.EngBtn.Size = new System.Drawing.Size(75, 29);
            this.EngBtn.TabIndex = 1;
            this.EngBtn.Text = "Англійська";
            this.EngBtn.UseVisualStyleBackColor = true;
            this.EngBtn.Click += new System.EventHandler(this.EngBtn_Click);
            // 
            // LanguageChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 285);
            this.Controls.Add(this.EngBtn);
            this.Controls.Add(this.UkrBtn);
            this.Name = "LanguageChoice";
            this.Text = "LanguageChoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UkrBtn;
        private System.Windows.Forms.Button EngBtn;
    }
}