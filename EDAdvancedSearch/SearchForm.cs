using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
/*  ED Advanced Search is a third party search tool for Elite:Dangerous
  *  Copyright (C) 2015  Benjamin Massingill
  *
  *  This program is free software: you can redistribute it and/or modify
  *  it under the terms of the GNU General Public License as published by
  *  the Free Software Foundation, either version 3 of the License, or
  *  (at your option) any later version.
  *
  *  This program is distributed in the hope that it will be useful,
  *  but WITHOUT ANY WARRANTY; without even the implied warranty of
  *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  *  GNU General Public License for more details.
  *
  *  You should have received a copy of the GNU General Public License
  *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
  *  Elite:Dangerous is Property of Frontier Developments http://www.frontier.co.uk/
  *  Json.net is property of NewtonSoft http://www.newtonsoft.com
  *  Json files sourced from https://eddb.io/archive/v4/systems.json
  *  Some code sourced from MSDN https://msdn.microsoft.com/en-us/library/ms229644(v=vs.90).aspx
 *  some code sourced from stackoverflow http://stackoverflow.com/
  */
namespace EDAdvancedSearch
{
    public partial class SearchForm : Form
    {
        List<SysObj> list { get; set; }
        bool[] checkList { get; set;}
        SysObj param { get; set; }
        float? rad {get;set;}
        long? popMin {get;set;}
        long? popMax {get;set;}

        public SearchForm()
        {
            InitializeComponent();

        }
        
        private void SearchForm_Load(object sender, EventArgs e)
        {            

            buttonReset.Enabled = false;
            buttonReset.UseWaitCursor = true;
            buttonHelp.Enabled = false;
            buttonHelp.UseWaitCursor = true;
            buttonQuit.Enabled = false;
            buttonQuit.UseWaitCursor = true;
            buttonSearch.Enabled = false;
            buttonSearch.UseWaitCursor = true;

            ConsoleTextBox.Text = "Welcome to E:D Advanced Search \nBy: CMDR URMAMASLLAMA";
            //create government option list
            advComboGov.Items.AddRange(new object[] {"Government Type","Anarchy","Colony", "Communism", "Confederacy", "Cooperative", "Corporate", "Democracy",
                "Dictatorship", "Feudal", "Imperial", "None", "Patronage", "Prison Colony", "Theocracy"});
            advComboGov.SelectedIndex = 0;
            //create Allegiance option list
            advComboAll.Items.AddRange(new object[] {"Allegiance","Federation", "Empire", "Alliance","Independent","None"});
            advComboAll.SelectedIndex = 0;
            //create Security option list
            advComboSec.Items.AddRange(new object[] { "Security", "High", "Medium", "Low", "None" });
            advComboSec.SelectedIndex = 0;
            //create primary economy option list
            advComboEco.Items.AddRange(new object[] { "Economy", "Extraction", "Refinery", "Agriculture", "Industrial", "High Tech", "Terraforming", "Tourism", "Service", "None" });
            advComboEco.SelectedIndex = 0;
            //create power option list
            advComboPow.Items.AddRange(new object[] { "Power","Arissa Lavigny-Duval","Aisling Duval","Archon Delaine", "Denton Patreus", "Edmund Mahon", "Felicia Winters", "Li Yong-Rui", "Pranav Antal", "Zachary Hudson", "Zemina Torval", "None" });
            advComboPow.SelectedIndex = 0;
            //create power state option list
            advComboPos.Items.AddRange(new object[] { "Power State", "Contested", "Control", "Exploited", "None" });
            advComboPos.SelectedIndex = 0;
            //create permit option list
            advComboPer.Items.AddRange(new object[] { "Needs Permit", "True", "False"});
            advComboPer.SelectedIndex = 0;
        }

