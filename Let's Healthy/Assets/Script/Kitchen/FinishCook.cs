using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCook : MonoBehaviour
{
    int protein, vegetable;
    //bool spoon;
    bool turner;
    bool egg, carrot, porkWord;

    string CurrentFood;

    void Start()
    {

    }

    
    void Update()
    {
        
    }



    public void AddItemInCook(string ItemName)
    {

        switch (ItemName)
        {
            case "Spoon":
                //spoon = true;
                break;
            case "Turner":
                turner = true;
                break;
            #region Egg
            case "Egg1":
                egg = true;
                protein++;
                break;
            case "Egg2":
                egg = true;
                protein++;
                break;
            case "Egg3":
                egg = true;
                protein++;
                break;
            case "Egg4":
                egg = true;
                protein++;
                break;
            #endregion
            #region Carrot
            case "CutedCarrot1_Step2":
                carrot = true;
                vegetable += 2;
                break;
            case "CutedCarrot2_Step2":
                carrot = true;
                vegetable += 2;
                break;
            case "CutedCarrot3_Step2":
                carrot = true;
                vegetable += 2;
                break;
            case "CutedCarrot4_Step2":
                carrot = true;
                vegetable += 2;
                break;
            #endregion
            #region PorkWord
            case "MincedPork1":
                porkWord = true;
                protein += 2;
                break;
            case "MincedPork2":
                porkWord = true;
                protein += 2;
                break;
            case "MincedPork3":
                porkWord = true;
                protein += 2;
                break;
            case "MincedPork4":
                porkWord = true;
                protein += 2;
                break;
                #endregion
        }

    }

    public string DiagnoseFood(bool burn,string used, bool eatable)
    {

        if (egg == true && turner == true && used == "Pan" && eatable == true)
        {
            if (porkWord == true && carrot == false && burn == false) //����������Ѻ�����ͷ
            {
                CurrentFood = "Omelet_PW";
            }
            else if (porkWord == false && carrot == true && burn == false) //��������ͷ�������Ѻ
            {
                CurrentFood = "Omelet_C";
            }
            else if (porkWord == true && carrot == true && burn == false) //����������Ѻ��ͷ
            {
                CurrentFood = "Omelet_PW_C";
            }
            else if(porkWord == false && carrot == false && burn == false) //������
            {
                CurrentFood = "OmeletOnly";
            }
            else if (porkWord == true && carrot == false && burn == true) //����������Ѻ�����ͷ ����
            {
                CurrentFood = "Omelet_PW_Burn";
            }
            else if (porkWord == false && carrot == true && burn == true) //��������ͷ�������Ѻ ����
            {
                CurrentFood = "Omelet_C_Burn";
            }
            else if (porkWord == true && carrot == true && burn == true) //����������Ѻ��ͷ ����
            {
                CurrentFood = "Omelet_PW_C_Burn";
            }
            else if (porkWord == false && carrot == false && burn == true)//������ ����
            {
                CurrentFood = "OmeletOnly_Burn";
            }
        }

        return CurrentFood;

    }

    public void Reset()
    {
        protein = 0;
        vegetable = 0;

        turner = false;
        egg = false;
        carrot = false;
        porkWord = false;
    }
}
