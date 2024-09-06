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
using Object = UnityEngine.Object;

namespace IIDKQuest.Mods
{
    public class VisualMods
    {

        private static LightmapData[] hell = null;

        public static void FullBright()
    {
      RenderSettings.fog = false;
      RenderSettings.ambientLight = Color.white;
    }

        public static void FullDark()
    {
      RenderSettings.fog = true;
      RenderSettings.ambientLight = Color.black;
    }

        public static void StrobeColor()
        {
            GorillaKeyboardButton button1 = new GorillaKeyboardButton();
            button1.characterString = UnityEngine.Random.Range(0, 10).ToString();
            GorillaComputer.instance.ProcessColorState(button1);
            GorillaComputer.instance.colorCursorLine = UnityEngine.Random.Range(0, 3);
        }

        public static void CHAMS()
        {
            foreach (VRRig vrRig in Object.FindObjectsOfType<VRRig>())
            {
                if (!((Object)vrRig == (Object)GorillaTagger.Instance.offlineVRRig))
                {
                    vrRig.mainSkin.material.color = Color.magenta;
                    vrRig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                }
            }
        }


        public static void RedStrobe()
        {
            GorillaComputer.instance.currentState = GorillaComputer.ComputerState.Color;
            GameObject[] gameObjectArray = new GameObject[10]
            {
                GameObject.Find("1"),
                GameObject.Find("2"),
                GameObject.Find("3"),
                GameObject.Find("4"),
                GameObject.Find("5"),
                GameObject.Find("6"),
                GameObject.Find("7"),
                GameObject.Find("8"),
                GameObject.Find("9"),
                GameObject.Find("0")
            };
            int index = UnityEngine.Random.Range(0, gameObjectArray.Length);
            if ((bool)(UnityEngine.Object)gameObjectArray[index].GetComponent<GorillaKeyboardButton>())
            {
                gameObjectArray[index].GetComponent<GorillaKeyboardButton>().pressTime = 0.0f;
                gameObjectArray[index].GetComponent<GorillaKeyboardButton>().triggerBoxOnce = false;
                gameObjectArray[index].GetComponent<GorillaKeyboardButton>().repeatCooldown = 0.0f;
                gameObjectArray[index].GetComponent<GorillaKeyboardButton>().testClick = true;
            }

            if ((bool)(UnityEngine.Object)GameObject.Find("option 1").GetComponent<GorillaKeyboardButton>())
            {
                GameObject.Find("option 1").GetComponent<GorillaKeyboardButton>().pressTime = 0.0f;
                GameObject.Find("option 1").GetComponent<GorillaKeyboardButton>().triggerBoxOnce = false;
                GameObject.Find("option 1").GetComponent<GorillaKeyboardButton>().repeatCooldown = 0.0f;
                GameObject.Find("option 1").GetComponent<GorillaKeyboardButton>().testClick = true;
            }
        }

        public static void Beacons()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if ((UnityEngine.Object)vrrig != (UnityEngine.Object)GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject gameObject = new GameObject("Line");
                    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
                    Color grey = Color.magenta;
                    lineRenderer.startColor = grey;
                    lineRenderer.endColor = grey;
                    lineRenderer.startWidth = 0.025f;
                    lineRenderer.endWidth = 0.025f;
                    lineRenderer.positionCount = 2;
                    lineRenderer.useWorldSpace = true;
                    Vector3 position = vrrig.transform.position;
                    lineRenderer.SetPosition(0, position + Vector3.up * 9999f);
                    lineRenderer.SetPosition(1, position - Vector3.up * 9999f);
                    lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                    UnityEngine.Object.Destroy((UnityEngine.Object)gameObject, Time.deltaTime);
                }
            }
        }

                public static void RedTheme()
              {
            new GradientColorKey(Color.black, 0f);
            new GradientColorKey(Color.red, 0.5f);
            new GradientColorKey(Color.black, 1f);
              }
            }
        }
        
    