using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingOut : MonoBehaviour
{
    public int randomCountMax;
    public GameObject Attack;
    private bool bossVs;
    public GameObject vsStart;
    public bool trigger;
    public GameObject Boss;
    public int count;
    private bool lag;
    private int type;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bossVs = vsStart.GetComponent<BossStartTrigger>().bossStart;
        trigger = Boss.GetComponent<MoveBoss>().sinugayoi;
        type = Boss.GetComponent<MoveBoss>().bossTipe;

        if (bossVs == true)
        {
            if (trigger == true)
            {
                lag = true;
            }
        }
        if (lag == true)
        {
            count++;
            if (count == 25)
            {
                lag = false;
                count = 0;
                Instantiate(Attack, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
