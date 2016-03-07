using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {

	public float speed;
	//void onclick () {
		//Play.animation()
		//}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sheep")
		{
			transform.TransformDirection(new Vector3(0, 0,speed));
		}

		}
	}
