using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

	public Transform checkpoint;
	GameObject player;
	public Text textLivesScore;
	public Lives_counter referenceScore;
	public string livesStr = "Lives : ";
	public bool aliveAndWell = true;

	void Start()
	{
		player = GameObject.FindWithTag("Player");
		referenceScore.GetComponent<Lives_counter>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			player.transform.position = checkpoint.position;
			player.transform.rotation = checkpoint.rotation;
			aliveAndWell = false;
			if (aliveAndWell == false)
			{
				referenceScore.livesScore--;
				if (referenceScore.livesScore < 0)
				{
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				}
			}
		}		
	}
}
