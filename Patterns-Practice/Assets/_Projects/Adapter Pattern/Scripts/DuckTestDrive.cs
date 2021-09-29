using UnityEngine;

namespace Gisha.PatternsPractice.AdapterPattern
{
    public class DuckTestDrive : MonoBehaviour
    {
        private Duck _duck;
        private Turkey _turkey;
        private TurkeyAdapter _turkeyAdapter;

        private void Awake()
        {
            _duck = new MallardDuck();
            _turkey = new WildTurkey();
            _turkeyAdapter = new TurkeyAdapter(_turkey);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("<color=yellow>The Turkey says</color>");
                _turkey.Gobble();
                _turkey.Fly();
            }

            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("<color=yellow>The Duck says</color>");
                TestDuck(_duck);
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log("<color=yellow>The Turkey Adapter says</color>");
                TestDuck(_turkeyAdapter);
            }
        }

        private void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}