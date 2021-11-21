using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSlider : MonoBehaviour
{
    public Slider scale_slider;
    public float minValue;
    public float maxValue;

    // Start is called before the first frame update
    void Start()
    {
        scale_slider.minValue = minValue;
        scale_slider.maxValue = maxValue;

        scale_slider.onValueChanged.AddListener(ScaleObject);
    }

    void ScaleObject(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
}
