using UnityEngine;
using GorillaLocomotion;
using easyInputs;
using easyInputs;
using GorillaLocomotion;
using UnityEngine;
using easyInputs;
using GorillaLocomotion;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace IIDKQuest.Mods
{
    public class RigMods
    {
        public static void SpazMonk()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
            {
                GorillaTagger.Instance.myVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360),
                    (float)Random.Range(0, 360), (float)Random.Range(0, 360));
                GorillaTagger.Instance.myVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360),
                    (float)Random.Range(0, 360), (float)Random.Range(0, 360));
                GorillaTagger.Instance.myVRRig.rightHand.rigTarget.eulerAngles = new Vector3(
                    (float)Random.Range(0, 360),
                    (float)Random.Range(0, 360), (float)Random.Range(0, 360));
                GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3(
                    (float)Random.Range(0, 360),
                    (float)Random.Range(0, 180), (float)Random.Range(0, 180));
                GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles =
                    new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
                GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles =
                    new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
            }
        }


        public static void MosaSpeedBoost()
        {
            Player.Instance.maxJumpSpeed = 7.5f;
            Player.Instance.jumpMultiplier = 3.5f;
        }

        public static void steamlongarms()
        {
            ((Component)Player.Instance).transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
        }

        public static void ResetArms()
        {
            ((Component)Player.Instance).transform.localScale = new Vector3(1f, 1f, 1f);
        }
        
        
        

        public static void HeadSpinX()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset =
                GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(15f, 0f, 0f);
        }

        public static void HeadSpinY()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset =
                GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(0f, 15f, 0f);
        }

        public static void HeadSpinZ()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset =
                GorillaTagger.Instance.myVRRig.head.trackingRotationOffset + new Vector3(0f, 0f, 15f);
        }

        public static void FixHead()
        {
            GorillaTagger.Instance.myVRRig.head.trackingRotationOffset = new Vector3(0f, 0f, 0f);
        }

        public static void notag() => Player.Instance.disableMovement = false;


        public static void fly()
        {
            if (!EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand))
                return;
            Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 45f;
        }

        public static void RigSpam()
        {
            if (!EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
                return;
            UnityEngine.Object.Destroy((UnityEngine.Object)GorillaTagger.Instance.myVRRig);
            GorillaGameManager instance = GorillaGameManager.instance;
            int count = instance.playerVRRigDict.Count;
            int num = -4;
            instance.NewVRRig(PhotonNetwork.LocalPlayer, count, num != 0);
            PhotonNetwork.Instantiate("PhotonVR/Player",
                GorillaLocomotion.Player.Instance.transform.position + new Vector3(0.0f, 0.4f, 0.0f),
                GorillaLocomotion.Player.Instance.transform.rotation, (byte)90);
            PhotonNetwork.Instantiate("PhotonVR/Player",
                GorillaLocomotion.Player.Instance.transform.position + new Vector3(0.0f, 0.4f, 0.0f),
                GorillaLocomotion.Player.Instance.transform.rotation);
        }
    

        public static void rigdupee()
        {
            if (!EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
                return;
            Object.Destroy((Object)GorillaTagger.Instance.myVRRig);
            GorillaGameManager instance = GorillaGameManager.instance;
            int count = instance.playerVRRigDict.Count;
            int num = -4;
            instance.NewVRRig(PhotonNetwork.LocalPlayer, count, num != 0);
            PhotonNetwork.Instantiate("PhotonVR/Player",
                Player.Instance.transform.position + new Vector3(0.0f, 0.4f, 0.0f), Player.Instance.transform.rotation,
                (byte)90);
            PhotonNetwork.Instantiate("PhotonVR/Player",
                Player.Instance.transform.position + new Vector3(0.0f, 0.4f, 0.0f), Player.Instance.transform.rotation);
        }

        public static void TpToStump()
        {
            if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand))
            {
                foreach (Collider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    collider.enabled = false;
                Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
            }
            else
            {
                foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    if (!meshCollider.enabled)
                        meshCollider.enabled = true;
                    else
                        break;
                }
            }
        }

        public static void ghostmonke()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.myVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.mainSkin.enabled = true;
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.color =
                    (Color)new Color32((byte)0, byte.MaxValue, byte.MaxValue, (byte)50);
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.mainSkin.enabled = false;
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader =
                    GorillaTagger.Instance.myVRRig.mainSkin.material.shader;
                GorillaTagger.Instance.myVRRig.enabled = true;
            }
        }

        public static void invismonke()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
            {
                GorillaTagger.Instance.myVRRig.transform.position = new Vector3(100000f, 100000f, 100000f);
                GorillaTagger.Instance.myVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.mainSkin.enabled = true;
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.color =
                    (Color)new Color32((byte)0, byte.MaxValue, byte.MaxValue, (byte)50);
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.mainSkin.enabled = false;
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader =
                    GorillaTagger.Instance.myVRRig.mainSkin.material.shader;
                GorillaTagger.Instance.myVRRig.enabled = true;
            }
        }

        public static void SpazGorillaName()
        {
            string[] array = new string[]
            {
                "UMS ON TOP",
                "BSU SUCKS",
                "L",
                "UMS ON TOP",
                "BSU SUCKS",
                "L",
                "UMS ON TOP",
                "BSU SUCKS",
                "L",
                "UMS ON TOP",
                "BSU SUCKS",
                "UMS ON TOP",
                "BSU SUCKS",
                "L",
                "UMS ON TOP",
                "BSU SUCKS",
            };
            int num = new System.Random().Next(array.Length);
            PhotonNetwork.LocalPlayer.NickName = array[num];
            GorillaComputer.instance.currentName = array[num];
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", array[num]);
        }
    
        

        // by the sigma of sigma realx
        public static void onmenustart()
        {
            Application.OpenURL("https://discord.gg/eGHr2RhgWy");
        }

        public static void ForceTagFreeze() => GorillaLocomotion.Player.Instance.disableMovement = true;
    }
}

            
        
    
    