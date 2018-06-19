using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBird : MonoBehaviour {


    private GameObject bird;

	// Use this for initialization
	void Start () {
        bird = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 birdPosition = bird.transform.position;
        this.transform.position = new Vector3(birdPosition.x + 5.5f, this.transform.position.y, this.transform.position.z);
	}
}
