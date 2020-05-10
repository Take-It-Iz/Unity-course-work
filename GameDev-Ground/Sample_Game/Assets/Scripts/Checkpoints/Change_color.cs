using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color : MonoBehaviour {

	GameObject player;
	Renderer rend;	

	void Start()
	{	
		rend = GetComponent<Renderer>();
		player = GameObject.FindWithTag("Player");
		
		if (gameObject.tag == "Player")	
		{
			rend.material.color = Color.green;			
		}
		else
		{
			rend.material.color = Color.red;						
		}
	}

	private void OnTriggerEnter(Collider other) 
	{											
		if (other.gameObject.tag == "Player")
		{
			rend.material.color = Color.green;			
		}
	}
}