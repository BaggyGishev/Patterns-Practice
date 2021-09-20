namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class RotatingShape : Shape
    {
        public RotatingShape()
        {
            _motionBehaviour = new RotationBehaviour();
            _colorBehaviour = new UncoloredBehaviour();
        }
    }
}