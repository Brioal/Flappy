using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_up_down : MonoBehaviour {

    
    public GameManager gameManager;

    public AudioSource hidSource;
    public AudioSource dieSource;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameManager = GameManager.instance;
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameManager.gameState == GameManager.GAME_STATE_PLAYING)
            {
                // 播放碰撞声音
                hidSource.Play();
                // 播放死亡声音
                dieSource.Play();
                gameManager.gameState = GameManager.GAME_STATE_FAILED;
            }
           
            
        }
    }
}
