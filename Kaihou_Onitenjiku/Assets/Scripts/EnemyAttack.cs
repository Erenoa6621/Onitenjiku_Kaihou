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
	float period = 2f;
	public Animation ani;

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
		acceleration += (diff - velocity * period) * 2f / (period * period);

		if (acceleration.magnitude > 100f)
		{
			acceleration = acceleration.normalized * 100f;
		}
		period -= Time.deltaTime;
		velocity += acceleration * Time.deltaTime;
	}

	void FixedUpdate()
	{
		if (check == false)
		{
			rigid.MovePosition(transform.position + velocity * Time.deltaTime);
		}
		else if (check == true)
		{
			transform.position = transform.position;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(this.gameObject,5);
			check = true;
		}
		if (other.gameObject.tag == "Weapon")
		{
			if (Input.GetKey(KeyCode.A))
			{
				Destroy(this.gameObject);
			}
		}
	}
}