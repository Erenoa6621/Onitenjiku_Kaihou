using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutaSwing : MonoBehaviour
{
    GameObject BossPos;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BossPos = GameObject.Find("SwingOut");
        pos = BossPos.transform.position;
        transform.position = pos;
        Destroy(this.gameObject, 0.4f);
        
    }
}
