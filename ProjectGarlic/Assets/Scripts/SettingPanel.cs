using UnityEngine;
using System.Collections;

public class SettingPanel : MyPanel {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI(){
	}

	// Update is called once per frame
	public override void _Update () {
		if(Input.GetKeyDown(KeyCode.Q)){
			uiManger.ActiveDefaultPanel ();
		}
	}

	public override void OnActive()
	{
		isActivate = true;
		gameObject.SetActive (true);
	}

	public override void OffActive()
	{
		isActivate = false;
		gameObject.SetActive (false);
	}

	public override void Debug(){
		print ("Setting");
	}
}
