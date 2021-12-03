using System;

public class Class1

	public Class1()
	{

    class Vector3D : Triad
{
    public Vector3D(int first, int second, int third) : base(first, second, third)
    {
        First = first;
        Second = second;
        Third = third;
    }

    public static Vector3D operator +(Vector3D firstvector, Vector3D secondvector)
    {
        return new Vector3D(
            firstvector.First + secondvector.First,
            firstvector.Second + secondvector.Second,
            firstvector.Third + secondvector.Third);
    }

    public static int ScalarProduction(Vector3D firstvector, Vector3D secondvector)
    {
        return firstvector.First * secondvector.First + firstvector.Second * secondvector.Second + firstvector.Third * secondvector.Third;
    }
}
}
