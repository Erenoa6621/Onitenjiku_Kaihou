using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCon : MonoBehaviour
{
  
    public GameObject[] block;
    private bool damege;
    public bool playerDamede;
    private bool accel;
    public bool playeraccel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // enemyDamege = enemyCon.GetComponent<Enemy>().damegi;
        //blockDamege = block.GetComponent<Enemy>().damegi;
        //accel = enemyCon.GetComponent<Enemy>().accel;
        playeraccel = false;
        playerDamede = false;

        for (int i = 0; i < block.Length; i++)
        {
            damege = block[i].GetComponent<Enemy>().damegi;
            if (damege == true)
            {
                playerDamede = true;
            }
        }
    }
}
