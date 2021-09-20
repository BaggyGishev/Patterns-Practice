namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class RGBShape : Shape
    {
        public RGBShape()
        {
            _motionBehaviour = new StaticBehaviour();
            _colorBehaviour = new RGBBehaviour();
        }
    }
}