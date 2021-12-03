using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp12
{
    class Vector3D : Triad
    {
        public int First1 { get; set; }
        public int Second1 { get; set; }
        public int Third1 { get; set; }

        public Vector3D(int first, int second, int third) : base(first, second, third)
            {
                First1 = first;
                Second1 = second;
                Third1 = third;
            }

            public static Vector3D operator +(Vector3D firstvector, Vector3D secondvector)
            {
                return new Vector3D(
                    firstvector.First1 + secondvector.First1,
                    firstvector.Second1 + secondvector.Second1,
                    firstvector.Third1 + secondvector.Third1);
            }

            public static int ScalarProduction(Vector3D firstvector, Vector3D secondvector)
            {
                return firstvector.First1 * secondvector.First1 + firstvector.Second1 * secondvector.Second1 + firstvector.Third1 * secondvector.Third1;
            }
        }
}
