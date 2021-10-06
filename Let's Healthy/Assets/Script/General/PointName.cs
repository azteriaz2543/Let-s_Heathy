using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PointName : MonoBehaviour
{
    public GameObject uiHover;
    public GameObject Panel;
    public TMP_Text text;
    string showText;

    void Start()
    {
        Panel.SetActive(false);
    }


    void Update()
    {
        uiHover.transform.position = Input.mousePosition;

        text.text = showText;

    }

    public void Show(string pointName)
    {
        showText = pointName;
        Panel.SetActive(true);
    }
    public void Out()
    {
        showText = "";
        Panel.SetActive(false);
    }
}
