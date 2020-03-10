using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Memory;

namespace Foosh
{
    public partial class Foosh : Form
    {


        public int fishStatus = 0;


        public Foosh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
            cmbCastKey.DataSource = Enum.GetValues(typeof(VK));
            cmbHookKey.DataSource = Enum.GetValues(typeof(VK));
            cmbReleaseKey.DataSource = Enum.GetValues(typeof(VK));
            cmbChumKey.DataSource = Enum.GetValues(typeof(VK));
            try { Fishing.Attach(); }
            catch
            {
                MessageBox.Show("Please run as Administrator.");
                SaveSettings();
                System.Environment.Exit(1);
            }
            LoadSettings();
            timerUpdate.Enabled = true;
        }

        private void cmbCastKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Foosh_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Fishing.ReleaseKey = (int)cmbReleaseKey.SelectedValue;
            Fishing.CastKey = (int)cmbCastKey.SelectedValue;
            Fishing.HookKey = (int)cmbHookKey.SelectedValue;
            Fishing.ChumKey = (int)cmbChumKey.SelectedValue;
            Properties.Settings.Default.cmbCastKey = cmbCastKey.SelectedIndex;
           Properties.Settings.Default.cmbHookKey = cmbHookKey.SelectedIndex;
           Properties.Settings.Default.cmbReleaseKey = cmbReleaseKey.SelectedIndex;
           Properties.Settings.Default.isRelease = isRelease.Checked;
           Properties.Settings.Default.catchSmall = catchSmall.Checked;
           Properties.Settings.Default.catchMedium = catchMedium.Checked;
           Properties.Settings.Default.catchLarge = catchLarge.Checked;
           Properties.Settings.Default.maxDelay = (int)delayMax.Value;
           Properties.Settings.Default.minDelay = (int)delayMin.Value;
            Properties.Settings.Default.isChum = isChum.Checked;
            Properties.Settings.Default.cmbChumKey = cmbChumKey.SelectedIndex;
           Properties.Settings.Default.Save();
            //MessageBox.Show(Properties.Settings.Default.cmbCastKey.ToString());
        }
        public void LoadSettings()
        {
            cmbChumKey.SelectedItem = cmbChumKey.Items[Properties.Settings.Default.cmbChumKey];
            cmbCastKey.SelectedItem = cmbCastKey.Items[Properties.Settings.Default.cmbCastKey];
            cmbReleaseKey.SelectedItem = cmbReleaseKey.Items[Properties.Settings.Default.cmbReleaseKey];
            cmbHookKey.SelectedItem = cmbReleaseKey.Items[Properties.Settings.Default.cmbHookKey];
            /* cmbCastKey.SelectedIndex =Properties.Settings.Default.cmbCastKey;
             cmbHookKey.SelectedIndex =Properties.Settings.Default.cmbHookKey;
             cmbChumKey.SelectedIndex = Properties.Settings.Default.cmbChumKey;
             cmbReleaseKey.SelectedIndex =Properties.Settings.Default.cmbReleaseKey;*/
            isRelease.Checked =Properties.Settings.Default.isRelease;
            catchSmall.Checked =Properties.Settings.Default.catchSmall;
            catchMedium.Checked =Properties.Settings.Default.catchMedium;
            catchLarge.Checked =Properties.Settings.Default.catchLarge;
            delayMax.Value =Properties.Settings.Default.maxDelay;
            delayMin.Value =Properties.Settings.Default.minDelay;
            isChum.Checked = Properties.Settings.Default.isChum;
            
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            txtStatus.Text = Fishing.fishStatus.ToString() + ": " + Status.GetFishingStatus(Fishing.fishStatus).ToString();
            if (Fishing.GetGP() != -1)
            {
                txtStatus.Text += " - " + Fishing.GetGP().ToString();
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void isFishing_CheckedChanged(object sender, EventArgs e)
        {
            if (isFishing.Checked) { Fishing.isFishing = true; }
            else { Fishing.isFishing = false; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isRelease.Checked) { Fishing.isRelease = true; } else { Fishing.isRelease = false; }
            SaveSettings();
        }

        private void cmbReleaseKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void catchSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (catchSmall.Checked) { Fishing.catchSmall = true; } else { Fishing.catchSmall = false; }
            SaveSettings();
        }

        private void catchMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (catchMedium.Checked) { Fishing.catchMedium = true; } else { Fishing.catchMedium = false; }
            SaveSettings();
        }

        private void catchLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (catchLarge.Checked) { Fishing.catchLarge = true; } else { Fishing.catchLarge = false; }
            SaveSettings();
        }

        private void Foosh_Shown(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void isChum_CheckedChanged(object sender, EventArgs e)
        {
            if (isChum.Checked) { Fishing.isChum = true;  } else { Fishing.isChum = false; }
            SaveSettings();
        }

        private void cmbChumKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
