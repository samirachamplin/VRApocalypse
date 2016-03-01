using UnityEngine;
using System.Collections;

public class BatAttack : MonoBehaviour {


	//void onclick () {
		//Play.animation()
		//}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sheep")
		{
			//Apply force To sheep 

		}
	}
}
