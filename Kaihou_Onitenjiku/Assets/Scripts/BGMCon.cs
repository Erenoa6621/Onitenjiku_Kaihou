using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMCon : MonoBehaviour
{
    public GameObject BossCheck;
    private bool check;
    public bool Nomal;
    public bool Boss;
    // Start is called before the first frame update
    void Start()
    {
 
        check = false;
      
    }

    // Update is called once per frame
    void Update()
    {
     
        check = BossCheck.GetComponent<BossStartTrigger>().bossStart;
        if (check == true)
        {
            Boss = true;
            Nomal = false;
        }
        else
        {
            Boss = false;
            Nomal = true;
        }
       

    }
}
