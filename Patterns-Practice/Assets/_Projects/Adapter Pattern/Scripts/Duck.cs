using UnityEngine;

namespace Gisha.PatternsPractice.AdapterPattern
{
    public interface Duck
    {
        public void Quack();
        public void Fly();
    }

    public class MallardDuck : Duck
    {
        public void Quack()
        {
            Debug.Log("<color=green>Quack!</color>");
        }

        public void Fly()
        {
            Debug.Log("I'm flying!");
            EffectsManager.ShowBirdImage("Duck");
        }
    }
}