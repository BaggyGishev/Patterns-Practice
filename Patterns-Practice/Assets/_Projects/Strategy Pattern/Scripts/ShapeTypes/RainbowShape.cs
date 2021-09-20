namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class RainbowShape : Shape
    {
        public RainbowShape()
        {
            _motionBehaviour = new StaticBehaviour();
            _colorBehaviour = new RainbowBehaviour();
        }
    }
}