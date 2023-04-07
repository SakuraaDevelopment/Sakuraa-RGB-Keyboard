using System;
using BepInEx;
using UnityEngine;

namespace Sakuraa_RGB_Keyboard 
    // This code is messy asf but it gets the job done ...
    // I aint fixing it but feel free to fork it and make it better :) please ask me before you do though
    // discord: Sakuraa#1930
{
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
        private string stump_keydir = "/Level/lower level/UI/PhysicalComputer/keyboard/Buttons/Keys/";
        private string mountain_keydir = "/Level/mountain/Geometry/goodigloo/PhysicalComputer (2)/keyboard/Buttons/Keys/";
        private string clouds_keydir = "/Level/skyjungle/UI/PhysicalComputer (3)/keyboard/Buttons/Keys/";

        // stump
        private GameObject option1Object;
        private GameObject option2Object;
        private GameObject option3Object;
        private GameObject EnterObject;
        private GameObject DeleteObject;
        private GameObject UpObject;
        private GameObject DownObject;
        private GameObject number1Object;
        private GameObject number2Object;
        private GameObject number3Object;
        private GameObject number4Object;
        private GameObject number5Object;
        private GameObject number6Object;
        private GameObject number7Object;
        private GameObject number8Object;
        private GameObject number9Object;
        private GameObject number0Object;
        private GameObject LetterAObject;
        private GameObject LetterBObject;
        private GameObject LetterCObject;
        private GameObject LetterDObject;
        private GameObject LetterEObject;
        private GameObject LetterFObject;
        private GameObject LetterGObject;
        private GameObject LetterHObject;
        private GameObject LetterIObject;
        private GameObject LetterJObject;
        private GameObject LetterKObject;
        private GameObject LetterLObject;
        private GameObject LetterMObject;
        private GameObject LetterNObject;
        private GameObject LetterOObject;
        private GameObject LetterPObject;
        private GameObject LetterQObject;
        private GameObject LetterRObject;
        private GameObject LetterSObject;
        private GameObject LetterTObject;
        private GameObject LetterUObject;
        private GameObject LetterVObject;
        private GameObject LetterWObject;
        private GameObject LetterXObject;
        private GameObject LetterYObject;
        private GameObject LetterZObject;
        // computer interface mod:
        private GameObject ModdedUpObject;
        private GameObject ModdedDownObject;
        private GameObject ModdedLeftObject;
        private GameObject ModdedRightObject;
        private GameObject ModdedSpaceObject;
        private GameObject ModdedBackObject;


        // mountains
        private GameObject mountain_option1Object;
        private GameObject mountain_option2Object;
        private GameObject mountain_option3Object;
        private GameObject mountain_EnterObject;
        private GameObject mountain_DeleteObject;
        private GameObject mountain_UpObject;
        private GameObject mountain_DownObject;
        private GameObject mountain_number1Object;
        private GameObject mountain_number2Object;
        private GameObject mountain_number3Object;
        private GameObject mountain_number4Object;
        private GameObject mountain_number5Object;
        private GameObject mountain_number6Object;
        private GameObject mountain_number7Object;
        private GameObject mountain_number8Object;
        private GameObject mountain_number9Object;
        private GameObject mountain_number0Object;
        private GameObject mountain_LetterAObject;
        private GameObject mountain_LetterBObject;
        private GameObject mountain_LetterCObject;
        private GameObject mountain_LetterDObject;
        private GameObject mountain_LetterEObject;
        private GameObject mountain_LetterFObject;
        private GameObject mountain_LetterGObject;
        private GameObject mountain_LetterHObject;
        private GameObject mountain_LetterIObject;
        private GameObject mountain_LetterJObject;
        private GameObject mountain_LetterKObject;
        private GameObject mountain_LetterLObject;
        private GameObject mountain_LetterMObject;
        private GameObject mountain_LetterNObject;
        private GameObject mountain_LetterOObject;
        private GameObject mountain_LetterPObject;
        private GameObject mountain_LetterQObject;
        private GameObject mountain_LetterRObject;
        private GameObject mountain_LetterSObject;
        private GameObject mountain_LetterTObject;
        private GameObject mountain_LetterUObject;
        private GameObject mountain_LetterVObject;
        private GameObject mountain_LetterWObject;
        private GameObject mountain_LetterXObject;
        private GameObject mountain_LetterYObject;
        private GameObject mountain_LetterZObject;
        // computer interface mod:
        private GameObject mountain_ModdedUpObject;
        private GameObject mountain_ModdedDownObject;
        private GameObject mountain_ModdedLeftObject;
        private GameObject mountain_ModdedRightObject;
        private GameObject mountain_ModdedSpaceObject;
        private GameObject mountain_ModdedBackObject;


        // clouds
        private GameObject clouds_option1Object;
        private GameObject clouds_option2Object;
        private GameObject clouds_option3Object;
        private GameObject clouds_EnterObject;
        private GameObject clouds_DeleteObject;
        private GameObject clouds_UpObject;
        private GameObject clouds_DownObject;
        private GameObject clouds_number1Object;
        private GameObject clouds_number2Object;
        private GameObject clouds_number3Object;
        private GameObject clouds_number4Object;
        private GameObject clouds_number5Object;
        private GameObject clouds_number6Object;
        private GameObject clouds_number7Object;
        private GameObject clouds_number8Object;
        private GameObject clouds_number9Object;
        private GameObject clouds_number0Object;
        private GameObject clouds_LetterAObject;
        private GameObject clouds_LetterBObject;
        private GameObject clouds_LetterCObject;
        private GameObject clouds_LetterDObject;
        private GameObject clouds_LetterEObject;
        private GameObject clouds_LetterFObject;
        private GameObject clouds_LetterGObject;
        private GameObject clouds_LetterHObject;
        private GameObject clouds_LetterIObject;
        private GameObject clouds_LetterJObject;
        private GameObject clouds_LetterKObject;
        private GameObject clouds_LetterLObject;
        private GameObject clouds_LetterMObject;
        private GameObject clouds_LetterNObject;
        private GameObject clouds_LetterOObject;
        private GameObject clouds_LetterPObject;
        private GameObject clouds_LetterQObject;
        private GameObject clouds_LetterRObject;
        private GameObject clouds_LetterSObject;
        private GameObject clouds_LetterTObject;
        private GameObject clouds_LetterUObject;
        private GameObject clouds_LetterVObject;
        private GameObject clouds_LetterWObject;
        private GameObject clouds_LetterXObject;
        private GameObject clouds_LetterYObject;
        private GameObject clouds_LetterZObject;
        // computer interface mod:
        private GameObject clouds_ModdedUpObject;
        private GameObject clouds_ModdedDownObject;
        private GameObject clouds_ModdedLeftObject;
        private GameObject clouds_ModdedRightObject;
        private GameObject clouds_ModdedSpaceObject;
        private GameObject clouds_ModdedBackObject;

        void Start()
		{
			/* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

			Utilla.Events.GameInitialized += OnGameInitialized;
		}

		void OnEnable()
		{
			/* Set up your mod here */
			/* Code here runs at the start and whenever your mod is enabled*/

			HarmonyPatches.ApplyHarmonyPatches();
		}

		void OnDisable()
		{
			/* Undo mod setup here */
			/* This provides support for toggling mods with ComputerInterface, please implement it :) */
			/* Code here runs whenever your mod is disabled (including if it disabled on startup)*/

			HarmonyPatches.RemoveHarmonyPatches();
		}

		void OnGameInitialized(object sender, EventArgs e)
		{
            /* Code here runs after the game initializes (i.e. GorillaLocomotion.Player.Instance != null) */
            Debug.Log("Started Rainbow Keyboard Mod");

            // stump
            Debug.Log("Loading stump keys");
            try
            {
                option1Object = GameObject.Find(stump_keydir + "option 1");
                option2Object = GameObject.Find(stump_keydir + "option 2");
                option3Object = GameObject.Find(stump_keydir + "option 3");

                EnterObject = GameObject.Find(stump_keydir + "enterkeyforest");
                DeleteObject = GameObject.Find(stump_keydir + "delete");

                UpObject = GameObject.Find(stump_keydir + "up");
                DownObject = GameObject.Find(stump_keydir + "down");

                number1Object = GameObject.Find(stump_keydir + "1");
                number2Object = GameObject.Find(stump_keydir + "2");
                number3Object = GameObject.Find(stump_keydir + "3");
                number4Object = GameObject.Find(stump_keydir + "4");
                number5Object = GameObject.Find(stump_keydir + "5");
                number6Object = GameObject.Find(stump_keydir + "6");
                number7Object = GameObject.Find(stump_keydir + "7");
                number8Object = GameObject.Find(stump_keydir + "8");
                number9Object = GameObject.Find(stump_keydir + "9");
                number0Object = GameObject.Find(stump_keydir + "0");

                LetterAObject = GameObject.Find(stump_keydir + "a");
                LetterBObject = GameObject.Find(stump_keydir + "b");
                LetterCObject = GameObject.Find(stump_keydir + "c");
                LetterDObject = GameObject.Find(stump_keydir + "d");
                LetterEObject = GameObject.Find(stump_keydir + "e");
                LetterFObject = GameObject.Find(stump_keydir + "f");
                LetterGObject = GameObject.Find(stump_keydir + "g");
                LetterHObject = GameObject.Find(stump_keydir + "h");
                LetterIObject = GameObject.Find(stump_keydir + "i");
                LetterJObject = GameObject.Find(stump_keydir + "j");
                LetterKObject = GameObject.Find(stump_keydir + "k");
                LetterLObject = GameObject.Find(stump_keydir + "l");
                LetterMObject = GameObject.Find(stump_keydir + "m");
                LetterNObject = GameObject.Find(stump_keydir + "n");
                LetterOObject = GameObject.Find(stump_keydir + "o");
                LetterPObject = GameObject.Find(stump_keydir + "p");
                LetterQObject = GameObject.Find(stump_keydir + "q");
                LetterRObject = GameObject.Find(stump_keydir + "r");
                LetterSObject = GameObject.Find(stump_keydir + "s");
                LetterTObject = GameObject.Find(stump_keydir + "t");
                LetterUObject = GameObject.Find(stump_keydir + "u");
                LetterVObject = GameObject.Find(stump_keydir + "v");
                LetterWObject = GameObject.Find(stump_keydir + "w");
                LetterXObject = GameObject.Find(stump_keydir + "x");
                LetterYObject = GameObject.Find(stump_keydir + "y");
                LetterZObject = GameObject.Find(stump_keydir + "z");
                Debug.Log("Loaded regular stump keys");
            }
            // catch the error and log it
            catch (Exception ex)
            {
                Debug.Log("Error: " + ex.Message);
            }



            // mountains
            Debug.Log("Loading mountain keys");
            try
            {
                mountain_option1Object = GameObject.Find(mountain_keydir + "option 1");
                mountain_option2Object = GameObject.Find(mountain_keydir + "option 2");
                mountain_option3Object = GameObject.Find(mountain_keydir + "option 3");

                mountain_EnterObject = GameObject.Find(mountain_keydir + "enterkeymountain");
                mountain_DeleteObject = GameObject.Find(mountain_keydir + "delete");

                mountain_UpObject = GameObject.Find(mountain_keydir + "up");
                mountain_DownObject = GameObject.Find(mountain_keydir + "down");

                mountain_number1Object = GameObject.Find(mountain_keydir + "1");
                mountain_number2Object = GameObject.Find(mountain_keydir + "2");
                mountain_number3Object = GameObject.Find(mountain_keydir + "3");
                mountain_number4Object = GameObject.Find(mountain_keydir + "4");
                mountain_number5Object = GameObject.Find(mountain_keydir + "5");
                mountain_number6Object = GameObject.Find(mountain_keydir + "6");
                mountain_number7Object = GameObject.Find(mountain_keydir + "7");
                mountain_number8Object = GameObject.Find(mountain_keydir + "8");
                mountain_number9Object = GameObject.Find(mountain_keydir + "9");
                mountain_number0Object = GameObject.Find(mountain_keydir + "0");

                mountain_LetterAObject = GameObject.Find(mountain_keydir + "a");
                mountain_LetterBObject = GameObject.Find(mountain_keydir + "b");
                mountain_LetterCObject = GameObject.Find(mountain_keydir + "c");
                mountain_LetterDObject = GameObject.Find(mountain_keydir + "d");
                mountain_LetterEObject = GameObject.Find(mountain_keydir + "e");
                mountain_LetterFObject = GameObject.Find(mountain_keydir + "f");
                mountain_LetterGObject = GameObject.Find(mountain_keydir + "g");
                mountain_LetterHObject = GameObject.Find(mountain_keydir + "h");
                mountain_LetterIObject = GameObject.Find(mountain_keydir + "i");
                mountain_LetterJObject = GameObject.Find(mountain_keydir + "j");
                mountain_LetterKObject = GameObject.Find(mountain_keydir + "k");
                mountain_LetterLObject = GameObject.Find(mountain_keydir + "l");
                mountain_LetterMObject = GameObject.Find(mountain_keydir + "m");
                mountain_LetterNObject = GameObject.Find(mountain_keydir + "n");
                mountain_LetterOObject = GameObject.Find(mountain_keydir + "o");
                mountain_LetterPObject = GameObject.Find(mountain_keydir + "p");
                mountain_LetterQObject = GameObject.Find(mountain_keydir + "q");
                mountain_LetterRObject = GameObject.Find(mountain_keydir + "r");
                mountain_LetterSObject = GameObject.Find(mountain_keydir + "s");
                mountain_LetterTObject = GameObject.Find(mountain_keydir + "t");
                mountain_LetterUObject = GameObject.Find(mountain_keydir + "u");
                mountain_LetterVObject = GameObject.Find(mountain_keydir + "v");
                mountain_LetterWObject = GameObject.Find(mountain_keydir + "w");
                mountain_LetterXObject = GameObject.Find(mountain_keydir + "x");
                mountain_LetterYObject = GameObject.Find(mountain_keydir + "y");
                mountain_LetterZObject = GameObject.Find(mountain_keydir + "z");
                Debug.Log("Loaded mountain keys");
            }
            catch (Exception ex)
            {
                Debug.Log("Error: " + ex.Message);
            }


            // clouds
            Debug.Log("Loading clouds keys");
            try
            {
                clouds_option1Object = GameObject.Find(clouds_keydir + "option 1");
                clouds_option2Object = GameObject.Find(clouds_keydir + "option 2");
                clouds_option3Object = GameObject.Find(clouds_keydir + "option 3");

                clouds_EnterObject = GameObject.Find(clouds_keydir + "enterkeymountain"); // idek why this is called mountain in the sky map
                clouds_DeleteObject = GameObject.Find(clouds_keydir + "delete");

                clouds_UpObject = GameObject.Find(clouds_keydir + "up");
                clouds_DownObject = GameObject.Find(clouds_keydir + "down");

                clouds_number1Object = GameObject.Find(clouds_keydir + "1");
                clouds_number2Object = GameObject.Find(clouds_keydir + "2");
                clouds_number3Object = GameObject.Find(clouds_keydir + "3");
                clouds_number4Object = GameObject.Find(clouds_keydir + "4");
                clouds_number5Object = GameObject.Find(clouds_keydir + "5");
                clouds_number6Object = GameObject.Find(clouds_keydir + "6");
                clouds_number7Object = GameObject.Find(clouds_keydir + "7");
                clouds_number8Object = GameObject.Find(clouds_keydir + "8");
                clouds_number9Object = GameObject.Find(clouds_keydir + "9");
                clouds_number0Object = GameObject.Find(clouds_keydir + "0");

                clouds_LetterAObject = GameObject.Find(clouds_keydir + "a");
                clouds_LetterBObject = GameObject.Find(clouds_keydir + "b");
                clouds_LetterCObject = GameObject.Find(clouds_keydir + "c");
                clouds_LetterDObject = GameObject.Find(clouds_keydir + "d");
                clouds_LetterEObject = GameObject.Find(clouds_keydir + "e");
                clouds_LetterFObject = GameObject.Find(clouds_keydir + "f");
                clouds_LetterGObject = GameObject.Find(clouds_keydir + "g");
                clouds_LetterHObject = GameObject.Find(clouds_keydir + "h");
                clouds_LetterIObject = GameObject.Find(clouds_keydir + "i");
                clouds_LetterJObject = GameObject.Find(clouds_keydir + "j");
                clouds_LetterKObject = GameObject.Find(clouds_keydir + "k");
                clouds_LetterLObject = GameObject.Find(clouds_keydir + "l");
                clouds_LetterMObject = GameObject.Find(clouds_keydir + "m");
                clouds_LetterNObject = GameObject.Find(clouds_keydir + "n");
                clouds_LetterOObject = GameObject.Find(clouds_keydir + "o");
                clouds_LetterPObject = GameObject.Find(clouds_keydir + "p");
                clouds_LetterQObject = GameObject.Find(clouds_keydir + "q");
                clouds_LetterRObject = GameObject.Find(clouds_keydir + "r");
                clouds_LetterSObject = GameObject.Find(clouds_keydir + "s");
                clouds_LetterTObject = GameObject.Find(clouds_keydir + "t");
                clouds_LetterUObject = GameObject.Find(clouds_keydir + "u");
                clouds_LetterVObject = GameObject.Find(clouds_keydir + "v");
                clouds_LetterWObject = GameObject.Find(clouds_keydir + "w");
                clouds_LetterXObject = GameObject.Find(clouds_keydir + "x");
                clouds_LetterYObject = GameObject.Find(clouds_keydir + "y");
                clouds_LetterZObject = GameObject.Find(clouds_keydir + "z");
                Debug.Log("Loaded regular cloud keys");
            }
            // catch the error and log it
            catch (Exception ex)
            {
                Debug.Log("Error: " + ex.Message);
            }

            // computer interface mod:
            // stump
            try
            {
                ModdedUpObject = GameObject.Find(stump_keydir + "Up");
                ModdedDownObject = GameObject.Find(stump_keydir + "Down");
                ModdedLeftObject = GameObject.Find(stump_keydir + "Left");
                ModdedRightObject = GameObject.Find(stump_keydir + "Right");
                ModdedSpaceObject = GameObject.Find(stump_keydir + "Space");
                ModdedBackObject = GameObject.Find(stump_keydir + "Back");
                Debug.Log("Loaded stump modded keys");
            }
            catch
            {
                ModdedUpObject = null;
                ModdedDownObject = null;
                ModdedLeftObject = null;
                ModdedRightObject = null;
                ModdedSpaceObject = null;
                ModdedBackObject = null;
                Debug.Log("Couldnt get computer interface keys in stump");
            }
            // mountain
            try
            {
                mountain_ModdedUpObject = GameObject.Find(mountain_keydir + "Up");
                mountain_ModdedDownObject = GameObject.Find(mountain_keydir + "Down");
                mountain_ModdedLeftObject = GameObject.Find(mountain_keydir + "Left");
                mountain_ModdedRightObject = GameObject.Find(mountain_keydir + "Right");
                mountain_ModdedSpaceObject = GameObject.Find(mountain_keydir + "Space");
                mountain_ModdedBackObject = GameObject.Find(mountain_keydir + "Back");
                Debug.Log("Loaded mountain modded keys");
            }
            catch
            {
                mountain_ModdedUpObject = null;
                mountain_ModdedDownObject = null;
                mountain_ModdedLeftObject = null;
                mountain_ModdedRightObject = null;
                mountain_ModdedSpaceObject = null;
                mountain_ModdedBackObject = null;
                Debug.Log("Couldnt get computer interface keys in mountains");
            }
            // clouds
            try
            {
                clouds_ModdedUpObject = GameObject.Find(clouds_keydir + "Up");
                clouds_ModdedDownObject = GameObject.Find(clouds_keydir + "Down");
                clouds_ModdedLeftObject = GameObject.Find(clouds_keydir + "Left");
                clouds_ModdedRightObject = GameObject.Find(clouds_keydir + "Right");
                clouds_ModdedSpaceObject = GameObject.Find(clouds_keydir + "Space");
                clouds_ModdedBackObject = GameObject.Find(clouds_keydir + "Back");
                Debug.Log("Loaded cloud modded keys");
            }
            catch
            {
                clouds_ModdedUpObject = null;
                clouds_ModdedDownObject = null;
                clouds_ModdedLeftObject = null;
                clouds_ModdedRightObject = null;
                clouds_ModdedSpaceObject = null;
                clouds_ModdedBackObject = null;
                Debug.Log("Couldnt get computer interface keys in cloud");
            }

            ChangeColor();
        }

        void Update()
		{
            /* Code here runs every frame when the mod is enabled */
            ChangeColor();
        }

		public void ChangeColor()
		{
            Color rgb = Color.HSVToRGB(Time.time * 0.1f % 1, 1, 1);
            // change the color of the keyboard key to a color that slowely changes the  by changing the material

            // stump
            option1Object.GetComponent<Renderer>().material.color = rgb;
			option2Object.GetComponent<Renderer>().material.color = rgb;
			option3Object.GetComponent<Renderer>().material.color = rgb;
            EnterObject.GetComponent<Renderer>().material.color = rgb;
            DeleteObject.GetComponent<Renderer>().material.color = rgb;
            UpObject.GetComponent<Renderer>().material.color = rgb;
            DownObject.GetComponent<Renderer>().material.color = rgb;
            number1Object.GetComponent<Renderer>().material.color = rgb;
            number2Object.GetComponent<Renderer>().material.color = rgb;
			number3Object.GetComponent<Renderer>().material.color = rgb;
			number4Object.GetComponent<Renderer>().material.color = rgb;
            number5Object.GetComponent<Renderer>().material.color = rgb;
            number6Object.GetComponent<Renderer>().material.color = rgb;
            number7Object.GetComponent<Renderer>().material.color = rgb;
            number8Object.GetComponent<Renderer>().material.color = rgb;
            number9Object.GetComponent<Renderer>().material.color = rgb;
            number0Object.GetComponent<Renderer>().material.color = rgb;
			LetterAObject.GetComponent<Renderer>().material.color = rgb;
			LetterBObject.GetComponent<Renderer>().material.color = rgb;
            LetterCObject.GetComponent<Renderer>().material.color = rgb;
            LetterDObject.GetComponent<Renderer>().material.color = rgb;
            LetterEObject.GetComponent<Renderer>().material.color = rgb;
            LetterFObject.GetComponent<Renderer>().material.color = rgb;
            LetterGObject.GetComponent<Renderer>().material.color = rgb;
            LetterHObject.GetComponent<Renderer>().material.color = rgb;
            LetterIObject.GetComponent<Renderer>().material.color = rgb;
            LetterJObject.GetComponent<Renderer>().material.color = rgb;
            LetterKObject.GetComponent<Renderer>().material.color = rgb;
            LetterLObject.GetComponent<Renderer>().material.color = rgb;
            LetterMObject.GetComponent<Renderer>().material.color = rgb;
            LetterNObject.GetComponent<Renderer>().material.color = rgb;
            LetterOObject.GetComponent<Renderer>().material.color = rgb;
            LetterPObject.GetComponent<Renderer>().material.color = rgb;
            LetterQObject.GetComponent<Renderer>().material.color = rgb;
            LetterRObject.GetComponent<Renderer>().material.color = rgb;
            LetterSObject.GetComponent<Renderer>().material.color = rgb;
            LetterTObject.GetComponent<Renderer>().material.color = rgb;
            LetterUObject.GetComponent<Renderer>().material.color = rgb;
            LetterVObject.GetComponent<Renderer>().material.color = rgb;
            LetterWObject.GetComponent<Renderer>().material.color = rgb;
            LetterXObject.GetComponent<Renderer>().material.color = rgb;
            LetterYObject.GetComponent<Renderer>().material.color = rgb;
            LetterZObject.GetComponent<Renderer>().material.color = rgb;

            // mountains
            mountain_option1Object.GetComponent<Renderer>().material.color = rgb;
            mountain_option2Object.GetComponent<Renderer>().material.color = rgb;
            mountain_option3Object.GetComponent<Renderer>().material.color = rgb;
            mountain_EnterObject.GetComponent<Renderer>().material.color = rgb;
            mountain_DeleteObject.GetComponent<Renderer>().material.color = rgb;
            mountain_UpObject.GetComponent<Renderer>().material.color = rgb;
            mountain_DownObject.GetComponent<Renderer>().material.color = rgb;
            mountain_number1Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number2Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number3Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number4Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number5Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number6Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number7Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number8Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number9Object.GetComponent<Renderer>().material.color = rgb;
            mountain_number0Object.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterAObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterBObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterCObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterDObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterEObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterFObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterGObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterHObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterIObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterJObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterKObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterLObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterMObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterNObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterOObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterPObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterQObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterRObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterSObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterTObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterUObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterVObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterWObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterXObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterYObject.GetComponent<Renderer>().material.color = rgb;
            mountain_LetterZObject.GetComponent<Renderer>().material.color = rgb;

            // clouds
            clouds_option1Object.GetComponent<Renderer>().material.color = rgb;
            clouds_option2Object.GetComponent<Renderer>().material.color = rgb;
            clouds_option3Object.GetComponent<Renderer>().material.color = rgb;
            clouds_EnterObject.GetComponent<Renderer>().material.color = rgb;
            clouds_DeleteObject.GetComponent<Renderer>().material.color = rgb;
            clouds_UpObject.GetComponent<Renderer>().material.color = rgb;
            clouds_DownObject.GetComponent<Renderer>().material.color = rgb;
            clouds_number1Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number2Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number3Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number4Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number5Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number6Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number7Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number8Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number9Object.GetComponent<Renderer>().material.color = rgb;
            clouds_number0Object.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterAObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterBObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterCObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterDObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterEObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterFObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterGObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterHObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterIObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterJObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterKObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterLObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterMObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterNObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterOObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterPObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterQObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterRObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterSObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterTObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterUObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterVObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterWObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterXObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterYObject.GetComponent<Renderer>().material.color = rgb;
            clouds_LetterZObject.GetComponent<Renderer>().material.color = rgb;


            // computer interface mod:
            // stump
            try
            {
                ModdedUpObject.GetComponent<Renderer>().material.color = rgb;
                ModdedDownObject.GetComponent<Renderer>().material.color = rgb;
                ModdedLeftObject.GetComponent<Renderer>().material.color = rgb;
                ModdedRightObject.GetComponent<Renderer>().material.color = rgb;
                ModdedSpaceObject.GetComponent<Renderer>().material.color = rgb;
                ModdedBackObject.GetComponent<Renderer>().material.color = rgb;
            }
            catch { }
            // mountain
            try
            {
                mountain_ModdedUpObject.GetComponent<Renderer>().material.color = rgb;
                mountain_ModdedDownObject.GetComponent<Renderer>().material.color = rgb;
                mountain_ModdedLeftObject.GetComponent<Renderer>().material.color = rgb;
                mountain_ModdedRightObject.GetComponent<Renderer>().material.color = rgb;
                mountain_ModdedSpaceObject.GetComponent<Renderer>().material.color = rgb;
                mountain_ModdedBackObject.GetComponent<Renderer>().material.color = rgb;
            }
            catch { }
            // clouds
            try
            {
                clouds_ModdedUpObject.GetComponent<Renderer>().material.color = rgb;
                clouds_ModdedDownObject.GetComponent<Renderer>().material.color = rgb;
                clouds_ModdedLeftObject.GetComponent<Renderer>().material.color = rgb;
                clouds_ModdedRightObject.GetComponent<Renderer>().material.color = rgb;
                clouds_ModdedSpaceObject.GetComponent<Renderer>().material.color = rgb;
                clouds_ModdedBackObject.GetComponent<Renderer>().material.color = rgb;
            }
            catch { }
        }
	}
	
}
