using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
	private float timer = 60000f;
	private GameObject con;
	public GameObject flames;
	void Start()
	{
		con = GameObject.Find("Controller");
	}
	void Update()
	{
		if (con != null && !con.GetComponent<Controller>().isEasy)
		{
			if (timer > 0)
				timer -= Time.deltaTime;
			else if(gameObject.GetComponent<Light>().isActiveAndEnabled)
			{
				timer = 60000f;
				gameObject.GetComponent<Light>().enabled = false;
				flames.SetActive(false);
			}
		}
	}

	void OnTriggerStay(Collider player)
	{
		if (player.CompareTag("Player"))
		{
			gameObject.GetComponent<Light>().enabled = true;
			flames.SetActive(true);
			timer = 60000;
		}
	}
}
