using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackExit : MonoBehaviour
{
    public int randomCountMax;
    public GameObject Attack;
    private bool bossVs;
    public GameObject vsStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossVs = vsStart.GetComponent<BossStartTrigger>().bossStart;
        int randomCount = Random.Range(1, randomCountMax);

        if (bossVs == true)
        {
            if (randomCount == 1)
            {
                Instantiate(Attack, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
