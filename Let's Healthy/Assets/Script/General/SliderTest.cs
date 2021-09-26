using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    public Slider slider;
    float time = 0;

    void Start()
    {

    }
   
    void Update()
    {
        time += Time.deltaTime;
        slider.value = time;
    }
}
