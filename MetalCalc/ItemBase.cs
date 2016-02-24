using System;
using System.Collections.Generic;
using System.Text;

namespace MetalCalc
{
    public abstract class ItemBase
    {
        public Material Material
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double Length
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public float GetWeight()
        {
            throw new System.NotImplementedException();
        }
    }
}
