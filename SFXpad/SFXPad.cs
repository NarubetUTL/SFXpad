using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;
using Microsoft.VisualBasic;


namespace SFXpad
{
    public partial class SFXPad : Form
    {
        public SFXPad()
        {
            InitializeComponent();
        }
        private string clickbt;
        //private string musicpath;
        private string[] links=new string[25];

        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickbt = clickedButton.Name;
            if (checkBoxN.Checked == true)
            {
               var myvalue=Interaction.InputBox("Please create new name.", "New Name", clickedButton.Text);
                clickedButton.Text = myvalue;
            }
            else
            {
                musicplay();

            }

        }
        private void musicplay()
        {
            SoundPlayer snd = null;

            if (checkBoxEditS.Checked == true)
            {
                string file = dialog();
                switch (clickbt)
                {
                    case "button1":links[0] = file;
                        break;

                    case "button2":
                        links[1] = file;
                        break;
                    case "button3":
                        links[2] = file;
                        break;
                    case "button4":
                        links[3] = file;
                        break;
                    case "button5":
                        links[4] = file;
                        break;
                    case "button6":
                        links[5] = file;
                        break;
                    case "button7":
                        links[6] = file;
                        break;
                    case "button8":
                        links[7] = file;
                        break;
                    case "button9":
                        links[8] = file;
                        break;
                    case "button10":
                        links[9] = file;
                        break;
                    case "button11":
                        links[10] = file;
                        break;
                    case "button12":
                        links[11] = file;
                        break;
                    case "button13":
                        links[12] = file;
                        break;
                    case "button14":
                        links[13] = file;
                        break;
                    case "button15":
                        links[14] = file;
                        break;
                    case "button16":
                        links[15] = file;
                        break;
                    case "button17":
                        links[16] = file;
                        break;
                    case "button18":
                        links[17] = file;
                        break;
                    case "button19":
                        links[18] = file;
                        break;
                    case "button20":
                        links[19] = file;
                        break;
                    case "button21":
                        links[20] = file;
                        break;
                    case "button22":
                        links[21] = file;
                        break;
                    case "button23":
                        links[22] = file;
                        break;
                    case "button24":
                        links[23] = file;
                        break;
                    case "button25":
                        links[24] = file;
                        break;

                }
            }
            else
            {
                switch (clickbt)
                {
                    case "button1":
                        snd = new SoundPlayer(links[0]);
                        snd.Play();
                        break;

                    case "button2":
                        snd = new SoundPlayer(links[1]);
                        snd.Play(); break;
                    case "button3":
                        snd = new SoundPlayer(links[2]);
                        snd.Play();
                        break;
                    case "button4":
                        snd = new SoundPlayer(links[3]);
                        snd.Play();
                        break;
                    case "button5":
                        snd = new SoundPlayer(links[4]);
                        snd.Play();
                        break;
                    case "button6":
                        snd = new SoundPlayer(links[5]);
                        snd.Play();
                        break;
                    case "button7":
                        snd = new SoundPlayer(links[6]);
                        snd.Play();
                        break;
                    case "button8":
                        snd = new SoundPlayer(links[7]);
                        snd.Play();
                        break;
                    case "button9":
                        snd = new SoundPlayer(links[8]);
                        snd.Play();
                        break;
                    case "button10":
                        snd = new SoundPlayer(links[9]);
                        snd.Play();
                        break;
                    case "button11":
                        snd = new SoundPlayer(links[10]);
                        snd.Play();
                        break;
                    case "button12":
                        snd = new SoundPlayer(links[11]);
                        snd.Play();
                        break;
                    case "button13":
                        snd = new SoundPlayer(links[12]);
                        snd.Play();
                        break;
                    case "button14":
                        snd = new SoundPlayer(links[13]);
                        snd.Play();
                        break;
                    case "button15":
                        snd = new SoundPlayer(links[14]);
                        snd.Play();
                        break;
                    case "button16":
                        snd = new SoundPlayer(links[15]);
                        snd.Play();
                        break;
                    case "button17":
                        snd = new SoundPlayer(links[16]);
                        snd.Play();
                        break;
                    case "button18":
                        snd = new SoundPlayer(links[17]);
                        snd.Play();
                        break;
                    case "button19":
                        snd = new SoundPlayer(links[18]);
                        snd.Play();
                        break;
                    case "button20":
                        snd = new SoundPlayer(links[19]);
                        snd.Play();
                        break;
                    case "button21":
                        snd = new SoundPlayer(links[20]);
                        snd.Play();
                        break;
                    case "button22":
                        snd = new SoundPlayer(links[21]);
                        snd.Play();
                        break;
                    case "button23":
                        snd = new SoundPlayer(links[22]);
                        snd.Play();
                        break;
                    case "button24":
                        snd = new SoundPlayer(links[23]);
                        snd.Play();
                        break;
                    case "button25":
                        snd = new SoundPlayer(links[24]);
                        snd.Play();
                        break;

                }
            }
        }
        private string dialog()
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                        return filePath;

                   

            }
            else
            {
                return "ERROR";
            }
        }

        private void SFXPad_Load(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            //links[0] = Path.Combine(outPutDirectory, @"SFX\APRING.WAV");
            //links[1] = Path.Combine(outPutDirectory, @"SFX\BNCEDRIP.WAV");
            //links[2] = Path.Combine(outPutDirectory, @"SFX\BOINGER.WAV");
            //links[3] = Path.Combine(outPutDirectory, @"SFX\BOUNCE.WAV");
            //links[4] = Path.Combine(outPutDirectory, @"SFX\CARTDRUM.WAV");
            //links[5] = Path.Combine(outPutDirectory, @"SFX\CARTFX.WAV");
            //links[6] = Path.Combine(outPutDirectory, @"SFX\CARTSHAK.WAV");
            //links[7] = Path.Combine(outPutDirectory, @"SFX\CARTTONE.WAV");
            //links[8] = Path.Combine(outPutDirectory, @"SFX\CATCH.WAV");
            //links[9] = Path.Combine(outPutDirectory, @"SFX\CLICKING.WAV");
            //links[10] = Path.Combine(outPutDirectory, @"SFX\DESCDRUM.WAV");
            //links[11] = Path.Combine(outPutDirectory, @"SFX\DIVBOARD.WAV");
            //links[12] = Path.Combine(outPutDirectory, @"SFX\DIVBRD2.WAV");
            //links[13] = Path.Combine(outPutDirectory, @"SFX\DROPBRK.WAV");
            //links[14] = Path.Combine(outPutDirectory, @"SFX\DROPSND.WAV");
            //links[15] = Path.Combine(outPutDirectory, @"SFX\DWEEDWEE.WAV");
            //links[16] = Path.Combine(outPutDirectory, @"SFX\DWEEE.WAV");
            //links[17] = Path.Combine(outPutDirectory, @"SFX\FUNYDROP.WAV");
            //links[18] = Path.Combine(outPutDirectory, @"SFX\HARDBALL.WAV");
            //links[19] = Path.Combine(outPutDirectory, @"SFX\HEAVDROP.WAV");
            //links[20] = Path.Combine(outPutDirectory, @"SFX\HITWANG.WAV");
            //links[21] = Path.Combine(outPutDirectory, @"SFX\LONGBONG.WAV");
            //links[22] = Path.Combine(outPutDirectory, @"SFX\LOSQUIRT.WAV");
            //links[23] = Path.Combine(outPutDirectory, @"SFX\LOWBONG.WAV");
            //links[24] = Path.Combine(outPutDirectory, @"SFX\LOWSPIN.WAV");

            links[0] = FileName+ "\\APRING.WAV";
            links[1] = FileName + "\\BNCEDRIP.WAV";
            links[2] = FileName + "\\BOINGER.WAV";
            links[3] = FileName + "\\BOUNCE.WAV";
            links[4] = FileName + "\\CARTDRUM.WAV";
            links[5] = FileName + "\\CARTFX.WAV";
            links[6] = FileName + "\\CARTSHAK.WAV";
            links[7] = FileName + "\\CARTTONE.WAV";
            links[8] = FileName + "\\CATCH.WAV";
            links[9] = FileName + "\\CLICKING.WAV";
            links[10] = FileName + "\\DESCDRUM.WAV";
            links[11] = FileName + "\\DIVBOARD.WAV";
            links[12] = FileName + "\\DIVBRD2.WAV";
            links[13] = FileName + "\\DROPBRK.WAV";
            links[14] = FileName + "\\DROPSND.WAV";
            links[15] = FileName + "\\DWEEDWEE.WAV";
            links[16] = FileName + "\\DWEEE.WAV";
            links[17] = FileName + "\\FUNYDROP.WAV";
            links[18] = FileName + "\\HARDBALL.WAV";
            links[19] = FileName + "\\HEAVDROP.WAV";
            links[20] = FileName + "\\HITWANG.WAV";
            links[21] = FileName + "\\LONGBONG.WAV";
            links[22] = FileName + "\\LOSQUIRT.WAV";
            links[23] = FileName + "\\LOWBONG.WAV";
            links[24] = FileName + "\\LOWSPIN.WAV";


        }

        private void checkBoxEditS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxN.Checked == true)
            {
                checkBoxN.Checked = false;

            }
        }

        private void checkBoxN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditS.Checked == true)
            {
                checkBoxEditS.Checked = false;

            }
        }
    }
}
