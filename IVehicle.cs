using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    #region 方式一：接口没有分离
    public interface IVehicle
    {
        //飞行
        public void Fly();

        //陆行
        public void Run();

        //航行
        public void Sail();
    }
    #endregion

    #region 方式二：接口采取细化分离
    public interface IFly
    {
        public void Fly();
    }

    public interface IRun
    {
        public void Run();
    }

    public interface ISail
    {
        public void Sail();
    }
    #endregion
}
