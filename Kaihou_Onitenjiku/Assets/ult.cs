using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ult : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5f);
        transform.position += transform.right * 60f * Time.deltaTime;
    }
}
