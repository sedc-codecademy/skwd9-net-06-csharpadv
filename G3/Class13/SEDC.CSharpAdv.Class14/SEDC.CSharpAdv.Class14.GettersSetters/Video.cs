using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    public class Video
    {
        public string Title { get; set; }

        // using getter to calculkate availability
        // public int Quantity { get; set; }
        // public bool IsAvailable { get { return Quantity > 0; } }

        // seocnd way to calculate availability
        //public int Quantity { get; private set; }
        //public bool IsAvailable { get; set; }

        //private void SetAvailable()
        //{
        //    IsAvailable = Quantity > 0;
        //}

        //public void SetQuantity(int quantity)
        //{
        //    Quantity = quantity;
        //    SetAvailable();
        //}

        // third way of setting isavailable
        private int _quantity;
        public int Quantity 
        { 
            get 
            { 
                return _quantity; 
            } 
            set 
            { 
                _quantity = value; 
                IsAvailable = _quantity > 0; 
            } 
        }
        public bool IsAvailable { get; private set; }
    }
}
