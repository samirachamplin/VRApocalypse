using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	public Animation anim;

	// Use this for initialization
	void Start () {
		anim.Play();

	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
	{
			Debug.Log ("Something");
			Application.LoadLevel ("#3 Farmhouse");
	}
}
