namespace WindowsFormsApplication2
{
    partial class ViewAllMembersForm
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
            this.grdMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMembers.Location = new System.Drawing.Point(0, 0);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.Size = new System.Drawing.Size(284, 261);
            this.grdMembers.TabIndex = 0;
            // ViewAllMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grdMembers);
            this.Name = "ViewAllMembersForm";
            this.Text = "ViewAllMembers";
            this.Load += new System.EventHandler(this.ViewAllMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMembers;
    }
}