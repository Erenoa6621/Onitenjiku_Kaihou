using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStartTrigger : MonoBehaviour
{
    public bool bossStart = false;
    public Animator bossAni;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bossStart = true;
            bossAni.SetTrigger("BossStert");
            Player.transform.position = this.gameObject.transform.position;
        }
    }
}
