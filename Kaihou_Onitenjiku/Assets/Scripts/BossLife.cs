using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossLife : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int bossMaxLife;
    private int nowBossLife;
    public Slider Meter;
    public GameObject Player;
    private bool ultDmegi;
    void Start()
    {
        nowBossLife = bossMaxLife;

        Meter.maxValue = (float)bossMaxLife;
        Meter.minValue = 0f;

        Meter.value = (float)bossMaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        ultDmegi = Player.GetComponent<Player>().ult;
       
        if (ultDmegi == true)
        {
            nowBossLife -= 50;
        }
        Meter.value = nowBossLife;
        if (nowBossLife < 0)
        {
            SceneManager.LoadScene("Clear");
        }
    }
    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Counter")
        {
            nowBossLife -= 10;
            Destroy(other.gameObject);
        }
    }
}
