using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HospitalDigitalTwin : MonoBehaviour
{
    [Header("UI Sliders")]
    public Slider hrSlider;
    public Slider o2Slider;
    public Slider tempSlider;

    [Header("Displays")]
    public TextMeshProUGUI monitorText;
    public Renderer patientRenderer;

    void Update()
    {
        // Null check to prevent errors if things aren't assigned in Inspector
        if (hrSlider == null || o2Slider == null || tempSlider == null || monitorText == null || patientRenderer == null)
        {
            return;
        }

        // Read values from Sliders
        float hr = hrSlider.value;
        float o2 = o2Slider.value;
        float temp = tempSlider.value;

        // Update the Text
        monitorText.text = $"<color=red>HR:</color> {hr:F0} BPM\n" +
                           $"<color=blue>O2:</color> {o2:F0}%\n" +
                           $"<color=yellow>Temp:</color> {temp:F1}°C";

        // Update Patient Color
        UpdatePatientColor(hr, o2, temp);
    }

    void UpdatePatientColor(float hr, float o2, float temp)
    {
        // Logic: Red if any vital is critical
        if (hr > 120 || o2 < 92 || temp > 39.5f)
        {
            patientRenderer.material.color = Color.red;
        }
        else if (hr > 100 || temp > 38.5f || o2 < 95)
        {
            patientRenderer.material.color = new Color(1f, 0.64f, 0f); // Orange
        }
        else
        {
            patientRenderer.material.color = Color.green;
        }
    }
}