using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHide: MonoBehaviour {

	public Canvas rend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rend.gameObject.SetActive (false);
		//GetComponent<Renderer> ().enabled = false;
	}
}