        private void SearchForm_Shown(object sender, EventArgs e)
        {
            ConsoleTextBox.AppendText("\nChecking for Database Updates...");
            new Thread(delegate()
            {
                DateTime now = DateTime.Now;
                var folder = @".\EDDB";
                var path = folder + @"\systems-" + now.ToString("MM-dd-yyyy") + ".json";
                string up;
                try
                {
                    up = EDS.update(folder, path);
                    ConsoleWrite("\nLoading database...");
                    list = EDS.Prep(up);
                }
                catch
                {
                    ConsoleWrite("\nFailed to load attempting for mono...");
                    folder = @"EDDB";
                    path = folder + @"/systems-" + now.ToString("MM-dd-yyyy") + ".json";
                    up = EDS.update(folder, path);
                    ConsoleWrite("\nLoading database...");
                    list = EDS.Prep(up);
                }
                list = EDS.Prep();
                
                ConsoleWrite("\nDone.");
                ButtonRelease();

            }).Start();                        
            
        }

        delegate void ConsoleCallback(string text);
        delegate void ButtonLock();

        public void ButtonRelease()
        {
            if (this.ConsoleTextBox.InvokeRequired)
            {
                ButtonLock d = new ButtonLock(ButtonRelease);
                this.Invoke(d);
            }
            else
            {
                buttonReset.Enabled = true;
                buttonReset.UseWaitCursor = false;
                buttonHelp.Enabled = true;
                buttonHelp.UseWaitCursor = false;
                buttonQuit.Enabled = true;
                buttonQuit.UseWaitCursor = false;
                buttonSearch.Enabled = true;
                buttonSearch.UseWaitCursor = false;
            }
        }
        public void ConsoleWrite(string text)
        {
            if (this.ConsoleTextBox.InvokeRequired)
            {
                ConsoleCallback d = new ConsoleCallback(ConsoleWrite);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (ConsoleTextBox.Text != null)
                    this.ConsoleTextBox.AppendText(text);
                else
                    this.ConsoleTextBox.Text = (text);
            }
        }

