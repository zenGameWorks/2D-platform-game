﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFunction : MonoBehaviour
{
    [Header("Menu Scenes General")]
    public GameObject mainMenu;
    public GameObject settingsMenu;
    
    
    [Header("Settings Menu Scenes")]
    public GameObject controlsMenu;
    public GameObject graphicMenu;
    public GameObject soundMenu;
    public GameObject creditsMenu;


    [Header("Load Chapter Menu Scenes")]
    public GameObject loadChapterMenu;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Main Menu
            if (settingsMenu.activeSelf == true)
            {
                mainMenu.SetActive(true);
                settingsMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }

            //Settings Options
            if (controlsMenu.activeSelf == true)
            {
                settingsMenu.SetActive(true);
                controlsMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }
            if (graphicMenu.activeSelf == true)
            {
                settingsMenu.SetActive(true);
                graphicMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }
            if (soundMenu.activeSelf == true)
            {
                settingsMenu.SetActive(true);
                soundMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }
            if (creditsMenu.activeSelf == true)
            {
                settingsMenu.SetActive(true);
                creditsMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }
            
            //LoadChapterMenuScenes
            if (loadChapterMenu.activeSelf == true)
            {
                mainMenu.SetActive(true);
                loadChapterMenu.SetActive(false);
                AudioManager.PlayBackFromMenuNavigationAudio();
            }
        }
    }
}
