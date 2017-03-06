using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegState : MonoBehaviour {

	public Material hitTexture;
	public Material hitSupaTexture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (this.tag == "Supa")
		{
			GetComponent<MeshRenderer> ().material = hitSupaTexture;
		}
		else
		{
			GetComponent<MeshRenderer> ().material = hitTexture;
		}
	}
}
