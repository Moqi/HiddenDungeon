using UnityEngine;
using System.Collections;

public class FireTrigger : MonoBehaviour {
	public Animator Animat;

	public GameObject GunBarrel;
	public Light GunLight;
	public ParticleSystem GunEffect;

	public float RateOfFire = 60;
	public float Range = 50;
	public float ReloadTime = 2;

	public float Ammo = 60;
	public float ClipAmmo = 15;
	public float ClipSize = 15;

	public bool Reloading = false;

	public AudioClip GunSound;
	public AudioClip PlayerGunSound;
	public AudioClip ReloadSound;
	public AudioClip NoAmmoSound;


	// Use this for initialization
	void Start () 
	{
		GunLight.enabled = false;
	}

	private float nextFire;
	private bool HasAmmo;

/*	void Update () 
//	void OnClick ()
	{
		if(Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + (RateOfFire/60);
			FireGun ();
		}
	}
*/
	void Update () 
	{
		if (Reloading) return;
//		if (Reloading || Ammo < 1) return;
		if (Ammo < 1 && ClipAmmo < 1)
		{
			audio.PlayOneShot (NoAmmoSound);
			return;
		}

		//Reload
		if (ClipAmmo < 1) 
	 	{
			//			RelaodGun ();
			audio.PlayOneShot (ReloadSound);
			Animat.SetBool("Reloading",true);

			StartCoroutine (Relaod());
		}

		//Fire the gun
		if(CFInput.GetButton("Fire3") && Time.time > nextFire)
		{
			nextFire = Time.time + (RateOfFire/60);
			Firing = false;
			FireGun ();
			ClipAmmo -= 1;		//TEMP
//			Animat.SetBool("Shooting",true);
		}
	}

	public bool Firing = false;

	void FireGun ()
	{
		if (Firing) return;
		Firing = true;
		Animat.SetBool("Shooting",true);
		StartCoroutine(GunFlash());
		
		audio.PlayOneShot (GunSound);
		audio.PlayOneShot (PlayerGunSound);

		Vector3 fwd = GunBarrel.transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		if (Physics.SphereCast(GunBarrel.transform.position, 1f, fwd, out hit, Range))
		{
			print("GameObject: " + hit.collider.gameObject.name);
		}
	}

	void ReloadGun ()
	{
		//Remove Ammo form Ammo and move to ClipAmmo
		if (Ammo < ClipSize)
		{
			ClipAmmo = Ammo;
			Ammo = 0;
		}
		else
		{
			ClipAmmo = ClipSize;
			Ammo -=ClipSize;
		}
	}

	
	IEnumerator Relaod () {
		Reloading = true;
		yield return new WaitForSeconds(ReloadTime);
		ReloadGun ();
		Animat.SetBool("Reloading",false);
		Reloading = false;
	}

	IEnumerator GunFlash () {
		GunEffect.Play(true);
		GunLight.enabled = true;
		yield return new WaitForSeconds(0.1f);
		GunLight.enabled = false;
		yield return new WaitForSeconds(0.2f);
		Animat.SetBool("Shooting",false);
	}

	/*
	void OnDrawGizmos(Vector3 Start, Vector3 End, bool truefalse) {
		if (truefalse) 
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawLine(Start, End);
		}
	} */
}
