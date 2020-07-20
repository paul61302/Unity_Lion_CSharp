using UnityEngine;

public class Class5_IfSwitchLoop : MonoBehaviour
{

    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量"),Range(0,100)]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Day day;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    //public string test;

    public int i = 1;
    public int j = 1;
    public int k = 1;

    // GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

    private void CreateFloor(int length,int width)
    {
        // 巢狀迴圈
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                // API 實例化 (生成)
                // 生成(物件、座標、角度)
                // Vector3 三維向量(保存三個浮點數)
                // Quaternion 角度
                // Quaternion.identity 零角度
                // Quaternion.Euler(x, y, z)尤拉角度 - 0~360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270,0,0));
            }
        }
    }

    private void Awake()
    {
        #region 迴圈
        // 使用 for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取得資料：" + scores[i]);
        }

        // foreach 迴圈
        // 語法：foreach (取得資料的類型 取得資料的名稱 in 陣列) { 執行次數為陣列數量 }
        foreach(int item in scores)
        {
            print("foreach 迴圈取得資料：" + item);
        }

        CreateFloor(30,5);

        // while 迴圈
        // while (布林值) { 當布林值為 true 執行 }
        // 迴圈之前評估：第一次判斷 i
        while (i <= 10)
        {
            print("while 迴圈第：" + i + "次");
            i++;
        }

        // 迴圈之後評估：第一次判斷 j = 2
        do
        {
            print("do 迴圈第：" + j + "次");
            j++;
        } while (j <= 10);

        // for (初始值 ; 條件 ; 迭代器
        for (int k = 1; k <= 10; k++)
        {
            print("for 迴圈第：" + k + "次");
        }
        
        for (int k = 10; k >= 1; k--)
        {
            print("for 迴圈第：" + k + "次");
        }


        /*
        for (int i = 0; i < 101; i++)
        {
            print("break 迴圈：" + i);

            // 如果 i 等於 10 就打斷迴圈並且值型迴圈下方的程式
            if (i == 10) break;
        }
        print("break 迴圈外的程式");
        */

        /*
        for (int i = 0; i < 101; i++)
        {
            print("return 迴圈：" + i);

            // 如果 i 等於 10 就跳出方法外，下方的程式皆不執行
            if (i == 10) return;
        }
        print("return 迴圈外的程式");
        */

        /*
        // 執行結果：0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue 迴圈" + i);
        }
        print("continue 迴圈外的程式");
        */

        for (int i = 0; i < 10; i++)
        {
            // goto 標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈：" + i);
        }
    //標記寧稱：
    Test:
        // 標記陳述式
        print("這是標記陳述式");

        #endregion

    }

    private void Start()
    {
        // if 判斷式
        // if (布林值) { 布林值 = true 時執行}
        if (true)
        {
            print("哈囉，我是if判斷式~");
        }
    }

    // 更新事件：一秒執行約 60 次 (60FPS)
    private void Update()
    {
        // 當道具數量 >= 5 任務完成 true
        // 三元運算子語法 - 布林運算式 ? 運算式A : 運算式B
        // 指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        //  test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";

        /*
        if (count >= 5)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }
        */

        switch (prop)
        {
            case "紅水":
                print("補 HP~");
                break;
            case "藍水":
                print("補 MP~");
                break;
            case "黃水":
                print("補 EXP~");
                break;
            //default 可省略
            default:
                print("你吃了三小?????");
                break;
        }

        switch (day)
        {
            case Day.Sunday:
                print("星期天");
                break;
            case Day.Monday:
                print("星期一");
                break;
            case Day.Tuesday:
                print("星期二");
                break;
            case Day.Wendsday:
                print("星期三");
                break;
            case Day.Thursday:
                print("星期四");
                break;
            case Day.Friday:
                print("星期五");
                break;
            case Day.Saturday:
                print("星期六");
                break;
            default:
                break;
        }


        #region IF判斷式
        // 當 openDoor 為 true 執行 {開門}
        // 當 openDoor 為 false 執行 {關門}
        // if (openDoor == true)
        if (openDoor)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }

        // 比較運算子、邏輯運算子結果為布林值
        // 大於 60 及格
        // 小於 60 不及格
        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考~");
        }
        else if (score >= 20)
        {
            print("付錢補考~");
        }
        else
        {
            print("不及格~");
        }

        if (hp>100)
        {
            print("超過ㄌ啦");
        }
        else if (hp >= 70)
        {
            print("安全");
        }
        else if (hp >= 20)
        {
            print("警告");
        }
        else
        {
            print("危險");
        }
        #endregion
    }
}
