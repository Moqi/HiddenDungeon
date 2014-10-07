using UnityEngine;
using System.Collections;

public class TestAmmoScript : MonoBehaviour {
	public FireTrigger fireTrigger;

	void Start ()
	{
		
	}

	void OnGUI () 
	{
		GUILayout.BeginArea(new Rect(300,100,300,100));
			GUILayout.Box(fireTrigger.ClipAmmo + "|" + fireTrigger.Ammo);
		GUILayout.EndArea();
	}
}
