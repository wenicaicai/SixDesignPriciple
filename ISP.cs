using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    /// <summary>
    /// 接口隔离原则
    /// Interface Segregation Principle
    /// 告诉我们接口要设计得精简单一，不要庞大
    /// 主要：约束抽象
    /// 这个原则希望每个接口都足够小（不宜过多，导致过度设计）
    /// 接口小的话才能使得接口复用变得更加容易，提高内聚
    /// 
    /// 好处：
    /// 1.避免大接口被许多子类实现，降低耦合
    /// 2.减少没必要实现的冗余代码
    /// </summary>
    public class ISP
    {

    }

    #region 方式一：接口没有进行分离
    //实现了其他接口实际上没什么实际用途
    public class AirPlane : IVehicle
    {
        public void Fly()
        {
            Console.WriteLine("flying ...");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sail()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region 方式二：采取接口分离的实现
    public class Boeing : IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}
