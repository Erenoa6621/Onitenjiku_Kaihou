using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
	Rigidbody rigid;
	Vector3 velocity;
	Vector3 position;
	private Vector3 acceleration;
	public GameObject player;
	private bool check;
	float period = 3f;
	public bool backTrigger;
	private Vector3 backVec;
	private bool damege;
	private bool counter;
	void Start()
	{
		check = false;
		position = transform.position;
		rigid = this.GetComponent<Rigidbody>();
		velocity = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0);

	}

	void Update()
	{
		acceleration = Vector3.zero;
		var diff = player.transform.position - transform.position;
		acceleration += (diff - velocity * period) * 1f / (period * period);
		period -= Time.deltaTime;
		velocity += acceleration * Time.deltaTime;
		backTrigger = false;
		damege = player.GetComponent<Player>().missileDamege;
		counter = player.GetComponent<Player>().missileCounter;

		if (damege == true)
		{
			Destroy(this.gameObject);
			check = true;
		}
		if (counter == true)
		{
			backVec = rigid.velocity;
			backTrigger = true;
			rigid.velocity = Vector3.zero;
		}
	}

	void FixedUpdate()
	{
		if (check == false && backTrigger == false)
		{
			rigid.MovePosition(transform.position + velocity * Time.deltaTime);
		}
		else if (check == true)
		{
			transform.position = transform.position;
		}
		else if (backTrigger == true)
		{
			rigid.velocity = -1f * backVec;
		}
		Destroy(this.gameObject, 5);
		
	}
/*	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "Weapon")
		{
			if (Input.GetKey(KeyCode.A))
			{
				backVec = rigid.velocity;
				backTrigger = true;
				rigid.velocity = Vector3.zero;
			}
		}
	}
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
			check = true;
		}
	}*/
}