using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BoosLoop;
    private Vector3 nowPos;
    private Vector3 newPos;

    public bool check;
    // Start is called before the first frame update
    void Start()
    {
        nowPos = this.gameObject.transform.position;
        newPos = new Vector3(nowPos.x + 250, nowPos.y, nowPos.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            // GameObject floor = (GameObject)Resources.Load("mainFloor");
            Instantiate(BoosLoop, newPos, Quaternion.identity);

            Destroy(this.gameObject.transform.root.gameObject, 30);
            check = true;
        }

    }
}
