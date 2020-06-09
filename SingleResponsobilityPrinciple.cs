using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    ///教程有毒，没有给出根本解决方法
    /// <summary>
    /// 单一职责原则
    /// 主要针对：约束类实现和细节
    /// 职责扩散到无法控制前进行代码重构
    /// </summary>
    public class SingleResponsobilityPrinciple
    {
        public void CallingBreath()
        {
            Animal animal = new Animal();
            animal.Breath("鼠");
            animal.Breath("牛");
            animal.Breath("虎");
            //问题来了...哦不，是需求发生了变化
            //有一尾鱼
            //那么把动物划分为陆生生物+水生生物

        }
    }

    #region 刚开始的写法
    public class Animal
    {
        public void Breath(string animalName)
        {
            Console.WriteLine($"{animalName},呼吸...");
        }
    }
    #endregion

    #region 方式一：直接修改分解Animal 弊端：花销大，分解类

    /// <summary>
    /// 陆生生物
    /// </summary>
    public class Terricolous
    {
        public void Breath(string animalName)
        {
            Console.WriteLine($"{animalName},依赖肺部，呼吸...");
        }
    }

    /// <summary>
    /// 水生生物
    /// </summary>
    public class Aquatic
    {
        public void Breath(string animalName)
        {
            Console.WriteLine($"{animalName},依赖鱼鳃，呼吸...");
        }
    }
    #endregion

    #region 方式二：直接修改Animal里面的具体方法 弊端：违反单一职责
    //这样存在隐患，以后如果又更多的分类，则又要修改类，增加更多if判断
    public class AnimalI
    {
        public void Breath(string animalName)
        {
            if (animalName.Equals("鱼"))
                Console.WriteLine($"{animalName},依赖鱼鳃，呼吸...");
            else
                Console.WriteLine($"{animalName},依赖肺部，呼吸...");
        }
    }
    #endregion

    #region 方式三：仅仅在方法级别上遵循了单一职责原则，整体上依然违背了单一职责原则
    //没有改动原有方法
    public class AnimalII 
    {
        public void Breath(string animalName)
        {
            Console.WriteLine($"{animalName},依赖鱼鳃，呼吸...");
        }
        public void BreathI(string animalName)
        {
            Console.WriteLine($"{animalName},依赖肺部，呼吸...");
        }
    }
    #endregion
}
