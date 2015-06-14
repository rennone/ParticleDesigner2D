using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ParticleDesigner2D
{
    public class Particle
    {
        public class Param
        {
            public PointF InitialLocation_;
            public PointF InitialDirection_;
            public float InitialSpeed_;
            public float Accel_;
            public float RotateDegSpeed_;
            public float LifeTime_;
        }

        Param param;

        PointF location;
        PointF direction;
        float degree;
        float speed;

        public Particle(Param p)
        {
            Initailize(p);
        }

        public void Initailize(Param p)
        {
            param = p;
            location = param.InitialLocation_;
            direction = param.InitialDirection_;
            speed = param.InitialSpeed_;
        }

        public void Update(float deltaTime)
        {

        }

        public void Draw(Graphics g)
        {

        }
    }
}
