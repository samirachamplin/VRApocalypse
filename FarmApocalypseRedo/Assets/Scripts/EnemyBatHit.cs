using UnityEngine;
using System.Collections;

public class EnemyBatHit : MonoBehaviour {

void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Bat")
		{
			//Apply force To sheep 

		}
	}
}
