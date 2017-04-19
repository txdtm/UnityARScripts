using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHide : MonoBehaviour {

	public Canvas rend;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("You have clicked the button!");
		rend.gameObject.SetActive (false);

	}
}
