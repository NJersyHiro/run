using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

	public Rigidbody rb;
	public float movespeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter(Collision other){
		if(other.collider.tag == "FloorTag"){
			this.rb.AddForce(0, 400, 0);

		}

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		this.rb.AddForce (movement * movespeed);
	}
}
