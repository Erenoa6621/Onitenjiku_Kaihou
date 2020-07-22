using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossJanpCon : MonoBehaviour
{
    private bool UCheck;
    private bool MUCheck;
    public GameObject Upcaheck;
    public GameObject MostUpCheck;
    public Animator BossJunp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UCheck = Upcaheck.GetComponent<UPC>().check;
        MUCheck = MostUpCheck.GetComponent<MUC>().check;

        if (MUCheck == false && UCheck == true)
        {
            BossJunp.SetBool("BossStay", false);
            BossJunp.SetBool("BossStay1",true);
            BossJunp.SetBool("BossStay2", false);
        }
        else if (MUCheck == true && UCheck == false)
        {
            BossJunp.SetBool("BossStay", false);
            BossJunp.SetBool("BossStay1", false);
            BossJunp.SetBool("BossStay2", true);
        }
        else if (MUCheck == true && UCheck == true)
        {
            BossJunp.SetBool("BossStay", false);
            BossJunp.SetBool("BossStay1", false);
            BossJunp.SetBool("BossStay2", true);
        }
        else 
        {
            BossJunp.SetBool("BossStay", true);
            BossJunp.SetBool("BossStay1", false);
            BossJunp.SetBool("BossStay2", false);
        }
    }
}
