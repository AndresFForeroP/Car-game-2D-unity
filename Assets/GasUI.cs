using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GasUI : MonoBehaviour
{
    [SerializeField] Driver driver;
    [SerializeField] Slider gasSlider;
    [SerializeField] Image gasFill;
    [SerializeField] BlinkCoroutine blinkui;

    void Update()
    {
        gasSlider.value = driver.gas;
        if (driver.gas <= 20)
            {
                blinkui.StartBlink();
                gasFill.color = Color.red;
            }
        else if (driver.gas <= 50)
            gasFill.color = Color.yellow;
        else
            gasFill.color = Color.green;
    }
}
