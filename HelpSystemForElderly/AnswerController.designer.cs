
namespace UI_UX_VIRVOU.Forms
{
    partial class AnswerController
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
            this.shopItems = new FontAwesome.Sharp.IconButton();
            this.CallDoctor = new FontAwesome.Sharp.IconButton();
            this.SecondaryButtonPanel = new System.Windows.Forms.Panel();
            this.horizontalLineLabel = new System.Windows.Forms.Label();
            this.positiveIconButton = new FontAwesome.Sharp.IconButton();
            this.negativeIconButton = new FontAwesome.Sharp.IconButton();
            this.SecondaryButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopItems
            // 
            this.shopItems.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.shopItems.IconColor = System.Drawing.Color.Black;
            this.shopItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.shopItems.IconSize = 80;
            this.shopItems.Location = new System.Drawing.Point(69, 120);
            this.shopItems.Name = "shopItems";
            this.shopItems.Size = new System.Drawing.Size(165, 87);
            this.shopItems.TabIndex = 9;
            this.shopItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shopItems.UseVisualStyleBackColor = true;
            this.shopItems.Click += new System.EventHandler(this.shopItems_Click);
            // 
            // CallDoctor
            // 
            this.CallDoctor.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.CallDoctor.IconColor = System.Drawing.Color.Black;
            this.CallDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CallDoctor.IconSize = 80;
            this.CallDoctor.Location = new System.Drawing.Point(69, 3);
            this.CallDoctor.Name = "CallDoctor";
            this.CallDoctor.Size = new System.Drawing.Size(165, 90);
            this.CallDoctor.TabIndex = 12;
            this.CallDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CallDoctor.UseVisualStyleBackColor = true;
            this.CallDoctor.Click += new System.EventHandler(this.CallDoctor_Click);
            // 
            // SecondaryButtonPanel
            // 
            this.SecondaryButtonPanel.Controls.Add(this.CallDoctor);
            this.SecondaryButtonPanel.Controls.Add(this.shopItems);
            this.SecondaryButtonPanel.Location = new System.Drawing.Point(1, 266);
            this.SecondaryButtonPanel.Name = "SecondaryButtonPanel";
            this.SecondaryButtonPanel.Size = new System.Drawing.Size(309, 228);
            this.SecondaryButtonPanel.TabIndex = 13;
            // 
            // horizontalLineLabel
            // 
            this.horizontalLineLabel.AutoSize = true;
            this.horizontalLineLabel.Location = new System.Drawing.Point(-2, 233);
            this.horizontalLineLabel.Name = "horizontalLineLabel";
            this.horizontalLineLabel.Size = new System.Drawing.Size(14, 17);
            this.horizontalLineLabel.TabIndex = 14;
            this.horizontalLineLabel.Text = "x";
            // 
            // positiveIconButton
            // 
            this.positiveIconButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.positiveIconButton.IconColor = System.Drawing.Color.Green;
            this.positiveIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.positiveIconButton.IconSize = 80;
            this.positiveIconButton.Location = new System.Drawing.Point(70, 24);
            this.positiveIconButton.Name = "positiveIconButton";
            this.positiveIconButton.Size = new System.Drawing.Size(165, 96);
            this.positiveIconButton.TabIndex = 15;
            this.positiveIconButton.UseVisualStyleBackColor = true;
            this.positiveIconButton.Click += new System.EventHandler(this.positiveIconButton_Click);
            // 
            // negativeIconButton
            // 
            this.negativeIconButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.negativeIconButton.IconColor = System.Drawing.Color.Red;
            this.negativeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.negativeIconButton.IconSize = 80;
            this.negativeIconButton.Location = new System.Drawing.Point(70, 137);
            this.negativeIconButton.Name = "negativeIconButton";
            this.negativeIconButton.Size = new System.Drawing.Size(165, 97);
            this.negativeIconButton.TabIndex = 16;
            this.negativeIconButton.UseVisualStyleBackColor = true;
            this.negativeIconButton.Click += new System.EventHandler(this.negativeIconButton_Click);
            // 
            // AnswerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 496);
            this.Controls.Add(this.negativeIconButton);
            this.Controls.Add(this.positiveIconButton);
            this.Controls.Add(this.horizontalLineLabel);
            this.Controls.Add(this.SecondaryButtonPanel);
            this.Name = "AnswerController";
            this.Text = "AnswerController";
            this.Load += new System.EventHandler(this.AnswerController_Load);
            this.SecondaryButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton shopItems;
        private FontAwesome.Sharp.IconButton CallDoctor;
        private System.Windows.Forms.Panel SecondaryButtonPanel;
        private System.Windows.Forms.Label horizontalLineLabel;
        private FontAwesome.Sharp.IconButton positiveIconButton;
        private FontAwesome.Sharp.IconButton negativeIconButton;
    }
}