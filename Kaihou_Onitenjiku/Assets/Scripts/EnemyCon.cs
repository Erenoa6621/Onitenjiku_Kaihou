using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] enemy;
    private bool damege;
    public bool playerDamede;
    private  bool accel;
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

        for (int i = 0; i < enemy.Length; i++)
        {
            damege = enemy[i].GetComponent<Enemy>().damegi;
            accel = enemy[i].GetComponent<Enemy>().accel;
            if (damege == true)
            {
                playerDamede = true;
            }
            if (accel == true)
            {
                playeraccel = true;
            }
        }
    }
}
