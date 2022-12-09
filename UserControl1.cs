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
using Microsoft.Win32;

namespace poe
{
    public partial class UserControl1 : UserControl
    {
        public string clientpath = (@"D:\Steam\steamapps\common\Path of Exile\logs\Client.txt");
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
        public UserControl1()
        {
            InitializeComponent();
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

        public bool start = false;

        private void UserControl1_Load(object sender, EventArgs e)
        {
            foreach (TabPage c in bunifuPages1.TabPages)
            {
                c.BackColor = Color.Black;
                foreach (var control in c.Controls)
                {
                    var label = control as Bunifu.UI.WinForms.BunifuLabel;
                    if (label == null) continue;
                    label.ForeColor = Color.White;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Application.Exit();
        }

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
                        if (contentcopy.Contains(TCStr))
                        {
                            bunifuPages1.SetPage(TC);
                        }
                        if (contentcopy.Contains(MFStr))
                        {
                            bunifuPages1.SetPage(MF);
                        }
                        if (contentcopy.Contains(TIStr))
                        {
                            bunifuPages1.SetPage(TI);
                        }
                        if (contentcopy.Contains(SPStr))
                        {
                            bunifuPages1.SetPage(SP);
                        }
                        if (contentcopy.Contains(TLStr))
                        {
                            bunifuPages1.SetPage(TL);
                        }
                        if (contentcopy.Contains(FDStr))
                        {
                            bunifuPages1.SetPage(FD);
                        }
                        if (contentcopy.Contains(TCLStr))
                        {
                            bunifuPages1.SetPage(TCL);
                        }
                        if (contentcopy.Contains(TLPStr))
                        {
                            bunifuPages1.SetPage(TLP);
                        }
                        if (contentcopy.Contains(TUPStr))
                        {
                            bunifuPages1.SetPage(TUP);
                        }
                        if (contentcopy.Contains(PGStr))
                        {
                            bunifuPages1.SetPage(PG);
                        }
                        if (contentcopy.Contains(SGStr))
                        {
                            bunifuPages1.SetPage(SG);
                        }
                        if (contentcopy.Contains(COWStr))
                        {
                            bunifuPages1.SetPage(COW);
                        }
                        if (contentcopy.Contains(COAStr))
                        {
                            bunifuPages1.SetPage(COA);
                        }
                        //ACT2
                        if (contentcopy.Contains(A2SFStr))
                        {
                            bunifuPages1.SetPage(A2SF);
                        }
                        if (contentcopy.Contains(A2OFStr))
                        {
                            bunifuPages1.SetPage(A2OF);
                        }
                        if (contentcopy.Contains(A2DEStr))
                        {
                            bunifuPages1.SetPage(A2DE);
                        }
                        if (contentcopy.Contains(A2CRStr))
                        {
                            bunifuPages1.SetPage(A2CR);
                        }
                        if (contentcopy.Contains(A2FRStr))
                        {
                            bunifuPages1.SetPage(A2FR);
                        }
                        if (contentcopy.Contains(A2CL1Str))
                        {
                            bunifuPages1.SetPage(A2CL1);
                        }
                        if (contentcopy.Contains(A2BBStr))
                        {
                            bunifuPages1.SetPage(A2BB);
                        }
                        if (contentcopy.Contains(A2COSStr))
                        {
                            bunifuPages1.SetPage(A2COS);
                        }
                        if (contentcopy.Contains(A2COSL2Str))
                        {
                            bunifuPages1.SetPage(A2COSL2);
                        }
                        if (contentcopy.Contains(A2RWStr))
                        {
                            bunifuPages1.SetPage(A2RW);
                        }
                        if (contentcopy.Contains(A2WFStr))
                        {
                            bunifuPages1.SetPage(A2WF);
                        }
                        if (contentcopy.Contains(A2WCStr))
                        {
                            bunifuPages1.SetPage(A2WC);
                        }
                        if (contentcopy.Contains(A2WLStr))
                        {
                            bunifuPages1.SetPage(A2WL);
                        }
                        if (contentcopy.Contains(A2VRStr))
                        {
                            bunifuPages1.SetPage(A2VR);
                        }
                        if (contentcopy.Contains(A2NFStr))
                        {
                            bunifuPages1.SetPage(A2NF);
                        }
                        if (contentcopy.Contains(A2DTStr))
                        {
                            bunifuPages1.SetPage(A2DT);
                        }
                        if (contentcopy.Contains(A2CAStr))
                        {
                            bunifuPages1.SetPage(A2CA);
                        }
                        if (contentcopy.Contains(A2APStr))
                        {
                            bunifuPages1.SetPage(A2AP);
                        }
                        //ACT3
                        if (contentcopy.Contains(A3COSStr))
                        {
                            bunifuPages1.SetPage(A3COS);
                        }
                        if (contentcopy.Contains(A3SLStr))
                        {
                            bunifuPages1.SetPage(A3SLStr);
                        }
                        if (contentcopy.Contains(A3CMStr))
                        {
                            bunifuPages1.SetPage(A3CM);
                        }
                        if (contentcopy.Contains(A3SWStr))
                        {
                            bunifuPages1.SetPage(A3SW);
                        }
                        if (contentcopy.Contains(A3MPStr))
                        {
                            bunifuPages1.SetPage(A3MP);
                        }
                        if (contentcopy.Contains(A3BFStr))
                        {
                            bunifuPages1.SetPage(A3BF);
                        }
                        if (contentcopy.Contains(A3DOStr))
                        {
                            bunifuPages1.SetPage(A3DO);
                        }
                        if (contentcopy.Contains(A3STL1Str))
                        {
                            bunifuPages1.SetPage(A3STL1);
                        }
                        if (contentcopy.Contains(A3STL2Str))
                        {
                            bunifuPages1.SetPage(A3STL2);
                        }
                        if (contentcopy.Contains(A3EBStr))
                        {
                            bunifuPages1.SetPage(A3EB);
                        }
                        if (contentcopy.Contains(A3LTL1Str))
                        {
                            bunifuPages1.SetPage(A3LTL1);
                        }
                        if (contentcopy.Contains(A3LTL2Str))
                        {
                            bunifuPages1.SetPage(A3LTL2);
                        }
                        if (contentcopy.Contains(A3IGStr))
                        {
                            bunifuPages1.SetPage(A3IG);
                        }
                        if (contentcopy.Contains(A3SOGStr))
                        {
                            bunifuPages1.SetPage(A3SOG);
                        }
                        if (contentcopy.Contains(A3USOGStr))
                        {
                            bunifuPages1.SetPage(A3USOG);
                        }
                        //ACT4
                        if (contentcopy.Contains(A4ADStr))
                        {
                            bunifuPages1.SetPage(A4AD);
                        }
                        if (contentcopy.Contains(A4DLStr))
                        {
                            bunifuPages1.SetPage(A4DL);
                        }
                        if (contentcopy.Contains(A4M1Str))
                        {
                            bunifuPages1.SetPage(A4M1);
                        }
                        if (contentcopy.Contains(A4M2Str))
                        {
                            bunifuPages1.SetPage(A4M2);
                        }
                        if (contentcopy.Contains(A4CVStr))
                        {
                            bunifuPages1.SetPage(A4CV);
                        }
                        if (contentcopy.Contains(A4DDStr))
                        {
                            bunifuPages1.SetPage(A4DD);
                        }
                        if (contentcopy.Contains(A4GAStr))
                        {
                            bunifuPages1.SetPage(A4GA);
                        }
                        if (contentcopy.Contains(A4KDStr))
                        {
                            bunifuPages1.SetPage(A4KD);
                        }
                        if (contentcopy.Contains(A4KSStr))
                        {
                            bunifuPages1.SetPage(A4KS);
                        }
                        if (contentcopy.Contains(A4BOFB1Str))
                        {
                            bunifuPages1.SetPage(A4BOFB1);
                        }
                        if (contentcopy.Contains(A4BOFB2Str))
                        {
                            bunifuPages1.SetPage(A4BOFB2);
                        }
                        if (contentcopy.Contains(A4HAStr))
                        {
                            bunifuPages1.SetPage(A4HA);
                        }
                        if (contentcopy.Contains(A4ACStr))
                        {
                            bunifuPages1.SetPage(A4AC);
                        }
                        //ACT5
                        if (contentcopy.Contains(A5SPStr))
                        {
                            bunifuPages1.SetPage(A5SP);
                        }
                        if (contentcopy.Contains(A5CBStr))
                        {
                            bunifuPages1.SetPage(A5CB);
                        }
                        if (contentcopy.Contains(A5OSStr))
                        {
                            bunifuPages1.SetPage(A5OS);
                        }
                        if (contentcopy.Contains(A5TCStr))
                        {
                            bunifuPages1.SetPage(A5TC);
                        }
                        if (contentcopy.Contains(A5COIStr))
                        {
                            bunifuPages1.SetPage(A5COI);
                        }
                        if (contentcopy.Contains(A5TOCStr))
                        {
                            bunifuPages1.SetPage(A5TOC);
                        }
                        if (contentcopy.Contains(A5RSStr))
                        {
                            bunifuPages1.SetPage(A5RS);
                        }
                        if (contentcopy.Contains(A5OSUStr))
                        {
                            bunifuPages1.SetPage(A5OSU);
                        }
                        if (contentcopy.Contains(A5REStr))
                        {
                            bunifuPages1.SetPage(A5REStr);
                        }
                        if (contentcopy.Contains(A5CRStr))
                        {
                            bunifuPages1.SetPage(A5CR);
                        }
                        //ACT6
                        if (contentcopy.Contains(A6TSStr))
                        {
                            bunifuPages1.SetPage(A6TS);
                        }
                        if (contentcopy.Contains(A6TCStr))
                        {
                            bunifuPages1.SetPage(A6TC);
                        }
                        if (contentcopy.Contains(A6MFStr))
                        {
                            bunifuPages1.SetPage(A6MF);
                        }
                        if (contentcopy.Contains(A6KFStr))
                        {
                            bunifuPages1.SetPage(A6KF);
                        }
                        if (contentcopy.Contains(A6RIStr))
                        {
                            bunifuPages1.SetPage(A6RI);
                        }
                        if (contentcopy.Contains(A6LPStr))
                        {
                            bunifuPages1.SetPage(A6LP);
                        }
                        if (contentcopy.Contains(A6STStr))
                        {
                            bunifuPages1.SetPage(A6ST);
                        }
                        if (contentcopy.Contains(A6PGStr))
                        {
                            bunifuPages1.SetPage(A6PG);
                        }
                        if (contentcopy.Contains(A6WFStr))
                        {
                            bunifuPages1.SetPage(A6WF);
                        }
                        if (contentcopy.Contains(A6RWStr))
                        {
                            bunifuPages1.SetPage(A6RW);
                        }
                        if (contentcopy.Contains(A6WEStr))
                        {
                            bunifuPages1.SetPage(A6WE);
                        }
                        if (contentcopy.Contains(A6SFStr))
                        {
                            bunifuPages1.SetPage(A6SF);
                        }
                        if (contentcopy.Contains(A6COAStr))
                        {
                            bunifuPages1.SetPage(A6COA);
                        }
                        if (contentcopy.Contains(A6BEStr))
                        {
                            bunifuPages1.SetPage(A6BE);
                        }
                        if (contentcopy.Contains(A6BKRStr))
                        {
                            bunifuPages1.SetPage(A6BKR);
                        }
                        //ACT7
                        if (contentcopy.Contains(A7BBStr))
                        {
                            bunifuPages1.SetPage(A7BB);
                        }
                        if (contentcopy.Contains(A7CRStr))
                        {
                            bunifuPages1.SetPage(A7CR);
                        }
                        if (contentcopy.Contains(A7FRStr))
                        {
                            bunifuPages1.SetPage(A7FR);
                        }
                        if (contentcopy.Contains(A7CRL1Str))
                        {
                            bunifuPages1.SetPage(A7CRL1);
                        }
                        if (contentcopy.Contains(A7CRL2Str))
                        {
                            bunifuPages1.SetPage(A7CRL2);
                        }
                        if (contentcopy.Contains(A7COSL1Str))
                        {
                            bunifuPages1.SetPage(A7COSL1);
                        }
                        if (contentcopy.Contains(A7MSStr))
                        {
                            bunifuPages1.SetPage(A7MS);
                        }
                        if (contentcopy.Contains(A7COSL2Str))
                        {
                            bunifuPages1.SetPage(A7COSL2);
                        }
                        if (contentcopy.Contains(A7DEStr))
                        {
                            bunifuPages1.SetPage(A7DE);
                        }
                        if (contentcopy.Contains(A7AFStr))
                        {
                            bunifuPages1.SetPage(A7AF);
                        }
                        if (contentcopy.Contains(A7NFStr))
                        {
                            bunifuPages1.SetPage(A7NF);
                        }
                        if (contentcopy.Contains(A7DTStr))
                        {
                            bunifuPages1.SetPage(A7DT);
                        }
                        if (contentcopy.Contains(A7CAStr))
                        {
                            bunifuPages1.SetPage(A7CA);
                        }
                        if (contentcopy.Contains(A7VCStr))
                        {
                            bunifuPages1.SetPage(A7VC);
                        }
                        if (contentcopy.Contains(A7TODStr))
                        {
                            bunifuPages1.SetPage(A7TOD);
                        }
                        //ACT8
                        if (contentcopy.Contains(A8SRStr))
                        {
                            bunifuPages1.SetPage(A8SR);
                        }
                        if (contentcopy.Contains(A8TCStr))
                        {
                            bunifuPages1.SetPage(A8TC);
                        }
                        if (contentcopy.Contains(A8DCStr))
                        {
                            bunifuPages1.SetPage(A8DC);
                        }
                        if (contentcopy.Contains(A8GPStr))
                        {
                            bunifuPages1.SetPage(A8GP);
                        }
                        if (contentcopy.Contains(A8BHStr))
                        {
                            bunifuPages1.SetPage(A8BH);
                        }
                        if (contentcopy.Contains(A8LCStr))
                        {
                            bunifuPages1.SetPage(A8LC);
                        }
                        if (contentcopy.Contains(A8LTL1Str))
                        {
                            bunifuPages1.SetPage(A8LTL1);
                        }
                        if (contentcopy.Contains(A8LTL2Str))
                        {
                            bunifuPages1.SetPage(A8LTL2);
                        }
                        if (contentcopy.Contains(A8QUStr))
                        {
                            bunifuPages1.SetPage(A8QU);
                        }
                        if (contentcopy.Contains(A8GGStr))
                        {
                            bunifuPages1.SetPage(A8GG);
                        }
                        if (contentcopy.Contains(A8IFStr))
                        {
                            bunifuPages1.SetPage(A8IFStr);
                        }
                        if (contentcopy.Contains(A8STL1Str))
                        {
                            bunifuPages1.SetPage(A8STL1);
                        }
                        if (contentcopy.Contains(A8STL2Str))
                        {
                            bunifuPages1.SetPage(A8STL2);
                        }
                        if (contentcopy.Contains(A8HBStr))
                        {
                            bunifuPages1.SetPage(A8HB);
                        }
                        //ACT9
                        if (contentcopy.Contains(A9BAStr))
                        {
                            bunifuPages1.SetPage(A9BA);
                        }
                        if (contentcopy.Contains(A9DEStr))
                        {
                            bunifuPages1.SetPage(A9DE);
                        }
                        if (contentcopy.Contains(A9VDStr))
                        {
                            bunifuPages1.SetPage(A9VD);
                        }
                        if (contentcopy.Contains(A9OAStr))
                        {
                            bunifuPages1.SetPage(A9OA);
                        }
                        if (contentcopy.Contains(A9FOStr))
                        {
                            bunifuPages1.SetPage(A9FO);
                        }
                        if (contentcopy.Contains(A9BLStr))
                        {
                            bunifuPages1.SetPage(A9BL);
                        }
                        if (contentcopy.Contains(A9TUStr))
                        {
                            bunifuPages1.SetPage(A9TU);
                        }
                        if (contentcopy.Contains(A9QUStr))
                        {
                            bunifuPages1.SetPage(A9QU);
                        }
                        if (contentcopy.Contains(A9REStr))
                        {
                            bunifuPages1.SetPage(A9RE);
                        }
                        if (contentcopy.Contains(A9BOBStr))
                        {
                            bunifuPages1.SetPage(A9BOB);
                        }
                        //ACT10
                        if (contentcopy.Contains(A10CRStr))
                        {
                            bunifuPages1.SetPage(A10CR);
                        }
                        if (contentcopy.Contains(A10RSStr))
                        {
                            bunifuPages1.SetPage(A10RS);
                        }
                        if (contentcopy.Contains(A10OSStr))
                        {
                            bunifuPages1.SetPage(A10OS);
                        }
                        if (contentcopy.Contains(A10TCStr))
                        {
                            bunifuPages1.SetPage(A10TC);
                        }
                        if (contentcopy.Contains(A10DCStr))
                        {
                            bunifuPages1.SetPage(A10DC);
                        }
                        if (contentcopy.Contains(A10REStr))
                        {
                            bunifuPages1.SetPage(A10RE);
                        }
                        if (contentcopy.Contains(A10CBStr))
                        {
                            bunifuPages1.SetPage(A10CB);
                        }
                        if (contentcopy.Contains(A10CAStr))
                        {
                            bunifuPages1.SetPage(A10CA);
                        }
                        if (contentcopy.Contains(A10FTStr))
                        {
                            bunifuPages1.SetPage(A10FT);
                        }
                    }
                }
            }
        }
    }
}
