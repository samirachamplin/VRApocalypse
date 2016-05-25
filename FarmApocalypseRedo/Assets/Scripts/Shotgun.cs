using UnityEngine;
using System.Collections;
using Rewired;
public class Shotgun : MonoBehaviour {
	private float nextFire = 0.0F;
	public float fireRate = 0.5F;
	public GameObject shot;
	public int playerId = 0;
	private Player player;
	public AudioClip shotClip;
	void Awake ()
	{
		player = ReInput.players.GetPlayer(playerId);
	}	

	void Update ()
	{
		if (player.GetButton ("Fire_1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint (shotClip, transform.position);
		}
	}
}