using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using GuitarPro;
using Proxy.Models;

namespace diplom
{
    public partial class Form1 : Form
    {
        string pathToSounds = @"C:\Users\Acer\source\repos\diplom\sounds\";
        

        private AudioFileReader lad1_stryna1;
        private AudioFileReader lad1_stryna2;
        private AudioFileReader lad1_stryna3;
        private AudioFileReader lad1_stryna4;
        private AudioFileReader lad1_stryna5;
        private AudioFileReader lad1_stryna6;

        private AudioFileReader Am;
        
        //

        private WaveOutEvent output1;
        private WaveOutEvent output2;
        private WaveOutEvent output3;
        private WaveOutEvent output4;
        private WaveOutEvent output5;
        private WaveOutEvent output6;

        private WaveOutEvent output7;

        public Form1()
        {
            InitializeComponent();

            lad1_stryna1 = new AudioFileReader(pathToSounds + "lad1_stryna1.wav");
            lad1_stryna2 = new AudioFileReader(pathToSounds + "lad1_stryna2.wav");
            lad1_stryna3 = new AudioFileReader(pathToSounds + "lad1_stryna3.wav");
            lad1_stryna4 = new AudioFileReader(pathToSounds + "lad1_stryna4.wav");
            lad1_stryna5 = new AudioFileReader(pathToSounds + "lad1_stryna5.wav");
            lad1_stryna6 = new AudioFileReader(pathToSounds + "lad1_stryna6.wav");

            Am = new AudioFileReader(pathToSounds + "Am.wav");

            //
            //
            output1 = new WaveOutEvent();
            output2 = new WaveOutEvent();
            output3 = new WaveOutEvent();
            output4 = new WaveOutEvent();
            output5 = new WaveOutEvent();
            output6 = new WaveOutEvent();
            output7 = new WaveOutEvent();

            //
            //
            output1.Init(lad1_stryna1);
            output2.Init(lad1_stryna2);
            output3.Init(lad1_stryna3);
            output4 .Init(lad1_stryna4);
            output5 .Init(lad1_stryna5);
            output6.Init(lad1_stryna6);

            output7.Init(Am);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();

            

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (boy1_radioButton.Checked == true)
            {

                if (checkBox1lad2stryna.Checked == true && checkBox2lad3stryna.Checked == true && checkBox2lad4stryna.Checked == true)
                {
                    output7.Play();
                }
                else
                {
                    if (checkBox1lad1stryna.Checked == true)
                    {
                        output1.Play();
                    }
                    if (checkBox1lad2stryna.Checked == true)
                    {
                        output2.Play();
                    }
                    if (checkBox1lad3stryna.Checked == true)
                    {
                        output3.Play();
                    }
                    if (checkBox1lad4stryna.Checked == true)
                    {
                        output4.Play();
                    }
                    if (checkBox1lad5stryna.Checked == true)
                    {
                        output5.Play();
                    }
                    if (checkBox1lad6stryna.Checked == true)
                    {
                        output6.Play();
                    }
                }
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            output1.Stop();
            output2.Stop();
            output3.Stop();
            output4.Stop();
            output5.Stop();
            output6.Stop();
            output7.Stop();
            lad1_stryna1.Position = 0;
            lad1_stryna2.Position = 0;
            lad1_stryna3.Position = 0;
            lad1_stryna4.Position = 0;
            lad1_stryna5.Position = 0;
            lad1_stryna6.Position = 0;
            Am.Position = 0;
        }
        


        
    }
}
