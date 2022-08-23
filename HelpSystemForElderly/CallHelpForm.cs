using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_VIRVOU.CustomControls;

namespace UI_UX_VIRVOU.Forms
{
    public partial class CallHelpForm : Form
    {
        List<Image> images;
        List<CallHelpPhase> CHP = new List<CallHelpPhase>();
        public CamAndSpeech CAM = new CamAndSpeech();

        public CallHelpForm(List<Image> images, CamAndSpeech cam)
        {
            //MessageBox.Show("!!!");
            this.CAM = cam;
            this.images = images;
            InitializeComponent();
        }

        private void AppliancePhasesForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("!!!");
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.VerticalScroll.Visible = false;
            this.AutoScroll = true;

            this.Location = new Point(600, 300);
            //this.HorizontalScroll.Enabled = false;
            this.BackColor = Color.White;

            AskHelpTimer.Interval = 1000;
            AskHelpTimer.Enabled = false;


            //this.Size = new Size(300, 500);
            foreach (Image image in images)
            {
                CallHelpPhase AP = new CallHelpPhase(image);
                CHP.Add(AP);
                this.AppliancePhasePanel.Controls.Add(AP);
            }

            AskHelpTimer.Enabled = true;

        }

        private void StartMakingCoffee()
        {
            for (int i = 0; i < 4; i++)
            {
                //double j = 0;
                //int d = (int)j; 
                //((AppliancePhase)AppliancePhasePanel.Controls[i]).setPhaseApprovalPictureBox();
                //(AppliancePhasePanel.Controls[i] as AppliancePhase).setPhaseApprovalPictureBox();
            }
        }

        public int ticks = 0;
        private void AskHelpTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("!!!");
            if (ticks == 0){
                CHP[0].PhaseApprovalPictureBox.ImageLocation = @"..\..\Resources\LoadingImages\4.jpg";
                //MessageBox.Show("!!!");
                //CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Καλέσαμε ασθενοφόρο!", Color.Green));
                CAM.AddLabelToMessagePanel(CAM.SetUpLabel("An ambulance is on the way!", Color.Green));
            }
            else if (ticks == 1){
                CHP[1].PhaseApprovalPictureBox.ImageLocation = @"..\..\Resources\LoadingImages\4.jpg";
                CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Relatives are on the way", Color.Green));
                AskHelpTimer.Enabled = false;
                ticks = 0;
            }
            ticks += 1;
        }

        private void ApprovalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
