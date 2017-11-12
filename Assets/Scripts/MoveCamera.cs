using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	public GameObject Camera;
	// Use this for initialization
	void Start () {
		
	}
	void setCameraPosition(){
		Camera.transform.position = new Vector3(transform.position.x,Camera.transform.position.y,-10);
	}
	// Update is called once per frame
	void Update () {
		setCameraPosition();
	}
}
