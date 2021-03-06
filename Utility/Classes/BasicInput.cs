﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BasicInput : MonoBehaviour
{
    public KeyCodeUnityEventDictionary KeyEvent;
    
    private void Update()
    {
        foreach(KeyValuePair<KeyCode, UnityEvent> kvp in KeyEvent)
        {
            if (Input.GetKey(kvp.Key))
            {
                kvp.Value.Invoke();
            }
        }
    }

    [System.Serializable] public class KeyCodeUnityEventDictionary : SerializableDictionary<KeyCode, UnityEvent> { }
}