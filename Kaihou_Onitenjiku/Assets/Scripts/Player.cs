using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed;
    [SerializeField] float damegiSpeed;
    [SerializeField] float junpSpeed;
    public GameObject playerPos;
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
    public Animator playerAni;
    public bool missileDamege;
    public bool missileCounter;
    public bool ult;
    private bool BossStart;
    public GameObject bossSrtartTriger;
    public GameObject BlockCon;
    private int junpCount;
    public GameObject Kuronoa;
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
        BossStart = bossSrtartTriger.GetComponent<BossStartTrigger>().bossStart;
        blockDamege = BlockCon.GetComponent<BlockCon>().playerDamede;
    
        if (enemyDamege == true || blockDamege == true)
        {
            nowSpeed = damegiSpeed;
            playerAni.SetTrigger("Damege");
        }
        if (nowSpeed < 5)
        {
            nowSpeed = 5;
           
        }
        if (nowSpeed > 20)
        {
            nowSpeed = 20;
        }

     

        nowSpeed -= 0.3f * Time.deltaTime;
        transform.position += transform.right * nowSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        if (Input.GetKeyDown(KeyCode.Space) && junpCheck == true)
        {
            rb.velocity = new Vector3(0.0f, junpSpeed, 0.0f);
            playerAni.SetTrigger("Junp");
            playerAni.SetBool("JunpEnd", false);
            junpCheck = false;
        }
        if (accel == true)
        {
            nowSpeed += 2;
        }

        if (nowSpeed > 18)
        {
            blur = true;
            Kuronoa.gameObject.SetActive(true);

        }
        else
        {
            blur = false;
            Kuronoa.gameObject.SetActive(false);
        }
        



        if (BossStart == true && nowSpeed > 18 && Input.GetKey(KeyCode.S))
        {
            ult = true;
          
            nowSpeed = 10;
        }
        else 
        {
            ult = false;
           
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAni.SetTrigger("Atack");
        }
    }
    void OnCollisionEnter(Collision other)
    {
      
        if (other.gameObject.tag == "Stage")
        {
            junpCheck = true;

            playerAni.SetBool("JunpEnd",true);
        }

        if (other.gameObject.tag == "beem")
        {
            nowSpeed = 10;
            transform.position = new Vector3(transform.position.x,transform.position.y,playerPos.transform.position.z);// playerPos.transform.position;
            Destroy(other.gameObject);
            playerAni.SetTrigger("Damege");
        }
        else
        {
            missileDamege = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "beem")
        {
            if (Input.GetKey(KeyCode.A))
            {
                missileCounter = true;
                nowSpeed += 3;
                Destroy(other.gameObject);
            }
          
        }
        else
        {
            missileCounter = false;
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
