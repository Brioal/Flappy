using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // 游戏菜单模式
    public static int GAME_STATE_MENU = 0;
    // 正在游戏模式
    public static int GAME_STATE_PLAYING = 1;
    // 游戏失败状态
    public static int GAME_STATE_FAILED = 2;


    // 最后一个背景
    public Transform firstBg;
    // 游戏状态
    public int gameState = GAME_STATE_MENU;

    

    // 分数
    private int score = 0;


    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }

    // 获取分数
    public int getScore()
    {
        return score;
    }

    public void addScore()
    {
        score++;
        print(score);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 菜单状态
        if (gameState == GAME_STATE_MENU)
        {
            if (Input.GetMouseButton(0))
            {
                // 开始游戏
                gameState = GAME_STATE_PLAYING;
            }
        }	
	}

    
}
