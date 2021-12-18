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
            case "�����˭�":
            case "���":
            case "��Է������":
            case "���":
            case "����������":
            case "����������������ѡ":
            case "�����������":
            case "�����������������ѡ":
            case "�������ͻ��":
            case "�������ͻ��������ѡ":
            case "�����������":
            case "�����������������ѡ":
            case "���ټѡ��ǹ":
            case "᫹�Ԫ����":
            case "᫹�Ԫ�������":
            case "᫹�Ԫ�ٹ��":
            case "᫹�Ԫ���Ѵ":
            case "᫹�Ԫ��":
            case "���¼��":
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
                protein = 5.5f;
                kiloCalories = 51f;
                break;
            case "ᵧ���":
                sodium = 2;
                fat = 0.1f;
                protein = 0.6f;
                kiloCalories = 18;
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
                sodium = 18;
                fat = 0.2f;
                protein = 1.7f;
                kiloCalories = 33f;
                break;
            case "�ԧ":
                sodium = 1.3f;
                fat = 0.1f;
                protein = 0.2f;
                kiloCalories = 7.9f;
                break;
            case "�й��":
                sodium = 2;
                fat = 0;
                protein = 1;
                kiloCalories = 22;
                break;
            case "��":
                sodium = 105.6f;
                fat = 2.4f;
                protein = 8.16f;
                kiloCalories = 100.8f;
                break;
            case "���ͺ�":
                sodium = 37.8f;
                fat = 6.2f;
                protein = 19.45f;
                kiloCalories = 99.5f;
                break;
            case "����Ѻ":
                sodium = 47;
                fat = 16.45f;
                protein = 11.4f;
                kiloCalories = 85.5f;
                break;
            case "�������˭�":
                sodium = 4.4f;
                fat = 0.1f;
                protein = 1.2f;
                kiloCalories = 44f;
                break;
            case "�������":
                sodium = 94;
                fat = 32.9f;
                protein = 22.8f;
                kiloCalories = 171f;
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
                sodium = 10;
                fat = 0;
                protein = 0;
                kiloCalories = 17.7f;
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
                sodium = 500;
                fat = 0;
                protein = 0.9f;
                kiloCalories = 3;
                break;
            case "�����¹ҧ��":
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
                sodium = 800;
                fat = 0;
                protein = 0;
                kiloCalories = 0;
                break;
            case "����":
                sodium = 950;
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
            case "㺡�����":
                sodium = 0.1f;
                fat = 0;
                protein = 0.1f;
                kiloCalories = 0.6f;
                break;
            case "��ԡ":
                sodium = 0f;
                fat = 0f;
                protein = 0f;
                kiloCalories = 14.1f;
                break;
            case "���Ѵ":
                sodium = 557.1f;
                fat = 0.6f;
                protein = 6.4f;
                kiloCalories = 84f;
                break;
            case "���":
                sodium = 900f;
                fat = 9f;
                protein = 17f;
                kiloCalories = 165f;
                break;
            case "����ѧ":
                sodium = 110f;
                fat = 1.3f;
                protein = 2.5f;
                kiloCalories = 65f;
                break;
            case "����":
                sodium = 54.8f;
                fat = 0.1f;
                protein = 3.6f;
                kiloCalories = 17f;
                break;
            case "�ٹ�ҡ�л�ͧ":
                sodium = 120;
                fat = 0f;
                protein = 19f;
                kiloCalories = 80f;
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
