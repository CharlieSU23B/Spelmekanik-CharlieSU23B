using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider mSlider;
    int MouseHoldDown = 0;
    float SliderValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        mSlider.value = 0f;
        mSlider.maxValue = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && MouseHoldDown < 350)
        {
            MouseHoldDown++;
            SliderValue = MouseHoldDown / 350f;
            mSlider.value = SliderValue;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            MouseHoldDown = 0;
            mSlider.value = 0f;
        }
    }
}
