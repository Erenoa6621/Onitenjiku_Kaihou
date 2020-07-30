using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PouseCon : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Pouse;
    public GameObject GamePanel;
    public GameObject TitlePanel;
    public GameObject PoseCanvas;
    public int select;
    void Start()
    {
        Pouse = false;
        select = 0;
        PoseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pouse == true)
            {
                Pouse = false;
                PoseCanvas.SetActive(false);
            }
            else if (Pouse == false)
            {
                Pouse = true;
                PoseCanvas.SetActive(true);
            }
        }
        PouseSelect();
        
    }
    public void PouseSelect()
    {
        if (Pouse == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                select -= 1;
                if (select == -1)
                {
                    select = 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                select++;
                if (select == 2)
                {
                    select = 0;
                }
            }

            if (select == 0)
            {
                GamePanel.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
                TitlePanel.transform.localScale = Vector3.one;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Pouse = false;
                    PoseCanvas.SetActive(false);
                }
            }
            else if (select == 1)
            {
                GamePanel.transform.localScale = Vector3.one;
                TitlePanel.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene("Title");
                    PoseCanvas.SetActive(false);
                }
            }
        }

    }
}
