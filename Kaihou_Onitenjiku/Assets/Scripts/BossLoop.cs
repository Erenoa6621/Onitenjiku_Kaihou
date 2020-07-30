using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BoosLoop;
    private Vector3 nowPos;
    private Vector3 newPos;
    private float whidew;
    public bool check;
    public GameObject stage;
    // Start is called before the first frame update
    void Start()
    {
        nowPos = this.gameObject.transform.position;
        whidew = stage.GetComponent<SpriteRenderer>().bounds.size.x;
        newPos = new Vector3(nowPos.x + whidew, nowPos.y, nowPos.z);
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

            Destroy(this.gameObject.transform.root.gameObject, 100);
            check = true;
        }

    }
}
