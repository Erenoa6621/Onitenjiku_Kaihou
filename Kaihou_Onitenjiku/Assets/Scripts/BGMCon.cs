using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMCon : MonoBehaviour
{
    public GameObject BossCheck;
    private bool check;
    public bool Nomal;
    public bool Boss;
    public bool Clear;
    public GameObject bossLife;
    private bool end;
    // Start is called before the first frame update
    void Start()
    {
 
        check = false;
      
    }

    // Update is called once per frame
    void Update()
    {
     
        check = BossCheck.GetComponent<BossStartTrigger>().bossStart;
        end = bossLife.GetComponent<BossLife>().end;
        if (check == true && end == false)
        {
            Boss = true;
            Nomal = false;
            Clear = false;
        }
        else if (check == false && end == false)
        {
            Boss = false;
            Nomal = true;
            Clear = false;
        }
        else if (end == true)
        {
            Clear = true;
            Boss = false;
            Nomal = false;
        }

    }
}
