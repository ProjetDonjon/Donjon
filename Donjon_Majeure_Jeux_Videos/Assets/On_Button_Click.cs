using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Button_Click : MonoBehaviour {
	void Start () {
		
	}

	void OnCollisionEnter(){
		if (Input.GetKey ("1")) {
			Destroy (transform.parent.gameObject);
		}
	}
		
	void Update () {
		OnCollisionEnter ();
	}
}
