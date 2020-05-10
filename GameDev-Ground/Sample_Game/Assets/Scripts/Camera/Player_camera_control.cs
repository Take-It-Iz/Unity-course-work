using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_camera_control : MonoBehaviour
{		
	public Transform player;	
	private Vector3 offset = new Vector3(-25f, 25f, 60f);	

	void LateUpdate ()
	{
		transform.position = player.position + offset;
	}
}