        //system name text box events
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.ReadOnly)
            {
                textBoxName.Text = "";
                textBoxName.ReadOnly = false;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "System Name";
                textBoxName.ReadOnly = true;
            }
        }

        private void textBoxName_DoubleClick(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }

        // x coord text box events
        private void numericBoxX_Enter(object sender, EventArgs e)
        {
            if (numericBoxX.ReadOnly)
            {
                numericBoxX.Text = "";
                numericBoxX.ReadOnly = false;
            }
        }

        private void numericBoxX_Leave(object sender, EventArgs e)
        {
            if (numericBoxX.Text == "")
            {
                numericBoxX.Text = "X Coordinate";
                numericBoxX.ReadOnly = true;
            }
        }

        private void numericBoxX_DoubleClick(object sender, EventArgs e)
        {
            numericBoxX.Text = "";
        }

        // y coord text box events
        private void numericBoxY_Enter(object sender, EventArgs e)
        {
            if (numericBoxY.ReadOnly)
            {
                numericBoxY.Text = "";
                numericBoxY.ReadOnly = false;
            }
        }

        private void numericBoxY_Leave(object sender, EventArgs e)
        {
            if (numericBoxY.Text == "")
            {
                numericBoxY.Text = "Y Coordinate";
                numericBoxY.ReadOnly = true;
            }
        }

        private void numericBoxY_DoubleClick(object sender, EventArgs e)
        {
            numericBoxY.Text = "";
        }

        //z coord text box events
        private void numericBoxZ_Enter(object sender, EventArgs e)
        {
            if (numericBoxZ.ReadOnly)
            {
                numericBoxZ.Text = "";
                numericBoxZ.ReadOnly = false;
            }
        }

        private void numericBoxZ_Leave(object sender, EventArgs e)
        {
            if (numericBoxZ.Text == "")
            {
                numericBoxZ.Text = "Z Coordinate";
                numericBoxZ.ReadOnly = true;
            }
        }

        private void numericBoxZ_DoubleClick(object sender, EventArgs e)
        {
            numericBoxZ.Text = "";
        }

        // coord radius box events
        private void numericBoxR_Enter(object sender, EventArgs e)
        {
            if (numericBoxR.ReadOnly)
            {
                numericBoxR.Text = "";
                numericBoxR.ReadOnly = false;
            }
        }

        private void numericBoxR_Leave(object sender, EventArgs e)
        {
            if (numericBoxR.Text == "")
            {
                numericBoxR.Text = "Radius";
                numericBoxR.ReadOnly = true;
            }
        }

        private void numericBoxR_DoubleClick(object sender, EventArgs e)
        {
            numericBoxR.Text = "";
        }

        // faction box events
        private void textBoxFaction_Enter(object sender, EventArgs e)
        {
            if (textBoxFaction.ReadOnly)
            {
                textBoxFaction.Text = "";
                textBoxFaction.ReadOnly = false;
            }
        }

        private void textBoxFaction_Leave(object sender, EventArgs e)
        {
            if (textBoxFaction.Text == "")
            {
                textBoxFaction.Text = "Faction Name";
                textBoxFaction.ReadOnly = true;
            }
        }

        private void textBoxFaction_DoubleClick(object sender, EventArgs e)
        {
            textBoxFaction.Text = "";
        }
        // pop min box events
        private void textBoxPMin_Enter(object sender, EventArgs e)
        {
            if (textBoxPMin.ReadOnly)
            {
                textBoxPMin.Text = "";
                textBoxPMin.ReadOnly = false;
            }
        }

        private void textBoxPMin_Leave(object sender, EventArgs e)
        {
            if (textBoxPMin.Text == "")
            {
                textBoxPMin.Text = "Population Min";
                textBoxPMin.ReadOnly = true;
            }
        }

        private void textBoxPMin_DoubleClick(object sender, EventArgs e)
        {
            textBoxPMin.Text = "";
        }
        // pop max box events
        private void textBoxPMax_Enter(object sender, EventArgs e)
        {
            if (textBoxPMax.ReadOnly)
            {
                textBoxPMax.Text = "";
                textBoxPMax.ReadOnly = false;
            }
        }

        private void textBoxPMax_Leave(object sender, EventArgs e)
        {
            if (textBoxPMax.Text == "")
            {
                textBoxPMax.Text = "Population Max";
                textBoxPMax.ReadOnly = true;
            }
        }

        private void textBoxPMax_DoubleClick(object sender, EventArgs e)
        {
            textBoxPMax.Text = "";
        }

        //workaround to avoid highlighting dropdown selections weird
        private void advComboGov_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboGov.Select(0, 0); }));
        }

        private void advComboAll_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboAll.Select(0, 0); }));
        }

        private void advComboSec_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboSec.Select(0, 0); }));
        }

        private void advComboEco_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboEco.Select(0, 0); }));
        }

        private void advComboPow_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboPow.Select(0, 0); }));
        }

        private void advComboPos_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboPos.Select(0, 0); }));
        }

        private void advComboPer_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { advComboPer.Select(0, 0); }));
        }

        //quit button
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //reset all search values
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ConsoleTextBox.Text = "All Search Terms Reset";
            advComboGov.SelectedIndex = 0;
            advComboAll.SelectedIndex = 0;
            advComboSec.SelectedIndex = 0;
            advComboEco.SelectedIndex = 0;
            advComboPow.SelectedIndex = 0;
            advComboPos.SelectedIndex = 0;
            advComboPer.SelectedIndex = 0;

            textBoxName.Text = "System Name";
            textBoxName.ReadOnly = true;

            numericBoxX.Text = "X Coordinate";
            numericBoxX.ReadOnly = true;

            numericBoxY.Text = "Y Coordinate";
            numericBoxY.ReadOnly = true;

            numericBoxZ.Text = "Z Coordinate";
            numericBoxZ.ReadOnly = true;

            numericBoxR.Text = "Radius";
            numericBoxR.ReadOnly = true;

            textBoxFaction.Text = "Faction Name";
            textBoxFaction.ReadOnly = true;

            textBoxPMin.Text = "Population Min";
            textBoxPMin.ReadOnly = true;

            textBoxPMax.Text = "Population Max";
            textBoxPMax.ReadOnly = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)//help file
        {
            ConsoleTextBox.Text = "Alright lets go over how everything works..." +
                "\n\n\tWARNING! System Name and Faction Name Fields are case sensitive" +
                "\n\n\tFirst off the most important thing is if you don't want to search for something leave that field blank or if it's a drop down select the title value. " +
            "Obviously the reset button puts everything back to default. However, if you just want to clear one field you can easily do so by double clicking it." +
            "\n\n\tIf you want to find a system, or group of systems, by name you can search using all of part of the name. " +
            "Keep in mind this is pulling from the EDDB database so not everything is available. Also remember if you don't want to search by this leave all of these fields blank." +
            "\n\n\tIf you want to search for systems around a certain set of coordinates use the x y and z values and then set a radius. Do note that this function only works when using all four fields." +
            "\n\n\tSearching by faction name works exactly like the system name search. Just put in all or part of the faction name you are looking for." +
            "\n\n\tSearching for systems by population works about the same and by coordinates put in a min and max and it will find them. Once again this function only works properly when both fields are used." +
            "\n\n\tThe drop-down menus should be pretty self explanatory. Just remember if you don't want to search by one put it back to it't title option." +
            "\n\n\tThe checkbox allow you to choose what information displays on output by default they are all selected and system name is always enabled" +
            "\n\n\tAnd of course once you've set your search terms how you like hit that big 'ol search button. " +
            "Keep in mind that if you want to hold on to your results you need to copy-paste them somewhere because this Console resets everyime you push the buttom." +
            "\n\n\tIf the auto update fails it is highly recommended you update manually, to do so go to https://eddb.io/api and download the systems.json file." +
            "to do that right click the link and \"select save link as\" then save it to the folder for this application with the name \"backup.json\""+
            "\n\n\tLegal:\nED Advanced Search is a third party search tool for Elite:Dangerous" +
                "\nCopyright (C) 2015  Benjamin Massingill \n\nThis program is free software: you can redistribute it and/or modify"+
                "\nit under the terms of the GNU General Public License as published by\nthe Free Software Foundation, either version 3 of the License, or" +
                "\n(at your option) any later version.\n\nThis program is distributed in the hope that it will be useful,\nbut WITHOUT ANY WARRANTY; without even the implied warranty of"+
                "\nMERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\nGNU General Public License for more details.\n\nYou should have received a copy of the GNU General Public License"+
                "\nalong with this program.  If not, see <http://www.gnu.org/licenses/>. \n\nElite:Dangerous is Property of Frontier Developments http://www.frontier.co.uk/" +
                "\nJson.net is property of NewtonSoft http://www.newtonsoft.com \nJson files sourced from https://eddb.io/archive/v4/systems.json" +
                "\nSome code sourced from MSDN https://msdn.microsoft.com/en-us/library/ms229644(v=vs.90).aspx \nsome code sourced from stackoverflow http://stackoverflow.com/";
 
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            param = new SysObj();                        
            

            if (!textBoxName.ReadOnly)//system name pull            
                param.name = textBoxName.Text.ToString();
            else
                param.name = null;

            if (!numericBoxR.ReadOnly && !numericBoxX.ReadOnly && !numericBoxY.ReadOnly && !numericBoxZ.ReadOnly)//coord and radius pull
            {
                //ConsoleWrite("coord value passed");
                rad = float.Parse(numericBoxR.Text.ToString());
                param.x = float.Parse(numericBoxX.Text.ToString());
                param.y = float.Parse(numericBoxY.Text.ToString());
                param.z = float.Parse(numericBoxZ.Text.ToString());
            }
            else
            {
                rad = null;
                param.x = null;
                param.y = null;
                param.z = null;
            }

            if (!textBoxFaction.ReadOnly) //faction pull            
                param.faction = textBoxFaction.Text.ToString();            
            else            
                param.faction = null;            

            if (!textBoxPMin.ReadOnly || !textBoxPMax.ReadOnly)//population min and max pull
            {
                //ConsoleWrite("pop value passed");
                popMin = long.Parse(textBoxPMin.Text.ToString());
                popMax = long.Parse(textBoxPMax.Text.ToString());
            }
            else
            {
                popMin = null;
                popMax = null;
            }

            if (advComboGov.SelectedIndex != 0)                           
                param.government = advComboGov.SelectedItem.ToString();                            
            else
                param.government = null;

            if (advComboAll.SelectedIndex != 0)
                param.allegiance = advComboAll.SelectedItem.ToString();
            else
                param.allegiance = null;

            if (advComboSec.SelectedIndex != 0)
                param.security = advComboSec.SelectedItem.ToString();
            else
                param.security = null;

            if (advComboEco.SelectedIndex != 0)
                param.primary_economy = advComboEco.SelectedItem.ToString();
            else
                param.primary_economy = null;

            if (advComboPow.SelectedIndex != 0)
                param.power = advComboPow.SelectedItem.ToString();
            else
                param.power = null;

            if (advComboPos.SelectedIndex != 0)
                param.power_state = advComboPos.SelectedItem.ToString();
            else
                param.power_state = null;

            if (advComboPer.SelectedIndex != 0)
            {
                if (advComboPer.SelectedItem.ToString() == "True")
                    param.needs_permit = 1;
                else
                    param.needs_permit = 0;
            }
            else
                param.needs_permit = null;

            checkList = new bool[] { checkCrd.Checked, checkPop.Checked, checkFac.Checked, checkGov.Checked, checkAll.Checked,
                checkSec.Checked, checkEco.Checked, checkPow.Checked, checkPos.Checked, checkPer.Checked,};
            ConsoleTextBox.Text = "";
                        
            ConsoleWrite("Searching Query...");

            buttonReset.Enabled = false;
            buttonReset.UseWaitCursor = true;
            buttonHelp.Enabled = false;
            buttonHelp.UseWaitCursor = true;
            buttonQuit.Enabled = false;
            buttonQuit.UseWaitCursor = true;
            buttonSearch.Enabled = false;
            buttonSearch.UseWaitCursor = true;

            StartResult(list, param, rad, popMin, popMax, checkList);                        
          

        }
        public Thread StartResult(List<SysObj> l, SysObj p, float? r, long? pI, long? pA, bool[] ck)
        {
            var t = new Thread(() => SendResult(l, p, r, pI, pA, ck));
            t.Start();
            return t;
        }
        public void SendResult(List<SysObj> l, SysObj p, float? r, long? pI, long? pA , bool[] ck)
        {
            List<SysObj> result = EDS.Search(l, p, r, pI, pA);
            
            ConsoleWrite("\nResults Found! Will now output\n");
            bool conf = true;
            if (result.Count >= 100)
            {
                var cf = MessageBox.Show("Warning! Output contains " + result.Count + " results. Continue?","Warning! Large Output!", MessageBoxButtons.YesNo);
                if (cf == DialogResult.No)
                    conf = false;                   
            }
            if (conf)
            {
                for (int cnt = 0; cnt < result.Count; cnt++)
                {
                    string s = "\nSystem Name: " + result[cnt].name;
                    if (ck[0])
                        s += "\nCoordinates: X: " + result[cnt].x + " Y: " + result[cnt].y + " Z: " + result[cnt].z;
                    if (!(p.x == null) && !(p.y == null) && !(p.z == null) && !(p.x == null))
                    {
                        double dist = Math.Sqrt(Math.Pow(p.x.Value - l[cnt].x.Value, 2) + 
                            Math.Pow(p.y.Value - l[cnt].y.Value, 2) + Math.Pow(p.z.Value - l[cnt].z.Value, 2));
                        s += "\nDistance " + dist;
                    }
                    if (ck[1])
                        s += "\nPopulation: " + result[cnt].population;
                    if (ck[2])
                        s += "\nFaction Name: " + result[cnt].faction;
                    if (ck[3])
                        s += "\nGovernment: " + result[cnt].government;
                    if (ck[4])
                        s += "\nAllegiance: " + result[cnt].allegiance;
                    if (ck[5])
                        s += "\nSecurity: " + result[cnt].security;
                    if (ck[6])
                        s += "\nEconomy: " + result[cnt].primary_economy;
                    if (ck[7])
                        s += "\nPower: " + result[cnt].power;
                    if (ck[8])
                        s += "\nPower State: " + result[cnt].power_state;
                    if (ck[9])
                    {
                        s += "\nPermit: ";
                        if (result[cnt].needs_permit == 0)
                            s += "False";
                        else
                            s += "True";
                    }
                    s += "\nLast Updated: " + EDS.FromUnixTime(result[cnt].updated_at) + "\n";
                    ConsoleWrite(s);

                }
                ConsoleWrite("\nDone.");
            }
            else
                ConsoleWrite("\nOutput cancelled by user.");
            ButtonRelease();
        }

        
    }
}
