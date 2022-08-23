using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_UX_VIRVOU.Forms
{
    public partial class CamAndSpeech : Form
    {
        private int imageNumber = 3;
        private int ticks = 0;
        public SpeechSynthesizer spee = new SpeechSynthesizer();
        public AnswerController aC;
        public CamAndSpeech()
        {
            InitializeComponent();
        }

        private void Slider(Boolean direction)
        {
            //MessageBox.Show("!!!!!!!");
            //Console.WriteLine("!!!!!!!!!");
            if (direction)
            {
                if (imageNumber == 5)
                {
                    imageNumber = 1;
                }
                else
                {
                    imageNumber += 1;
                }
            }
            else
            {
                if (imageNumber == 1)
                {
                    imageNumber = 5;
                }
                else
                {
                    imageNumber -= 1;
                }
            }
            camPictureBox.ImageLocation = @"..\..\Resources\CamPictures\" + imageNumber.ToString() + ".jpg";
        }

        private void prevIconButton_Click(object sender, EventArgs e)
        {
            Slider(true);
        }

        private void nextIconButton_Click(object sender, EventArgs e)
        {
            Slider(true);
        }

        private void CamAndSpeech_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.MaximizeBox = false;

            camPictureBox.BorderStyle = BorderStyle.Fixed3D;

            this.Location = new Point(50, 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            MessageTimer.Enabled = false;
            MessageTimer.Interval = 6000;

            camPictureBox.ImageLocation = @"..\..\Resources\CamPictures\" + imageNumber.ToString() + ".jpg";
            camPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            messageFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            messageFlowLayoutPanel.WrapContents = false;
            messageFlowLayoutPanel.AutoScroll = true;


            aC = new AnswerController(this);
            aC.Show();
        }

        private void eldermanGetsDown_Click(object sender, EventArgs e)
        {
            aC.ResetElderGetsDown();
            aC.EnableAnswerButtons();
            PauseSpeaker();

            imageNumber = 1;
            camPictureBox.ImageLocation = @"..\..\Resources\CamPictures\" + imageNumber.ToString() + ".jpg";
            MessageTimer.Enabled = true;


            spee = new SpeechSynthesizer();
            //spee.SelectVoice("Microsoft Stefanos");
            
            //spee.SpeakAsync("yo yo yo nigga");
            //spee.SpeakAsync("Κύριε Παπαδημητρίου είσαστε καλά;");
            string str1 = "Mr. Kostas are you alright?";

            spee.SpeakAsync(str1);
            AddLabelToMessagePanel(SetUpLabel("------------------------------------------------------------", Color.Gray));

            AddLabelToMessagePanel(SetUpLabel(str1, Color.Black));
            //AddLabelToMessagePanel(SetUpLabel("Κύριε Παπαδημητρίου είσαστε καλά;", Color.Black));
        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            Label messageLabel;
            ticks += 1;
            string str2 = "Mr Kostas?";
            if (ticks == 1)
            {
                //spee.SpeakAsync("Με ακούτε;");
                spee.SpeakAsync(str2);

                messageLabel = SetUpLabel(str2, Color.Black);
                //messageLabel = SetUpLabel("Με ακούτε;", Color.Black);
                AddLabelToMessagePanel(messageLabel);
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\beep-warning-6387.wav");
                player.Play();
                //spee.SpeakAsync("Κύριε Παπαδημητρίουυυυυυυυυυυυυυυ!");
                //messageLabel = SetUpLabel("Κύριε Παπαδημητρίουoυoυoυoυoυoυoυ!!!", Color.Black);

            }

            

            if (ticks == 2)
            {
                MessageTimer.Enabled = false;

                //AddLabelToMessagePanel(SetUpLabel("Καλέσαμε ασθενοφόρο και συγγενείς", Color.Red));

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
                new CallHelpForm(images, this).Show();
                //new CallHelpForm2(images).Show();

                InitializeTimer();
                aC.DisableAnswerButtons();

            }

            


        }
        public void InitializeTimer()
        {
            MessageTimer.Enabled = false;
            ticks = 0;

        }

        public Label SetUpLabel(String message, Color foreColor)
        {
            Label messageLabel = new Label();
            messageLabel.MaximumSize = messageFlowLayoutPanel.Size;
            messageLabel.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.AutoSize = true;

            if (foreColor == Color.Gray)
            {
                messageLabel.Text = message;
            }
            else
            {
                messageLabel.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8) + ": " + message;
            }

            messageLabel.ForeColor = foreColor;

            return messageLabel;
        }

        public void AddLabelToMessagePanel(Label label)
        {
            messageFlowLayoutPanel.Controls.Add(label);
            messageFlowLayoutPanel.ScrollControlIntoView(messageFlowLayoutPanel.Controls[messageFlowLayoutPanel.Controls.Count - 1]);
        }

        public void PauseSpeaker()
        {
            if (spee.State == SynthesizerState.Speaking)
            {
                spee.Pause();
            }
        }

        private void CamAndSpeech_FormClosed(object sender, FormClosedEventArgs e)
        {
            aC.Close();
        }

        private void CamAndSpeech_SizeChanged(object sender, EventArgs e)
        {
            //this.camPictureBox.Size = new Size(1000, 1000);
        }

        private void CamAndSpeech_ResizeBegin(object sender, EventArgs e)
        {
            //this.camPictureBox.Size = new Size(1000, 1000);
        }
    }
}
