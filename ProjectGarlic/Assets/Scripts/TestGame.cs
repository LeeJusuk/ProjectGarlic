using UnityEngine;
using System.Collections;

public class TestGame : MonoBehaviour {

	bool flag;
	public UIManager uiManager;

	void Awake(){
	}
	// Use this for initialization
	void Start () {
		Screen.SetResolution (Screen.width, Screen.width * 16 / 10, true);
		flag = false;
	}

	// Update is called once per frame
	void Update () {
		//init Game members
		if (!flag) { 
			flag = true;
			uiManager.init ();
			return;
		}
		//Update Game members
		if(uiManager.IsDefault()){
			//get Player Update also
		}
		uiManager._Update ();

	}
}
