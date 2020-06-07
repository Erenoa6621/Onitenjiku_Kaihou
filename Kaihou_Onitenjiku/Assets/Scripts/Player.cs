using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed;
    [SerializeField] float junpSpeed;
    public GameObject player;
    private Rigidbody rb;
    public bool junpCheck;

    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * playerSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow) && junpCheck == true)
        {
            rb.AddForce(0, junpSpeed, 0);
            junpCheck = false;
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stage")
        {
            junpCheck = true;
        }

    }

}
