using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using gma.System.Windows;
using System.Globalization;
using Microsoft.Win32;

namespace poe
{
    public partial class Form1 : Form
    {
        public string clientpath = (@"D:\Steam\steamapps\common\Path of Exile\logs\Client.txt");
        public string clientpath2 = (@"C:\Program Files\Steam\steamapps\common\Path of Exile\logs\Client.txt");
        public string clientpath3 = (@"C:\Program Files (x86)\Steam\steamapps\common\Path of Exile\logs\Client.txt");
        public string clientpath4 = (@"E:\Steam\steamapps\common\Path of Exile\logs\Client.txt");
        public string clientpath5 = (@"E:\SteamLibrary\steamapps\common\Path of Exile\logs\Client.txt");
        public string clientcopy = Environment.CurrentDirectory + @"\ClientCopy.txt";
        string TCStr = ("1_1_2");
        string MFStr = ("1_1_3");
        string TIStr = ("1_1_2a");
        string SPStr = ("1_1_4_1");
        string TLStr = ("You have entered The Ledge");
        string FDStr = ("You have entered The Flooded Depths");
        string TCLStr = ("You have entered The Climb");
        string TLPStr = ("1_7_1");
        string TUPStr = ("You have entered The Upper Prison");
        string PGStr = ("1_1_8");
        string SGStr = ("You have entered The Ship Graveyard");
        string COWStr = ("You have entered The Cavern of Wrath");
        string COAStr = ("You have entered The Cavern of Anger");
        string A2SFStr = ("level 13");
        string A2OFStr = ("You have entered The Old Fields");
        string A2DEStr = ("1_2_2a");
        string A2CRStr = ("1_2_3");
        string A2FRStr = ("1_1_15");
        string A2CL1Str = ("1_2_5_1");
        string A2BBStr = ("You have entered The Broken Bridge");
        string A2COSStr = ("1_2_6_1");
        string A2COSL2Str = ("1_2_6_2");
        string A2RWStr = ("1_2_7");
        string A2WFStr = ("1_2_9");
        string A2WCStr = ("You have entered The Weaver’s Chambers");
        string A2WLStr = ("You have entered The Wetlands");
        string A2VRStr = ("You have entered The Vaal Ruins");
        string A2NFStr = ("1_2_8");
        string A2DTStr = ("You have entered The Dread Thicket");
        string A2CAStr = ("You have entered The Caverns");
        string A2APStr = ("You have entered The Ancient Pyramid");
        string Act1 = ('"'+"1_1");
        string Act2 = ('"'+"1_2");
        string Act3 = ('"'+"1_3");
        string Act4 = ('"'+"1_4");
        string Act5 = ('"'+"1_5");
        string Act6 = ('"'+"2_6");
        string Act7 = ('"'+"2_7");
        string Act8 = ('"'+"2_8");
        string Act9 = ('"'+"2_9");
        string Act10 = ('"'+"2_10");
        string A3COSStr = ("You have entered The City of Sarn");
        string A3SLStr = ("You have entered The Slums");
        string A3CMStr = ("You have entered The Crematorium");
        string A3SWStr = ("You have entered The Sewers");
        string A3MPStr = ("You have entered The Marketplace");
        string A3BFStr = ("You have entered The Battlefront");
        string A3DOStr = ("You have entered The Docks");
        string A3STL1Str = ("1_3_8_1");
        string A3STL2Str = ("1_3_8_2");
        string A3EBStr = ("You have entered The Ebony Barracks");
        string A3LTL1Str = ("1_3_14_1");
        string A3LTL2Str = ("1_3_14_2");
        string A3IGStr = ("You have entered The Imperial Gardens");
        string A3SOGStr = ("You have entered The Sceptre of God");
        string A3USOGStr = ("You have entered The Upper Sceptre of God");
        string A4ADStr = ("You have entered The Aqueduct");
        string A4DLStr = ("You have entered The Dried Lake");
        string A4M1Str = ("You have entered The Mines Level 1");
        string A4M2Str = ("You have entered The Mines Level 2");
        string A4CVStr = ("You have entered The Crystal Veins");
        string A4DDStr = ("You have entered Daresso’s Dream");
        string A4GAStr = ("You have entered The Grand Arena");
        string A4KDStr = ("You have entered Kaom’s Dream");
        string A4KSStr = ("1_4_4");
        string A4BOFB1Str = ("1_4_6_1");
        string A4BOFB2Str = ("1_4_6_2");
        string A4HAStr = ("You have entered The Harvest");
        string A4ACStr = ("You have entered The Ascent");
        string A5SPStr = ("You have entered The Slave Pens");
        string A5CBStr = ("1_5_2");
        string A5OSStr = ("You have entered Oriath Square");
        string A5TCStr = ("You have entered The Templar Courts");
        string A5COIStr = ("You have entered The Chamber of Innocence");
        string A5TOCStr = ("1_5_4b");
        string A5RSStr = ("You have entered The Ruined Square");
        string A5OSUStr = ("1_5_6");
        string A5REStr = ("1_5_7");
        string A5CRStr = ("1_5_8");
        string A6TSStr = ("You have entered The Twilight Strand");
        string A6TCStr = ("2_6_2");
        string A6MFStr = ("2_6_4");
        string A6KFStr = ("You have entered The Karui Fortress");
        string A6RIStr = ("You have entered The Ridge");
        string A6LPStr = ("2_6_7");
        string A6STStr = ("You have entered The Shavronne’s Tower");
        string A6PGStr = ("2_6_8");
        string A6WFStr = ("2_6_9");
        string A6RWStr = ("2_6_10");
        string A6WEStr = ("2_6_11");
        string A6SFStr = ("2_6_12");
        string A6COAStr = ("You have entered The Cavern of Anger");
        string A6BEStr = ("You have entered The Beacon");
        string A6BKRStr = ("2_6_15");
        string A7BBStr = ("2_7_1");
        string A7CRStr = ("2_7_2");
        string A7FRStr = ("2_7_3");
        string A7CRL1Str = ("2_7_4");
        string A7CRL2Str = ("You have entered The Crypt Level 2");
        string A7COSL1Str = ("2_7_5_1");
        string A7MSStr = ("You have entered Maligaro’s Sanctum");
        string A7COSL2Str = ("2_7_5_2");
        string A7DEStr = ("2_7_6");
        string A7AFStr = ("You have entered The Ashen Fields");
        string A7NFStr = ("2_7_8");
        string A7DTStr = ("You have entered The Dread Thicket");
        string A7CAStr = ("You have entered The Causeway");
        string A7VCStr = ("You have entered The Vaal City");
        string A7TODStr = ("You have entered The Temple of Decay");
        string A8SRStr = ("You have entered The Sarn Ramparts");
        string A8TCStr = ("You have entered The Toxic Conduits");
        string A8DCStr = ("2_8_2_2");
        string A8GPStr = ("You have entered The Grand Promenade");
        string A8BHStr = ("You have entered The Bath House");
        string A8LCStr = ("You have entered The Lunaris Concourse");
        string A8LTL1Str = ("2_8_7_1");
        string A8LTL2Str = ("2_8_7_2");
        string A8QUStr = ("You have entered The Quay");
        string A8GGStr = ("You have entered The Grain Gate");
        string A8IFStr = ("You have entered The Imperial Fields");
        string A8STL1Str = ("2_8_12_1");
        string A8STL2Str = ("2_8_12_2");
        string A8HBStr = ("You have entered The Harbour Bridge");
        string A9BAStr = ("You have entered The Blood Aqueduct");
        string A9DEStr = ("You have entered The Descent");
        string A9VDStr = ("You have entered The Vastiri Desert");
        string A9OAStr = ("You have entered The Oasis");
        string A9FOStr = ("You have entered The Foothills");
        string A9BLStr = ("You have entered The Boiling Lake");
        string A9TUStr = ("You have entered The Tunnel");
        string A9QUStr = ("You have entered The Quarry");
        string A9REStr = ("You have entered The Refinery");
        string A9BOBStr = ("You have entered The Belly of the Beast");
        string A10CRStr = ("2_10_1");
        string A10RSStr = ("You have entered The Ravaged Square");
        string A10OSStr = ("2_10_9");
        string A10TCStr = ("2_10_3");
        string A10DCStr = ("2_10_4");
        string A10REStr = ("2_10_8");
        string A10CBStr = ("2_10_7");
        string A10CAStr = ("You have entered The Canals");
        string A10FTStr = ("You have entered The Feeding Trough");

