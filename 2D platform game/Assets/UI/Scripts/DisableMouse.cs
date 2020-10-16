﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisableMouse : MonoBehaviour
{
    GameObject lastselect;

    void Start()
    {
        lastselect = new GameObject();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update () 
    {         
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(lastselect);
        }
        else
        {
            lastselect = EventSystem.current.currentSelectedGameObject;
        }
    }
}
