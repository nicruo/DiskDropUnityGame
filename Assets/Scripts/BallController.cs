using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody body;

	public float speed = 30;

	void Start () {
		body = this.GetComponent<Rigidbody>();

	}

	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		body.AddForce (new Vector3(horizontal*speed,vertical*speed,0));

		//Debug.Log (horizontal);
	}

}
