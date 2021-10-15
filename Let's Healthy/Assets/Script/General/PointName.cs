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

    bool overRigth;

    public GameObject InfoPanel;

    public TMP_Text Title;
    public Text So, Fat, Pro, Cal;
    float sodium,fat,protein,kiloCalories;
    void Start()
    {
        Panel.SetActive(false);
        overRigth = false;
        InfoPanel.SetActive(false);
    }


    void Update()
    {
        if (overRigth == false)
        {
            uiHover.transform.position = Input.mousePosition;

        }
        else
        {
            uiHover.transform.position = Input.mousePosition + new Vector3(-120, 0, 0);
        }

        text.text = showText;

        if (Input.GetMouseButtonUp(0))
        {
            Out();
        }

        InfoUpdate();

    }

    public void Show(string pointName)
    {
        showText = pointName;
        Panel.SetActive(true);

        switch (pointName)
        {
            default:
                InfoPanel.SetActive(true);
                break;
            case "������":
            case "⫹����":
            case "⫹���":
            case "⫹�������":
            case "⫹����ͧ��ا":
            case "������":
            case "����������":
            case "�ѵ�ػ��ȹҷ����������":
            case "���ǵ��":
            case "�����й��":
            case "����������Ѻ":
            case "���ǼѴ�ԧ":
            case "���ǼѴ���":
            case "�����ѹ��":
            case "ᡧ������":
            case "���ǹ��":
            case "�ػ���Ȩ����":
            case "����":
            case "��з�":
            case "�Ѿ��":
            case "������":
            case "��һ����":
            case "���¤�":
            case "�մ":
            case "���":
                InfoPanel.SetActive(false);
                break;
        }
        
    }
    public void Out()
    {
        showText = "";
        Panel.SetActive(false);
        overRigth = false;
        InfoPanel.SetActive(false);
    }
    public void OverRigth()
    {
        overRigth = true;
    }

    void InfoUpdate()
    {
        //����������������Ѻ�������� ���������� �ͧ����� �����ҡ��¹�鴵������������������ѹ ;-;
        switch (showText)
        {
            case "����":
                sodium = 1;
                fat = 0.3f;
                protein = 2.7f;
                kiloCalories = 130;
                break;
            case "�������":
                sodium = 75.6f;
                fat = 12.4f;
                protein = 38.9f;
                kiloCalories = 199;
                break;
            case "��ͷ":
                sodium = 42.1f;
                fat = 0.1f;
                protein = 0.5f;
                kiloCalories = 28.1f;
                break;
            case "������":
                sodium = 45;
                fat = 2.6f;
                protein = 22.5f;
                kiloCalories = 120;
                break;
            case "�й��":
                sodium = 6.2f;
                fat = 0.6f;
                protein = 1;
                kiloCalories = 19.4f;
                break;
            case "�з�":
                sodium = 36;
                fat = 57.6f;
                protein = 5.52f;
                kiloCalories = 813.6f;
                break;
            case "ᵧ���":
                sodium = 4;
                fat = 0.22f;
                protein = 1.12f;
                kiloCalories = 36;
                break;
            case "��":
                sodium = 71;
                fat = 4.8f;
                protein = 6.3f;
                kiloCalories = 72f;
                break;
            case "���µ���":
                sodium = 71;
                fat = 4.8f;
                protein = 6.3f;
                kiloCalories = 72f;
                break;
            case "���ͻ��":
                sodium = 15;
                fat = 0.7f;
                protein = 1.1f;
                kiloCalories = 22f;
                break;
            case "�������":
                sodium = 36;
                fat = 0.4f;
                protein = 3.4f;
                kiloCalories = 66f;
                break;
            case "�ԧ":
                sodium = 1.3f;
                fat = 0.08f;
                protein = 0.18f;
                kiloCalories = 7.9f;
                break;
            case "�й��":
                sodium = 8;
                fat = 0;
                protein = 4;
                kiloCalories = 176;
                break;
            case "��":
                sodium = 105.6f;
                fat = 2.4f;
                protein = 8.16f;
                kiloCalories = 100.8f;
                break;
            case "���ͺ�":
                sodium = 32.3f;
                fat = 8.2f;
                protein = 19.3f;
                kiloCalories = 199;
                break;
            case "����Ѻ":
                sodium = 94;
                fat = 32.9f;
                protein = 22.8f;
                kiloCalories = 171f;
                break;
            case "�������˭�":
                sodium = 4.4f;
                fat = 0.1f;
                protein = 1.2f;
                kiloCalories = 44f;
                break;
            case "�������":
                sodium = 188;
                fat = 65.8f;
                protein = 45.6f;
                kiloCalories = 342f;
                break;
            case "�ѹ����":
                sodium = 421;
                fat = 0.1f;
                protein = 2f;
                kiloCalories = 77f;
                break;
            case "���ᴧ":
                sodium = 2.4f;
                fat = 0f;
                protein = 0.6f;
                kiloCalories = 14.4f;
                break;
            case "�����":
                sodium = 16;
                fat = 0.1f;
                protein = 1.8f;
                kiloCalories = 16f;
                break;
            case "�������":
                sodium = 20;
                fat = 0;
                protein = 0;
                kiloCalories = 35.4f;
                break;
            case "����й��":
                sodium = 0.1f;
                fat = 0.02f;
                protein = 0.04f;
                kiloCalories = 2.1f;
                break;
            case "��������":
                sodium = 580;
                fat = 3;
                protein = 1;
                kiloCalories = 45;
                break;
            case "���ͧ��":
                sodium = 95.25f;
                fat = 11.25f;
                protein = 0.15f;
                kiloCalories = 101.85f;
                break;
            case "���ͧ�� �":
                sodium = 70.1f;
                fat = 2.71f;
                protein = 0.04f;
                kiloCalories = 32.7f;
                break;
            case "���ͧ�� ��ѹ���":
                sodium = 120;
                fat = 0;
                protein = 0.03f;
                kiloCalories = 10.2f;
                break;
            case "�����Ǵ�":
                sodium = 560;
                fat = 0;
                protein = 0.5f;
                kiloCalories = 5;
                break;
            case "�����Ǣ��":
                sodium = 400;
                fat = 0;
                protein = 0.9f;
                kiloCalories = 15;
                break;
            case "��ӻ��":
                sodium = 490;
                fat = 0;
                protein = 0f;
                kiloCalories = 0;
                break;
            case "����ѹ���":
                sodium = 165;
                fat = 0;
                protein = 0.2f;
                kiloCalories = 15;
                break;
            case "������ (MSG)":
                sodium = 484.1f;
                fat = 0;
                protein = 0;
                kiloCalories = 12;
                break;
            case "��ԡ��":
                sodium = 0.5f;
                fat = 0.1f;
                protein = 0.2f;
                kiloCalories = 7.5f;
                break;
            case "��ԡ���¹":
                sodium = 98.4f;
                fat = 0.85f;
                protein = 0.81f;
                kiloCalories = 16.92f;
                break;
            case "�����������":
            case "����":
                sodium = 1900;
                fat = 0;
                protein = 0;
                kiloCalories = 0;
                break;
            case "��ӵ�ŷ��¢��":
                sodium = 0;
                fat = 0;
                protein = 0;
                kiloCalories = 19;
                break;
            case "����������":
                sodium = 47.5f;
                fat = 0;
                protein = 0;
                kiloCalories = 15;
                break;
            case "��ӵ�ŷ���ᴧ":
                sodium = 1;
                fat = 0;
                protein = 0;
                kiloCalories = 18;
                break;
            case "ͺ��":
                sodium = 30.4f;
                fat = 0.12f;
                protein = 0.4f;
                kiloCalories = 24.7f;
                break;


        }

        Title.text = showText;

        if (showText == "")
        {
            So.text = "";
            Fat.text = "";
            Pro.text = "";
            Cal.text = "";
        }
        else
        {
            So.text = "��������� " + sodium.ToString()+ " ����";
            Fat.text = "�����ѹ " + fat.ToString() + " ����";
            Pro.text = "����õչ " + protein.ToString() + " ����";
            Cal.text = "��������� " + kiloCalories.ToString() + " ����������";
        }

    }

}
