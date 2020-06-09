using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed;
    [SerializeField] float damegiSpeed;
    [SerializeField] float junpSpeed;
    public GameObject enemy;
    public GameObject player;
    public GameObject block;
   
    private Rigidbody rb;
    public bool junpCheck;
    public float nowSpeed;
    private bool enemyDamege;
    private bool blockDamege;
   

    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyDamege = enemy.GetComponent<Enemy>().damegi;
        blockDamege = block.GetComponent<Enemy>().damegi;
      

        if (enemyDamege == false && blockDamege == false )
        {
            transform.position += transform.right * playerSpeed * Time.deltaTime;
            nowSpeed = playerSpeed;
        }
        else if (enemyDamege == true || blockDamege == true)
        {
            transform.position += transform.right * damegiSpeed * Time.deltaTime;
            nowSpeed = damegiSpeed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && junpCheck == true)
        {
            rb.AddForce(0, junpSpeed, 0);
            junpCheck = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stage")
        {
            junpCheck = true;
        }

    }
  /*  void movePlayer()
    {
        if (playerDamege == false)
        {
            transform.position += transform.right * playerSpeed * Time.deltaTime;
            nowSpeed = playerSpeed;
        }
        else if (playerDamege == true)
        {
            transform.position += transform.right * damegiSpeed * Time.deltaTime;
            nowSpeed = damegiSpeed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && junpCheck == true)
        {
            rb.AddForce(0, junpSpeed, 0);
            junpCheck = false;
        }

    }*/
}
