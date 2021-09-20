namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class RGBRotatingShape : Shape
    {
        public RGBRotatingShape()
        {
            _motionBehaviour = new RotationBehaviour();
            _colorBehaviour = new RGBBehaviour();
        }
    }
}