using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_UX_VIRVOU.CustomControls
{
    public partial class CallHelpPhase : UserControl
    {
        public CallHelpPhase(Image phaseImage)
        {
            InitializeComponent();

            this.PhaseMainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PhaseMainPictureBox.Image = phaseImage;

            this.PhaseApprovalPictureBox.ImageLocation = @"..\..\Resources\LoadingImages\3.gif";
            this.PhaseApprovalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //camPictureBox.ImageLocation = @"..\..\Resources\CamPictures\" + imageNumber.ToString() + ".jpg";
        }

        public void setPhaseApprovalPictureBox(Image ApprovalImage)
        {
            this.PhaseApprovalPictureBox.Image = ApprovalImage;
        }
    }
}
