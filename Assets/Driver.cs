using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 250f;
    [SerializeField] public float gas = 100f;
    
    void Start() {
        // transform.DOPath(waypoints,30);
        // transform.DOLocalRotate(new Vector3(0,0,10),1);
    }

    void Update()
    {
        float speed = 0;
        float steer = 0;
        if (Keyboard.current.wKey.isPressed)
        {
            speed = 0.02f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            speed = -0.02f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 0.3f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            steer = -0.3f;
        }
        float moveAmount = speed * moveSpeed * Time.deltaTime;
        float steerAmount = steerSpeed * steer * Time.deltaTime;
        if (moveAmount != 0)
        {
            gas -= .01f;
            if (gas <= 0)
            {
                moveAmount = 0;
            }
        }
        
        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,steerAmount);
    }
}
