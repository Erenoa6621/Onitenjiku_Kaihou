﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン移動のため                           
public class TimeManager : MonoBehaviour
{
	[SerializeField]
	private int minute;
	[SerializeField]
	private float seconds;
	//　前のUpdateの時の秒数
	private float oldSeconds;
	//　タイマー表示用テキスト
	private Text timerText;
	private bool Pouse;
	public GameObject PCon;
	public GameObject EndCon;
	private bool end;
	public int Type;
	void Start()
	{
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
	}

	void Update()
	{
		Pouse = PCon.GetComponent<PouseCon>().Pouse;
		end = EndCon.GetComponent<BossLife>().end;
		if (Pouse == false && end == false)
		{
			seconds += Time.deltaTime;
			if (seconds >= 60f)
			{
				minute++;
				seconds = seconds - 60;
			}
			//　値が変わった時だけテキストUIを更新
			if ((int)seconds != (int)oldSeconds)
			{
				timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
			}
			oldSeconds = seconds;

			
			
		}

		if (end == true && Type == 0)
		{
			PlayerPrefs.SetFloat("Minute", minute);
			PlayerPrefs.Save();
			PlayerPrefs.SetFloat("Second", seconds);
			PlayerPrefs.Save();
		}
		if (end == true && Type == 1)
		{
			PlayerPrefs.SetFloat("Minute2", minute);
			PlayerPrefs.Save();
			PlayerPrefs.SetFloat("Second2", seconds);
			PlayerPrefs.Save();
		}
	}
}