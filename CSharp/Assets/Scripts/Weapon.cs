using UnityEngine;

namespace KID.Class8
{
    public class Weapon : MonoBehaviour, ICanUse
    {
        public Data data;

        public void Use()
        {
            print("使用武器：" + data.name);

            transform.SetParent(FindObjectOfType<Player>().hand);       // 設定父物件(玩家.手)
            transform.localEulerAngles = new Vector3(70, 0, 0);         // 旋轉角度
            transform.localPosition = new Vector3(0, 0, 40);
            //transform.localPosition = Vector3.zero;                     // 區域座標 = 零
            GetComponent<Collider>().enabled = false;                   // 關閉碰撞
        }
    }
}