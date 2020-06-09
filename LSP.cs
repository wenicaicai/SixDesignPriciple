using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    /// <summary>
    /// 里氏替换原则
    /// Liskov Subsitution Principle
    /// 告诉我们不要破坏继承体系
    /// 子类可以继承父类，且不改变父类的方法
    /// 主要就是为了继承正确
    /// 类B继承类A，无意间重载了类A的方法I，即修改了方法I
    /// 采取做法：将类A与类B的继承关系去掉，以依赖、聚合、组合等关系替代
    /// 1.不要覆盖父类非抽象方法
    /// 2.增加特有方法
    /// 3.方法的前置条件（形参）要比父类宽松
    /// 4.方法的后置条件（返回值）要比父类严格
    /// </summary>
    public class LSP
    {

    }
}
