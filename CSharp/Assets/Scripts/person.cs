﻿using UnityEngine;

public class person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    // 定義方法語法：
    // 修飾詞 傳回類型 方法名稱 (參數) { 陳述式 }
    // void 無傳回：當使用此方法時不會得到任何傳回資料
    public void Talk()
    {
        // gameObject 套用此腳本的物件
        // gameObject.name 套用此腳本的物件 的 名稱
        print("Hey,hey you! 我是 " + gameObject.name);
    }

    // 傳回方法：傳回類型不是 void
    // 使用此方法會得到傳回資料，必須使用關鍵字 return
    /// <summary>
    /// 計算人的BMI
    /// </summary>
    /// <returns>計算完的BMI</returns>
    public float BMI()
    {
        // BMI 公式
        float result = weight / ((height / 100) * (height / 100));
        // 傳回 return
        return result;
    }

    public void walk10()
    {
        print("好累喔");
    }

    public void walk20()
    {
        print("用時速 20 公里走路");
    }

    // 參數語法：類型、名稱
    // 有預設值的參數稱為【選填式參數】 - 可以不填，值為預設值
    // 選填式參數必須定義在最右邊
    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed">需要以多少速度走路</param>
    public void walk(int speed, string direction = "前方", string sound = "嘿嘿嘿")
    {
        print("用時速"+ speed + "公里走路");
        print("發出了" + sound + "的聲音");
        print("走路方向：" + direction);
    }

    // 攻擊方法：徒手
    public void Attackwithhand()
    {
    
    }
    // 攻擊方法：拿武器攻擊，音效
    public void Attackwithiweapon()
    {
    
    }

    // 多載 Overload
    // 1. 相同名稱的方法
    // 2. 參數數量不同 或者 參數類型不同
    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!!!");
    }

    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    /// <param name="weapon">想要使用的武器</param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器：" + weapon + "攻擊!!!");
        print("攻擊音效");
    }

    // 讓 Unity 按鈕 Button 使用方法條件：
    // 1. 修飾詞為公開 public
    // 2. 參數數量小於等於 1 
    /// <summary>
    /// 技能
    /// </summary>
    public void skill()
    {
        
        print(gameObject.name + "使用" + "!!" );
    }

}
