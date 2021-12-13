using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Rekt_Custom_Animation_Tool
{
    public partial class Form1 : Form
    {

        Mem m = new Mem();
        public bool KnifeLungeToggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("t5m.exe");
        }

        private void SelectedWeap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (WeaponBox.Text == "============================================================")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Please Select A Weapon" });
                }
                if (WeaponBox.Text == "")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Please Select A Weapon" });
                }
                if (WeaponBox.Text == "MP5K")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty" });
                }
                if (WeaponBox.Text == "Skorpion")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Grip Idle",
                    "Grip Fire", "Grip Reload", "Grip Reload Empty", "Grip Pullout", "Grip Canswap", "Grip Putaway",
                    "============================================================", "Dual Wield Right Gun Idle",
                    "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "MAC11")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Grip Idle",
                    "Grip Fire", "Grip Reload", "Grip Reload Empty", "Grip Pullout", "Grip Canswap", "Grip Putaway",
                    "============================================================", "Dual Wield Right Gun Idle",
                    "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "AK74u")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================",
                    "Dual Mags Reload", "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty",
                    "Grenade Launcher Pullout", "Grenade Launcher Putaway",
                    "============================================================", "Grip Idle", "Grip Fire", "Grip Reload",
                    "Grip Reload Empty", "Grip Pullout", "Grip Putaway", "============================================================",
                    "Grip Extended Mags Reload", "Grip Extended Mags Reload Empty", "============================================================",
                    "Grip Dual Mags Reload", "Grip Dual Mags Reload Empty", "Grip Dual Mags Fast Reload",
                    "Grip Dual Mags Fast Reload Empty" });
                }
                if (WeaponBox.Text == "Uzi")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================"," Grip Canswap"});
                }
                if (WeaponBox.Text == "PM63")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Canswap", "============================================================",
                    "Extended Mags Reload","Extended Mags Reload Empty", "============================================================", "Grip Idle",
                    "Grip Fire", "Grip Reload", "Grip Reload Empty", "Grip Pullout", "Grip Canswap", "Grip Putaway",
                    "============================================================", "Dual Wield Right Gun Idle",
                    "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "MPL")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Dual Mags Reload", "Duals Mags Reload Empty",
                    "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty", "============================================================"," Grip Canswap"});
                }
                if (WeaponBox.Text == "Spectre")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================"," Grip Canswap"});
                }
                if (WeaponBox.Text == "Kiparis")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap", "Putaway",
                    "============================================================", "Extended Mags Reload","Extended Mags Reload Empty",
                    "============================================================", "Grip Idle", "Grip Fire", "Grip Reload", "Grip Reload Empty",
                    "Grip Pullout", "Grip Canswap", "Grip Putaway", "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "M16")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Reload",
                    "Flamethrower Pullout", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Pullout", "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "Enfield")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Fire", "Flamethrower Reload",
                    "Flamethrower Pullout", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Pullout", "Grenade Launcher Putaway"  });
                }
                if (WeaponBox.Text == "M14")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Flamethrower Idle", "Flamethrower Fire",
                    "Flamethrower Reload", "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Reload",
                    "Masterkey Reload Empty", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway", "============================================================", "Grip Idle", "Grip Fire", "Grip Reload",
                    "Grip Reload Empty", "Grip Pullout", "Grip Canswap", "Grip Putaway"});
                }
                if (WeaponBox.Text == "Famas")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Fire", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload",
                    "Masterkey Reload Empty", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "Galil")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "AUG")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Fire", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "FN FAL")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "AK47")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "Commando")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty",
                    "============================================================", "Flamethrower Idle", "Flamethrower Reload",
                    "Flamethrower Reload Empty", "Flamethrower Pullout", "Flamethrower Canswap", "Flamethrower Putaway",
                    "============================================================", "Masterkey Idle", "Masterkey Fire", "Masterkey Cockback", "Masterkey Reload Loop",
                    "Masterkey Reload In", "Masterkey Reload Out", "Masterkey Pullout", "Masterkey Canswap", "Masterkey Putaway",
                    "============================================================", "Grenade Launcher Idle",
                    "Grenade Launcher Fire", "Grenade Launcher Reload", "Grenade Launcher Reload Empty", "Grenade Launcher Pullout",
                    "Grenade Launcher Putaway" });
                }
                if (WeaponBox.Text == "G11")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway" });
                }
                if (WeaponBox.Text == "Olympia")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway" });
                }
                if (WeaponBox.Text == "Stakeout")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Cockback", "Reload Loop", "Reload In", "Reload Out", "Pullout", "Canswap",
                    "Putaway","============================================================", "Grip Idle", "Grip Fire", "Grip Cockback",
                    "Grip Reload Loop", "Grip Reload In", "Grip Reload Out", "Grip Pullout", "Grip Canswap", "Grip Putaway"});
                }
                if (WeaponBox.Text == "SPAS-12")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload Loop", "Reload In", "Reload Out", "Pullout", "Canswap",
                    "Putaway" });
                }
                if (WeaponBox.Text == "HS10")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload Loop", "Reload Intro", "Reload Outro", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Dual Wield Right Gun Idle",
                    "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Putaway"  });
                }
                if (WeaponBox.Text == "HK21")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty" });
                }
                if (WeaponBox.Text == "RPK")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================", "Dual Mags Reload",
                    "Duals Mags Reload Empty", "Dual Mags Fast Reload", "Dual Mags Fast Reload Empty" });
                }
                if (WeaponBox.Text == "M60")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Grip Idle", "Grip Fire", "Grip Reload",
                    "Grip Pullout", "Grip Putaway" });
                }
                if (WeaponBox.Text == "Stoner63")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty" });
                }
                if (WeaponBox.Text == "Dragunov")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty"});
                }
                if (WeaponBox.Text == "WA2000")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty"});
                }
                if (WeaponBox.Text == "L96A1")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Cockback", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty"});
                }
                if (WeaponBox.Text == "PSG1")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty"});
                }
                if (WeaponBox.Text == "ASP")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "M1911")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "Makarov")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "Python")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload Loop", "Reload Intro", "Reload Outro", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Speed Reloader Reload",
                    "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "CZ75")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway", "============================================================", "Extended Mags Reload",
                    "Extended Mags Reload Empty", "============================================================",
                    "Dual Wield Right Gun Idle", "Dual Wield Left Gun Idle", "Dual Wield Right Gun Fire", "Dual Wield Left Gun Fire",
                    "Dual Wield Right Gun Reload", "Dual Wield Left Gun Reload", "Dual Wield Right Gun Reload Empty",
                    "Dual Wield Left Gun Reload Empty", "Dual Wield Pullout", "Dual Wield Canswap", "Dual Wield Putaway"});
                }
                if (WeaponBox.Text == "M72 LAW")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway"});
                }
                if (WeaponBox.Text == "RPG")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway"});
                }
                if (WeaponBox.Text == "Strela-3")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Reload Empty", "Pullout", "Canswap",
                    "Putaway"});
                }
                if (WeaponBox.Text == "China Lake")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Cockback", "Reload", "Reload In", "Reload Out", "Pullout", "Canswap",
                    "Putaway"});
                }
                if (WeaponBox.Text == "Ballistic Knife")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Pullout", "Canswap",
                    "Putaway", "Swipe", "Lunge"});
                }
                if (WeaponBox.Text == "Crossbow")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Reload", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Grim Reaper") // viewmodel_m202_idle_loop
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] {"Idle", "Fire", "Reload", "Pullout", "Canswap",
                    "Putaway"});
                }
                if (WeaponBox.Text == "RC-XD") // viewmodel_rc_carbomb_idle
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Carepackage") // viewmodel_supply_drop_idle
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Bomb")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Camera Spike")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Hold Fire", "Pullout", "Canswap", "Putaway" });
                }
                if (WeaponBox.Text == "C4")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Hold Fire", "Detonator Fire", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Tactical Insertion")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Pull Pin", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Jammer")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Hold Fire", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Motion Sensor")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Hold Fire", "Pullout", "Putaway" });
                }
                if (WeaponBox.Text == "Claymore")
                {
                    AnimationBox.Items.Clear();
                    AnimationBox.Items.AddRange(new object[] { "Idle", "Fire", "Hold Fire", "Pullout", "Putaway" });
                }
            }
            catch
            {
                AnimationBox.Items.Clear();
                AnimationBox.Items.AddRange(new object[] { "Please Select A Weapon" });
            }
        }

        private void SetAnimation_Click(object sender, EventArgs e)
        {
            try
            {
                m.OpenProcess("t5m.exe");
                if (WeaponBox.Text == "============================================================")
                {
                    MessageBox.Show("Please select a valid weapon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (WeaponBox.Text == "")
                {
                    MessageBox.Show("Please select a valid weapon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (WeaponBox.Text == "MP5K") // SMGs
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1A8AB4C0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1A8ABAB8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1A8AC2B2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1A8B0DBF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1A8B715B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A8BC4CC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1A8B86DE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1A8BA9D0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A8BD56D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1A8C48C0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A8C969F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Skorpion")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1AAE0184", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1AAE078C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1AAE0FCE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1AAE517F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1AAEA987", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1AAEC276", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1AAEE974", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1AAF7C6A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1AAFBDFF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1AB027C4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1AB02DCC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1AB0360E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1AB07797", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1AB0CF73", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1AB0E866", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1AB10984", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1AB3EB84", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1AB3FA95", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1AB3FF57", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1AB41DE3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1AB73B6B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1AB7366C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1AB76D02", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1AB74ACE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1AB43D9D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1AB45BAB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1AB47E80", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "MAC11")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1A6CA4D8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1A6CAAF4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1A6CB2A7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1A6CFB3F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1A6D5C98", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A6D743C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1A6D6A4A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1A6DFF78", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A6E45A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1A6EB604", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1A6EBC20", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1A6EC3D3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1A6F0C4F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1A6F6D78", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A6FABF0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1A6F7B2A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0x1A6FA1FD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1A7452B4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1A74621C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1A7466D7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1A747682", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1A789C7F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1A789794", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1A78B9A8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1A78AA22", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1A748648", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A74A88C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1A749A08", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "AK74u")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1A43EEE0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1A43F58C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1A43FE47", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1A444687", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1A44A953", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A450FC5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1A44C89F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1A44F433", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A45233F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1A45C786", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A460CBB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1A466C79", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1A469217", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1A46E194", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A4726A7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1A4797D8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1A479E88", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1A47A727", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1A47ED33", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1A484D55", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A488749", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1A486BD3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A48989B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Dual Mags Reload")
                    {
                        m.WriteMemory("0X1A491568", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A495AB0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1A49BBB5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1A49E1C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Extended Mags Reload")
                    {
                        m.WriteMemory("0X1A4A30CC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A4A76DF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1A4AE8D8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1A4AEF90", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1A4AF867", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload Empty")
                    {
                        m.WriteMemory("0X1A4B428F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1A4BA8F3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A4BFB35", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1A4C0EC7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A4BC923", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle (In Launcher)")
                    {
                        m.WriteMemory("0X1A4CCCB4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire (In Launcher)")
                    {
                        m.WriteMemory("0X1A4CD374", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload (In Launcher)")
                    {
                        m.WriteMemory("0X1A4CDE66", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout (In Launcher)")
                    {
                        m.WriteMemory("0X1A4D46B4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A4D6379", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway (In Launcher)")
                    {
                        m.WriteMemory("0X1A4D567A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A4BE4F9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Uzi")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1ACCEAC8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1ACCF244", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1ACCFB72", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1ACD3746", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1ACD8E39", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1ACDEBD3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1ACDA3BE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1ACDD623", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1ACDFDFE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1ACE883A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1ACEC3FE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1ACF2CC0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "PM63")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1A9FD31D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1AA0AF52", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1AA0E7DB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1A9F2358", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1A9F2A30", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A9F330A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1A9F3BE0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1A9F72B5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1A9FB8F6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AA00DE6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1AA13790", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1A9FF83B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AA025B9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1AA59828", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1AA5A6B2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AA5AB9F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1AA5B0DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1AA5C8BB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1AAA9788", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1AAA8CB8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AAA9213", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1AAABE58", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1AAAA3CF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1AA5E1B7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1AA5F4C4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "MPL")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1A96D028", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1A96D958", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1A96E466", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1A972D59", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1A978C5D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1A97ECF2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1A97A54C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1A97D4F5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1A989136", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A98CFCF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1A9924AA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1A99565D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1A99B600", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Spectre")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1AC065AC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1AC06CB8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1AC075BE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1AC0B71B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1AC10BD0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AC16374", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1AC123FD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1AC14E46", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AC177FC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1AC1F6D6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1AC23837", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1AC29FA4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Kiparis")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1A59396C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1A593F70", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1A594950", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1A598015", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1A59C6DF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1A59E56A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1A5A88A6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1A5ABF79", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1A5B1864", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1A5B1E68", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1A5B2848", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1A5B5F11", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1A5BA5DF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1A5BC46E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1A5BE549", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1A60CDFC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1A60DC55", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1A60E1EB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1A654307", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1A653D50", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1A6571C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1A65506D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1A610584", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1A611994", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1A613572", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "M16") // ARs
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1BF7E084", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFAB9BC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFD40DE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFFD5EA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1BF7E688", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFABFFC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFD470C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFFDC10", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1BF7EE3E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFAC7F6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFD4EF2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFFE3EE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1BF823B1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFAFEAD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFD83D9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C001845", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1BF865DA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BF8B93F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFB4302", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFDC50A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C00597E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFBB232", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFE37FD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C00C61C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1BF87961", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFB5888", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFDDA48", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C006EB4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1BF89CDC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BF8D577", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFB7C6C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFDFE00", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C00927C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFBCFC7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFE54EB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C00E2FF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1BFA31B0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1BFA6615", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1BF94D18", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1BF9818C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1BF9C375", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1BF9E90A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1BFC3627", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFC3FB8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1BFC4610", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1BFC9651", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFCC5C6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1BFCB5FD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFB993F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1BFEBBB0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1BFEC1F4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1BFECB8D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1BFED688", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1BFEF738", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1BFF1CC7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1BFF3B6E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFF5CDC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1BFF4D8D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BFE19D3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1C01491C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1C014F5C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1C01598F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1C01A46A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C01D20A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1C01C311", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C00AE3B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Enfield")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B0B97B0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0F86B8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B124FEA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1531F6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B0B9E64", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1256BC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1538D4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0F8CF4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B0BA71A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B125F6D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B15418D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0F94EE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B0BF970", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0FE698", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B12B1C0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B159390", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B0C55F0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0CBDA9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1043DB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B130E94", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B15F164", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B10D3DC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B13A08B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B168330", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B0C760C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1066AD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1331C5", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B161491", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B0CA2F9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B0CD0BE", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B108FFA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B135C13", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B163ED3", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B10C760", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B139322", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1675DE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1B0EBD78", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B0F1374", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1B0D4B98", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B0D9FA6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1B0E000E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1B0E4BD7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1B114818", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Fire")
                    {
                        m.WriteMemory("0X1B114FF8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1B115650", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1B11A36E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B11C216", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B11B501", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B10AAD2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1B1411F4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1B1418DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1B142350", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1B142EE4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1B144F92", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1B1475DD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1B149726", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B14B676", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1B14A8D1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1376E2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1B16F1CC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1B16F8B4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1B1703BB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1B1756E3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1776F2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1B176929", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B16599E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "M14")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1BD78B30", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BD9A1CB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDEB2C0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE1E19E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1BD79C2A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BD9A878", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDEB968", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE1E830", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1BD7B386", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BD9B456", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDED122", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE1FFE6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1BD80590", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDA090C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDF2390", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE25220", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1BD8763E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BD8E013", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BDA7C9A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDF94CA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE2C326", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BDB05E4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE01DF7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE34A4E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1BDA9B73", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B1066AD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDFB387", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE2E1A7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1BD8C59F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BD90439", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BDACD23", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDFE50F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE312F3", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BDB2AAD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE0428D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE36EAD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1BDBA9B4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDBB180", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1BDBB848", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1BDC097D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDC28B6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B11B501", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDAE7C3", "string", this.NewAnimation.Text + "\0"); 
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1BE0C0A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1BE0C760", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1BE0D16E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1BE0DCD1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1BE0FE5D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1BE126A6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1BE145AB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE168A4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1BE158BF", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDFFFA3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1BE3EB80", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1BE3F22C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1BE3FC9C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1BE44A4D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE47899", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1BE4693A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BE32D67", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1BDCB5A6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1BDCC6A6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDCD256", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1BDCDE0E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Empty")
                    {
                        m.WriteMemory("0X1BDD3168", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1BDDA41D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDE0EB5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Canswap")
                    {
                        m.WriteMemory("0X1BDDC2A1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1BDDF3EB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BDE338B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Famas")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B2B4A50", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2EBADC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3170D4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B342D14", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B2B5130", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2EC1D0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3177D0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3433F8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B2B5A72", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2ECC41", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B31812A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B343CCE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B2B9694", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2F0A30", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B31BD58", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3478DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B2BF5A9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2C4D23", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B2F6B29", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B321C01", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B34D75D", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B2FE67D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B329D89", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B354982", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B2C0C2D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2F8299", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3232F1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B34EDC1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B2C37F3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2C5E18", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B2FB09B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B325F94", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B351A4B", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B2FF756", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B328FF1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B355AAA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1B2E1032", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B2E4B72", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1B2CD8DE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B2D14E4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1B2D73DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1B2DB008", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1B3060E4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Fire")
                    {
                        m.WriteMemory("0X1B30690C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1B307008", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1B30C1C0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B2FC68E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B30D90F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B30EA99", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1B3170D4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1B3177D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1B331DB3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload")
                    {
                        m.WriteMemory("0X1B31812A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Empty")
                    {
                        m.WriteMemory("0X1B31BD58", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1B321C01", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B30EA99", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1B325F94", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3274E7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1B35C328", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1B35C9F4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1B35D4FB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1B36280C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B352F97", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1B363A77", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B3647C1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Galil")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1BB42B90", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB802C4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBAE150", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBDCEC4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1BB431F4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB80A6C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBAE80C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBDD538", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1BB43AF6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB813D2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBAF13A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBDDE46", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1BB4860A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB8633E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBB3D60", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBE2966", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1BB4FA78", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB559D7", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BB8DE58", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBBB450", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBE9DFC", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BB95C43", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBC34D6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBF1657", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1BB51AF8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB90087", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBBD6AE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBEBE47", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1BB53CA1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB56B93", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BB922E7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBBF809", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBEDFA3", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1BB96E24", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBC45FC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBF2738", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1BB7308A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1BB77C16", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1BB5E2C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1BB62FDC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1BB6A52B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1BB6CE6F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1BB9DCD8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB9E454", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1BB9EAC0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1BBA3B16", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBA65ED", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1BBA5750", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BB941CE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1BBCAF5C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1BBCB614", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1BBCBFFD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1BBCCBC5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1BBCE921", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1BBD0D32", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1BBD2AFC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBD5451", "string", this.NewAnimation.Text + "\0"); 
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1BBD4622", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBC15BC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1BBF9114", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1BBF9A1D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1BBFA8A9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1BBFF99D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BC023A9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1BC015A8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BBEFD3D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "AUG")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1AEA6CA0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEDC974", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF082B2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF38D36", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1AEA7358", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEDD06C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF08994", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF3940C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1AEA7BD2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEDD93A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF0923E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF39CAA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1AEAC472", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEE242C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF0DA68", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF3E4DE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1AEB1E0E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEB75E9", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1AEE80A7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF1338F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF43DFD", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1AEEF7B0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF1B594", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF4B264", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1AEB3794", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEE99AD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF14CF9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF45759", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1AEB5EEF", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEB856A", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1AEEC147", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF1738F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF47DE9", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1AEF0782", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF1A83B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF4C20E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1AED1548", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1AED5DF2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1AEC0438", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1AEC4CE2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1AECA686", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1AECCD47", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1AEF7A90", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Fire")
                    {
                        m.WriteMemory("0X1AEF8274", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1AEF8980", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1AEFD35A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEFF836", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1AEFE75E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AEED8EF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1AF266D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1AF26DBC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1AF277F1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1AF28335", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1AF2A2C1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1AF2C8D7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1AF2E9D6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF30C84", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1AF2FC92", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF18A8F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1AF52D0C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1AF533F4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1AF53E8F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1AF58C3B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF5AEBE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1AF59EE2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1AF494AB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "FN FAL")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B9534DC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B98A030", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9B5424", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9E1D40", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B953C5F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B98A7EF", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9B5BDF", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9E24E3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B954486", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B98B052", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9B643A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9E2D2A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B958C6A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B98FB44", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9BAD48", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9E75C0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B95EA7A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B962FE1", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B995A85", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C0B3B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9ED447", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B99BC4A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C6C53", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9F32C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B95FDE4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B996E62", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C1EB1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9EE798", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B9612C1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9645FA", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B99841C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C341C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9EFCD0", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B99D25A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C81AE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9F47EE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1B97E8CA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B9830CA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1B96C48E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B971274", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1B977328", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1B979D3C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1B9A447C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9A4C58", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1B9A52D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1B9AA377", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9AD201", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B9AC0D9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B99A2BD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1B9CF2A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1B9CF910", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1B9D0329", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1B9D0F54", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1B9D2E87", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1B9D53CC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1B9D73C9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9D9B15", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1B9D85AC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9C51B5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1B9FBF80", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1B9FC618", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1B9FD029", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1BA01F31", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1BA04D83", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1BA0698F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B9F1A61", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "AK47")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B57AF08", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5B4BC0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5E021A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B60C7C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B57B538", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5B51F8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5E0844", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B60CDD8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B57BD2F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5B5B53", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5E102F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B60D5AF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B580EF4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5BAAB8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5E5D04", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B612262", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B587377", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B58C09C", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B5C131D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5EBD77", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B6183B0", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B5C785E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5F23E9", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B61E5AB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B588802", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5C272A", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5ED17E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B61973E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B58AD52", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B58DD17", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B5C4BE2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5EF5DE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B61BACA", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B5C944B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5F3D6F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B6200D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1B5A8378", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B5AD554", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1B595A60", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B59AC50", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1B5A1105", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1B5A35E2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1B5D0234", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1B5D09A8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1B5D51BD", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5D7AAD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B5D6CB3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5C5ED0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1B5FAC88", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1B5FB2C8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1B5FBC4A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1B5FC7E0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1B5FE503", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1B6008D2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1B6025A0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B606AAB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1B604030", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B5F0874", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1B626894", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1B626EC4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1B627A47", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1B62C842", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B62EF19", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1B62E1D3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B61CD4C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Commando")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B787940", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7BB108", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7E7E22", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B81594A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B787F98", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7BB8EA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7E8830", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B8161E6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B78877B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7BC1AB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7E9033", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B816A27", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B78C5B1", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7C04CC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7ECFD4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B81AA10", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B7918BB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B796009", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B7C5C35", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7F22E2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B81FD95", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B7CCA95", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7F8EBE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B826959", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B792B5F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7C711E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7F37B4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B82387A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B795032", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B797A70", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B7C97EE", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7F5CD2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B82387A", "string", this.NewAnimation.Text + "\0");

                        m.WriteMemory("0X1B7CE6BC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7FA934", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B828440", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1B7B0EC8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B7B4CA7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1B7A0248", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1B7A4170", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1B7A933B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1B7AC16F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Idle")
                    {
                        m.WriteMemory("0X1B7D6104", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Reload")
                    {
                        m.WriteMemory("0X1B7D6ADB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Pullout")
                    {
                        m.WriteMemory("0X1B7DBF33", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7DEB82", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Flamethrower Putaway")
                    {
                        m.WriteMemory("0X1B7DDB7F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7CAAE9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Idle")
                    {
                        m.WriteMemory("0X1B801F88", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Fire")
                    {
                        m.WriteMemory("0X1B8029D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Cockback")
                    {
                        m.WriteMemory("0X1B803431", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Loop")
                    {
                        m.WriteMemory("0X1B804088", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload In")
                    {
                        m.WriteMemory("0X1B806380", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Reload Out")
                    {
                        m.WriteMemory("0X1B808D5F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Pullout")
                    {
                        m.WriteMemory("0X1B80B145", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B80DA73", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Masterkey Putaway")
                    {
                        m.WriteMemory("0X1B80C8BA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B7F6EA5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Idle")
                    {
                        m.WriteMemory("0X1B82FCE0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Fire")
                    {
                        m.WriteMemory("0X1B83056F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Reload")
                    {
                        m.WriteMemory("0X1B83116F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Pullout")
                    {
                        m.WriteMemory("0X1B83630E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B83930E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grenade Launcher Putaway")
                    {
                        m.WriteMemory("0X1B83828C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B82387A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "G11")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1B42FE64", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1B430514", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1B430DAE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1B4361D1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1B43EE03", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B446BCA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1B440644", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1B445609", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1B447CE6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Olympia") // shotgun
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CE89C00", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CE8A208", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1CE8AB52", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1CE90DB8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CE98C0D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE9E2FD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CE9A8EB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CE9C815", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE9FE1F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Stakeout")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CE21320", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CE21938", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Cockback")
                    {
                        m.WriteMemory("0X1CE22213", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Loop")
                    {
                        m.WriteMemory("0X1CE22D83", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload In")
                    {
                        m.WriteMemory("0X1CE245BA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Out")
                    {
                        m.WriteMemory("0X1CE270A5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CE28CA2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE2E56E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CE2AA4A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CE2C81F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE30179", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1CE3847C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1CE38C18", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Cockback")
                    {
                        m.WriteMemory("0X1CE3956F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Loop")
                    {
                        m.WriteMemory("0X1CE3A151", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload In")
                    {
                        m.WriteMemory("0X1CE3B972", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload Out")
                    {
                        m.WriteMemory("0X1CE3E4B6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1CE3FF20", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE43A92", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1CE41D4D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CE4568F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "SPAS-12")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CEEFDA0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CEF03D4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Loop")
                    {
                        m.WriteMemory("0X1CEF0D2C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload In")
                    {
                        m.WriteMemory("0X1CEF28A5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Out")
                    {
                        m.WriteMemory("0X1CEF5B06", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CEF74C6", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CEFCA9F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CEF919C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CEFAC9D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CEFE290", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "HS10")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CDBF0C8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CDBF730", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Loop")
                    {
                        m.WriteMemory("0X1CDBFFC1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload In")
                    {
                        m.WriteMemory("0X1CDC1FB2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Out")
                    {
                        m.WriteMemory("0X1CDC57B7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CDC7F3F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CDCEA2A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CDC9E25", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CDCD009", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CDCFD20", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1CF335DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1CF33A98", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1CF340BA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CF35F2C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1CF37D2C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CF3AF2C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1CF39770", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CF3C5B2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CF7195E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CF712D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CF73D94", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CF71E9C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "HK21") // LMGs
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C0FB188", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C0FB9E0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C0FC39D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C1012AA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C107B48", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C10D4E9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C109015", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C10C357", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C10E4F9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C115D5C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C11B1E3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "RPK")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C3F4B84", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C3F52A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C3F5C6C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C3FBD46", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C4033C4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C40851E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C404779", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C4073B4", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C4093AD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C428CD8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C42D011", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload")
                    {
                        m.WriteMemory("0X1C411940", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C41793E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload")
                    {
                        m.WriteMemory("0X1C41EE79", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Mags Fast Reload Empty")
                    {
                        m.WriteMemory("0X1C42305F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "M60")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C2A7DEC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C2A856C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C2A92B5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C107B48", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C2B8F71", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C2BA9B6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Idle")
                    {
                        m.WriteMemory("0X1C2C356B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Fire")
                    {
                        m.WriteMemory("0X1C2C3ED4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Reload")
                    {
                        m.WriteMemory("0X1C2C4E09", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Pullout")
                    {
                        m.WriteMemory("0X1C2D2D80", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Grip Putaway")
                    {
                        m.WriteMemory("0X1C2D47F4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Stoner63")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C4F982C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C4F9F2C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C4FA7B5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C4FEFF1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C504B08", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C507B80", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C5068DC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C508CDA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C50F93C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C5140D5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Dragunov") // Snipers
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C6185C8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C618BE0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C619565", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C61F11C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C625D7E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C62E6E5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C628FDC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C62C6D3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C6301DA", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C6372C0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C63CE5C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "WA2000")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C954954", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C9550B0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C955AA5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C95AC16", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C960F11", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C969F59", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C964572", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C967338", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C96B771", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C9739D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C978B36", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "L96A1")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C716D08", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C717320", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Cockback")
                    {
                        m.WriteMemory("0X1C717B60", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C71A05C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C71F3E1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C72722E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C72F422", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C729C56", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C72CC84", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C730DE6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C73A8D6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C73FBB7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "PSG1")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C860C6C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C861434", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C861E29", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C866CD1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C86E741", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C878294", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C8721E7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C874FDB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C879E97", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1C881160", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1C885CF7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "ASP") // Pistols
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1C9AAED8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1C9AB4D8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1C9ABCCF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1C9AC4E4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1C9AF401", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1C9B257B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1C9B4864", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1C9B6E11", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1C9E0E68", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1C9E1C9D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1C9E2121", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1C9E3839", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1C9E53BD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1C9E678A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1C9E86B2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CA12502", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CA12058", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CA14F98", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CA13416", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "M1911")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CB10918", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CB10F28", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CB11548", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CB11E73", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1CB1287E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1CB15AC7", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CB18EF2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CB1AC73", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CB1D853", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1CB2DDD0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1CB30ED4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1CB62BF0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1CB63A45", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1CB6444E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CB65EB4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1CB69025", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1CB6A466", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1CB6E907", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CBA4E66", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CBA43D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CBA8CC8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CBA5D06", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Makarov")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CBE4EC4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CBE54D0", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CBE5DFF", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1CBE6733", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1CBE9A78", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CBECF90", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CBEECD1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CBF1932", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1CBF9C28", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1CBFCE50", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1CC2CD14", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1CC2DB19", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1CC2E055", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CC2F8CC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1CC3166E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1CC32A52", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1CC3490E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CC68A91", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CC68544", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CC6B70E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CC699BE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Python")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CCDFE4C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CBE54D0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Loop")
                    {
                        m.WriteMemory("0X1CCE1041", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload In")
                    {
                        m.WriteMemory("0X1CCE2F5F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Out")
                    {
                        m.WriteMemory("0X1CCE7084", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CCEA137", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CCEC672", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CCF0085", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Speed Reloader Reload")
                    {
                        m.WriteMemory("0X1CCF86A8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CCFB980", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1CD3F0BC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1CD40036", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1CD407F8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1CD42FD0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1CD44917", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1CD474F3", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CD8D22F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CD8C9FC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CD8E2B6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "CZ75")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CA4DF4C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CA4E560", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CA4EF4D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1CA4F94A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Empty")
                    {
                        m.WriteMemory("0X1CA52C58", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CA5683E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CA58553", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CA5AD75", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload")
                    {
                        m.WriteMemory("0X1CA63D6C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Extended Mags Reload Empty")
                    {
                        m.WriteMemory("0X1CA67054", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Idle")
                    {
                        m.WriteMemory("0X1CA9625C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Fire")
                    {
                        m.WriteMemory("0X1CA97988", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload")
                    {
                        m.WriteMemory("0X1CA98400", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Right Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CA99F98", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Pullout")
                    {
                        m.WriteMemory("0X1CA9BDC2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Canswap")
                    {
                        m.WriteMemory("0X1CA9D1F6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Putaway")
                    {
                        m.WriteMemory("0X1CA9F0FC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Idle")
                    {
                        m.WriteMemory("0X1CAD4038", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Fire")
                    {
                        m.WriteMemory("0X1CAD3538", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload")
                    {
                        m.WriteMemory("0X1CAD6D9E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Dual Wield Left Gun Reload Empty")
                    {
                        m.WriteMemory("0X1CAD4EF1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "M72 LAW")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D07C2F8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D07C930", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1D07D5B9", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D080F8B", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D08C4E5", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1D0840FE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D0892B7", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D08D3CB", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "RPG")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D0E49DC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D0E4FEC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D0E5948", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1D0E6433", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D0E95FC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D0EAB54", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Strela-3")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1CFEBE8C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1CFEC5C8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1CFECE2E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1CFEE8A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1CFEFC4F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1CFF14CB", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1CFF2425", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "China Lake")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D137020", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D137640", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Cockback")
                    {
                        m.WriteMemory("0X1D138432", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Loop")
                    {
                        m.WriteMemory("0X1D13A2B1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload In")
                    {
                        m.WriteMemory("0X1D13C9A0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload Out")
                    {
                        m.WriteMemory("0X1D140459", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D141FD3", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D14954D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1D144D7A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D147175", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0x1D14B121", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Ballistic Knife")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D416CD4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D419E32", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1D41D9E8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D42086F", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D425D50", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1D422B07", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D424A75", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Swipe")
                    {
                        m.WriteMemory("0X1D41AF69", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Lunge")
                    {
                        m.WriteMemory("0X1D41C0F2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Crossbow")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D20E574", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D20EC3C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D20F44E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D21265E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1D212F7B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D217842", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D219C6C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D21BBF1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D218B31", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D21AF4D", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D21D03A", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Grim Reaper")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D29C9AC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D29D7AC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Reload")
                    {
                        m.WriteMemory("0X1D29E3A1", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D2A5EEC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D2AD3CE", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D2AA252", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D2AEE7E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "RC-XD")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D58B1EC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D58B7F8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D58E455", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Carepackage")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D68B7EC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D68EE0F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D68FC06", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Bomb")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1DBE96B0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1DBEA79D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1DBEE36E", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1DBEFF04", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Camera Spike")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D7ECEB0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D7EDAB8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Hold Fire")
                    {
                        m.WriteMemory("0X1D7EE8A4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D7EF342", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1D7F186E", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D7F0C4B", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "C4")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D47655C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D4838E4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D476C60", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D4838F6", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Hold Fire")
                    {
                        m.WriteMemory("0X1D478CD8", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D483908", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Detonator Fire")
                    {
                        m.WriteMemory("0X1D481E24", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D4839C2", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D4799AC", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D48391F", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Canswap")
                    {
                        m.WriteMemory("0X1D47E2FA", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D47F08C", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D483949", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D483962", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D47C2C2", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D483934", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Tactical Insertion")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D8E1DA4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0X1D8E23B0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pull Pin")
                    {
                        m.WriteMemory("0X1D8E45DD", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D8E741C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D8E7E4D", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Jammer")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D977BF4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0x1D9781D4", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Hold Fire")
                    {
                        m.WriteMemory("0X1D978CB0", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D979735", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D97C676", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D97B0DC", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Motion Sensor")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D8B5780", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0x1D8B5D7C", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Hold Fire")
                    {
                        m.WriteMemory("0X1D8B6544", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D8B6F26", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D8B7E88", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (WeaponBox.Text == "Claymore")
                {
                    if (AnimationBox.Text == "============================================================")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "")
                    {
                        MessageBox.Show("Please select a valid animation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (AnimationBox.Text == "Idle")
                    {
                        m.WriteMemory("0X1D720F90", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D7215C8", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Fire")
                    {
                        m.WriteMemory("0x1D721C04", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0x1D725802", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Hold Fire")
                    {
                        m.WriteMemory("0X1D724907", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Pullout")
                    {
                        m.WriteMemory("0X1D726982", "string", this.NewAnimation.Text + "\0");
                        m.WriteMemory("0X1D729E12", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AnimationBox.Text == "Putaway")
                    {
                        m.WriteMemory("0X1D728687", "string", this.NewAnimation.Text + "\0");
                        MessageBox.Show(WeaponBox.Text + "'s " + AnimationBox.Text + " animation has changed to " + NewAnimation.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
        }

        private void AnimList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/fHACdhvK");
            this.AnimList.LinkVisited = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(KnifeLungeToggle == false)
                {
                    m.WriteMemory("0X1D3D3818", "string", "viewmodel_m4m203_knife_melee_2");
                    m.WriteMemory("0X1D3D6DE8", "string", "viewmodel_M4m203_knife_melee_2");
                    MessageBox.Show("Always knife lunge is now [ON]", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KnifeLungeToggle = true;
                }
                else if(KnifeLungeToggle == true)
                {
                    m.WriteMemory("0X1D3D3818", "string", "viewmodel_m4m203_knife_melee_1");
                    m.WriteMemory("0X1D3D6DE8", "string", "viewmodel_M4m203_knife_melee_1");
                    MessageBox.Show("Always knife lunge is now [OFF]", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KnifeLungeToggle = false;
                }
                
            }
            catch
            {

            }
        }
    }
}
