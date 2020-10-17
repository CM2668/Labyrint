using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{

	void OnTriggerEnter(Collider player)
	{
		if (player.CompareTag("Player"))
		{
			GameObject.Find("Controller").GetComponent<Controller>().PlayerDeath(player.gameObject);
		}
	}
}
