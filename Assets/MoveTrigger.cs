using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {

    public Transform currentBg;
    public pipe pipe1;
    public pipe pipe2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 当小鸟碰撞到时候
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           Transform firstBg = GameManager.instance.firstBg;
            currentBg.position = new Vector3(firstBg.position.x+9.9f, currentBg.position.y, currentBg.position.z);
            GameManager.instance.firstBg = currentBg;
            pipe1.RandomGeneratePosition();
            pipe2.RandomGeneratePosition();
        }
    }
}