        public Form1()
        {
            InitializeComponent();
            bunifuDropdown1.SelectedIndex = 0;
            this.TopMost = true;

            if (File.Exists(clientpath) && (File.Exists(clientcopy)))
            {
                start = true;
            }

            var r = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache");
            var rr = r.GetValueNames();
            foreach (string name in rr)
            {
                if (name.Contains("PathOfExile"))
                {
                    clientpath = name.Replace("PathOfExileSteam.exe.FriendlyAppName", @"logs\Client.txt");
                }
            }
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] SArray = new[] { "Lioneye's Watch", "The Coast", "The Submerged Passage", "The Ledge", "The Climb", "The Lower Prison", "Prisoner's Gate", "The Ship Graveyard", "The Cavern of Wrath", "The Southern Forest", "The Forest Encampment", "The Crossroads", "The Broken Bridge", "The Crypt Level 1", "The Chamber of Sins 1", "The Western Forest", "The Wetlands", "The Riverways", "The Northern Forest", "The Caverns", "The City of Sarn", "The Sarn Encampment", "The Crematorium", "The Warehouse Sewers", "The Marketplace", "The Battlefront", "The Solaris Temple Level 1", "The Solaris Temple Level 2", "The Docks", "The Ebony Barracks", "The Lunaris Temple Level 1", "The Imperial Gardens", "The Library", "The Sceptre of God", "The Aqueduct", "Highgate", "The Crystal Veins", "The Grand Arena", "Kaom's Stronghold", "The Harvest", "The Slave Pens", "Overseer's Tower", "Oriath Square", "The Templar Courts", "The Chamber of Innocence", "The Ruined Square", "The Reliquary", "The Cathedral Rooftop", "Lioneye's Watch", "The Coast", "The Ridge", "The Lower Prison", "Prisoner's Gate", "The Western Forest", "The Riverways", "The Southern Forest", "The Beacon", "The Brine King's Reef", "The Bridge Encampment", "The Crossroads", "The Crypt", "The Chamber of Sins 1", "The Den", "The Ashen Fields", "The Northern Forest", "The Causeway", "The Vaal City", "The Sarn Ramparts", "The Sarn Encampment", "The Toxic Conduits", "The Grain Gate", "The Imperial Fields", "The Solaris Temple", "The Solaris Concourse", "The Bath House", "The Lunaris Concourse", "The Lunaris Temple", "The Blood Aqueduct", "Highgate", "The Vastiri Desert", "The Foothills", "The Tunnel", "The Quarry", "Oriath Docks", "The Ravaged Square", "The Control Blocks", "The Reliquary", "The Desecrated Chambers" };
            string[] SArray2 = new[] { "The Lower Prison", "The Crypt Level 1", "Chamber of Sins 2", "The Crematorium", "The Catacombs", "The Imperial Gardens", "The Bath House", "The Tunnel", "The Ossuary" };
            var Waypoint = global::poe.Properties.Resources.waypoint_area_icon;
                var NoWaypoint = global::poe.Properties.Resources.no_waypoint_area_icon;
                if (SArray.Contains(bunifuDropdown1.Text))
                {
                    WaypointPic.Image = Waypoint;
                }
                else
                {
                    WaypointPic.Image = NoWaypoint;
                }
            if (SArray2.Contains(bunifuDropdown1.Text) && Properties.Settings.Default.LabS == true)
            {
                Lab.Visible = true;
            }
            else
            {
                Lab.Visible = false;
            }
            //START ACT 1
            if (bunifuDropdown1.SelectedIndex == -1)
            {
                bunifuDropdown1.Text = ("CHOOSE A MAP");
            }
            if (bunifuDropdown1.Text == "The Coast" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TC);
            }
            if (bunifuDropdown1.Text == "Mud Flats" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(MF);
            }
            if (bunifuDropdown1.Text == "Tidal Island" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TI);
            }
            if (bunifuDropdown1.Text == "Submerged Passage" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(SP);
            }
            if (bunifuDropdown1.Text == "The Ledge" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TL);
            }
            if (bunifuDropdown1.Text == "Flooded Depths" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(FD);
            }
            if (bunifuDropdown1.Text == "The Climb" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TCL);
            }
            if (bunifuDropdown1.Text == "The Lower Prison" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TLP);
            }
            if (bunifuDropdown1.Text == "The Upper Prison" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(TUP);
            }
            if (bunifuDropdown1.Text == "The Prisoner’s Gate" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(PG);
            }
            if (bunifuDropdown1.Text == "The Ship Graveyard" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(SG);
            }
            if (bunifuDropdown1.Text == "The Cavern of Wrath" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(COW);
            }
            if (bunifuDropdown1.Text == "The Cavern of Anger" && bunifuLabel1.Text == "Act 1")
            {
                bunifuPages1.SetPage(COA);
            }
            //END ACT 1

            //START ACT 2
            if (bunifuDropdown1.SelectedIndex == 13 && bunifuLabel1.Text == "Act 1")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Southern Forest", "The Old Fields", "The Den", "The Crossroads", "The Fellshrine Ruins", "The Crypt Level 1", "The Broken Bridge", "Chamber of Sins 1", "Chamber of Sins 2", "The Riverways", "The Western Forest", "Weaver’s Chambers", "The Wetlands", "The Vaal Ruins", "The Northern Forest", "The Dread Thicket", "The Caverns", "Ancient Pyramid", "" });
                bunifuLabel1.Text = ("Act 2");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 2")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Coast", "Mud Flats", "Tidal Island", "Submerged Passage", "The Ledge", "Flooded Depths", "The Climb", "The Lower Prison", "The Upper Prison", "The Prisoner’s Gate", "The Ship Graveyard", "The Cavern of Wrath", "The Cavern of Anger", "" });
                bunifuLabel1.Text = ("Act 1");
                bunifuDropdown1.SelectedIndex = 12;
            }
            //END ACT 2
            if (bunifuDropdown1.Text == "The Southern Forest" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2SF);
            }
            if (bunifuDropdown1.Text == "The Old Fields" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2OF);
            }
            if (bunifuDropdown1.Text == "The Den" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2DE);
            }
            if (bunifuDropdown1.Text == "The Crossroads" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2CR);
            }
            if (bunifuDropdown1.Text == "The Fellshrine Ruins" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2FR);
            }
            if (bunifuDropdown1.Text == "The Crypt Level 1" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2CL1);
            }
            if (bunifuDropdown1.Text == "The Broken Bridge" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2BB);
            }
            if (bunifuDropdown1.Text == "Chamber of Sins 1" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2COS);
            }
            if (bunifuDropdown1.Text == "Chamber of Sins 2" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2COSL2);
            }
            if (bunifuDropdown1.Text == "The Riverways" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2RW);
            }
            if (bunifuDropdown1.Text == "The Western Forest" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2WF);
            }
            if (bunifuDropdown1.Text == "Weaver’s Chambers" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2WC);
            }
            if (bunifuDropdown1.Text == "The Wetlands" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2WL);
            }
            if (bunifuDropdown1.Text == "The Vaal Ruins" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2VR);
            }
            if (bunifuDropdown1.Text == "The Northern Forest" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2NF);
            }
            if (bunifuDropdown1.Text == "The Caverns" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2CA);
            }
            if (bunifuDropdown1.Text == "Ancient Pyramid" && bunifuLabel1.Text == "Act 2")
            {
                bunifuPages1.SetPage(A2AP);
            }
            //START ACT3
            if (bunifuDropdown1.SelectedIndex == 18 && bunifuLabel1.Text == "Act 2")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The City of Sarn", "The Slums", "The Crematorium", "The Sewers", "The Marketplace", "The Battlefront", "The Docks", "The Solaris Temple 1", "The Solaris Temple 2", "The Ebony Barracks", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Imperial Gardens", "The Sceptre of God", "The Upper Sceptre of God", "" });
                bunifuLabel1.Text = ("Act 3");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 3")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Southern Forest", "The Old Fields", "The Den", "The Crossroads", "The Fellshrine Ruins", "The Crypt Level 1", "The Broken Bridge", "Chamber of Sins 1", "Chamber of Sins 2", "The Riverways", "The Western Forest", "Weaver’s Chambers", "The Wetlands", "The Vaal Ruins", "The Northern Forest", "The Dread Thicket", "The Caverns", "Ancient Pyramid", "" });
                bunifuLabel1.Text = ("Act 2");
                bunifuDropdown1.SelectedIndex = 17;
            }
            //END ACT3
            if (bunifuDropdown1.Text == "The City of Sarn" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3COS);
            }
            if (bunifuDropdown1.Text == "The Slums" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3SL);
            }
            if (bunifuDropdown1.Text == "The Crematorium" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3CM);
            }
            if (bunifuDropdown1.Text == "The Sewers" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3SW);
            }
            if (bunifuDropdown1.Text == "The Marketplace" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3MP);
            }
            if (bunifuDropdown1.Text == "The Battlefront" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3BF);
            }
            if (bunifuDropdown1.Text == "The Docks" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3DO);
            }
            if (bunifuDropdown1.Text == "The Solaris Temple 1" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3STL1);
            }
            if (bunifuDropdown1.Text == "The Solaris Temple 2" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3STL2);
            }
            if (bunifuDropdown1.Text == "The Ebony Barracks" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3EB);
            }
            if (bunifuDropdown1.Text == "The Lunaris Temple 1" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3LTL1);
            }
            if (bunifuDropdown1.Text == "The Lunaris Temple 2" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3LTL2);
            }
            if (bunifuDropdown1.Text == "The Imperial Gardens" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3IG);
            }
            if (bunifuDropdown1.Text == "The The Sceptre of God" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3SOG);
            }
            if (bunifuDropdown1.Text == "The Upper Sceptre of God" && bunifuLabel1.Text == "Act 3")
            {
                bunifuPages1.SetPage(A3USOG);
            }
            //START ACT4
            if (bunifuDropdown1.SelectedIndex == 15 && bunifuLabel1.Text == "Act 3")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Aqueduct", "The Dried Lake", "The Mines 1", "The Mines 2", "The Crystal Veins", "Daresso’s Dream", "The Grand Arena", "Kaom’s Dream", "Kaom’s Stronghold", "Belly of the Beast 1", "Belly of the Beast 2", "The Harvest", "The Ascent", "" });
                bunifuLabel1.Text = ("Act 4");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 4")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The City of Sarn", "The Slums", "The Crematorium", "The Sewers", "The Marketplace", "The Battlefront", "The Docks", "The Solaris Temple 1", "The Solaris Temple 2", "The Ebony Barracks", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Imperial Gardens", "The Sceptre of God", "The Upper Sceptre of God", "" });
                bunifuLabel1.Text = ("Act 3");
                bunifuDropdown1.SelectedIndex = 14;
            }
            //END ACT4
            if (bunifuDropdown1.Text == "The Aqueduct" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4AD);
            }
            if (bunifuDropdown1.Text == "The Dried Lake" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4DL);
            }
            if (bunifuDropdown1.Text == "The Mines 1" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4M1);
            }
            if (bunifuDropdown1.Text == "The Mines 2" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4M2);
            }
            if (bunifuDropdown1.Text == "The Crystal Veins" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4CV);
            }
            if (bunifuDropdown1.Text == "Daresso’s Dream" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4DD);
            }
            if (bunifuDropdown1.Text == "The Grand Arena" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4GA);
            }
            if (bunifuDropdown1.Text == "Kaom’s Dream" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4KD);
            }
            if (bunifuDropdown1.Text == "Kaom’s Stronghold")
            {
                bunifuPages1.SetPage(A4KS);
            }
            if (bunifuDropdown1.Text == "The Belly of the Beast 1" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4BOFB1);
            }
            if (bunifuDropdown1.Text == "The Belly of the Beast 2" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4BOFB2);
            }
            if (bunifuDropdown1.Text == "The Harvest" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4HA);
            }
            if (bunifuDropdown1.Text == "The Ascent" && bunifuLabel1.Text == "Act 4")
            {
                bunifuPages1.SetPage(A4AC);
            }
            //START ACT5
            if (bunifuDropdown1.SelectedIndex == 13 && bunifuLabel1.Text == "Act 4")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Slave Pens", "The Control Blocks", "Oriath Square", "The Templar Courts", "The Chamber of Innocence", "The Torched Courts", "The Ruined Square", "The Ossuary", "The Reliquary", "The Cathedral Rooftop", "" });
                bunifuLabel1.Text = ("Act 5");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 5")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Aqueduct", "The Dried Lake", "The Mines 1", "The Mines 2", "The Crystal Veins", "Daresso’s Dream", "The Grand Arena", "Kaom’s Dream", "Kaom’s Stronghold", "Belly of the Beast 1", "Belly of the Beast 2", "The Harvest", "The Ascent", "" });
                bunifuLabel1.Text = ("Act 4");
                bunifuDropdown1.SelectedIndex = 12;
            }
            //END ACT5
            if (bunifuDropdown1.Text == "The Slave Pens" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5SP);
            }
            if (bunifuDropdown1.Text == "The Control Blocks" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5CB);
            }
            if (bunifuDropdown1.Text == "Oriath Square" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5OS);
            }
            if (bunifuDropdown1.Text == "The Templar Courts" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5TC);
            }
            if (bunifuDropdown1.Text == "The Chamber of Innocence" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5COI);
            }
            if (bunifuDropdown1.Text == "The Torched Courts" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5TOC);
            }
            if (bunifuDropdown1.Text == "The Ruined Square" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5RS);
            }
            if (bunifuDropdown1.Text == "The Ossuary" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5OSU);
            }
            if (bunifuDropdown1.Text == "The Reliquary" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5RE);
            }
            if (bunifuDropdown1.Text == "The Cathedral Rooftop" && bunifuLabel1.Text == "Act 5")
            {
                bunifuPages1.SetPage(A5CR);
            }
            //START ACT6
            if (bunifuDropdown1.SelectedIndex == 10 && bunifuLabel1.Text == "Act 5")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Twilight Strand", "The Coast", "The Mud Flats", "The Karui Fortress", "The Ridge", "The Lower Prison", "Shavronne’s Tower", "Prisoner’s Gate", "The Western Forest", "The Riverways", "The Wetlands", "The Southern Forest", "The Cavern of Anger", "The Beacon", "The Brine King’s Reef", "" });
                bunifuLabel1.Text = ("Act 6");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 6")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Slave Pens", "The Control Blocks", "Oriath Square", "The Templar Courts", "The Chamber of Innocence", "The Torched Courts", "The Ruined Square", "The Ossuary", "The Reliquary", "The Cathedral Rooftop", "" });
                bunifuLabel1.Text = ("Act 5");
                bunifuDropdown1.SelectedIndex = 9;
            }
            //END ACT6
            if (bunifuDropdown1.Text == "The Twilight Strand" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6TS);
            }
            if (bunifuDropdown1.Text == "The Coast" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6TC);
            }
            if (bunifuDropdown1.Text == "The Mud Flats" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6MF);
            }
            if (bunifuDropdown1.Text == "The Karui Fortress" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6KF);
            }
            if (bunifuDropdown1.Text == "The Ridge" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6RI);
            }
            if (bunifuDropdown1.Text == "The Lower Prison" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6LP);
            }
            if (bunifuDropdown1.Text == "Shavronne’s Tower" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6ST);
            }
            if (bunifuDropdown1.Text == "Prisoner’s Gate" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6PG);
            }
            if (bunifuDropdown1.Text == "The Western Forest" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6WF);
            }
            if (bunifuDropdown1.Text == "The Riverways" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6RW);
            }
            if (bunifuDropdown1.Text == "The Wetlands" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6WE);
            }
            if (bunifuDropdown1.Text == "The Southern Forest" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6SF);
            }
            if (bunifuDropdown1.Text == "The Cavern of Anger" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6COA);
            }
            if (bunifuDropdown1.Text == "The Beacon" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6BE);
            }
            if (bunifuDropdown1.Text == "The Brine King’s Reef" && bunifuLabel1.Text == "Act 6")
            {
                bunifuPages1.SetPage(A6BKR);
            }
            //START ACT7
            if (bunifuDropdown1.SelectedIndex == 15 && bunifuLabel1.Text == "Act 6")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Broken Bridge", "The Crossroads", "The Fellshrine Ruins", "The Crypt 1", "The Crypt 2", "The Chamber of Sins 1", "Maligaro’s Sanctum", "The Chamber of Sins 2", "The Den", "The Ashen Fields", "The Northern Forest", "The Dread Thicket", "The Causeway", "The Vaal City", "The Temple of Decay", "" });
                bunifuLabel1.Text = ("Act 7");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 7")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Twilight Strand", "The Coast", "The Mud Flats", "The Karui Fortress", "The Ridge", "The Lower Prison", "Shavronne’s Tower", "Prisoner’s Gate", "The Western Forest", "The Riverways", "The Wetlands", "The Southern Forest", "The Cavern of Anger", "The Beacon", "The Brine King’s Reef", "" });
                bunifuLabel1.Text = ("Act 6");
                bunifuDropdown1.SelectedIndex = 14;
            }
            //END ACT7
            if (bunifuDropdown1.Text == "The Broken Bridge" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7BB);
            }
            if (bunifuDropdown1.Text == "The Crossroads" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7CR);
            }
            if (bunifuDropdown1.Text == "The Fellshrine Ruins" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7FR);
            }
            if (bunifuDropdown1.Text == "The Crypt 1" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7CRL1);
            }
            if (bunifuDropdown1.Text == "The Crypt 2" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7CRL2);
            }
            if (bunifuDropdown1.Text == "The Chamber of Sins 1" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7COSL1);
            }
            if (bunifuDropdown1.Text == "Maligaro’s Sanctum" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7MS);
            }
            if (bunifuDropdown1.Text == "The Chamber of Sins 2" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7COSL2);
            }
            if (bunifuDropdown1.Text == "The Den" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7DE);
            }
            if (bunifuDropdown1.Text == "The Ashen Fields" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7AF);
            }
            if (bunifuDropdown1.Text == "The Northern Forest" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7NF);
            }
            if (bunifuDropdown1.Text == "The Dread Thicket" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7DT);
            }
            if (bunifuDropdown1.Text == "The Causeway" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7CA);
            }
            if (bunifuDropdown1.Text == "The Vaal City" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7VC);
            }
            if (bunifuDropdown1.Text == "The Temple of Decay" && bunifuLabel1.Text == "Act 7")
            {
                bunifuPages1.SetPage(A7TOD);
            }
            //START ACT8
            if (bunifuDropdown1.SelectedIndex == 15 && bunifuLabel1.Text == "Act 7")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Sarn Ramparts", "The Toxic Conduits", "Doedre’s Cesspool", "The Grand Promenade", "The Bath House", "The Lunaris Concourse", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Quay", "The Grain Gate", "The Imperial Fields", "The Solaris Temple 1", "The Solaris Temple 2", "The Harbour Bridge", "" });
                bunifuLabel1.Text = ("Act 8");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 8")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Broken Bridge", "The Crossroads", "The Fellshrine Ruins", "The Crypt 1", "The Crypt 2", "The Chamber of Sins 1", "Maligaro’s Sanctum", "The Chamber of Sins 2", "The Den", "The Ashen Fields", "The Northern Forest", "The Dread Thicket", "The Causeway", "The Vaal City", "The Temple of Decay", "" });
                bunifuLabel1.Text = ("Act 7");
                bunifuDropdown1.SelectedIndex = 14;
            }
            //END ACT8
            if (bunifuDropdown1.Text == "The Sarn Ramparts" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8SR);
            }
            if (bunifuDropdown1.Text == "The Toxic Conduits" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8TC);
            }
            if (bunifuDropdown1.Text == "Doedre’s Cesspool" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8DC);
            }
            if (bunifuDropdown1.Text == "The Grand Promenade" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8GP);
            }
            if (bunifuDropdown1.Text == "The Bath House" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8BH);
            }
            if (bunifuDropdown1.Text == "The Lunaris Concourse" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8LC);
            }
            if (bunifuDropdown1.Text == "The Lunaris Temple 1" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8LTL1);
            }
            if (bunifuDropdown1.Text == "The Lunaris Temple 2" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8LTL2);
            }
            if (bunifuDropdown1.Text == "The Quay" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8QU);
            }
            if (bunifuDropdown1.Text == "The Grain Gate" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8GG);
            }
            if (bunifuDropdown1.Text == "The Imperial Fields" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8IG);
            }
            if (bunifuDropdown1.Text == "The Solaris Temple 1" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8STL1);
            }
            if (bunifuDropdown1.Text == "The Solaris Temple 2" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8STL2);
            }
            if (bunifuDropdown1.Text == "The Harbour Bridge" && bunifuLabel1.Text == "Act 8")
            {
                bunifuPages1.SetPage(A8HB);
            }
            //START ACT9
            if (bunifuDropdown1.SelectedIndex == 14 && bunifuLabel1.Text == "Act 8")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Blood Aqueduct", "The Descent", "The Vastiri Desert", "The Oasis", "The Foothills", "The Boiling Lake", "The Tunnel", "The Quarry", "The Refinery", "The Belly of the Beast", "" });
                bunifuLabel1.Text = ("Act 9");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 9")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Sarn Ramparts", "The Toxic Conduits", "Doedre’s Cesspool", "The Grand Promenade", "The Bath House", "The Lunaris Concourse", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Quay", "The Grain Gate", "The Imperial Fields", "The Solaris Temple 1", "The Solaris Temple 2", "The Harbour Bridge", "" });
                bunifuLabel1.Text = ("Act 8");
                bunifuDropdown1.SelectedIndex = 13;
            }
            //END ACT9
            if (bunifuDropdown1.Text == "The Blood Aqueduct" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9BA);
            }
            if (bunifuDropdown1.Text == "The Descent" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9DE);
            }
            if (bunifuDropdown1.Text == "The Vastiri Desert" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9VD);
            }
            if (bunifuDropdown1.Text == "The Oasis" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9OA);
            }
            if (bunifuDropdown1.Text == "The Foothills" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9FO);
            }
            if (bunifuDropdown1.Text == "The Boiling Lake" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9BL);
            }
            if (bunifuDropdown1.Text == "The Tunnel" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9TU);
            }
            if (bunifuDropdown1.Text == "The Quarry" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9QU);
            }
            if (bunifuDropdown1.Text == "The Refinery" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9RE);
            }
            if (bunifuDropdown1.Text == "The Belly of the Beast" && bunifuLabel1.Text == "Act 9")
            {
                bunifuPages1.SetPage(A9BOB);
            }
            //START ACT10
            if (bunifuDropdown1.SelectedIndex == 10 && bunifuLabel1.Text == "Act 9")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Cathedral Rooftop", "The Ravaged Square", "The Ossuary", "The Torched Courts", "The Desecrated Chambers", "The Reliquary", "The Control Blocks", "The Canals", "The Feeding Trough" });
                bunifuLabel1.Text = ("Act 10");
                bunifuDropdown1.SelectedIndex = 0;
            }
            if (bunifuDropdown1.SelectedIndex == -1 && bunifuLabel1.Text == "Act 10")
            {
                bunifuDropdown1.Items.Clear();
                bunifuDropdown1.Items.AddRange(new string[] { "The Blood Aqueduct", "The Descent", "The Vastiri Desert", "The Oasis", "The Foothills", "The Boiling Lake", "The Tunnel", "The Quarry", "The Refinery", "The Belly of the Beast", "" });
                bunifuLabel1.Text = ("Act 9");
                bunifuDropdown1.SelectedIndex = 9;
            }
            //END ACT10
            if (bunifuDropdown1.Text == "The Cathedral Rooftop" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10CR);
            }
            if (bunifuDropdown1.Text == "The Ravaged Square" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10RS);
            }
            if (bunifuDropdown1.Text == "The Ossuary" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10OS);
            }
            if (bunifuDropdown1.Text == "The Torched Courts" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10TC);
            }
            if (bunifuDropdown1.Text == "The Desecrated Chambers" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10DC);
            }
            if (bunifuDropdown1.Text == "The Reliquary" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10RE);
            }
            if (bunifuDropdown1.Text == "The Control Blocks" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10CB);
            }
            if (bunifuDropdown1.Text == "The Canals" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10CA);
            }
            if (bunifuDropdown1.Text == "The Feeding Trough" && bunifuLabel1.Text == "Act 10")
            {
                bunifuPages1.SetPage(A10FT);
            }
        }
        void gkh_KeyRight(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Properties.Settings.Default.KeyNext)
            {
                bunifuDropdown1.SelectedIndex++;
            }
        }

        void gkh_KeyLeft(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Properties.Settings.Default.KeyPrevious)
            {
                bunifuDropdown1.SelectedIndex--;
            }
        }
        //public string checksum = GetMD5Checksum(@"D:\Steam\steamapps\common\Path of Exile\logs\Client.txt");
        public string Hash1 = global::poe.Properties.Settings.Default.Hash1;
        public string Hash2 = global::poe.Properties.Settings.Default.Hash2;
        UserActivityHook actHook;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Hash1 = checksum;
            actHook = new UserActivityHook(); // crate an instance

            // hang on events
            actHook.KeyDown+= new KeyEventHandler(gkh_KeyLeft);
            actHook.KeyDown += new KeyEventHandler(gkh_KeyRight);

            if (Properties.Settings.Default.ColorB == true)
            {
                this.BackColor = Color.FromArgb(0, 7, 22);
                foreach (TabPage c in bunifuPages1.TabPages)
                {
                    c.BackColor = this.BackColor;
                    foreach (var control in c.Controls)
                    {
                        var label = control as Bunifu.UI.WinForms.BunifuLabel;
                        if (label == null) continue;
                        label.ForeColor = Color.White;
                    }
                }
                bunifuLabel1.ForeColor = Color.White;
                bunifuDropdown1.BackgroundColor = this.BackColor;
                bunifuDropdown1.ForeColor = Color.White;
                Settings.Image = poe.Properties.Resources.icons8_setting_20;
            }
            else
            {
                this.BackColor = Color.White;
                foreach (TabPage c in bunifuPages1.TabPages)
                {
                    c.BackColor = this.BackColor;
                    foreach (var control in c.Controls)
                    {
                        var label = control as Bunifu.UI.WinForms.BunifuLabel;
                        if (label == null) continue;
                        label.ForeColor = Color.Black;
                    }
                }
                bunifuLabel1.ForeColor = Color.Black;
                bunifuDropdown1.BackgroundColor = this.BackColor;
                bunifuDropdown1.ForeColor = Color.Black;
                Settings.Image = poe.Properties.Resources.icons8_setdting_20;
            }
            if(Properties.Settings.Default.WayPointS == true)
            {
                WaypointPic.Visible = true;
            }
            else
            {
                WaypointPic.Visible = false;
            }

            this.Opacity = Properties.Settings.Default.OpacityS;
        }

        public void MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        public bool start = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                    int n = 10; //or any arbitrary number
                    int count = 0;
                    string content;
                    string contentcopy;
                    byte[] buffer = new byte[1];

                    using (FileStream fileStream = new FileStream(clientpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        // read to the end.
                        fileStream.Seek(0, SeekOrigin.End);

                        // read backwards 'n' lines
                        while (count < n)
                        {
                            fileStream.Seek(-1, SeekOrigin.Current);
                            fileStream.Read(buffer, 0, 1);
                            if (buffer[0] == '\n')
                            {
                                count++;
                            }

                            fileStream.Seek(-1, SeekOrigin.Current); // fs.Read(...) advances the position, so we need to go back again
                        }
                        fileStream.Seek(1, SeekOrigin.Current); // go past the last '\n'

                        // read the last n lines
                        using (StreamReader sr = new StreamReader(fileStream))
                        {
                            content = sr.ReadToEnd();
                        }
                        using (StreamWriter sw = new StreamWriter(clientcopy))
                        {
                            sw.Write(content);
                        }
                        using (StreamReader srcopy = new StreamReader(clientcopy))
                        {
                            contentcopy = srcopy.ReadToEnd();
                            srcopy.Close();
                            if (contentcopy.Contains(Act1))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Coast", "Mud Flats", "Tidal Island", "Submerged Passage", "The Ledge", "Flooded Depths", "The Climb", "The Lower Prison", "The Upper Prison", "The Prisoner’s Gate", "The Ship Graveyard", "The Cavern of Wrath", "The Cavern of Anger", "" });
                                bunifuLabel1.Text = ("Act 1");
                            }
                            if (contentcopy.Contains(Act2))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Southern Forest", "The Old Fields", "The Den", "The Crossroads", "The Fellshrine Ruins", "The Crypt Level 1", "The Broken Bridge", "Chamber of Sins 1", "Chamber of Sins 2", "The Riverways", "The Western Forest", "Weaver’s Chambers", "The Wetlands", "The Vaal Ruins", "The Northern Forest", "The Dread Thicket", "The Caverns", "Ancient Pyramid", "" });
                                bunifuLabel1.Text = ("Act 2");
                            }
                            if (contentcopy.Contains(Act3))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The City of Sarn", "The Slums", "The Crematorium", "The Sewers", "The Marketplace", "The Battlefront", "The Docks", "The Solaris Temple 1", "The Solaris Temple 2", "The Ebony Barracks", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Imperial Gardens", "The Sceptre of God", "The Upper Sceptre of God", "" });
                                bunifuLabel1.Text = ("Act 3");
                            }
                            if (contentcopy.Contains(Act4))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Aqueduct", "The Dried Lake", "The Mines 1", "The Mines 2", "The Crystal Veins", "Daresso’s Dream", "The Grand Arena", "Kaom’s Dream", "Kaom’s Stronghold", "Belly of the Beast 1", "Belly of the Beast 2", "The Harvest", "The Ascent", "" });
                                bunifuLabel1.Text = ("Act 4");
                            }
                            if (contentcopy.Contains(Act5))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Slave Pens", "The Control Blocks", "Oriath Square", "The Templar Courts", "The Chamber of Innocence", "The Torched Courts", "The Ruined Square", "The Ossuary", "The Reliquary", "The Cathedral Rooftop", "" });
                                bunifuLabel1.Text = ("Act 5");
                            }
                            if (contentcopy.Contains(Act6))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Twilight Strand", "The Coast", "The Mud Flats", "The Karui Fortress", "The Ridge", "The Lower Prison", "Shavronne’s Tower", "Prisoner’s Gate", "The Western Forest", "The Riverways", "The Wetlands", "The Southern Forest", "The Cavern of Anger", "The Beacon", "The Brine King’s Reef", "" });
                                bunifuLabel1.Text = ("Act 6");
                            }
                            if (contentcopy.Contains(Act7))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Broken Bridge", "The Crossroads", "The Fellshrine Ruins", "The Crypt 1", "The Crypt 2", "The Chamber of Sins 1", "Maligaro’s Sanctum", "The Chamber of Sins 2", "The Den", "The Ashen Fields", "The Northern Forest", "The Dread Thicket", "The Causeway", "The Vaal City", "The Temple of Decay", "" });
                                bunifuLabel1.Text = ("Act 7");
                            }
                            if (contentcopy.Contains(Act8))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Sarn Ramparts", "The Toxic Conduits", "Doedre’s Cesspool", "The Grand Promenade", "The Bath House", "The Lunaris Concourse", "The Lunaris Temple 1", "The Lunaris Temple 2", "The Quay", "The Grain Gate", "The Imperial Fields", "The Solaris Temple 1", "The Solaris Temple 2", "The Harbour Bridge", "" });
                                bunifuLabel1.Text = ("Act 8");
                            }
                            if (contentcopy.Contains(Act9))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Blood Aqueduct", "The Descent", "The Vastiri Desert", "The Oasis", "The Foothills", "The Boiling Lake", "The Tunnel", "The Quarry", "The Refinery", "The Belly of the Beast", "" });
                                bunifuLabel1.Text = ("Act 9");
                            }
                            if (contentcopy.Contains(Act10))
                            {
                                bunifuDropdown1.Items.Clear();
                                bunifuDropdown1.Items.AddRange(new string[] { "The Cathedral Rooftop", "The Ravaged Square", "The Ossuary", "The Torched Courts", "The Desecrated Chambers", "The Reliquary", "The Control Blocks", "The Canals", "The Feeding Trough" });
                                bunifuLabel1.Text = ("Act 10");
                            }
                            if (contentcopy.Contains(TCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(MFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(TIStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(SPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(TLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(FDStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(TCLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(TLPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(TUPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(PGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(SGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(COWStr))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(COAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            //ACT2
                            if (contentcopy.Contains(A2SFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A2OFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A2DEStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A2CRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A2FRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A2CL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A2BBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A2COSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A2COSL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A2RWStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A2WFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A2WCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A2WLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            if (contentcopy.Contains(A2VRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 13;
                            }
                            if (contentcopy.Contains(A2NFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 14;
                            }
                            if (contentcopy.Contains(A2DTStr))
                            {
                                bunifuDropdown1.SelectedIndex = 15;
                            }
                            if (contentcopy.Contains(A2CAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 16;
                            }
                            if (contentcopy.Contains(A2APStr))
                            {
                                bunifuDropdown1.SelectedIndex = 17;
                            }
                            //ACT3
                            if (contentcopy.Contains(A3COSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A3SLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A3CMStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A3SWStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A3MPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A3BFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A3DOStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A3STL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A3STL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A3EBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A3LTL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A3LTL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A3IGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            if (contentcopy.Contains(A3SOGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 13;
                            }
                            if (contentcopy.Contains(A3USOGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 14;
                            }
                            //ACT4
                            if (contentcopy.Contains(A4ADStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A4DLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A4M1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A4M2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A4CVStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A4DDStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A4GAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A4KDStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A4KSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A4BOFB1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A4BOFB2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A4HAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A4ACStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            //ACT5
                            if (contentcopy.Contains(A5SPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A5CBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A5OSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A5TCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A5COIStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A5TOCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A5RSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A5OSUStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A5REStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A5CRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            //ACT6
                            if (contentcopy.Contains(A6TSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A6TCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A6MFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A6KFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A6RIStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A6LPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A6STStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A6PGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A6WFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A6RWStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A6WEStr))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A6SFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A6COAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            if (contentcopy.Contains(A6BEStr))
                            {
                                bunifuDropdown1.SelectedIndex = 13;
                            }
                            if (contentcopy.Contains(A6BKRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 14;
                            }
                            //ACT7
                            if (contentcopy.Contains(A7BBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A7CRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A7FRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A7CRL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A7CRL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A7COSL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A7MSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A7COSL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A7DEStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A7AFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A7NFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A7DTStr))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A7CAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            if (contentcopy.Contains(A7VCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 13;
                            }
                            if (contentcopy.Contains(A7TODStr))
                            {
                                bunifuDropdown1.SelectedIndex = 14;
                            }
                            //ACT8
                            if (contentcopy.Contains(A8SRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A8TCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A8DCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A8GPStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A8BHStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A8LCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A8LTL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A8LTL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A8QUStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A8GGStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            if (contentcopy.Contains(A8IFStr))
                            {
                                bunifuDropdown1.SelectedIndex = 10;
                            }
                            if (contentcopy.Contains(A8STL1Str))
                            {
                                bunifuDropdown1.SelectedIndex = 11;
                            }
                            if (contentcopy.Contains(A8STL2Str))
                            {
                                bunifuDropdown1.SelectedIndex = 12;
                            }
                            if (contentcopy.Contains(A8HBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 13;
                            }
                            //ACT9
                            if (contentcopy.Contains(A9BAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A9DEStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A9VDStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A9OAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A9FOStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A9BLStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A9TUStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A9QUStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A9REStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                            if (contentcopy.Contains(A9BOBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 9;
                            }
                            //ACT10
                            if (contentcopy.Contains(A10CRStr))
                            {
                                bunifuDropdown1.SelectedIndex = 0;
                            }
                            if (contentcopy.Contains(A10RSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 1;
                            }
                            if (contentcopy.Contains(A10OSStr))
                            {
                                bunifuDropdown1.SelectedIndex = 2;
                            }
                            if (contentcopy.Contains(A10TCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 3;
                            }
                            if (contentcopy.Contains(A10DCStr))
                            {
                                bunifuDropdown1.SelectedIndex = 4;
                            }
                            if (contentcopy.Contains(A10REStr))
                            {
                                bunifuDropdown1.SelectedIndex = 5;
                            }
                            if (contentcopy.Contains(A10CBStr))
                            {
                                bunifuDropdown1.SelectedIndex = 6;
                            }
                            if (contentcopy.Contains(A10CAStr))
                            {
                                bunifuDropdown1.SelectedIndex = 7;
                            }
                            if (contentcopy.Contains(A10FTStr))
                            {
                                bunifuDropdown1.SelectedIndex = 8;
                            }
                        }
                    }
                }
            }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Properties.Settings.Default.Save();
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            Form2 Settings = new Form2(this);
            Settings.ShowDialog();
        }
        public double OpacityS
        {
            get { return (int)Opacity; }
            set { Opacity = value; }
        }
        public bool WayPointS
        {
            get { return WaypointPic.Visible; }
            set { WaypointPic.Visible = value; }
        }

        public bool LabS
        {
            get { return Lab.Visible; }
            set { Lab.Visible = false; }
        }
        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            if(this.BackColor == Color.FromArgb(0, 7, 22))
            {
                foreach (TabPage c in bunifuPages1.TabPages)
                {
                    c.BackColor = this.BackColor;
                    foreach (var control in c.Controls)
                    {
                        var label = control as Bunifu.UI.WinForms.BunifuLabel;
                        if (label == null) continue;
                        label.ForeColor = Color.White;
                    }
                }
                bunifuLabel1.ForeColor = Color.White;
                bunifuDropdown1.BackgroundColor = this.BackColor;
                bunifuDropdown1.ForeColor = Color.White;
                Settings.Image = poe.Properties.Resources.icons8_setting_20;
            }
            else
            {
                foreach (TabPage c in bunifuPages1.TabPages)
                {
                    c.BackColor = this.BackColor;
                    foreach (var control in c.Controls)
                    {
                        var label = control as Bunifu.UI.WinForms.BunifuLabel;
                        if (label == null) continue;
                        label.ForeColor = Color.Black;
                    }
                }
                bunifuLabel1.ForeColor = Color.Black;
                bunifuDropdown1.BackgroundColor = this.BackColor;
                bunifuDropdown1.ForeColor = Color.Black;
                Settings.Image = poe.Properties.Resources.icons8_setdting_20;
            }
        }
    }
}
