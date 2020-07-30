using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPC : MonoBehaviour
{
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stage")
        {
            check = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Stage")
        {
            check = false;
        }
    }
}
