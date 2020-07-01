using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : MonoBehaviour
{
    private bool start;
    public Vector3 pos;
    public GameObject playerPos;
    public GameObject mainPlayer;
    private float speed;
    public bool Slash;
    public bool fire;
    public int randomCountMax;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        start = playerPos.GetComponent<BossStartTrigger>().bossStart;
        pos = this.gameObject.transform.position;
        speed = mainPlayer.GetComponent<Player>().nowSpeed;
        int randomCount = Random.Range(1, randomCountMax);
        if (start == true)
        {
            transform.position = new Vector3(playerPos.transform.position.x + speed * Time.deltaTime, pos.y, pos.z);
        }
        if (randomCount == 1)
        {
            fire = true;
        }
        else if (randomCount == 2)
        {
            Slash = true;
        }
        else
        {
            fire = false;
            Slash = false;
        }

    }
}
