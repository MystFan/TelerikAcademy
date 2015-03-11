
namespace _04.PathOfPoints
{
    using _02.StaticReadOnlyField;
    using System.Collections.Generic;
    using System.Linq;

    public class Path
    {
        private List<Point3D> points;

        public Path(List<Point3D> points)
        {
            this.points = points;
        }

        public Path(Point3D[] points)
        {
            this.points = points.ToList();
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }
    }
}
