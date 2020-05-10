using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives_counter : MonoBehaviour
{
	public GameObject player;
	GameObject checkpoint;
	public Text textLivesScore;
	public int livesScore = 0;
	public string livesStr = "Lives : ";

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Respawn")
		{
			livesScore++;
			other.gameObject.tag = "Checkpoint_checked";			
		}
	}

	public void FixedUpdate()
	{
		textLivesScore.text = livesStr + livesScore.ToString();
	}

}
