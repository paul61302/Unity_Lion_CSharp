﻿using UnityEngine;    // 引用 Unity 的API (函式庫：Unity 屬性、功能...)

// 類別 Class 定義一個物件
// 語法：class 類別名稱
// ：MonoBehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會執行
public class Class1 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1. 英文字母大小寫不一樣
    // 2. 括號一定成對出現 () [] {} ' ' " " < >

    // 事件：在特定時間會以指定次數執行的方法 (名稱為藍色)
    // 開始事件：撥放遊戲時執行一次 - 初始設定
    private void Start()
    {
        // 輸出("文字訊息")
        //C# 結尾為分號 ;
        print("ㄩㄇ");
    }
}
