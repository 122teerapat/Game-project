using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    [SerializeField] private Slider slider;
    [SerializeField] private Image fillImage;

    void Awake()
    {
         slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void updateHealth(float currentValue,float maxValue)
    {
        float fillValue = currentValue / maxValue;
        if (fillValue <= slider.maxValue / 2)
        {
            fillImage.color = new Color(1.0f, 0.7f, 0.0f);
        }
        else if (fillValue > slider.maxValue / 2)
        {
            fillImage.color = Color.green;
        }

        slider.value = fillValue;
        
    }
}
