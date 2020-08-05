using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bakuha;
    public GameObject Enemy;
    private bool check;
    void Start()
    {
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy.GetComponent<Enemy>().ExFlag == true)
        {
            if (check == false)
            {
              GameObject Ex =  Instantiate(bakuha, this.gameObject.transform.position, Quaternion.identity);
                check = true;
                Destroy(Ex, 0.2f);
            }
        }
    }
  
}
