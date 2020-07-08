using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCounterMissile : MonoBehaviour
{
    Rigidbody rigid;
    Vector3 velocity;
    Vector3 position;
    private Vector3 acceleration;
    private GameObject enemy;
    private bool check;
    float period = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        //check = false;
        //position = transform.position;
        //rigid = this.GetComponent<Rigidbody>();
        //enemy = GameObject.Find("BossEnemy");
        //velocity = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //acceleration = Vector3.zero;
        //var diff = enemy.transform.position - transform.position;
        //acceleration += (diff - velocity * period) * 0.1f / (period * period);
        //period -= Time.deltaTime;
        //velocity += acceleration * Time.deltaTime;
        Destroy(this.gameObject, 10);
    }
    void FixedUpdate()
    {
      //   rigid.MovePosition(transform.position + velocity * Time.deltaTime);
        transform.position += transform.right * 25f * Time.deltaTime;
       // rigid.AddForce(new Vector3(0.0f, 0.5f, 0.0f));
    }
}
