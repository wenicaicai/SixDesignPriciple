using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    /// <summary>
    /// 迪米特法则
    /// Law of Demeter
    /// 亦称：最少知道法则 LKP ...... Least Konwledge Principle
    /// 对象J对对象Q有尽可能少的了解，尽量少知道一些细节
    /// 降低类之间的耦合
    /// </summary>
    public class LOD
    {

    }

    /// <summary>
    /// 这样，对于一个具体的煮汤活动来说
    /// 第三方调用者不需要知道具体煮汤的细节，只需要得到一碗美味健康的汤
    /// </summary>
    public class CookSoup
    {
        private void AddWater()
        {
            Console.WriteLine("添加水..");
        }
        private void AddFood()
        {
            Console.WriteLine("加食物..");
        }
        private void Heat()
        {
            Console.WriteLine("加热..");
        }
        private void AddSalt()
        {
            Console.WriteLine("添加盐..");
        }

        /*
         * 封装煮汤的步骤
         */
        public void MakeSoup()
        {
            AddWater();
            AddFood();
            Heat();
            AddSalt();
        }
    }
}
