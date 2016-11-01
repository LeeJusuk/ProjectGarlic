using UnityEngine;
using System.Collections;

public class DefaultPanel : MyPanel {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void _Update () {
		if(Input.GetKeyDown(KeyCode.Q)){
			uiManger.ActiveSettingPanel ();
		}
		if(Input.GetKeyDown(KeyCode.E)){
			uiManger.ActiveEvoPanel ();
		}
		if(Input.GetKeyDown(KeyCode.R)){
			uiManger.ActiveDnaPanel ();
		}
		if(Input.GetKeyDown(KeyCode.F)){
			uiManger.ActiveStatusPanel ();
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
		print ("default");
	}
}
