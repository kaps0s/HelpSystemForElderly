
namespace UI_UX_VIRVOU.Forms
{
    partial class CamAndSpeech
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
            this.messageFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.eldermanGetsDown = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.camPanel = new System.Windows.Forms.Panel();
            this.camPictureBox = new System.Windows.Forms.PictureBox();
            this.nextIconButton = new FontAwesome.Sharp.IconButton();
            this.prevIconButton = new FontAwesome.Sharp.IconButton();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.camPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messageFlowLayoutPanel
            // 
            this.messageFlowLayoutPanel.Location = new System.Drawing.Point(12, 312);
            this.messageFlowLayoutPanel.Name = "messageFlowLayoutPanel";
            this.messageFlowLayoutPanel.Size = new System.Drawing.Size(698, 634);
            this.messageFlowLayoutPanel.TabIndex = 9;
            // 
            // eldermanGetsDown
            // 
            this.eldermanGetsDown.Location = new System.Drawing.Point(0, 0);
            this.eldermanGetsDown.Name = "eldermanGetsDown";
            this.eldermanGetsDown.Size = new System.Drawing.Size(206, 51);
            this.eldermanGetsDown.TabIndex = 8;
            this.eldermanGetsDown.Text = "Simulate falling";
            this.eldermanGetsDown.UseVisualStyleBackColor = true;
            this.eldermanGetsDown.Click += new System.EventHandler(this.eldermanGetsDown_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.Location = new System.Drawing.Point(283, 95);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(133, 123);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // camPanel
            // 
            this.camPanel.Controls.Add(this.camPictureBox);
            this.camPanel.Location = new System.Drawing.Point(732, 28);
            this.camPanel.Name = "camPanel";
            this.camPanel.Size = new System.Drawing.Size(1127, 767);
            this.camPanel.TabIndex = 6;
            // 
            // camPictureBox
            // 
            this.camPictureBox.Location = new System.Drawing.Point(22, 21);
            this.camPictureBox.Name = "camPictureBox";
            this.camPictureBox.Size = new System.Drawing.Size(1089, 721);
            this.camPictureBox.TabIndex = 0;
            this.camPictureBox.TabStop = false;
            // 
            // nextIconButton
            // 
            this.nextIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.nextIconButton.IconColor = System.Drawing.Color.Black;
            this.nextIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nextIconButton.Location = new System.Drawing.Point(1306, 851);
            this.nextIconButton.Name = "nextIconButton";
            this.nextIconButton.Size = new System.Drawing.Size(149, 95);
            this.nextIconButton.TabIndex = 2;
            this.nextIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nextIconButton.UseVisualStyleBackColor = true;
            this.nextIconButton.Click += new System.EventHandler(this.nextIconButton_Click);
            // 
            // prevIconButton
            // 
            this.prevIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.prevIconButton.IconColor = System.Drawing.Color.Black;
            this.prevIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prevIconButton.Location = new System.Drawing.Point(1110, 851);
            this.prevIconButton.Name = "prevIconButton";
            this.prevIconButton.Size = new System.Drawing.Size(144, 95);
            this.prevIconButton.TabIndex = 1;
            this.prevIconButton.UseVisualStyleBackColor = true;
            this.prevIconButton.Click += new System.EventHandler(this.prevIconButton_Click);
            // 
            // MessageTimer
            // 
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // CamAndSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 981);
            this.Controls.Add(this.nextIconButton);
            this.Controls.Add(this.messageFlowLayoutPanel);
            this.Controls.Add(this.prevIconButton);
            this.Controls.Add(this.eldermanGetsDown);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.camPanel);
            this.Name = "CamAndSpeech";
            this.Text = "CamAndSpeech";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CamAndSpeech_FormClosed);
            this.Load += new System.EventHandler(this.CamAndSpeech_Load);
            this.ResizeBegin += new System.EventHandler(this.CamAndSpeech_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.CamAndSpeech_SizeChanged);
            this.camPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel messageFlowLayoutPanel;
        private System.Windows.Forms.Button eldermanGetsDown;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel camPanel;
        private FontAwesome.Sharp.IconButton nextIconButton;
        private FontAwesome.Sharp.IconButton prevIconButton;
        private System.Windows.Forms.PictureBox camPictureBox;
        public System.Windows.Forms.Timer MessageTimer;
    }
}