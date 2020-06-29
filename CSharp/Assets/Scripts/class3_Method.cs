using UnityEngine;

public class class3_Method : MonoBehaviour
{
    public person person1;
    public person person2;

    private void Start()
    {
        // 呼叫 person1 方法 Talk
        person1.Talk();
        person2.Talk();
        // 傳回方法可以直接當作傳回類型使用
        print("8+9 BMI" + person1.BMI());
        print("地方媽媽" + person2.BMI());
        // 使用有參數的方法必須填入對應的引數
        // 指定選填式參數【選填式參數名稱：值】
        person1.walk(87, sound:"蛤啦?");
        person2.walk(17, "左邊");
        // 呼叫 person1 方法 walk10
        person1.walk10();

        person1.Attack();
        person2.Attack("電動棒");
        

    }

}
