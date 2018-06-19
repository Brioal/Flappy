using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour {

    public float timer;
    private int frameCount = 0;
    private int frameNumber = 10;

   
    // 游戏管理器
    public GameManager gameManager;
    // 是否已经设置了初速度
    private bool isSetSpeed = false;
   

   

	// Use this for initialization
	void Start () {
        // 赋值
        gameManager = GameManager.instance;
    }
	
	// Update is called once per frame
	void Update () {
        // 处理初速度
        action_speed();
        // 处理动画效果
        action_animation();
        // 处理跳跃效果
        action_jump();
        // 处理重力效果
        action_gravity();

    }



    // 处理初速度
    private void action_speed()
    {
        // 如果是正在游戏,则添加一个初速度
        if (gameManager.gameState == GameManager.GAME_STATE_PLAYING)
        {
            if (!isSetSpeed)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
                isSetSpeed = true;
            }
            
        }
     
    }

    // 处理重力效果
    private void action_gravity()
    {
       
        this.GetComponent<Rigidbody>().useGravity =( gameManager.gameState != GameManager.GAME_STATE_MENU);
    }

    // 处理跳跃效果
    private void action_jump()
    {
        if (gameManager.gameState!=GameManager.GAME_STATE_PLAYING)
        {
            return;
        }
        // 左键单击
        if (Input.GetMouseButton(0))
        {
            Vector3 vel = this.GetComponent<Rigidbody>().velocity;
            this.GetComponent<Rigidbody>().velocity = new Vector3(vel.x, 3, vel.z);
            // 播放声音
            
            this.GetComponent<AudioSource>().Play();
        }
    }

    // 处理动画效果
    private void action_animation()
    {
        if (gameManager.gameState != GameManager.GAME_STATE_PLAYING)
        {
            return;
        }
        // 动画
        timer += Time.deltaTime;
        if (timer >= 1.0f / frameNumber)
        {
            frameCount++;
            timer -= 1.0f / frameNumber;

            // 更新材质的偏移
            int frameIndex = frameCount % 3;
            this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.33333f * frameIndex, 0));

        }

    }
}
