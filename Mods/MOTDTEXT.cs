using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest.Mods
{
    public class MOTDTEXT
    {
        public static void motd()
        {
            GameObject.Find(nameof (motd)).GetComponent<Text>().text = "<color=purple> UMS CLIENT </color>";
            GameObject.Find("motdtext").GetComponent<Text>().text = "Thank you for downloading and giving this menu a chance. I am still working on it. Thanks";
            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "CURRENT VERSION V1.0.0";
            GameObject.Find("COC Text").GetComponent<Text>().text = "MENU TYPE: <color=lime> FREE </color>/<color=purple>TEST</color>";
        }
    }
}