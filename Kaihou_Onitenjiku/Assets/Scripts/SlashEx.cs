using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashEx : MonoBehaviour
{
    // Start is called before the first frame update
    public int randomCountMax;
    public GameObject slashAttack;
    private bool bossVs;
    public GameObject vsStart;
    public bool trigger;
    public GameObject Boss;
    private bool lag;
    private int count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bossVs = vsStart.GetComponent<BossStartTrigger>().bossStart;
        trigger = Boss.GetComponent<MoveBoss>().Slash;


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
                Instantiate(slashAttack, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
