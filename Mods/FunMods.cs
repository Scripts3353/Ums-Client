﻿using ExitGames.Client.Photon;
using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity.UtilityScripts;
using PlayFab.ClientModels;
using PlayFab;
using POpusCodec.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.UI.GridLayoutGroup;
using System.Runtime.InteropServices;
using UnityEngine;
using GorillaLocomotion;
using easyInputs;
using Object = UnityEngine.Object;
using Player = GorillaLocomotion.Player;
using Random = UnityEngine.Random;
using easyInputs;
using GorillaNetworking;
using Photon.Voice.Unity;
using Photon.Voice.Unity.UtilityScripts;
using POpusCodec.Enums;
using System.IO;
using IIDKQuest.Menu;
using UnityEngine;

namespace IIDKQuest.Mods
{
    public class FunMods
    {
        public static void LoudHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = int.MaxValue;
        }

        public static void SilentHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = 0;
        }

        public static void FixHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = 0.1f;
        }

        public static void Casual()
        {
            if (PhotonNetwork.CurrentRoom != null)
            {
                ExitGames.Client.Photon.Hashtable hashtable2 = new ExitGames.Client.Photon.Hashtable();
                hashtable2.Add("gameMode", "forestcitycanyonsmountainscavesDEFAULTMODDED_MODDED_CASUALCASUAL");
                PhotonNetwork.CurrentRoom.SetCustomProperties(hashtable2, null, null);
            }
        }

        public static void Infection()
        {
            if (PhotonNetwork.CurrentRoom != null)
            {
                ExitGames.Client.Photon.Hashtable hashtable3 = new ExitGames.Client.Photon.Hashtable();
                hashtable3.Add("gameMode", "forestcanyonsmountainscavesDEFAULTMODDED_MODDED_INFECTION");
                PhotonNetwork.CurrentRoom.SetCustomProperties(hashtable3, null, null);
            }
        }

        public static void hunt1()
        {
            PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            foreach (GorillaGameManager gorillaGameManager in
                     UnityEngine.Object.FindObjectsOfType<GorillaGameManager>())
            {
                if (!gorillaGameManager.photonView.IsMine)
                    gorillaGameManager.photonView.RequestOwnership();
                if (gorillaGameManager.photonView.IsMine)
                    PhotonNetwork.Destroy(gorillaGameManager.photonView);
            }

            Hashtable propertiesToSet = new Hashtable();
            propertiesToSet.Add((Il2CppSystem.Object)"gameMode", (Il2CppSystem.Object)"Hunt");
            PhotonNetwork.CurrentRoom.SetCustomProperties(propertiesToSet);
        }

        public static void cum1()
        {
            EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand);
            Vector3 position = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                               GorillaTagger.Instance.myVRRig.transform.forward.normalized * 0.5f;
            Quaternion rotation =
                GorillaTagger.Instance.myVRRig.transform.rotation * Quaternion.Euler(0.0f, 90f, 0.0f);
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
            Vector3 vector3_1 = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                                GorillaTagger.Instance.myVRRig.transform.forward.normalized * 1f;
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
            Vector3 vector3_2 = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                                GorillaTagger.Instance.myVRRig.transform.forward.normalized * 1.5f;
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
            Vector3 vector3_3 = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                                GorillaTagger.Instance.myVRRig.transform.forward.normalized * 2f;
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
            Vector3 vector3_4 = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                                GorillaTagger.Instance.myVRRig.transform.forward.normalized * 2.5f;
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
            Vector3 vector3_5 = GorillaTagger.Instance.myVRRig.transform.position + new Vector3(0.0f, 1.1f, 0.0f) +
                                GorillaTagger.Instance.myVRRig.transform.forward.normalized * 3f;
            PhotonNetwork.Instantiate("bulletPrefab", position, rotation);
        }

        public static void cubes_spawner()
        {
            if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                PhotonNetwork.Instantiate("bulletPrefab",
                    Player.Instance.headCollider.transform.position + new Vector3(0.0f, -0.2f, 0.0f),
                    Player.Instance.headCollider.transform.rotation * Quaternion.Euler(0.0f, 0.0f, -90f));
            if (!EasyInputs.GetGripButtonDown(EasyHand.LeftHand))
                return;
            PhotonNetwork.Instantiate("bulletPrefab",
                Player.Instance.headCollider.transform.position + new Vector3(0.0f, -0.2f, 0.0f),
                Player.Instance.headCollider.transform.rotation * Quaternion.Euler(0.0f, 0.0f, -90f));
        }

        public static void materiall()
        {
            PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            foreach (GorillaTagManager gorillaTagManager in (GorillaTagManager[])Object
                         .FindObjectsOfType<GorillaTagManager>())
                gorillaTagManager.ClearInfectionState();
            foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType<GorillaTagManager>())
            {
                gorillaTagManager.checkCooldown = 0.0f;
                gorillaTagManager.tagCoolDown = 0.0f;
                Player.Instance.disableMovement = false;
            }
        }

        public static void spez()
        {
            GameObject[] gameObjectArray1 = new GameObject[3]
            {
                GameObject.Find("WardrobeItemButton"),
                GameObject.Find("WardrobeItemButton (1)"),
                GameObject.Find("WardrobeItemButton (2)")
            };
            int index1 = Random.Range(0, gameObjectArray1.Length);
            if ((bool)(Object)gameObjectArray1[index1].GetComponent<GorillaPressableButton>())
                gameObjectArray1[index1].GetComponent<GorillaPressableButton>().ButtonActivation();
            GameObject[] gameObjectArray2 = new GameObject[1]
            {
                GameObject.Find("WardrobeRightItem")
            };
            int index2 = Random.Range(0, gameObjectArray2.Length);
            if (!(bool)(Object)gameObjectArray2[index2].GetComponent<WardrobeFunctionButton>())
                return;
            gameObjectArray2[index2].GetComponent<WardrobeFunctionButton>().ButtonActivation();
        }

        public static void UnTagGun()
        {
            RaycastHit hitInfo;
            Physics.Raycast(
                GorillaLocomotion.Player.Instance.rightHandTransform.position -
                GorillaLocomotion.Player.Instance.rightHandTransform.up,
                -GorillaLocomotion.Player.Instance.rightHandTransform.up, out hitInfo);
            GameObject primitive = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            primitive.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            primitive.transform.position = hitInfo.point;
            UnityEngine.Object.Destroy((UnityEngine.Object)primitive.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy((UnityEngine.Object)primitive.GetComponent<Collider>());
            UnityEngine.Object.Destroy((UnityEngine.Object)primitive, Time.deltaTime);
            if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
            {
                if (!(bool)(UnityEngine.Object)hitInfo.collider.GetComponentInParent<PhotonView>())
                    return;
                Photon.Realtime.Player owner = hitInfo.collider.GetComponentInParent<PhotonView>().Owner;
                foreach (GorillaTagManager gorillaTagManager in
                         UnityEngine.Object.FindObjectsOfType<GorillaTagManager>())
                {
                    Photon.Realtime.Player player = owner;
                    if (gorillaTagManager.currentInfected.Contains(player))
                    {
                        gorillaTagManager.currentInfected.Remove(player);
                        gorillaTagManager.UpdateState();
                    }
                }
            }
        }

        public static void LockRoom()
        {
            IIDKQuest.Mods.OpMods.SetMaster();
            Hashtable propertiesToSet = new Hashtable();
            propertiesToSet.Add((Il2CppSystem.Object)"gameMode",
                (Il2CppSystem.Object)("forestcitybasementcanyonsmountainsbeachskycaves" +
                                      GorillaComputer.instance.currentGameMode));
            PhotonNetwork.CurrentRoom.SetCustomProperties(propertiesToSet);
            GorillaNot.instance.CloseInvalidRoom();
            PhotonNetwork.CurrentRoom.IsOffline = true;
        }

        public static void givewatchall()
        {
            PhotonNetwork.Instantiate("gorillaprefabs/gorillahuntmanager",
                GorillaLocomotion.Player.Instance.rightHandTransform.transform.position,
                GorillaLocomotion.Player.Instance.rightHandTransform.transform.rotation);
        }

        public static void HighGrav()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>()
                .AddForce(new Vector3(0.0f, -500f, 0.0f), ForceMode.Acceleration);
        }

        public static void DefaultGrav()
        {
            Rigidbody component = GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>();
            component.useGravity = true;
            component.mass = 0.5f;
        }

        public static void LowGrav()
        {
            Rigidbody component = GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>();
            component.useGravity = false;
            component.mass = 0.5f;
        }


        public static void FlipHands()
        {
            Vector3 position1 = GorillaTagger.Instance.leftHandTransform.position;
            Vector3 position2 = GorillaTagger.Instance.rightHandTransform.position;
            Quaternion rotation1 = GorillaTagger.Instance.leftHandTransform.rotation;
            Quaternion rotation2 = GorillaTagger.Instance.rightHandTransform.rotation;
            ((Component)GorillaLocomotion.Player.Instance.rightHandTransform).transform.position = position1;
            ((Component)GorillaLocomotion.Player.Instance.leftHandTransform).transform.position = position2;
            ((Component)GorillaLocomotion.Player.Instance.rightHandTransform).transform.rotation = rotation1;
            ((Component)GorillaLocomotion.Player.Instance.leftHandTransform).transform.rotation = rotation2;
        }
        
        public static void LowQualityMicrophone()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            component.SamplingRate = (SamplingRate)8000;
            component.Bitrate = 5;
            component.RestartRecording();
        }
        
        public static void HighQualityMicrophone()
        {
            Recorder component = GameObject.Find("NetworkVoice").GetComponent<Recorder>();
            component.SamplingRate = (SamplingRate)16000;
            component.Bitrate = 30000;
            component.RestartRecording();
        }
        
        public static void ReloadMicrophone()
        {
            GameObject.Find("NetworkVoice").GetComponent<Recorder>().RestartRecording();
        }
       
        }
        
    }
        
        
        



    





         
        