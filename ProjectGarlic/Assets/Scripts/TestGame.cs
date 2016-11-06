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

	//기준 화면 폭
	static readonly float defaultScreenWidth = 1136;
	//현재 지정되어 있는 화면 폭과 실제 화면 폭과의 비율을 계산
	public static Rect ScaleRect(Rect origin){		
		float factorSize = Screen.width / defaultScreenWidth;

		float scalePosX	=origin.x*factorSize;
		float scalePosY	=origin.y*factorSize;
		float scaleSizeX=origin.width*factorSize;
		float scaleSizeY=origin.height*factorSize;

		return new Rect(scalePosX,scalePosY,scaleSizeX,scaleSizeY);
	}
	public static Rect ScaleRect(float originX,float originY, float originWieth,float originHeight){		
		float factorSize = Screen.width / defaultScreenWidth;

		float scalePosX	=originX*factorSize;
		float scalePosY	=originY*factorSize;
		float scaleSizeX=originWieth*factorSize;
		float scaleSizeY=originHeight*factorSize;		

		return new Rect(scalePosX,scalePosY,scaleSizeX,scaleSizeY);
	}
}
