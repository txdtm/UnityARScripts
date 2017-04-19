using UnityEngine;
using System.Collections;
using Vuforia;
using System;
using UnityEngine.UI;

public class LabelHide : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	//CanvasRenderer rend;
	public Canvas label1;
	public Canvas label2;
	public Canvas label3;
	public Canvas label4;
	public Canvas label5;
	public Canvas label6;
	public Canvas label7;
	public Canvas label8;
	public Canvas label9;
	public Canvas label10;
	public Canvas label11;
	public Canvas label12;


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

			label1.gameObject.SetActive (true);
			label2.gameObject.SetActive (true);
			label3.gameObject.SetActive (true);
			label4.gameObject.SetActive (true);
			label5.gameObject.SetActive (true);
			label6.gameObject.SetActive (true);
			label7.gameObject.SetActive (true);
			label8.gameObject.SetActive (true);
			label9.gameObject.SetActive (true);
			label10.gameObject.SetActive (true);
			label11.gameObject.SetActive (true);
			label12.gameObject.SetActive (true);
		}
		else
		{

			label1.gameObject.SetActive (false);
			label2.gameObject.SetActive (false);
			label3.gameObject.SetActive (false);
			label4.gameObject.SetActive (false);
			label5.gameObject.SetActive (false);
			label6.gameObject.SetActive (false);
			label7.gameObject.SetActive (false);
			label8.gameObject.SetActive (false);
			label9.gameObject.SetActive (false);
			label10.gameObject.SetActive (false);
			label11.gameObject.SetActive (false);
			label12.gameObject.SetActive (false);

		}
	}
}
