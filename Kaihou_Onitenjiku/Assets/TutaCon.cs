using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutaCon : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 nowPos;
    void Start()
    {
        nowPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        nowPos.x += 5 * Time.deltaTime;
        transform.position = nowPos;

    }
}
