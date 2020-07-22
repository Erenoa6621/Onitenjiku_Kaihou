using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : MonoBehaviour
{
    private bool start;
    public Vector3 pos;
    public GameObject playerPos;
    public GameObject mainPlayer;
    public Animator bossAni;
    private float speed;
    public bool Slash;
    public bool fire;
    public int randomCountMax;
    private int countdouwn = 0;
    private bool countdouwnTrigger;
    private bool Pouse;
    public GameObject PCon;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Pouse = PCon.GetComponent<PouseCon>().Pouse;
        if (Pouse == false)
        {
            start = playerPos.GetComponent<BossStartTrigger>().bossStart;
            pos = this.gameObject.transform.position;
            speed = mainPlayer.GetComponent<Player>().nowSpeed;
            int randomCount = Random.Range(1, randomCountMax);
            if (start == true)
            {
                transform.position = new Vector3(playerPos.transform.position.x + speed * Time.deltaTime, pos.y, pos.z);
            }

            if (countdouwnTrigger == false)
            {
                if (randomCount == 1)
                {
                    fire = true;
                    countdouwnTrigger = true;
                    bossAni.SetTrigger("Atack2");
                }
                else if (randomCount == 2)
                {
                    countdouwnTrigger = true;
                    Slash = true;
                    bossAni.SetTrigger("Atack1");
                }
                else
                {
                    fire = false;
                    Slash = false;
                }
            }
            else
            {
                fire = false;
                Slash = false;
                countdouwn++;
                if (countdouwn == 60)
                {
                    countdouwn = 0;
                    countdouwnTrigger = false;
                }
            }
        }
    }
}
