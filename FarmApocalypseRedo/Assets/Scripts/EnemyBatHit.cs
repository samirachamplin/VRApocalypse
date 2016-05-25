using UnityEngine;
using System.Collections;
using Rewired;

public class EnemyBatHit : MonoBehaviour {
	private Player player;
	public AudioClip hitClip;
	public int playerId = 0;
	public Animation batswing;

	void Awake ()
	{
		player = ReInput.players.GetPlayer(playerId);
	}	

	void Update (){
		if (player.GetButton ("Fire_1")) {
			batswing.Play ();

		}
	}


void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Bat")
		{
			//ragdoll sheep
			AudioSource.PlayClipAtPoint(hitClip, transform.position);


		}
	}
}
