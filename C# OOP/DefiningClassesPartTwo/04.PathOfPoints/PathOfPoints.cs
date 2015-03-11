/*Problem 4. Path

    Create a class Path to hold a sequence of points in the 3D space.
    Create a static class PathStorage with static methods to save and load paths from a text file.
    Use a file format of your choice.
*/

namespace _04.PathOfPoints
{
    using _02.StaticReadOnlyField;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    class PathOfPoints
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<Point3D> points = new List<Point3D>()
            {
                new Point3D(12,23,24),
                new Point3D(34,23,5),
                new Point3D(12.3, 34.23, 12),
                new Point3D(34,21,12)
            };
            Path path = new Path(points);
            PathStorage.SavePath(path, "..\\..\\paths.txt");

            List<Path> paths = PathStorage.LoadPaths("..\\..\\paths.txt");
        }
    }
}
