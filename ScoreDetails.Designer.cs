namespace ModelMatchSys
{
    partial class ScoreDetails
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
            this.detailText_tb = new System.Windows.Forms.RichTextBox();
            this.teamName_lbl = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // detailText_tb
            // 
            this.detailText_tb.Location = new System.Drawing.Point(17, 76);
            this.detailText_tb.Name = "detailText_tb";
            this.detailText_tb.Size = new System.Drawing.Size(253, 337);
            this.detailText_tb.TabIndex = 0;
            this.detailText_tb.Text = "";
            // 
            // teamName_lbl
            // 
            this.teamName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.teamName_lbl.BorderColor = System.Drawing.Color.White;
            this.teamName_lbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teamName_lbl.Location = new System.Drawing.Point(14, 41);
            this.teamName_lbl.Name = "teamName_lbl";
            this.teamName_lbl.Size = new System.Drawing.Size(256, 23);
            this.teamName_lbl.TabIndex = 1;
            this.teamName_lbl.Text = "队名";
            this.teamName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teamName_lbl.Click += new System.EventHandler(this.teamName_lbl_Click);
            // 
            // ScoreDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 438);
            this.Controls.Add(this.teamName_lbl);
            this.Controls.Add(this.detailText_tb);
            this.Name = "ScoreDetails";
            this.Text = "";
            this.Load += new System.EventHandler(this.ScoreDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox detailText_tb;
        private CCWin.SkinControl.SkinLabel teamName_lbl;
    }
}