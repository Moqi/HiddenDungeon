using UnityEngine;
using System.Collections;

public class TestButtons : MonoBehaviour {
	public TouchController touchControl;
	public GameObject MenuNGUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
/*		if(CFInput.GetButton("Fire3"))		//In the FireTrigger Script
		{
			print ("Fire");
		}
*/
		if(CFInput.GetButton("Menu"))
		{
			print ("Menu");
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				touchControl.enabled = false;
				MenuNGUI.SetActive (true);
//				MenuNGUI.SetActive = true;
			}
			else
			{
				Time.timeScale = 1;
			}
		}
		
		if(CFInput.GetButton("Action"))
		{
			print ("Action");
		}
		
		if(CFInput.GetButton("Inven"))
		{
			print ("Inven");
		}
	}
}
