using IIDKQuest.Classes;
using IIDKQuest.Mods;
using static IIDKQuest.Settings;

namespace IIDKQuest.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Creds", method =() => SettingsMods.Creds(), isTogglable = false, toolTip = "Open Creds."},
                new ButtonInfo { buttonText = "Room Mods", method =() => SettingsMods.RoomMods(), isTogglable = false, toolTip = "Open Room mods."},
                new ButtonInfo { buttonText = "Basic Mods", method =() => SettingsMods.RigMods(), isTogglable = false, toolTip = "Open rig mods."},
                new ButtonInfo { buttonText = "Visual Mods", method =() => SettingsMods.VisualMods(), isTogglable = false, toolTip = "Open Visual mods."},
                new ButtonInfo { buttonText = "Fun Mods", method =() => SettingsMods.FunMods(), isTogglable = false, toolTip = "Open Fun mods."},
                new ButtonInfo { buttonText = "Custom Ids", method =() => SettingsMods.IDs(), isTogglable = false, toolTip = "Open op mods."},
                new ButtonInfo { buttonText = "Op Mods", method =() => SettingsMods.OpMods(), isTogglable = false, toolTip = "Open op mods."},
                
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Visual", method =() => SettingsMods.VisualSettings(), isTogglable = false, toolTip = "Opens the visual settings for the menu."},
               
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = "MOTD Text", method =() => MOTDTEXT.motd(), toolTip = "Description"},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },
            
            new ButtonInfo[] { // Visual Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "1", method =() => GRAPHICS.Graphics1(), toolTip = "1"},
                new ButtonInfo { buttonText = "2", method =() => GRAPHICS.Graphics2(), toolTip = "2"},
                new ButtonInfo { buttonText = "3", method =() => GRAPHICS.Graphics3(), toolTip = "3"},
                new ButtonInfo { buttonText = "4", method =() => GRAPHICS.Graphics4(), toolTip = "4"},
                new ButtonInfo { buttonText = "5", method =() => GRAPHICS.Graphics5(), toolTip = "5"},
                new ButtonInfo { buttonText = "6", method =() => GRAPHICS.Graphics6(), toolTip = "6"},
                new ButtonInfo { buttonText = "7", method =() => GRAPHICS.Graphics7(), toolTip = "7"},
                new ButtonInfo { buttonText = "8", method =() => GRAPHICS.Graphics8(), toolTip = "8"},
                new ButtonInfo { buttonText = "Reset", method =() => GRAPHICS.Reset(), toolTip = "go back to normal"},
                new ButtonInfo { buttonText = "Red Theme <color=red>[NW]</color>", method =() => VisualMods.RedTheme(), toolTip = "Description"},
            },
            
            new ButtonInfo[] { // Rig Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms <color=lime>[W]</color>", method =() => OpMods.PlatformsPlank(), toolTip = "kool"},
                new ButtonInfo { buttonText = "Ghost Monke <color=lime>[W]</color>", method =() => RigMods.ghostmonke(), toolTip = "mhm dad"},
                new ButtonInfo { buttonText = "Invis Monke <color=lime>[W?]</color>", method =() => RigMods.invismonke(), toolTip = "mmmm"},
                new ButtonInfo { buttonText = "Spaz Monke <color=lime>[W]</color>", method =() => RigMods.SpazMonk(), toolTip = "Spaz monke is the name"},
                new ButtonInfo { buttonText = "Mosa speed boost <color=lime>[W]</color>", method =() => RigMods.MosaSpeedBoost(), toolTip = "Makes you a bit faster"},
                new ButtonInfo { buttonText = "Long Arms <color=lime>[W]</color>", method =() => RigMods.steamlongarms(), toolTip = "get long arms"},
                new ButtonInfo { buttonText = "Reset arms <color=lime>[W]</color>", method =() => RigMods.ResetArms(), toolTip = "Its the name..."},
                new ButtonInfo { buttonText = "Spin Head X <color=lime>[W]</color>", method =() => RigMods.HeadSpinX(), toolTip = "x"},
                new ButtonInfo { buttonText = "Spin Head Y <color=lime>[W]</color>", method =() => RigMods.HeadSpinY(), toolTip = "Y"},
                new ButtonInfo { buttonText = "Spin Head Z <color=lime>[W]</color>", method =() => RigMods.HeadSpinZ(), toolTip = "Z"},
                new ButtonInfo { buttonText = "Fix Head <color=lime>[W]</color>", method =() => RigMods.FixHead(), toolTip = "Fix"},
                new ButtonInfo { buttonText = "Fly  <color=lime>[W]</color>", method =() => RigMods.fly(), toolTip = "fly like a bird"},
                new ButtonInfo { buttonText = "Rig Spam <color=lime>[W]</color>", method =() => RigMods.RigSpam(), toolTip = "spam"},
                new ButtonInfo { buttonText = "Force Tag freeze <color=lime>[W]</color>", method =() => RigMods.ForceTagFreeze(), toolTip = "The name says it all"},
                new ButtonInfo { buttonText = "No Tag Freeze <color=lime>[W]</color>", method =() => RigMods.notag(), toolTip = "THE NAME"},
            },
            
            new ButtonInfo[] { // Op Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Crash <color=lime>[W]</color>", method =() => OpMods.CrashMod(), toolTip = "Crash People"},
                new ButtonInfo { buttonText = "Crash Gun <color=lime>[W]</color> <color=purple>[M]</color>", method =() => OpMods.Crashgun(), toolTip = "Crash People With a gun"},
                new ButtonInfo { buttonText = "Lag All <color=lime>[W]</color>", method =() => OpMods.LagAll(), toolTip = "Lag All"},
                new ButtonInfo { buttonText = "All cosmetics <color=lime>[W]</color>", method =() => OpMods.Cosmetc(), toolTip = "get all cosmetics"},
                new ButtonInfo { buttonText = "Set Master <color=lime>[W]</color>", method =() => OpMods.SetMaster(), toolTip = "Set Master"},
                 new ButtonInfo { buttonText = "Disable Network triggers <color=lime>[W]</color>", method =() => OpMods.DisableNetworkTriggers(), toolTip = "Disable Network triggers"},
                new ButtonInfo { buttonText = "Enable Network Triggers <color=lime>[W]</color>", method =() => OpMods.EnableNetworkTriggers(), toolTip = "Enable Network Triggers"},
                new ButtonInfo { buttonText = "Give Shiny Rocks  <color=lime>[W]</color>", method =() => OpMods.givesr(), toolTip = "get lots of sr"},
                new ButtonInfo { buttonText = "Slow All <color=lime>[W]</color>", method =() => OpMods.slowall(), toolTip = "Slow all with your goo"}, 
              
            },
            
            new ButtonInfo[] { // Visual Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "FullBright <color=lime>[W]</color>", method =() => VisualMods.FullBright(), toolTip = "MY EYES"},
                new ButtonInfo { buttonText = "Full dark <color=lime>[W]</color> <color=yellow>[Buggy]</color>", method =() => VisualMods.FullDark(), toolTip = "keep it kool"},
                new ButtonInfo { buttonText = "Strobe <color=lime>[W]</color>", method =() => VisualMods.StrobeColor(), toolTip = "WOAHHH"},
                new ButtonInfo { buttonText = "Strobe Red <color=lime>[W]</color>", method =() => VisualMods.RedStrobe(), toolTip = "Strobe but all red"},
                new ButtonInfo { buttonText = "Charms  <color=lime>[W]</color>", method =() => VisualMods.CHAMS(), toolTip = "see everywhere"},
                new ButtonInfo { buttonText = "Becons <color=lime>[W]</color>", method =() => VisualMods.Beacons(), toolTip = " I C U"},
                new ButtonInfo { buttonText = "Spaz Names <color=lime>[W]</color> ", method =() => RigMods.SpazGorillaName(), toolTip = "Description"},             
                 
            },
            
            new ButtonInfo[] { // Fun Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Casual <color=lime>[W]</color>", method =() => FunMods.Casual(), toolTip = "change gamemode"},
                new ButtonInfo { buttonText = "Infection <color=lime>[W]</color>", method =() => FunMods.Infection(), toolTip = "change gamemode"},
                new ButtonInfo { buttonText = "Hunt <color=lime>[W]</color>", method =() => FunMods.hunt1(), toolTip = "change gamemode"},
                new ButtonInfo { buttonText = "loud HandTaps <color=lime>[W]</color>", method =() => FunMods.LoudHandTaps(), toolTip = "loud"},
                new ButtonInfo { buttonText = "Silent Handtaps <color=lime>[W]</color>", method =() => FunMods.SilentHandTaps(), toolTip = "Silent"},
                new ButtonInfo { buttonText = "Fix HandTaps <color=lime>[W]</color>", method =() => FunMods.FixHandTaps(), toolTip = "Fix"},
                new ButtonInfo { buttonText = "Cum  <color=lime>[W]</color>", method =() => FunMods.cum1(), toolTip = "OoOoOo"},
                new ButtonInfo { buttonText = "Cube rain  <color=lime>[W?]</color>", method =() => FunMods.cubes_spawner(), toolTip = "make it rain"},
                new ButtonInfo { buttonText = "Mat All <color=Red>[NW]</color>", method =() => FunMods.materiall(), toolTip = "Mat all"},
                new ButtonInfo { buttonText = "UnTag Gun  <color=lime>[W?]</color>", method =() => FunMods.UnTagGun(), toolTip = "Untag a player"},
                new ButtonInfo { buttonText = "High gravity <color=lime>[W]</color>", method =() => FunMods.HighGrav(), toolTip = "aka pbbv walk"},
                new ButtonInfo { buttonText = "Low Gravity <color=lime>[W]</color>", method =() => FunMods.LowGrav(), toolTip = "Space"},
                new ButtonInfo { buttonText = "Normal Gravity <color=lime>[W]</color>", method =() => FunMods.DefaultGrav(), toolTip = "Normal Grav"},
                new ButtonInfo { buttonText = "Give all watch <color=lime>[W]</color>", method =() => FunMods.givewatchall(), toolTip = "name ahhhh"},
                
            },
            
            new ButtonInfo[] { // Room Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                
                new ButtonInfo { buttonText = "Lock Room <color=purple>[M]</color>", method =() => FunMods.LockRoom(), toolTip = "Lock any room you do need master"},
            },
            
            new ButtonInfo[] { // custom ids
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "IDumbk Menu Owner Id <color=lime>[W]</color>", method =() => CustomIDs.IDumbkOwnerId(), toolTip = "Reel"},

                new ButtonInfo { buttonText = "Genisist Crunk Id <color=lime>[W]</color>", method =() => CustomIDs.OWNERName(), toolTip = "Description"},
                new ButtonInfo { buttonText = "UMS FAKE OWNER ID <color=lime>[W]</color>", method =() => CustomIDs.FAKEUMSOWNERID(), toolTip = "Description"},
            },

            new ButtonInfo[] { // Creds
             new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
            new ButtonInfo { buttonText = "RealX- Founder/Developer/tester", method =() => GRAPHICS.Reset(), toolTip = "Description"},
            new ButtonInfo { buttonText = "genesis.t- Co-Owner/Helper", method =() => GRAPHICS.Reset(), toolTip = "Description"},
             new ButtonInfo { buttonText = "Popcat- Helper", method =() => GRAPHICS.Reset(), toolTip = "Description"},
            
            },
            
            new ButtonInfo[] { // Owner Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                
                
            },
            
            
           
            
            
        };
    }
}
