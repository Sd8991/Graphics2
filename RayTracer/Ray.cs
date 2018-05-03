using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ray
{
    Vector3 start;
    Vector3 direction;

    public Ray(Vector3 start, Vector3 direction)
    {
        this.start = start;
        this.direction = direction;
    }
}

