using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public Camera MainCam;
	public Camera FirstPersonCam;
	// Use this for initialization
	void Start () {

		//MainCam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
		//FirstPersonCam = GameObject.FindWithTag("FirstPersonCamera").GetComponent<Camera>();
		MainCam.enabled = true;
		FirstPersonCam.enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.C))
		{
			MainCam.enabled = !MainCam.enabled;
			FirstPersonCam.enabled = !FirstPersonCam.enabled;
			//GameObject.Find("MainCamera").camera.enabled = true;
			//GameObject.Find("FirstPersonCamera").camera.enabled = false;

		}

	}
}
