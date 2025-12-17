using UnityEngine;
using UnityEngine.InputSystem;

public class PoliceCar : MonoBehaviour
{
    [SerializeField] Animator _animator; //Se ve este campo en inspector

    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            _animator.SetBool("IsLightsOn", false);
        }

        if (Keyboard.current.leftShiftKey.isPressed)
        {
            _animator.SetBool("IsLightsOn", true);
        }
    }
}
