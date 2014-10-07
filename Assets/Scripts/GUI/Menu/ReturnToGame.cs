using UnityEngine;
using System.Collections;

public class ReturnToGame : MonoBehaviour {
	public TouchController touchController;
	public GameObject GUIMenu;

	void OnClick ()
	{
		touchController.enabled = true;
		GUIMenu.SetActive (false);
	}
}
