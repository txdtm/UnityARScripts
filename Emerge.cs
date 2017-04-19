using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emerge : MonoBehaviour {

	public float speed;
	// public Transform startPoint;
	public Transform endPoint;

	// Use this for initialization
	void Start () {

	}
		

	// Update is called once per frame
	void Update () {
		// float distance = Vector3.Distance (startPoint.transform.position.y, endPoint.transform.position.y);
		if (transform.localPosition.y < endPoint.transform.localPosition.y) {
			transform.Translate (Vector3.up * Time.deltaTime * speed, Space.Self);
			Debug.Log (transform.localPosition.y);
		} 
		else  {
		}
	}
}