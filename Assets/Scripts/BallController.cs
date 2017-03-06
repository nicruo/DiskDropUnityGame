using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	private Rigidbody body;
	private bool falling = false;

	public float speed = 30;

	void Start () {
		body = this.GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		if (!falling && Input.GetButtonDown("Jump")) {
			body.useGravity = true;
			falling = true;
		}

		if(!falling)
		{
			float horizontal = Input.GetAxis ("Horizontal");
			//float vertical = Input.GetAxis ("Vertical");

			body.AddForce (new Vector3(horizontal*speed,0,0));

			//Debug.Log (horizontal);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			//Destroy (this.gameObject);
			SceneManager.LoadScene("Main");

		}
	}
}
