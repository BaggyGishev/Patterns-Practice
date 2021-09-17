using UnityEngine;

namespace Gisha.PatternsPractice.ObserverPattern.LittleGame.Core
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10f;
        public bool IsArmed => _isArmed;

        private Vector3 _input;
        private bool _isArmed = false;

        private Rigidbody _rigidbody;
        private Animator _animator;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            _rigidbody.velocity = _input.normalized * moveSpeed;

            if (_input.magnitude > 0)
            {
                _rigidbody.rotation = Quaternion.LookRotation(_input);
                _animator.SetBool("IsRunning", true);
            }
            else
                _animator.SetBool("IsRunning", false);
        }

        public void GetArmed()
        {
            _isArmed = true;
        }
    }
}