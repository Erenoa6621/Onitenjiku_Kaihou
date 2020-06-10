using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beem : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem beem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            beem.Play();
        }
        else
        {
            beem.Stop();
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("しんだ！");

        }

    }
}