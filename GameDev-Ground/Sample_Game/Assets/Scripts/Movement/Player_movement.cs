using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movement : MonoBehaviour {

    public Rigidbody sandbox_prop_1;
	public float addSomeForce = 1500f;

	void FixedUpdate ()
    {				
		if (Input.GetKey("w")) //move forwards
		{
			sandbox_prop_1.AddForce(addSomeForce * Time.deltaTime, 0, -addSomeForce * Time.deltaTime);
		}
		else if (Input.GetKey("s")) //move backwards
		{
			sandbox_prop_1.AddForce(-addSomeForce * Time.deltaTime, 0, addSomeForce * Time.deltaTime);
		}
		else if (Input.GetKey("a")) //move leftwards
		{
			sandbox_prop_1.AddForce(addSomeForce * Time.deltaTime, 0, addSomeForce * Time.deltaTime);
		}
		else if (Input.GetKey("d")) //move rightwards
		{
			sandbox_prop_1.AddForce(-addSomeForce * Time.deltaTime, 0, -addSomeForce * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.Escape))//load main menu
		{
			SceneManager.LoadScene(0);
		}
	}
}
