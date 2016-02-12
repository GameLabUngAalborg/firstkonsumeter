using UnityEngine;
using System.Collections;

public class RockPickUp : MonoBehaviour {

	private Teacher.ResourceController ResourceController;
	public int AmountOfRock = 10;

	void Awake()
	{
		ResourceController = GameObject.Find("ResourceController").GetComponent<Teacher.ResourceController>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player") // if the hitting object has a player tag
		{
			ResourceController.Rock += AmountOfRock; // Add wood to resourcecontroller
			Destroy(gameObject);  // Destroy itself after it has been picked up
		}
	}
}
