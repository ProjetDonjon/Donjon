using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetKey("n"))
			UnityEditor.EditorApplication.isPlaying = false;
	}
}
