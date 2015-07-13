namespace Abstraction
{
    public interface IFigure
    {
        double Width { get; }
        double Height { get; }
        double CalcPerimeter();
        double CalcSurface();
    }
}
