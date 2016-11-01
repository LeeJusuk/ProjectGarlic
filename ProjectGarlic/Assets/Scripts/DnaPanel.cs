using UnityEngine;
using System.Collections;

public class DnaPanel : MyPanel {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
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
		print ("Dna");
	}
}
