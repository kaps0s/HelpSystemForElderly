
namespace UI_UX_VIRVOU.Forms
{
    partial class CallHelpForm
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
            this.components = new System.ComponentModel.Container();
            this.AppliancePhasePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AskHelpTimer = new System.Windows.Forms.Timer(this.components);
            this.ApprovalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppliancePhasePanel
            // 
            this.AppliancePhasePanel.Location = new System.Drawing.Point(12, 23);
            this.AppliancePhasePanel.Name = "AppliancePhasePanel";
            this.AppliancePhasePanel.Size = new System.Drawing.Size(382, 331);
            this.AppliancePhasePanel.TabIndex = 0;
            // 
            // AskHelpTimer
            // 
            this.AskHelpTimer.Tick += new System.EventHandler(this.AskHelpTimer_Tick);
            // 
            // ApprovalButton
            // 
            this.ApprovalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalButton.Location = new System.Drawing.Point(111, 423);
            this.ApprovalButton.Name = "ApprovalButton";
            this.ApprovalButton.Size = new System.Drawing.Size(182, 56);
            this.ApprovalButton.TabIndex = 4;
            this.ApprovalButton.Text = "ΟΚ";
            this.ApprovalButton.UseVisualStyleBackColor = true;
            this.ApprovalButton.Click += new System.EventHandler(this.ApprovalButton_Click);
            // 
            // CallHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(433, 508);
            this.Controls.Add(this.ApprovalButton);
            this.Controls.Add(this.AppliancePhasePanel);
            this.Name = "CallHelpForm";
            this.Text = "CallHelpForm";
            this.Load += new System.EventHandler(this.AppliancePhasesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AppliancePhasePanel;
        private System.Windows.Forms.Timer AskHelpTimer;
        private System.Windows.Forms.Button ApprovalButton;
    }
}