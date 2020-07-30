using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltIn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BossPos;
    public GameObject PlayerUlt;
    private bool UltOn;
    public GameObject Ult;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        UltOn = PlayerUlt.GetComponent<Player>().ult;
        this.gameObject.transform.position = new Vector3(BossPos.transform.position.x, BossPos.transform.position.y -0.5f, 0);

        if (UltOn == true)
        {
            Instantiate(Ult, this.gameObject.transform.position, Quaternion.identity);
            audioSource.Play();
            //Destroy(Ult, 10f);
        }
    }
}
