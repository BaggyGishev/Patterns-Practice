namespace Gisha.PatternsPractice.StrategyPattern.ShapeTypes
{
    public class JumpingShape : Shape
    {
        public JumpingShape()
        {
            _motionBehaviour = new JumpBehaviour();
            _colorBehaviour = new UncoloredBehaviour();
        }
    }
}