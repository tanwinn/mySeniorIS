﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDisplay : DisplayScript {
    
    // Use this for initialization
    void Start () {
        GetComponent<Renderer>().material = scriptObject.material;
        name = scriptObject.name;
        transform.localScale = new Vector3(scriptObject.size, scriptObject.size, scriptObject.size);

        Rigidbody rb = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        
        if (scriptObject.isInteractive)
            gameObject.AddComponent<Leap.Unity.Interaction.InteractionBehaviour>();
    }

    #region Deprecated
    //// Keeps track of the change for ome-time update
    //private bool ObjectIsModified = false;

    //public void setIsInteractive(bool input) {
    //    scriptObject.isInteractive = input;
    //    ObjectIsModified = true;
    //}

    //void Update() {
    //    if (ObjectIsModified) {
    //        if (scriptObject.isInteractive) {
    //            gameObject.AddComponent<Leap.Unity.Interaction.InteractionBehaviour>();
    //        }
    //        else if (gameObject.GetComponent<Leap.Unity.Interaction.InteractionBehaviour>()) {
    //            //Debug.Log("Destroy Interaction Behaviour");
    //            Destroy(gameObject.GetComponent<Leap.Unity.Interaction.InteractionBehaviour>());
    //            if (gameObject.GetComponent<Rigidbody>() == null) {
    //                Rigidbody rb = gameObject.AddComponent<Rigidbody>() as Rigidbody;
    //                //rb.mass = scriptObject.mass;
    //            }
    //        }
    //        ObjectIsModified = false;
    //    }
    //}

    #endregion
}
