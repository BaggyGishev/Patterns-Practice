using UnityEngine;

namespace Gisha.PatternsPractice.AdapterPattern
{
    public class TurkeyAdapter : Duck
    {
        private Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            _turkey.Fly();
        }
    }
}