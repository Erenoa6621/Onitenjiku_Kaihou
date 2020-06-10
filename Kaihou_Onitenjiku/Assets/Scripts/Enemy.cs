using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int damegeTime;
    public bool damegi;
    private int time;
    public Animator enemyAni;
    // Start is called before the first frame update
    void Start()
    {
        damegi = false;
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
            }
        }
        if (other.gameObject.tag == "beem")
        {
            enemyAni.SetTrigger("EnemyAttck");
        }
    }
}
