using _02.StaticReadOnlyField;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PathOfPoints
{
    static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            List<Path> paths = LoadPaths(filePath);
            
            if (!paths.Contains(path))
            {
                paths.Add(path);
            }

            StreamWriter writer = new StreamWriter(filePath);

            using (writer)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in paths)
                {
                    for (int i = 0; i < item.Points.Count; i++)
                    {
                        sb.Append("(" + item.Points[i].X + ";" + item.Points[i].Y + ";" + item.Points[i].Z + ")");
                    }
                    writer.WriteLine(sb.ToString());
                    sb.Clear();
                }
            }

        }

        public static List<Path> LoadPaths(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            List<Path> paths = new List<Path>();
            using (reader)
            {
                string row = reader.ReadLine();
                while (row != null)
                {
                    if (row == "")
                    {
                        break;
                    }
                    List<Point3D> rows = new List<Point3D>();
                    string[] data = row.Split(new char[] { ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < data.Length; i++)
                    {
                        double[] pointsSplit = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                        Point3D point = new Point3D(pointsSplit[0], pointsSplit[1], pointsSplit[2]);
                        rows.Add(point);
                    }
                    Path currentPath = new Path(rows);
                    paths.Add(currentPath);
                    row = reader.ReadLine();
                }
            }

            return paths;
        }
    }
}
