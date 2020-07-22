using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFloor : MonoBehaviour
{
    public GameObject floor;
    public GameObject subFloor;
    public GameObject PlayerPos;
    public Animator BossAni;
    private Vector3 nowPos;
    private Vector3 newPos;
    private bool cossCheck;
    private int randomFloor;
    private int counter; 
    public bool check;
    private bool counterCheck;
    public GameObject Meadow;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        nowPos = this.gameObject.transform.position;
        width = Meadow.GetComponent<SpriteRenderer>().bounds.size.x;
        newPos = new Vector3(nowPos.x + width, nowPos.y, nowPos.z);
        cossCheck = PlayerPos.GetComponent<BossStartTrigger>().bossStart;
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Weapon")
        {
            // GameObject floor = (GameObject)Resources.Load("mainFloor");
           
            Instantiate(floor, newPos, Quaternion.Euler(0f,0f,90f));

            Destroy(this.gameObject.transform.root.gameObject, 15);
            check = true;
            if (cossCheck == true)
            {
                randomFloor = Random.Range(0, 3);
                if (randomFloor == 0)
                {
                    counterCheck = true;
                    if (counter == 30)
                    {
                        BossAni.SetTrigger("BossStay");
                        counter = 0;
                    }
                
                }
                if (randomFloor == 1)
                {
                    Instantiate(subFloor, new Vector3(nowPos.x+30,nowPos.y + 5,nowPos.z), Quaternion.identity);
                    counterCheck = true;
                    if (counter == 30)
                    {
                        BossAni.SetTrigger("BossStay1");
                        counter = 0;
                    }
                }
                if (randomFloor == 2)
                {
                    Instantiate(subFloor, new Vector3(nowPos.x+30, nowPos.y + 10, nowPos.z), Quaternion.identity);
                    counterCheck = true;
                    if (counter == 30)
                    {
                        BossAni.SetTrigger("BossStay2");
                        counter = 0;
                    }
                }

                if (counterCheck == true)
                {
                    counter++;
                }
            }
        }
    
    }
}
