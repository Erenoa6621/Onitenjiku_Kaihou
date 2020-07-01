using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform cameraTrans;
    [SerializeField] Transform playerTrans;
    private Vector3 cameraVec;
    private Vector3 lerpCamera;
    public GameObject player;
    public GameObject cameraPos;
    private bool speedTrigger;
    public float moveSpeed;
   
    void Start()
    {
        cameraTrans = transform;

    }
    void LateUpdate()
    {
        cameraVec = cameraPos.transform.position - player.transform.position;
        speedTrigger = player.GetComponent<Player>().blur;

        if (speedTrigger == false)
        {
            moveSpeed += 0.1f * Time.deltaTime;
            if (moveSpeed > 8.0f)
            {
                moveSpeed = 8;
            }
        }
        else if (speedTrigger == true)
        {
            moveSpeed = 4.0f;
        }
        cameraTrans.position = Vector3.Lerp(cameraTrans.position, playerTrans.position + cameraVec, moveSpeed * Time.deltaTime);
    }



}

