using UnityEngine;

namespace Gisha.PatternsPractice.AdapterPattern
{
    public interface Turkey
    {
        public void Gobble();
        public void Fly();
    }

    public class WildTurkey : Turkey
    {
        public void Gobble()
        {
            Debug.Log("<color=red>Gobble!</color>");
        }

        public void Fly()
        {
            Debug.Log("I'm flying!");
            EffectsManager.ShowBirdImage("Turkey");
        }
    }
}