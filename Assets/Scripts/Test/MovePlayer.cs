using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	//Vars
	public GameObject Player;
	public CharacterController CharController;
	public Animator Animat;
	public float Speed = 100.0f;
	public float RotateSpeed = 100.0f;

	public UISlider rotationSlider;

	void Start () 
	{

	}

	void Update () 
	{
		RotateSpeed = ((rotationSlider.value - 0.5f) * 50) + 100;

		float translation = CFInput.GetAxis("Vertical") * Speed;
//		float translation = Input.GetAxis("Vertical") * Speed;
		float rotation = CFInput.GetAxis("Horizontal") * RotateSpeed;
//		float rotation = Input.GetAxis("Horizontal") * RotateSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		Vector3 forward = transform.TransformDirection(Vector3.forward * translation);
		CharController.SimpleMove (forward);
		transform.Rotate(0, rotation, 0);

//		float spd = CFInput.GetAxis ("Vertical")*10;
//		print (spd);
		Animat.SetFloat ("Speed",CFInput.GetAxis ("Vertical"));
//		Animat.SetFloat ("Speed",spd);
//		Animat.SetFloat ("Direction",CFInput.GetAxis ("Horizontal"));
	}
}
