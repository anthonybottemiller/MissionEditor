using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionEditor
{
    public partial class Form1 : Form
    {

        Campaign campaign;
        int currentMissionIndex;

        public Form1()
        {
            InitializeComponent();
            campaign = new Campaign();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Campaign Files|*.cam";
            openFileDialog1.Title = "Select a Campaign File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                campaign.Load(openFileDialog1.OpenFile());
                EnableEditor();
                UpdateEditor();
                populateMissionList();
            }
        }

        private void populateMissionList()
        {
            missionList.Items.Clear();
            foreach(MissionParameters mission in campaign.Missions)
            {
                missionList.Items.Add(mission.DestinationName);
            }
        }

        private void campaignName_TextChanged(object sender, EventArgs e)
        {
            this.campaign.campaignName = campaignName.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            campaign = new Campaign();
            EnableEditor();
            UpdateEditor();
            populateMissionList();
            CampaignEditor.Enabled = false;

        }

        private void UpdateEditor()
        {
            campaignName.Text = campaign.campaignName;
        }

        private void EnableEditor()
        {
            campaignName.Enabled = true;
        }

        private void EnableMissionEditor()
        {
            CampaignEditor.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Campaign File |*.cam";
            saveFileDialog.Title = "Save Campaign File";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                campaign.Save(fs);
            }

        }

        private void addMission_Click(object sender, EventArgs e)
        {
            //if (!CampaignEditor.Enabled) { CampaignEditor.Enabled = true; }
            MissionParameters newMission = new MissionParameters();
            campaign.Missions.Add(newMission);
            populateMissionList();
        }

        private void missionList_Click(object sender, EventArgs e)
        {
            int selectedMission = missionList.SelectedIndex;
            if(campaign.Missions.Count > 0)
            {
                currentMissionIndex = selectedMission;
                EnableMissionEditor();
                populateMissionEditor();
            }
        }

        private void populateMissionEditor()
        {
            if(currentMissionIndex != -1)
            {
                systemName.Text = campaign.Missions[currentMissionIndex].DestinationName;
                updateOperationButtons();
                updateTermParameters();
                updateGeneralInfo();
            }
            else
            {
                CampaignEditor.Enabled = false;
            }
        }

        private void systemName_TextChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].DestinationName = systemName.Text;
            populateMissionList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MissionParameters missionToDelete = campaign.Missions[currentMissionIndex];
            campaign.Missions.Remove(missionToDelete);
            populateMissionList();
            CampaignEditor.Enabled = false;
            lightyearInput.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAddition_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        campaign.Missions[currentMissionIndex].operation = radio.Text;
                    }
                }
            }
        }

        private void updateOperationButtons()
        {
            switch(campaign.Missions[currentMissionIndex].operation)
            {
                case "+":
                    radioButtonAddition.Checked = true;
                    break;
                case "-":
                    radioButtonSubtraction.Checked = true;
                    break;
                case "*":
                    radioButtonMultiplication.Checked = true;
                    break;
                case "/":
                    radioButtonDivision.Checked = true;
                    break;
            }
        }

        private void term0Upper_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].term0Upper = (int)term0Upper.Value;
        }

        private void term0Lower_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].term0Lower = (int)term0Lower.Value;
        }

        private void term1Upper_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].term1Upper = (int)term1Upper.Value;
        }

        private void term1Lower_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].term1Lower = (int)term1Lower.Value;
        }

        private void updateTermParameters()
        {
            term0Upper.Value = campaign.Missions[currentMissionIndex].term0Upper;
            term0Lower.Value = campaign.Missions[currentMissionIndex].term0Lower;
            term1Upper.Value = campaign.Missions[currentMissionIndex].term1Upper;
            term1Lower.Value = campaign.Missions[currentMissionIndex].term1Lower;

            numberOfProblems.Value = campaign.Missions[currentMissionIndex].NumberOfProblems;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].DistanceToDestination = (float)lightyearInput.Value;
        }

        private void updateGeneralInfo()
        {
            lightyearInput.Enabled = true;
            lightyearInput.Value = (decimal)campaign.Missions[currentMissionIndex].DistanceToDestination;

            numericUpDown1.Value = campaign.Missions[currentMissionIndex].NumberOfStars;

            briefingText.Text = campaign.Missions[currentMissionIndex].BriefingText;
            discoveryText.Text = campaign.Missions[currentMissionIndex].DiscoveryInfoText;
            systemDataText.Text = campaign.Missions[currentMissionIndex].SystemDataText;

        }

        private void numberOfProblems_ValueChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].NumberOfProblems = (int)numberOfProblems.Value;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].NumberOfStars = (int)numericUpDown1.Value;
        }

        private void briefingText_TextChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].BriefingText = briefingText.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].DiscoveryInfoText = discoveryText.Text;
        }

        private void systemDataText_TextChanged(object sender, EventArgs e)
        {
            campaign.Missions[currentMissionIndex].SystemDataText = systemDataText.Text;
        }
    }

}
