using UnityEngine;

namespace TestTask
{
    public class StartButton : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private GameObject _particleSystem;

        private const string ToStateParametr = "SetState";

        public void Click()
        {
            _animator.SetBool(ToStateParametr, true);
            _particleSystem.SetActive(true);
        }
    }
}