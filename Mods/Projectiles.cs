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
    public class Projectiles
    {
          public static void ProjectileSpam()
    {
      if (EasyInputs.GetGripButtonDown((EasyHand) 1))
        PhotonNetwork.Instantiate("bulletPrefab", GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.rotation, (byte) 0, (Il2CppReferenceArray<Object>) null);
      if (!EasyInputs.GetGripButtonDown((EasyHand) 0))
        return;
      PhotonNetwork.Instantiate("bulletPrefab", GorillaTagger.Instance.leftHandTransform.position, GorillaTagger.Instance.leftHandTransform.rotation, (byte) 0, (Il2CppReferenceArray<Object>) null);
    }

    public static void Urine()
    {
      if (!EasyInputs.GetGripButtonDown((EasyHand) 1))
        return;
      PhotonNetwork.Instantiate("bulletPrefab", Vector3.op_Addition(((Component) GorillaTagger.Instance.bodyCollider).transform.position, new Vector3(0.0f, -0.15f, 0.0f)), ((Component) GorillaTagger.Instance.bodyCollider).transform.rotation, (byte) 0, (Il2CppReferenceArray<Object>) null);
    }


           
           
           }
           
        }
    