﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FlexibleUIInstance : Editor {

    static GameObject clickedObject;

    private static GameObject Create (string objectName)
    {
        GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
        instance.name = objectName;
        clickedObject = UnityEditor.Selection.activeObject as GameObject;
        if( null != clickedObject)
        {
            instance.transform.SetParent(clickedObject.transform, false);
        }

        return instance;
    }
}
