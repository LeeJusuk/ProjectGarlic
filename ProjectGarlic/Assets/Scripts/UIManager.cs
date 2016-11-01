using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	enum UiFlag{
		Default,
		Dna,
		Setting,
		Evo,
		Status
	}
	UiFlag uiFlag;
	MyPanel[] panels ;
	int length;
	// Use this for initialization
	void Start () {
		panels = gameObject.GetComponentsInChildren<MyPanel> ();
		length = panels.Length;
		/*
		print (length);
		for(int i=0;i<length;i++){
			panels [i].Debug ();
		}*/
	}
	
	// Update is called once per frame
	public void _Update () {
		panels [(int)uiFlag]._Update ();
	}

	public void init(){
		this.ActiveDefaultPanel ();
	}

	public void ActiveDnaPanel()
	{
		panels [0].OffActive();
		panels [1].OnActive ();
		uiFlag = UiFlag.Dna;
	}

	public void ActiveSettingPanel()
	{
		panels [0].OffActive();
		panels [2].OnActive ();
		uiFlag = UiFlag.Setting;
	}

	public void ActiveEvoPanel()
	{
		panels [0].OffActive();
		panels [3].OnActive ();
		uiFlag = UiFlag.Evo;
	}

	public void ActiveStatusPanel()
	{
		panels [0].OffActive();
		panels [4].OnActive ();
		uiFlag = UiFlag.Status;
	}

	public void ActiveDefaultPanel()
	{
		for(int i=1;i<length;i++)
			panels [i].OffActive();
		
		panels [0].OnActive ();
		uiFlag = UiFlag.Default;

	}
	public bool IsDefault()
	{
		if (uiFlag == UiFlag.Default)
			return true;
		else
			return false;
	}
}
