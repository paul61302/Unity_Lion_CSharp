﻿using UnityEngine;

public class Class4_PropArrayEnum : MonoBehaviour
{
    public Ship ship;

    private void Start()
    {
        // 設定屬性
        ship.lenght = 99.9f;
        // 取得屬性
        print("船的長度：" + ship.lenght);

        // 設定唯獨屬性
        // ship.width = 20.5f; // 錯誤
        // 取得唯獨屬性
        print("船的寬度：" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力：" + ship.atk);
    }
}
