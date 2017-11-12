using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	float time;
	bool isGrounded;
	// Update is called once per frame
	void Update () {

		// if (Physics2D.Raycast (transform.position - new Vector3 (0, 0.6f, 0), Vector2.down, 0.1f)) {
		// 	isGrounded = true;
		// } else {
		// 	isGrounded = false;
		// }
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.1f) {
				GetComponent<Rigidbody2D> ().AddForce(new Vector2 (Input.GetAxis ("Horizontal") * 10, 0)) ;

		}

		if (Input.GetKey ("space")) {

			if (isGrounded) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, 10);
			}

		}
	}
	private void OnCollisionEnter2D(Collision2D other) {
	if(other.gameObject.CompareTag("ground")){
			isGrounded=true;
		}	
	}
	private void OnCollisionExit2D(Collision2D other) {
		if(other.gameObject.CompareTag("ground")){
			isGrounded=false;
		}
	}
}