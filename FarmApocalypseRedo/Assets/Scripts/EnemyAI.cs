using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	PlayerHealth playerHealth;    
	public GameObject player; 
	public Transform tr_Player;
	public float f_RotSpeed=3.0f,f_MoveSpeed = 3.0f;
	public int attackDamage = 100;  
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		tr_Player = GameObject.FindGameObjectWithTag ("Player").transform; }

	// Update is called once per frame
	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
	}
	void Update () {
		/* Look at Player*/
		transform.rotation = Quaternion.Slerp (transform.rotation , Quaternion.LookRotation (tr_Player.position - transform.position) , f_RotSpeed * Time.deltaTime);

		/* Move at Player*/
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
	void FixedUpdate()
	{

		rb.AddForce(transform.forward * f_MoveSpeed);
	
		float stayY = GetComponent<Rigidbody>().transform.position.y;
		stayY = 0;
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			Invoke("Damage", 1);
		}
	}
	void Damage ()
	{
		playerHealth.TakeDamage (attackDamage);

	}
}