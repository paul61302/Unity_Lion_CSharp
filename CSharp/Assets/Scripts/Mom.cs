using UnityEngine;

namespace KID.Class9
{
    public class Mom : MonoBehaviour
    {
        // 訂閱者：訂閱事件
        public Boy boy;

        private void Start()
        {
            // 1. 訂閱事件
            boy.onNoMoney += GiveMoney;
        }

        // 2. 實作方法
        private void GiveMoney()
        {
            print("= =");
            boy.money += 1000;
        }
    }
}

