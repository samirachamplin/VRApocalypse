using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {

<<<<<<< Updated upstream
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
=======
	void Update(){
		if (Input.GetMouseButtonDown (0)) {
	//play bat animation	
		}
	}
}
>>>>>>> Stashed changes
