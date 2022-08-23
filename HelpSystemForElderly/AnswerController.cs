using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_UX_VIRVOU.Forms
{
    public partial class AnswerController : Form
    {
        private CamAndSpeech CAM;
        public AnswerController(CamAndSpeech CAM)
        {
            InitializeComponent();

            this.CAM = CAM;
        }

        private void AnswerController_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1600, 300);
            this.TopMost = true;
            horizontalLineLabel.Text = "____________________________________";
            //SecondaryButtonPanel.Width = this.Width;
            DisableAnswerButtons();
        }

        private void positiveButton_Click(object sender, EventArgs e)
        {

        }

        private void negativeButton_Click(object sender, EventArgs e)
        {

        }

        private void CallDoctor_Click(object sender, EventArgs e)
        {
            ResetElderGetsDown();

            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("------------------------------------------------------------", Color.Gray));
            //CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Κάλεσε για γιατρό ", Color.Red));
            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Mr. Kostas is calling for an ambulance!", Color.Red));
            //CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Κάλεσαμε για ασθενοφόρο και τους συγγενείς", Color.Red));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\beep-warning-6387.wav");
            player.Play();

            List<Image> images = new List<Image>();

            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            //    @"..\..\Recourses\AppliancePhasesPictures\CoffeMachinePictures");

            string path = Path.Combine(Environment.CurrentDirectory,
                @"..\..\Resources\CallHelpImages");

            String[] S = Directory.GetFiles(path, "*.jpg*", SearchOption.TopDirectoryOnly);
            //String[] F = Directory.GetFiles(path, "*.gif*", SearchOption.TopDirectoryOnly);
            //String[] W = Directory.GetFiles(path, "*.jpg*", SearchOption.TopDirectoryOnly);


            List <String> filenames = new List<String>();

            foreach (String s in S)
            {
                filenames.Add(s);
            }

            //foreach (String f in F)
            //{
            //    filenames.Add(f);
            //}



            //MessageBox.Show(filenames.Length.ToString());
            foreach (string filename in filenames)
            {
                //Size s = new Size(100, 100);
                Bitmap bm = new Bitmap(filename);
                bm = new Bitmap(bm, 75, 75);
                images.Add(bm);
            }
            new CallHelpForm(images,CAM).Show();
           //new CallHelpForm2(images).Show();
        }

        private void shopItems_Click(object sender, EventArgs e)
        {
            ResetElderGetsDown();

            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("------------------------------------------------------------", Color.Gray));
            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Mr. Kostas is calling for supplies.", Color.Green));
        }

        public void EnableAnswerButtons()
        {
            positiveIconButton.Enabled = true;
            negativeIconButton.Enabled = true;
        }

        public void DisableAnswerButtons()
        {
            positiveIconButton.Enabled = false;
            negativeIconButton.Enabled = false;
        }

        public void ResetElderGetsDown()
        {
            CAM.MessageTimer.Enabled = false;
            CAM.PauseSpeaker();
            CAM.InitializeTimer();
            DisableAnswerButtons();
        }

        private void positiveIconButton_Click(object sender, EventArgs e)
        {
            ResetElderGetsDown();

            //CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Ο κυρίος παπαδημητρίου μάλλον είναι καλά!", Color.Green));
            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Mr. Kostas is safe.", Color.Green));
        }

        private void negativeIconButton_Click(object sender, EventArgs e)
        {
            ResetElderGetsDown();

            CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Mr. Kostas is calling for an ambulance!", Color.Red));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\beep-warning-6387.wav");
            player.Play();

            List<Image> images = new List<Image>();

            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            //    @"..\..\Recourses\AppliancePhasesPictures\CoffeMachinePictures");

            string path = Path.Combine(Environment.CurrentDirectory,
                @"..\..\Resources\CallHelpImages");

            String[] S = Directory.GetFiles(path, "*.jpg*", SearchOption.TopDirectoryOnly);
            //String[] F = Directory.GetFiles(path, "*.gif*", SearchOption.TopDirectoryOnly);
            //String[] W = Directory.GetFiles(path, "*.jpg*", SearchOption.TopDirectoryOnly);


            List<String> filenames = new List<String>();

            foreach (String s in S)
            {
                filenames.Add(s);
            }

            //foreach (String f in F)
            //{
            //    filenames.Add(f);
            //}



            //MessageBox.Show(filenames.Length.ToString());
            foreach (string filename in filenames)
            {
                //Size s = new Size(100, 100);
                Bitmap bm = new Bitmap(filename);
                bm = new Bitmap(bm, 75, 75);
                images.Add(bm);
            }
            new CallHelpForm(images, CAM).Show();
            //CAM.AddLabelToMessagePanel(CAM.SetUpLabel("Σταλθηκέ αίτημα για ασθενοφόρο και επικοινωνήσαμε με συγγενείς", Color.Red));
        }
    }
}
