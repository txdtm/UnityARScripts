using UnityEngine;
using System.Collections;
using Vuforia;
using System;

public class ButtonPopup : MonoBehaviour, ITrackableEventHandler {

	float native_width = 1000f;
	float native_height = 700f;
	//float native_width= 1920f;
	//float native_height= 1080f;
	public Texture btntexture;
	public Texture LogoTexture;
	public Texture MobiliyaTexture;


	private TrackableBehaviour mTrackableBehaviour;

	private bool mShowGUIButton = false;


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
			mShowGUIButton = true;
		}
		else
		{
			mShowGUIButton = false;
		}
	}

	void OnGUI() {

		//set up scaling
		float rx = Screen.width / native_width;
		float ry = Screen.height / native_height;

		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));

		Rect mButtonRect = new Rect(400, 10, 75, 75);
		GUIStyle myTextStyle = new GUIStyle(GUI.skin.textField);
		myTextStyle.fontSize = 50;
		myTextStyle.richText=true;

		GUI.DrawTexture(new Rect(10,10, 150, 150),LogoTexture); 
		GUI.DrawTexture (new Rect (200, 10, 75, 75), MobiliyaTexture);


		if (!btntexture) // This is the button that triggers AR and UI camera On/Off
		{
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}

		if (mShowGUIButton) {

			GUI.Label(new Rect(1920-100, 200, 550, 70), "<b> TARGET ACQUIRED </b>",myTextStyle);



			//GUI.Box (new Rect (0,0,100,50), "Top-left");
			//GUI.Box (new Rect (1920 - 100,0,100,50), "Top-right");
			//GUI.Box (new Rect (0,1080- 50,100,50), "Bottom-left");
			//GUI.Box (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Bottom right");

			// draw the GUI button
			if (GUI.Button(mButtonRect, btntexture)) {
				// do something on button click 
				OpenVideoActivity();
			}
		}
	}

	public void OpenVideoActivity()
	{
		var androidJC = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		var jo = androidJC.GetStatic<AndroidJavaObject>("currentActivity");
		// Accessing the class to call a static method on it
		var jc = new AndroidJavaClass("com.mobiliya.gepoc.StartVideoActivity");
		// Calling a Call method to which the current activity is passed
		jc.CallStatic("Call", jo);
	}

}
