using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    private bool check;
    public int Type;
    private int count;
    public GameObject Con;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Type == 0)
        {
            check = Con.GetComponent<BGMCon>().Nomal;
        }
        else if (Type == 1)
        {
            check = Con.GetComponent<BGMCon>().Boss;
        }
        if (check == true && count == 0)
        {
            audioSource.Play();
            count++;
        }
        else if (check == false)
        {
            audioSource.Stop();
        }
       
        
    }
}
