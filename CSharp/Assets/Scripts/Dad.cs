using UnityEngine;

namespace KID.Class9
{
    public class Dad : MonoBehaviour
    {
        public Boy boy;
        
        void Start()
        {
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 10;
            print("10塊錢");
        }

        private void HitBoy()
        {
            print("挖嘎挖嘎");
        }
    }
}

