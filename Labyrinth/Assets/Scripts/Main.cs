using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
	public Button easy, hard, quit;
	public GameObject menu, player;

	void Awake()
	{
		easy.onClick.AddListener(EasyButton);
		hard.onClick.AddListener(HardButton);
		quit.onClick.AddListener(QuitButton);
	}

	void EasyButton()
	{
		menu.SetActive(false);
		player.SetActive(true);
	}

	void HardButton()
	{

	}

	void QuitButton()
	{
		Application.Quit();
	}
}
