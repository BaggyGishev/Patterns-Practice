namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class RGBJumpingShape : Shape
    {
        public RGBJumpingShape()
        {
            _motionBehaviour = new JumpBehaviour();
            _colorBehaviour = new RGBBehaviour();
        }
    }
}