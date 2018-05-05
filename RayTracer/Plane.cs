using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Plane : Primitive
{
    Vector3 normal;
    //Vector3 position;

    public Plane(Vector3 position, Vector3 normal) : base(position)
    {
        this.normal = normal;
        base.position = position;
    }
}
