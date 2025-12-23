using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class Collision : MonoBehaviour
{
    [SerializeField] Driver driver;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("choco");
        transform.DOShakePosition(0.03f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        // if (collision.CompareTag("Point"))
        // {
        //     Debug.Log("sumar punto");
        //     // Instantiate(carro); // esto es para crear objetos
        //     // collision.gameObject.SetActive(false); // asi se desactiva objeto juego
        //     // Destroy(collision.gameObject); // asi se destruye un objeto de juego
        // }
        if (collision.CompareTag("caida"))
        {
            transform.Translate(0,-3,0);
        }
        if(collision.CompareTag("Gas"))
        {
            Destroy(collision.gameObject);
            driver.gas += 20f;
            if (driver.gas > 100)
            {
                driver.gas = 100;
            }
        }
    }
}
