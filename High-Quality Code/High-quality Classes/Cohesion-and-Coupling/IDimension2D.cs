namespace CohesionAndCoupling
{
    public interface IDimension2D : IDimension
    {
        double CalcDistance2D(double x1, double y1, double x2, double y2);

        double CalcDiagonalXY();
    }
}
