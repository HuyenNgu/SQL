namespace WindowsFormsApplication2
{
    partial class ViewAllMembers
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
            this.btnViewAllMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewAllMembers
            // 
            this.btnViewAllMembers.Location = new System.Drawing.Point(102, 76);
            this.btnViewAllMembers.Name = "btnViewAllMembers";
            this.btnViewAllMembers.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllMembers.TabIndex = 0;
            this.btnViewAllMembers.Text = "View all members";
            this.btnViewAllMembers.UseVisualStyleBackColor = true;
            this.btnViewAllMembers.Click += new System.EventHandler(this.btnViewAllMembers_Click);
            // 
            // ViewAllMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnViewAllMembers);
            this.Name = "ViewAllMembers";
            this.Text = "ViewAllMembers";
            this.Load += new System.EventHandler(this.ViewAllMembers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllMembers;
    }
}

