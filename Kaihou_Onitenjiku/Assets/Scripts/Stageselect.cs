using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stageselect : MonoBehaviour
{
    // Start is called before the first frame update
    public int Select;
    public Animator selectAni;
    public GameObject PauseCon;
    private bool PauseCheck;
    void Start()
    {
        Select = 0;

    }

    // Update is called once per frame
    void Update()
    {

        PauseCheck = PauseCon.GetComponent<PouseCon>().Pouse;
        if (PauseCheck == false)
        {
            if (Select == 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene("Stage1");
                }
                selectAni.SetBool("2_1select", true);
                selectAni.SetBool("1_2select", false);
                selectAni.SetBool("3_2select", false);
                selectAni.SetBool("2_3select", false);

            }
            if (Select == 1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene("Stage2");
                }
                selectAni.SetBool("2_1select", false);
                selectAni.SetBool("1_2select", true);
                selectAni.SetBool("3_2select", true);
                selectAni.SetBool("2_3select", false);

            }
            if (Select == 2)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    SceneManager.LoadScene("Stage3");
                }
                selectAni.SetBool("2_1select", false);
                selectAni.SetBool("1_2select", false);
                selectAni.SetBool("3_2select", false);
                selectAni.SetBool("2_3select", true);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Select -= 1;
                if (Select == -1)
                {
                    Select = 0;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Select++;
                if (Select == 4)
                {
                    Select = 3;
                }
            }


        }
    }
}
