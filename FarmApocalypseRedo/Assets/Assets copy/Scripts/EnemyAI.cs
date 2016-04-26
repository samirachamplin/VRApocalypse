using UnityEngine;
using System.Collections;

public class EnemyAI: MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public bool inTrigger;
	public int maxDistance;

	private Transform myTransform;

	void Awake() {
		myTransform = transform;
	}

	// Use this for initialization
	void Start() {
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;

		maxDistance = 2;
	}

	// Update is called once per frame
	void Update() {

		if(inTrigger){
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

			if(Vector3.Distance(target.position, myTransform.position) > maxDistance){
				myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			}
		}

	}

	void OnTriggerEnter(Collider other) {
		inTrigger = true;
	}

	void OnTriggerExit(Collider other) {
		inTrigger = false;    
	}
}