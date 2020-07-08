using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int damegeTime;
    public bool damegi;
    public bool accel;
    private int time;
    public Animator enemyAni;
    private Collider col;
    private AudioSource audioSource;
  //  public bool cameraIn;
    // Start is called before the first frame update
    void Start()
    {
        damegi = false;
        col = this.gameObject.GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damegi == true)
        {
            time++;
            if (time == damegeTime*60)
            {
                damegi = false;
                time = 0;
            }
            if (time == 0)
            {
                //audioSource.Play();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            damegi = true;
        }
        if (other.gameObject.tag == "Weapon")
        {
            if (Input.GetKey(KeyCode.A))
            {
                enemyAni.SetTrigger("EnemyAttck");
                audioSource.Play();
                accel = true;
                // Destroy(col);
            }
        }
        else 
        {
            accel = false;
        }
        if (other.gameObject.tag == "beem")
        {
            enemyAni.SetTrigger("EnemyAttck");
        }
       
        
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            accel = false;
        }
    }
   /* private void OnWillRenderObject()
    {
        if (Camera.current.name == "MainCamera")
        {
            cameraIn = true;
        }
    }*/

}
