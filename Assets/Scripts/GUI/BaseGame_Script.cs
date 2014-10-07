using UnityEngine;
using System.Collections;

public class BaseGame_Script : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CFInput.GetButton ("Pause"))
		{
			Time.timeScale = 0f;
		}
	}
}
