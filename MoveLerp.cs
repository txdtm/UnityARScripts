using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour {

	public Transform StartPositionGO;
	public Transform EndPositionGO;
	float StartTime;
	float TotalDistanceToDestination;
	public float AccelerationMultiplier = 1.0f;
	public float DecelerationMultiplier = 1.0f;

	// Use this for initialization
	void Start () {

		StartTime = Time.time + 1;
		TotalDistanceToDestination = Vector3.Distance (StartPositionGO.position, EndPositionGO.position);

	}
	
	// Update is called once per frame
	void Update () {

		float currentDuration = Time.time - StartTime;
		float journeyFraction = (currentDuration * AccelerationMultiplier) / (TotalDistanceToDestination * DecelerationMultiplier);
		transform.position = Vector3.Lerp (StartPositionGO.position, EndPositionGO.position, journeyFraction);

		Debug.Log (string.Format ("Duration: {0} -- Distance: {1}", currentDuration, TotalDistanceToDestination));

	}
}
