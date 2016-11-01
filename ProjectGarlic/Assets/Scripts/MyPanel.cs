using UnityEngine;
using System.Collections;

public class MyPanel : MonoBehaviour {

	protected Animator animator;
	protected bool isActivate;
	protected UIManager uiManger;

	void Awake()
	{
		uiManger = gameObject.GetComponentInParent<UIManager> ();
		//uiManger = GameObject.Find ("Canvas").GetComponent<UIManager>();
	}

	public bool IsActivate()
	{
		return isActivate;
	}
	public virtual void _Update(){
	}

	public virtual void OnActive()
	{
		
	}

	public virtual void OffActive()
	{

	}

	public virtual void Debug(){
	}
}
