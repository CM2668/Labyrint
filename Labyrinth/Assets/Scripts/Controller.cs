using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
	public static Controller instance { get; private set; } 
	public bool isEasy;
	public Vector3 start;

	public Button easy, hard, quit;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}

		easy.onClick.AddListener(EasyButton);
		hard.onClick.AddListener(HardButton);
		quit.onClick.AddListener(QuitButton);
	}

	void EasyButton()
	{
		isEasy = true;
		SceneManager.LoadScene(1);
	}

	void HardButton()
	{
		SceneManager.LoadScene(1);
	}

	void QuitButton()
	{
		Application.Quit();
	}

	public void PlayerDeath(GameObject player)
	{
		if (isEasy)
		{
			player.GetComponent<AudioSource>().Play();
			player.transform.position = start;
			player.transform.Rotate(Vector3.up);
		}
		else
			SceneManager.LoadScene(1);
	}
}
