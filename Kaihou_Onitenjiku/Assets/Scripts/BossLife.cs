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
    private Slider Meter;
    public GameObject LifeMeter;
    public GameObject Player;
    private bool ultDmegi;
    public GameObject damegi;
    private bool nomalDamege;
    public bool end;
    public GameObject clearText;
    void Start()
    {
        Meter = LifeMeter.GetComponent<Slider>();
        nowBossLife = bossMaxLife;

        Meter.maxValue = (float)bossMaxLife;
        Meter.minValue = 0f;
        end = false;
        Meter.value = (float)bossMaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        ultDmegi = Player.GetComponent<Player>().ult;
        nomalDamege = damegi.GetComponent<OutCounter>().Atack;
      
        if (ultDmegi == true)
        {
            nowBossLife -= 50;
        }
        Meter.value = nowBossLife;
        if (nowBossLife < 0)
        {
            end = true;

            Destroy(LifeMeter);
          
        }
        if (nomalDamege == true)
        {
            nowBossLife -= 10;
        }
        if (end == true)
        {
            clearText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("StageSelect");
            }
        }
    }

    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Counter")
        {
           
            Destroy(other.gameObject);
        }
    }
}
