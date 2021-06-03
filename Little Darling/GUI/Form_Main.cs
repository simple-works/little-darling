using System;
using System.Windows.Forms;
using CSCore.SoundOut;
using Microsoft.Win32;

namespace LittleDarling
{
    public partial class Form_Main : Form
    {
        public bool Stop { get; set; }

        public Form_Main()
        {
            InitializeComponent();
            this.EnableButtonsHoverEffects();
            Stop = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Stop)
            {
                Windows.ToggleStartupLaunch(false);
            }
            else
            {
                e.Cancel = true;
                Hide();
                timer_main.SetRandomInterval();
                timer_main.Start();
                Windows.ToggleStartupLaunch(true);
            }
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            if (audioPlayer_main.PlaybackState != PlaybackState.Playing)
            {
                RandomAudio.Play(audioPlayer_main);
            }
            timer_main.SetRandomInterval();
        }

        private void contextMenuItem_about_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog(this);
        }

        private void contextMenuItem_stop_Click(object sender, EventArgs e)
        {
            Stop = true;
            Close();
        }
    }
}
