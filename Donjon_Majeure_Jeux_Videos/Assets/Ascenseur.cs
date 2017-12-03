using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ascenseur : MonoBehaviour {
	public Transform t;

	// Use this for initialization
	void Start () {
		t = GetComponent<Transform> ();
	}

	void OnCollisionEnter(){
		if (Input.GetKey ("e")) {
			t.transform.position += new Vector3 (0, Mathf.Lerp (0f, 5f, 0.1f), 0);
		}

		if (Input.GetKey ("r")) {
			t.transform.position -= new Vector3 (0, Mathf.Lerp (0f, 5f, 0.1f), 0);
		}
	}

	// Update is called once per frame
	void Update () {
		OnCollisionEnter();
	}
}
