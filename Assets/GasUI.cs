using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GasUI : MonoBehaviour
{
    [SerializeField] Driver driver;
    [SerializeField] Text gasText;
    [SerializeField] Slider gasSlider;
    void Update()
    {
        gasText.text = $"Gasoline: {driver.gas:f0}%";
        gasSlider.value = driver.gas;
    }
}
