
namespace UI_UX_VIRVOU.CustomControls
{
    partial class CallHelpPhase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhaseMainPictureBox = new System.Windows.Forms.PictureBox();
            this.PhaseApprovalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseMainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseApprovalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhaseMainPictureBox
            // 
            this.PhaseMainPictureBox.Location = new System.Drawing.Point(26, 3);
            this.PhaseMainPictureBox.Name = "PhaseMainPictureBox";
            this.PhaseMainPictureBox.Size = new System.Drawing.Size(120, 120);
            this.PhaseMainPictureBox.TabIndex = 0;
            this.PhaseMainPictureBox.TabStop = false;
            // 
            // PhaseApprovalPictureBox
            // 
            this.PhaseApprovalPictureBox.Location = new System.Drawing.Point(233, 16);
            this.PhaseApprovalPictureBox.Name = "PhaseApprovalPictureBox";
            this.PhaseApprovalPictureBox.Size = new System.Drawing.Size(92, 90);
            this.PhaseApprovalPictureBox.TabIndex = 1;
            this.PhaseApprovalPictureBox.TabStop = false;
            // 
            // CallHelpPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhaseApprovalPictureBox);
            this.Controls.Add(this.PhaseMainPictureBox);
            this.Name = "CallHelpPhase";
            this.Size = new System.Drawing.Size(414, 170);
            ((System.ComponentModel.ISupportInitialize)(this.PhaseMainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseApprovalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PhaseMainPictureBox;
        public System.Windows.Forms.PictureBox PhaseApprovalPictureBox;
    }
}
