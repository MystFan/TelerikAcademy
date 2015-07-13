namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            // Console.WriteLine(FileInfo.GetFileExtension("example"));
            Console.WriteLine(FileInfo.GetFileExtension("example.pdf"));
            Console.WriteLine(FileInfo.GetFileExtension("example.new.pdf"));

            // Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example.new.pdf"));

            Dimension2D dimension2D = new Dimension2D(10, 10);
            Dimension3D dimension3D = new Dimension3D(10, 10, 10);

            Console.WriteLine("Distance in the 2D space = {0:f2}", dimension2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", dimension3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            dimension3D.Width = 3;
            dimension3D.Height = 4;
            dimension3D.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", dimension3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", dimension3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", dimension2D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", dimension3D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", dimension3D.CalcDiagonalYZ());
        }
    }
}
