using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenyuCon : MonoBehaviour
{
    // Start is called before the first frame update
    public Text push;
    public Animator Ani;
    private bool check;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (check == false)
            {
                check = true;
                Ani.SetTrigger("Entry");
            }
            else
            {
                check = false;
                Ani.SetTrigger("Exit");
            }
        }

        if (check == false)
        {
            push.enabled = true;
        }
        else
        {
            push.enabled = false;

        }


      
        
    }
}
