using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.SOLID.InterfaceSegregationPrinciple
{
    public interface IClickGeneral : IClick, ITouch
    {
        void OnClick();
        void OnDoubleClick();
        void OnTouch();
        void OnSwipe();
    }

    public interface IClick
    {
        void OnClick();
        void OnDoubleClick();
    }

    public interface ITouch
    {
        void OnTouch();
        void OnSwipe();
    }

    public class Click : IClickGeneral
    {
        public void OnClick()
        {
            throw new NotImplementedException();
        }

        public void OnDoubleClick()
        {
            throw new NotImplementedException();
        }

        public void OnSwipe()
        {
            throw new NotImplementedException();
        }

        public void OnTouch()
        {
            throw new NotImplementedException();
        }
    }
}
