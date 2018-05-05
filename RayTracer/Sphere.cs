using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sphere : Primitive
{
    public float radius;
    //public Vector3 position;

    public Sphere(Vector3 position, float radius) : base(position)
    {
        this.radius = radius;
        base.position = position;
    }
}
