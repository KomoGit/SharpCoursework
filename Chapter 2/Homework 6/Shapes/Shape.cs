using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract public class Shape
    {
        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
