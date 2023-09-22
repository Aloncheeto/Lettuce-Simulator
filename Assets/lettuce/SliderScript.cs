using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SliderScript : MonoBehaviour
{
    public SliderInt mainSlider;
    public void AmountWake(float value)
    {
        PlayerPrefs.SetFloat("LettuceAmount", value);
        print(value);
    }

}
