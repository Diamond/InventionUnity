using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public bool walking = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Get the Animator component from your gameObject
		Animator anim = GetComponent<Animator>();
		// Sets the value
		anim.SetBool("Walking", true); 

		Vector3 moving = new Vector3(1.0f, this.rigidbody2D.velocity.y, 0.0f);
		this.rigidbody2D.velocity = moving;
	}
}
