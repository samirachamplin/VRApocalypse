using UnityEngine;
using System.Collections;

public class JoystickTest : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("X"))
			
		{
			Debug.Log ("Works");
		}
	}
}
