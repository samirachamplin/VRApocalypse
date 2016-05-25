using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {
	public float bulletSpeed = 10;
	public Rigidbody bullet;
	// Use this for initialization
	void Start () {

		bullet.velocity = transform.forward * bulletSpeed;
	}
	

}
