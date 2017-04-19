using UnityEngine;
using System.Collections;
using Vuforia;
using System;
using UnityEngine.UI;

public class Announce : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	//CanvasRenderer rend;
	public Canvas rend;

	void Start () {

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}

	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{

			rend.gameObject.SetActive (true);
			Debug.Log ("SET ACTIVE - TRUE");
		}
		else
		{

			rend.gameObject.SetActive (false);
			Debug.Log ("SET ACTIVE - FALSE");

		}
	}
}
