using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace JSRF_Character_Renamer
{
    public partial class Main : Form
    {

        bool xbeLoaded = false;
        string currentXbe = "";

        int hex(int dec)
        {
            string hexValue = dec.ToString("X");
            return int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        }

        void loadXbe(string file)
        {
            closeItem.Enabled = true;
            xbeLoaded = true;
            currentXbe = file;
            this.Text = "JSRF Renamer - " + Path.GetFileName(file);
        }

        void closeXbe()
        {
            closeItem.Enabled = false;
            xbeLoaded = false;
            currentXbe = "";
            this.Text = "JSRF Renamer";
        }

        private void openXbe_Click(object sender, EventArgs e)
        {
            closeXbe();

            OpenFileDialog ogFileOFD = new OpenFileDialog();
            ogFileOFD.Filter = "JSRF xbe|*.xbe";
            ogFileOFD.Title = "Select your JSRF xbe to mod.";

            ogFileOFD.ShowDialog();
            var file = ogFileOFD.FileName;

            if (File.Exists(file))
            {
                if (Renamer.checkXbeModded(file) == false)
                {
                    SaveFileDialog newFileSFD = new SaveFileDialog();
                    newFileSFD.Filter = "Modded xbe|*.xbe";
                    newFileSFD.Title = "Select the location for the new xbe.";

                    newFileSFD.ShowDialog();
                    var newFile = newFileSFD.FileName;

                    Renamer.addSections(file, newFile);

                    loadXbe(newFile);
                    MessageBox.Show("The xbe wasn't modded, it has been modded to the new location.", "JSRF Renamer");
                }
                else
                {
                    loadXbe(file);
                }
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (characterList.Text == "") {
                MessageBox.Show("No Character selected.", "JSRF Renamer");
            } else {
                if (xbeLoaded) {
                    if (newName.Text == "") {
                        MessageBox.Show("Name cannot be empty.", "JSRF Renamer");
                    } else {
                        if (newName.Text.Length > 99) {
                            MessageBox.Show("Name cannot be over 99 characters.", "JSRF Renamer");
                        } else {
                            string character = characterList.Text;

                            switch (character) {
                                case "A.KU.MU":
                                    // Unimplemented
                                    throw new NotImplementedException();
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0, newName.Text, 0x231000, 0x28a650, currentXbe);
                                    break;

                                case "Beat":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD15C, newName.Text, 0x231000 + hex(100), 0x28a650 + hex(100), currentXbe);
                                    break;

                                case "Boogie":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD16C, newName.Text, 0x231000 + hex(200), 0x28a650 + hex(200), currentXbe);
                                    break;

                                case "Clutch":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD184, newName.Text, 0x231000 + hex(300), 0x28a650 + hex(300), currentXbe);
                                    break;

                                case "Combo":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD168, newName.Text, 0x231000 + hex(400), 0x28a650 + hex(400), currentXbe);
                                    break;

                                case "Corn":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD164, newName.Text, 0x231000 + hex(500), 0x28a650 + hex(500), currentXbe);
                                    break;

                                case "Cube":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD178, newName.Text, 0x231000 + hex(600), 0x28a650 + hex(600), currentXbe);
                                    break;

                                case "Doom Riders":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD19C, newName.Text, 0x231000 + hex(700), 0x28a650 + hex(700), currentXbe);
                                    break;

                                case "Garam":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD170, newName.Text, 0x231000 + hex(800), 0x28a650 + hex(800), currentXbe);
                                    break;

                                case "Goji":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1FC, newName.Text, 0x231000 + hex(900), 0x28a650 + hex(900), currentXbe);
                                    break;

                                case "Gum":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD160, newName.Text, 0x231000 + hex(1000), 0x28a650 + hex(1000), currentXbe);
                                    break;

                                case "Jazz":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD188, newName.Text, 0x231000 + hex(1100), 0x28a650 + hex(1100), currentXbe);
                                    break;

                                case "Love Shockers":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1A0, newName.Text, 0x231000 + hex(1200), 0x28a650 + hex(1200), currentXbe);
                                    break;

                                case "NT-3000":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1F8, newName.Text, 0x231000 + hex(1300), 0x28a650 + hex(1300), currentXbe);
                                    break;

                                case "Poison Jam":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD18C, newName.Text, 0x231000 + hex(1400), 0x28a650 + hex(1400), currentXbe);
                                    break;

                                case "Pots":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1A4, newName.Text, 0x231000 + hex(1500), 0x28a650 + hex(1500), currentXbe);
                                    break;

                                case "Rapid 99":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD190, newName.Text, 0x231000 + hex(1600), 0x28a650 + hex(1600), currentXbe);
                                    break;

                                case "Rhyth":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD174, newName.Text, 0x231000 + hex(1700), 0x28a650 + hex(1700), currentXbe);
                                    break;

                                case "Roboy":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1E8, newName.Text, 0x231000 + hex(1800), 0x28a650 + hex(1800), currentXbe);
                                    break;

                                case "Soda":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD180, newName.Text, 0x231000 + hex(1900), 0x28a650 + hex(1900), currentXbe);
                                    break;

                                case "Immortals":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD194, newName.Text, 0x231000 + hex(2000), 0x28a650 + hex(2000), currentXbe);
                                    break;

                                case "Yoyo":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD17C, newName.Text, 0x231000 + hex(2100), 0x28a650 + hex(2100), currentXbe);
                                    break;

                                case "Zero Beat":
                                    if (ntsc.Checked)
                                        Renamer.changePlayerName(0x1FD1E4, newName.Text, 0x231000 + hex(2200), 0x28a650 + hex(2200), currentXbe);
                                    break;
                            }
                        }
                    }
                } else {
                    MessageBox.Show("No xbe loaded.", "JSRF Renamer");
                }
            }
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e) { newName.Text = "";  }

        private void about_Click(object sender, EventArgs e) { MessageBox.Show("JSRF Renamer\n\nCreated by ChrisDerWahre\nSection code by Fusecavator\n\nLicensed under MIT license.", "JSRF Renamer"); }

        private void contactMe_Click(object sender, EventArgs e) { MessageBox.Show("Contact me:\n\nDiscord: ChrisDerWahre#9694\nTwitter: ChrisDerWahre", "JSRF Renamer"); }

        private void reportIssue_Click(object sender, EventArgs e) { Process.Start("https://github.com/chrisderwahre/JSRF_renamer/issues"); }

        private void exit_Click(object sender, EventArgs e) { this.Close(); }

        public Main() { InitializeComponent(); }

        private void closeXbe_Click(object sender, EventArgs e) { closeXbe(); }
    }
}
