using UnityEngine;

// 定義列舉
// 定義在類別外可以讓所有類別使用
public enum Season
{
    Spring, Summer, Fall, Winter
}

public enum State
{
    Idle, Walk, Attack, Damage, Skill, Dead
}

// 自行變更編號
public enum Day
{
    Sunday = 7, Monday = 1, Tuesday, Wendsday, Thursday, Friday, Saturday
}

public class Class4_PropArrayEnum : MonoBehaviour
{
    // 使用列舉
    // 修飾詞 列舉名稱 自訂名稱
    public Season _season;
    public State _state;
    public Day _day = Day.Wendsday;

    #region 練習陣列
    public Ship ship;

    // 一般欄位
    public string name1 = "KID";
    public string name2 = "50大大";
    public string name3 = "亮亮大大";

    // 陣列：類型[]
    // 屬性面板上 size 指的是數量
    // 屬性面板上的 Element 微陣列成員 編號從 0 開始
    public string[] names;                                  // 宣告陣列不指定數量

    public float[] weights = new float[3];                  // 宣告陣列並指定數量

    public int[] scores = new int[] { 10, 20, 50, 90 };     // 宣告陣列並指定內容

    public bool[] mission = { true, false, false };         // 宣告陣列並指定內容

    #endregion

    // 喚醒事件：Start 之前執行一次
    private void Awake()
    {
        // 取得列舉
        print("季節：" + _season);
        print("狀態：" + (int)_state);         // (int) 將列舉轉型為整數
        print("日期：" + (int)_day);
        // 存放列舉
        _state = State.Walk;
    }

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

        ship.def = 10.1f;
        print("船的防禦力：" + ship.def);

        // 指定陣列資料
        names = new string[] { "怪物A", "怪物B", "怪物C" };

        // 陣列[編號] - 注意編號從 0 開始
        // 陣列存放
        scores[0] = 77;
        // 陣列取得
        print("取得怪物陣列第三筆資料：" + names[2]);
        // 陣列常見錯誤：編號超出範圍
        // IndexOutOfRangeException

        // 陣列.Length 長度 (數量)
        print("分數陣列的長度 (數量) ：" + scores.Length);

        // 呼叫改變分數方法並將分數陣列傳進方法內
        ChangeScore(scores);

        TestValue(A);
        TestRefe(B);
    }

    // 陣列為參考型別
    /// <summary>
    /// 改變第二筆分數為 99 分
    /// </summary>
    private void ChangeScore(int[] theArray)
    {
        theArray[1] = 99;
    }

    // 整數為實質型別
    public int A = 99;
    // 陣列為參考型別
    public int[] B = { 99 };

    /// <summary>
    /// 測試實值型別：傳值 - 傳資料進來，不會修改原本資料
    /// </summary>
    private void TestValue(int test)
    {
        test = 0;
    }

    /// <summary>
    /// 測試參考型別：傳值 - 傳地址進來，會修改原本資料
    /// </summary>
    private void TestRefe(int[] test)
    {
        test[0] = 0;
    }
}
