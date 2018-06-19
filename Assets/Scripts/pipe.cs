using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour {

    // Use this for initialization
    public GameManager gameManager;
	void Start () {
        // 赋值
        gameManager = GameManager.instance;
        RandomGeneratePosition();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 生成一个随机位置
    public void RandomGeneratePosition()
    {
        float position_y=Random.Range(0.45f, 0.25f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, position_y, this.transform.localPosition.z);

    }

    // 碰到触发器的时候得分
    void OnTriggerEnter(Collider other)
    {
        gameManager.addScore();
        // 播放声音
        this.GetComponent<AudioSource>().Play();
    }


    void OnGUI()
    {
        GUILayout.Label("Score:" + gameManager.getScore());
    }
}
