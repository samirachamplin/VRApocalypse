using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
		public BoxCollider territory;
		GameObject player;
		bool playerInTerritory;

		public GameObject enemy;
	EnemyChase basicenemy;

		// Use this for initialization
		void Start ()
		{
			player = GameObject.FindGameObjectWithTag ("Player");
		basicenemy = enemy.GetComponent <EnemyChase> ();
			playerInTerritory = false;
		}

		// Update is called once per frame
		void Update ()
		{
			if (playerInTerritory == true)
			{
				basicenemy.MoveToPlayer ();
			}

			if (playerInTerritory == false)
			{
				basicenemy.Rest ();
			}
		}

		void OnTriggerEnter (Collider other)
		{
			if (other.gameObject == player)
			{
				playerInTerritory = true;
			}
		}

		void OnTriggerExit (Collider other)
		{
			if (other.gameObject == player) 
			{
				playerInTerritory = false;
			}
		}
	}