using System;
using System.Linq;
using easyInputs;
using ExitGames.Client.Photon;
using Photon.Pun;
using PlayFab.ClientModels;
using PlayFab;
using GorillaNetworking;
using UnityEngine;
using UnhollowerBaseLib;
using UnityEngine.UI;
using System.Reflection;
using GorillaLocomotion;
using GorillaNetworking;
using UnityEngine;
using GorillaModManager;
using Random = System.Random;

namespace IIDKQuest.Mods
{
    public class CustomIDs
    {
        public static void IDumbkOwnerId()
        {
            string[] strArray = new string[5]
            {
                "<color=orange>IDumbK Menu</color>\n<color=orange>Owner</color>",
                "<color=orange>IDumbK Menu</color>\n<color=orange>Owner</color>",
                "<color=orange>IDumbK Menu</color>\n<color=orange>Owner</color>",
                "<color=orange>IDumbK Menu</color>\n<color=orange>Owner</color>",
                "<color=orange>IDumbK Menu</color>\n<color=orange>Owner</color>"
            };
            int index = new Random().Next(strArray.Length);
            PhotonNetwork.LocalPlayer.NickName = strArray[index];
            GorillaComputer.instance.currentName = strArray[index];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", strArray[index]);
            PhotonNetwork.LocalPlayer.UserId = "CANT BAN ME BOZO\n\n\n\n\n\n\n\n\n\n\n\n";
        }
        
        public static void ZinxOwnerId()
        {
            string[] strArray = new string[5]
            {
                "<color=black>Secret Service Menu</color>\n<color=gray>Owner</color>",
                "<color=black>Secret Service Menu</color>\n<color=gray>Owner</color>",
                "<color=white>Secret Service Menu</color>\n<color=gray>Owner</color>",
                "<color=white>Secret Service Menu</color>\n<color=gray>Owner</color>",
                "<color=black>Secret Service Menu</color>\n<color=gray>Owner</color>"
            };
            int index = new Random().Next(strArray.Length);
            PhotonNetwork.LocalPlayer.NickName = strArray[index];
            GorillaComputer.instance.currentName = strArray[index];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", strArray[index]);
            PhotonNetwork.LocalPlayer.UserId = "CANT BAN ME BOZO\n\n\n\n\n\n\n\n\n\n\n\n";
        }
        //Reel Use it lol
        public static void OWNERName()
        {
            string[] strArray = new string[6]
            {
                "<color=grey> SHIBAGT GENESIS [TESTER/DEV/CRUNK]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP",
                "<color=black>SHIBAGT GENESIS [TESTER/DEV/CRUNK]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP",
                "<color=grey> SHIBAGT GENESIS [TESTER/DEV/CRUNK]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP",
                "<color=black>SHIBAGT GENESIS [TESTER/DEV/CRUNK ]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP",
                "<color=grey> SHIBAGT GENESIS [TESTER/DEV/CRUNK ]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP",
                "<color=black>SHIBAGT GENESIS [TESTER/DEV/CRUNK ]</color>\ndiscord.gg/pJc2KQFBDR\n\n\n\n\n\nID: HE63JGF92BS01EGS2 \n '''@everyone SHIBAGT GENESIS ON TOP"
            };
            int index = new System.Random().Next(strArray.Length);
            PhotonNetwork.LocalPlayer.NickName = strArray[index];
            GorillaComputer.instance.currentName = strArray[index];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", strArray[index]);
            PhotonNetwork.LocalPlayer.UserId = "SHIBAGT GENSIS[USER]\n\nANTIBAN\n\nID: HE63JGF92BS01EGS2\n\nSHIBAGT GENESIS ON TOP\n\nID: A42J56S783JFG";
        }

        public static void FAKEUMSOWNERID()
        {
            string[] strArray = new string[5]
            {
                "<color=black>FAKE UMS OWNER</color>\ndiscord.gg/eGHr2RhgWy",
                "<color=red>FAKE UMS OWNER</color>\ndiscord.gg/eGHr2RhgWy",
                "<color=black>FAKE UMS OWNER</color>\ndiscord.gg/eGHr2RhgWy",
                "<color=red>FAKE UMS OWNER</color>\ndiscord.gg/eGHr2RhgWy",
                "<color=black>FAKE UMS OWNER</color>\ndiscord.gg/eGHr2RhgWy"
            };
            int index = new Random().Next(strArray.Length);
            PhotonNetwork.LocalPlayer.NickName = strArray[index];
            GorillaComputer.instance.currentName = strArray[index];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", strArray[index]);
            PhotonNetwork.LocalPlayer.UserId = "CANT BAN ME BOZO\n\n\n\n\n\n\n\n\n\n\n\n";
        }

    }
}