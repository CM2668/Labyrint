using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.CompareTag("Player"))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(2);
		}
	}
}
