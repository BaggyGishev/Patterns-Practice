using UnityEngine;

namespace Gisha.PatternsPractice.FacadePattern
{
    public class Door : MonoBehaviour, IActiveable
    {
        private Animator _animator;
        private BoxCollider _boxCollider;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider>();
            _animator = GetComponent<Animator>();
        }

        public void Activate()
        {
            _boxCollider.enabled = false;
            _animator.SetBool("IsOpened", true);
        }

        public void Deactivate()
        {
            _boxCollider.enabled = true;
            _animator.SetBool("IsOpened", false);
        }
    }
}