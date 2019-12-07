using System;

namespace CSharp8Features.ReadOnlyMember
{
    struct ReadOnlyMember
    {
        public double Radius { get; set; }
       
        public readonly double Circumference => 2 * Math.PI * Radius;

        public readonly override string ToString()
        {
            return $"Circumference of the circle is {Circumference}"; 
        }
    }

}
