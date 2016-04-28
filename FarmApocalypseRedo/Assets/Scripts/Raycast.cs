using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {
	public Camera CameraFacing;
	void Update () {
		RaycastHit hit;	
		{
			if (Physics.Raycast  (new Ray (CameraFacing.transform.position,
				CameraFacing.transform.rotation * Vector3.forward),
				out hit)) {
				if (hit.collider.tag == "Trigger")
				{
					// move BOTH cameras
					Debug.Log("triggered");
				}

			}
		}
	}
}