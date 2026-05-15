using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chargeBar : MonoBehaviour
{
    [SerializeField] public Slider slider;
    [SerializeField] public Image fillImage;
    //[SerializeField] private Camera _camera;
    //[SerializeField] private Transform target;
    void Awake()
    {
        slider = GetComponent<Slider>();
        transform.localRotation = Quaternion.identity;
    }

  
    // Update is called once per frame
    void Update()
    {
        //transform.rotation = camera.transform.rotation;
        //target.position = target.position;
    }

    public void updateCharge(float currentValue, float maxValue)
    {
        
        slider.value = (currentValue - 5) / (maxValue - 5); ;

    }
}
