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
            case "ตู้เย็น":
            case "โซนเตาแกส":
            case "โซนหั่น":
            case "โซนเค้าเตอร์":
            case "โซนเครื่องปรุง":
            case "ไข่เจียว":
            case "ไข่เจียวไหม้":
            case "วัตถุปริศนาที่ไหม้แล้ว":
            case "ข้าวต้ม":
            case "ไก่นึ่งมะนาว":
            case "กระเพราหมูสับ":
            case "ข้าวผัดขิง":
            case "ข้าวผัดหมู":
            case "ข้าวมันไก่":
            case "แกงมัสมั่น":
            case "ไข่ดาวน้ำ":
            case "ซุปมหัศจรรย์":
            case "หม้อ":
            case "กระทะ":
            case "ทัพพี":
            case "ตะหลิว":
            case "ผ้าปูโต๊ะ":
            case "ถ้วยคน":
            case "มีด":
            case "น้ำ":
            case "ถ้วยใหญ่":
            case "ผสม":
            case "สวิทช์เตาแกส":
            case "ชาม":
            case "เมนูเนื้อไก่":
            case "เมนูเนื้อไก่ไม่ใส่ผัก":
            case "เมนูเนื้อหมู":
            case "เมนูเนื้อหมูไม่ใส่ผัก":
            case "เมนูเนื้อปลา":
            case "เมนูเนื้อปลาไม่ใส่ผัก":
            case "เมนูเนื้อวัว":
            case "เมนูเนื้อวัวไม่ใส่ผัก":
            case "เมนูผักล้วน":
            case "แซนวิชไข่ขาว":
            case "แซนวิชไข่ขาวแฮม":
            case "แซนวิชทูน่า":
            case "แซนวิชปูอัด":
            case "แซนวิชไข่":
            case "ถ้วยผสม":
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
        //ที่ใช้ภาษาไทยเพราะรับข้อมูลเป็น ชื่อภาษาไทย ของไอเท็ม ไม่อยากเขียนโค้ดตัวใหม่แล้วไปใส่ทีละอัน ;-;
        switch (showText)
        {
            case "ข้าว":
                sodium = 1;
                fat = 0.3f;
                protein = 2.7f;
                kiloCalories = 130;
                break;
            case "เนื้อวัว":
                sodium = 75.6f;
                fat = 12.4f;
                protein = 38.9f;
                kiloCalories = 199;
                break;
            case "แครอท":
                sodium = 42.1f;
                fat = 0.1f;
                protein = 0.5f;
                kiloCalories = 28.1f;
                break;
            case "เนื้อไก่":
                sodium = 45;
                fat = 2.6f;
                protein = 22.5f;
                kiloCalories = 120;
                break;
            case "คะน้า":
                sodium = 6.2f;
                fat = 0.6f;
                protein = 1;
                kiloCalories = 19.4f;
                break;
            case "กะทิ":
                sodium = 36;
                fat = 57.6f;
                protein = 5.5f;
                kiloCalories = 51f;
                break;
            case "แตงกวา":
                sodium = 2;
                fat = 0.1f;
                protein = 0.6f;
                kiloCalories = 18;
                break;
            case "ไข่":
                sodium = 71;
                fat = 4.8f;
                protein = 6.3f;
                kiloCalories = 72f;
                break;
            case "ถ้วยตีไข่":
                sodium = 71;
                fat = 4.8f;
                protein = 6.3f;
                kiloCalories = 72f;
                break;
            case "เนื้อปลา":
                sodium = 15;
                fat = 0.7f;
                protein = 1.1f;
                kiloCalories = 22f;
                break;
            case "กระเทียม":
                sodium = 18;
                fat = 0.2f;
                protein = 1.7f;
                kiloCalories = 33f;
                break;
            case "ขิง":
                sodium = 1.3f;
                fat = 0.1f;
                protein = 0.2f;
                kiloCalories = 7.9f;
                break;
            case "มะนาว":
                sodium = 2;
                fat = 0;
                protein = 1;
                kiloCalories = 22;
                break;
            case "นม":
                sodium = 105.6f;
                fat = 2.4f;
                protein = 8.16f;
                kiloCalories = 100.8f;
                break;
            case "เนื้อบด":
                sodium = 37.8f;
                fat = 6.2f;
                protein = 19.45f;
                kiloCalories = 99.5f;
                break;
            case "หมูสับ":
                sodium = 47;
                fat = 16.45f;
                protein = 11.4f;
                kiloCalories = 85.5f;
                break;
            case "หัวหอมใหญ่":
                sodium = 4.4f;
                fat = 0.1f;
                protein = 1.2f;
                kiloCalories = 44f;
                break;
            case "เนื้อหมู":
                sodium = 94;
                fat = 32.9f;
                protein = 22.8f;
                kiloCalories = 171f;
                break;
            case "มันฝรั่ง":
                sodium = 421;
                fat = 0.1f;
                protein = 2f;
                kiloCalories = 77f;
                break;
            case "หอมแดง":
                sodium = 2.4f;
                fat = 0f;
                protein = 0.6f;
                kiloCalories = 14.4f;
                break;
            case "ต้นหอม":
                sodium = 16;
                fat = 0.1f;
                protein = 1.8f;
                kiloCalories = 16f;
                break;
            case "มะเขือเทศ":
                sodium = 10;
                fat = 0;
                protein = 0;
                kiloCalories = 17.7f;
                break;
            case "น้ำมะนาว":
                sodium = 0.1f;
                fat = 0.02f;
                protein = 0.04f;
                kiloCalories = 2.1f;
                break;
            case "ผงมัสมั่น":
                sodium = 580;
                fat = 3;
                protein = 1;
                kiloCalories = 45;
                break;
            case "มายองเนส":
                sodium = 95.25f;
                fat = 11.25f;
                protein = 0.15f;
                kiloCalories = 101.85f;
                break;
            case "มายองเนส เจ":
                sodium = 70.1f;
                fat = 2.71f;
                protein = 0.04f;
                kiloCalories = 32.7f;
                break;
            case "มายองเนส ไขมันต่ำ":
                sodium = 120;
                fat = 0;
                protein = 0.03f;
                kiloCalories = 10.2f;
                break;
            case "ซีอิ๊วดำ":
                sodium = 560;
                fat = 0;
                protein = 0.5f;
                kiloCalories = 5;
                break;
            case "ซีอิ๊วขาว":
                sodium = 400;
                fat = 0;
                protein = 0.9f;
                kiloCalories = 15;
                break;
            case "น้ำปลา":
                sodium = 500;
                fat = 0;
                protein = 0.9f;
                kiloCalories = 3;
                break;
            case "ซอสหอยนางรม":
                sodium = 165;
                fat = 0;
                protein = 0.2f;
                kiloCalories = 15;
                break;
            case "ผงชูรส (MSG)":
                sodium = 484.1f;
                fat = 0;
                protein = 0;
                kiloCalories = 12;
                break;
            case "พริกไทย":
                sodium = 0.5f;
                fat = 0.1f;
                protein = 0.2f;
                kiloCalories = 7.5f;
                break;
            case "พริกคาเยน":
                sodium = 98.4f;
                fat = 0.85f;
                protein = 0.81f;
                kiloCalories = 16.92f;
                break;
            case "เกลือหิมาลัย":
                sodium = 800;
                fat = 0;
                protein = 0;
                kiloCalories = 0;
                break;
            case "เกลือ":
                sodium = 950;
                fat = 0;
                protein = 0;
                kiloCalories = 0;
                break;
            case "น้ำตาลทรายขาว":
                sodium = 0;
                fat = 0;
                protein = 0;
                kiloCalories = 19;
                break;
            case "ซอสมะเขือเทศ":
                sodium = 47.5f;
                fat = 0;
                protein = 0;
                kiloCalories = 15;
                break;
            case "น้ำตาลทรายแดง":
                sodium = 1;
                fat = 0;
                protein = 0;
                kiloCalories = 18;
                break;
            case "อบเชย":
                sodium = 30.4f;
                fat = 0.12f;
                protein = 0.4f;
                kiloCalories = 24.7f;
                break;
            case "ใบกระเพรา":
                sodium = 0.1f;
                fat = 0;
                protein = 0.1f;
                kiloCalories = 0.6f;
                break;
            case "พริก":
                sodium = 0f;
                fat = 0f;
                protein = 0f;
                kiloCalories = 14.1f;
                break;
            case "ปูอัด":
                sodium = 557.1f;
                fat = 0.6f;
                protein = 6.4f;
                kiloCalories = 84f;
                break;
            case "แฮม":
                sodium = 900f;
                fat = 9f;
                protein = 17f;
                kiloCalories = 165f;
                break;
            case "ขนมปัง":
                sodium = 110f;
                fat = 1.3f;
                protein = 2.5f;
                kiloCalories = 65f;
                break;
            case "ไข่ขาว":
                sodium = 54.8f;
                fat = 0.1f;
                protein = 3.6f;
                kiloCalories = 17f;
                break;
            case "ทูน่ากระป๋อง":
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
            So.text = "ค่าโซเดี่ยม " + sodium.ToString()+ " กรัม";
            Fat.text = "ค่าไขมัน " + fat.ToString() + " กรัม";
            Pro.text = "ค่าโปรตีน " + protein.ToString() + " กรัม";
            Cal.text = "ค่าแคลอรี่ " + kiloCalories.ToString() + " กิโลแคลอรี่";
        }

    }

}
