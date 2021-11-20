using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSlider : MonoBehaviour
{
    public Slider rotate_slider;
    public float minValue;
    public float maxValue;

    // Start is called before the first frame update
    void Start()
    {
        rotate_slider.minValue = minValue;
        rotate_slider.maxValue = maxValue;

        rotate_slider.onValueChanged.AddListener(RotateObject);
    }

    void RotateObject(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.y, value);

    }
}
