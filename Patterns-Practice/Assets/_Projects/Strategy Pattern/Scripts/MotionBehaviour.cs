using UnityEngine;

namespace Gisha.PatternsPractice.StrategyPattern
{
    public interface MotionBehaviour
    {
        public void DoMotion(Rigidbody rb);
    }

    public class StaticBehaviour : MotionBehaviour
    {
        public void DoMotion(Rigidbody rb)
        {
        }
    }

    public class JumpBehaviour : MotionBehaviour
    {
        public void DoMotion(Rigidbody rb)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    public class RotationBehaviour : MotionBehaviour
    {
        public void DoMotion(Rigidbody rb)
        {
            rb.AddTorque(Vector3.up * 45f, ForceMode.Impulse);
        }
    }
}