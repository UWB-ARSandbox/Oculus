using System;
using UnityEngine;
using System.Collections;

public class RightHandToViveController : MonoBehaviour
{
    private GameObject cameraRig;

	// Use this for initialization
	void Start () {
        try
        {
            cameraRig = GameObject.FindGameObjectWithTag("CameraRig");
        }
        catch (Exception e)
        {
            // Expected to be null reference in every project but Vive. 
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (cameraRig != null)
        {
            this.transform.position = cameraRig.transform.GetChild(1).position;
            this.transform.rotation = cameraRig.transform.GetChild(1).rotation;
        }
    }
}
