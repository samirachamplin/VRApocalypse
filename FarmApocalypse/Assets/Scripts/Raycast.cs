using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {
	public Camera CameraFacing;
	public float Speed;
	public GameObject Cube;
	void Update () {
		RaycastHit hit;	
		{
			if (Physics.Raycast  (new Ray (CameraFacing.transform.position,
				CameraFacing.transform.rotation * Vector3.forward),
				out hit)) {
				if (hit.collider.tag == "Test")
				{
					GetComponent<Rigidbody>().velocity = transform.forward * Speed;
					Destroy (Cube);
				}

			}
		}
	}
}