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
    public AudioClip Enter;
    public AudioClip Exit;

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (check == false)
            {
                check = true;
                Ani.SetTrigger("Entry");
                audioSource.PlayOneShot(Enter);
               
            }
            else
            {
                check = false;
                Ani.SetTrigger("Exit");
                audioSource.PlayOneShot(Exit);
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

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
      
        
    }
}
