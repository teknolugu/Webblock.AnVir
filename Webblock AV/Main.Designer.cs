namespace Webblock_AV
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialPanel1 = new MyComponents.MaterialPanel();
            this.materialPanel2 = new MyComponents.MaterialPanel();
            this.materialPanel3 = new MyComponents.MaterialPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 126);
            this.panel1.TabIndex = 0;
            // 
            // materialPanel1
            // 
            this.materialPanel1.Location = new System.Drawing.Point(13, 145);
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(223, 130);
            this.materialPanel1.TabIndex = 1;
            // 
            // materialPanel2
            // 
            this.materialPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialPanel2.Location = new System.Drawing.Point(277, 145);
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Size = new System.Drawing.Size(223, 130);
            this.materialPanel2.TabIndex = 2;
            // 
            // materialPanel3
            // 
            this.materialPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel3.Location = new System.Drawing.Point(541, 145);
            this.materialPanel3.Name = "materialPanel3";
            this.materialPanel3.Size = new System.Drawing.Size(223, 130);
            this.materialPanel3.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 479);
            this.Controls.Add(this.materialPanel3);
            this.Controls.Add(this.materialPanel2);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyComponents.MaterialPanel materialPanel1;
        private MyComponents.MaterialPanel materialPanel2;
        private MyComponents.MaterialPanel materialPanel3;
    }
}