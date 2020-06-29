using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIP_Practice : MonoBehaviour
{
    public SpriteRenderer SR;
    public float a = 1.23456f;
    public Rigidbody Ball;
    
    void Start()
    {
        #region 設定遊戲速度

        #endregion
        Time.timeScale = 2f;

        #region 翻轉圖片

        #endregion
        SR.flipX = true;

        #region 去小數點

        #endregion
        print(Mathf.Floor(a));

        #region 添加推力

        #endregion
        //Ball.AddForce(0, 800, 1500);
        
    }

    void Update()
    {
        //print(Time.time);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball.AddForce(0, 800, 1500);
        }
    }

}
