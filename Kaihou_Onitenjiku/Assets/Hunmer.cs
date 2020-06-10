using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunmer : MonoBehaviour
{
    public Animator HunmerAni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HunmerAni.SetTrigger("Atack");
        }

    }
}
