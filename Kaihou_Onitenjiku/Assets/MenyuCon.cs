﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenyuCon : MonoBehaviour
{
    // Start is called before the first frame update
    //public Text push;
    public Animator Ani;
    public bool check;
    public AudioClip Enter;
    public AudioClip Exit;
    public GameObject GameStart;
    public GameObject HowTo;
    public GameObject Close;
    AudioSource audioSource;
    public int Meynucase;
    private Vector3 Bigg;
    private Vector3 Nomal;
    private Vector3 GBiggPos;
    private Vector3 HBiggPos;
    private Vector3 CBiggPos;
    private Vector3 GNomalPos;
    private Vector3 HNomalPos;
    private Vector3 CNomalPos;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Meynucase = 0;
        Bigg = new Vector3(1.4f, 1.1f, 1.1f);
        Nomal = new Vector3(1.3f,1f,1f);
        GBiggPos = new Vector3(-2.3f,-1.4f,-11.71f);
        HBiggPos = new Vector3(-2.3f, -3f, -11.71f);
        CBiggPos = new Vector3(-2.3f, -4.45f, -11.71f);
        GNomalPos = new Vector3(-1.62f, -1.4f,-11.71f); ;
        HNomalPos = new Vector3(-1.62f, -3f, -11.71f);
        CNomalPos = new Vector3(-1.6f, -4.45f, -11.71f); ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Meynucase == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage1");
            }
            GameStart.transform.localScale = Bigg;
            HowTo.transform.localScale = Nomal;
            Close.transform.localScale = Nomal;
            GameStart.transform.position = GBiggPos;
            HowTo.transform.position = HNomalPos;
            Close.transform.position = CNomalPos; 
        }
        if (Meynucase == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (check == false)
                {
                    check = true;
                    Ani.SetTrigger("Entry");
                    audioSource.PlayOneShot(Enter);
                }
                else if (check == true)
                {               
                    check = false;
                    Ani.SetTrigger("Exit");
                    audioSource.PlayOneShot(Exit);
                    Meynucase = 1;
                    
                }
            }

            GameStart.transform.localScale = Nomal;
            HowTo.transform.localScale = Bigg;
            Close.transform.localScale = Nomal;
            GameStart.transform.position = GNomalPos;
            HowTo.transform.position = HBiggPos;
            Close.transform.position = CNomalPos;
        }
        if (Meynucase == 2)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Application.Quit();
            }
            GameStart.transform.localScale = Nomal;
            HowTo.transform.localScale = Nomal;
            Close.transform.localScale = Bigg;
            GameStart.transform.position = GNomalPos;
            HowTo.transform.position = HNomalPos;
            Close.transform.position = CBiggPos;
        }

   
      
        if (check == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Meynucase -= 1;
                if (Meynucase == -1)
                {
                    Meynucase = 3;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Meynucase++;
                if (Meynucase == 4)
                {
                    Meynucase = 0;
                }
            }
        }

   

       
      
        
    }
}
