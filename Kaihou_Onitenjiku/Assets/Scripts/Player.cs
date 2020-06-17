using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed;
    [SerializeField] float damegiSpeed;
    [SerializeField] float junpSpeed;
    public GameObject enemyCon;
    public GameObject player;
    public GameObject block;
    public bool blur;
    private Rigidbody rb;
    public bool junpCheck;
    public float nowSpeed;
    public bool enemyDamege;
    private bool blockDamege;
    public bool accel;


    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
        nowSpeed = playerSpeed;
        blur = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemyDamege = enemyCon.GetComponent<EnemyCon>().playerDamede;
        blockDamege = block.GetComponent<Enemy>().damegi;
        accel = enemyCon.GetComponent<EnemyCon>().playeraccel;

    
        if (enemyDamege == true || blockDamege == true)
        {
            nowSpeed = damegiSpeed;        
        }
        if (nowSpeed < 5)
        {
            nowSpeed = 5;
           
        }

     

        nowSpeed -= 0.5f * Time.deltaTime;
        transform.position += transform.right * nowSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow) && junpCheck == true)
        {
            rb.AddForce(0, junpSpeed, 0);
            junpCheck = false;
        }
        if (accel == true)
        {
            nowSpeed += 1;
        }

        if (nowSpeed > 20)
        {
            blur = true;
        }
        else
        {
            blur = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
      
        if (other.gameObject.tag == "Stage")
        {
            junpCheck = true;
        }

    }
    private void OnCollisionExit(Collision other)
    {
        enemyDamege = false;
        blockDamege = false;
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
