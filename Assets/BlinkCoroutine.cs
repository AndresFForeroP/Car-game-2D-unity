using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlinkCoroutine : MonoBehaviour
{
    [SerializeField] float blinkSpeed = 2f;
    Image image;
    Coroutine routine;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    public void StartBlink()
    {
        if (routine == null)
            routine = StartCoroutine(Blink());
    }

    public void StopBlink()
    {
        if (routine != null)
        {
            StopCoroutine(routine);
            routine = null;
            SetAlpha(1f);
        }
    }

    IEnumerator Blink()
    {
        while (true)
        {
            float alpha = Mathf.Abs(Mathf.Sin(Time.time * blinkSpeed));
            SetAlpha(alpha);
            yield return null;
        }
    }

    void SetAlpha(float alpha)
    {
        image.color = new Color(
            image.color.r,
            image.color.g,
            image.color.b,
            alpha
        );
    }
}
