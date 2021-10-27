using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{

    public GameObject[] CutedItems;

    Kitchen_UI kitchen_UI;

    public GameObject[] ItemDrop;
    public Transform ItemSpawn;
    public GameObject Pot, Pan;

    bool startCook;
    public bool endCook;
    public GameObject[] FinishCook;

    public GameObject Fire ,SmokeFire;

    public Slider slider;
    float time = 0;
    bool eatable;
    bool burn;

    public FinishCook finishCook;
    public GameObject[] Food;

    string kitchenwere;

    string targetSpawn;

    public GameObject PlateGO;

    private void Awake()
    {

    }

    void Start()
    {

        for (int i = 0; i < Food.Length; i++)
        {
                Food[i].SetActive(false);
        }

        for (int i = 0; i < FinishCook.Length; i++)
        {
                FinishCook[i].SetActive(false);
        }

        kitchen_UI = GameObject.Find("Kitchen_UI_Manager").GetComponent<Kitchen_UI>();

        for (int i = 0;i < CutedItems.Length;i++)
        {
            CutedItems[i].SetActive(false);
        }

        Pot.SetActive(false);
        Pan.SetActive(false);

        startCook = false;
        endCook = false;
        Fire.SetActive(false);
        SmokeFire.SetActive(false);

        finishCook = finishCook.GetComponent<FinishCook>();

        PlateGO.SetActive(false);
    }

    void Update()
    {
        if (startCook == true)
        {
            time += Time.deltaTime;      
        }

        slider.value = time;

        if (time > 2f)
        {
            eatable = true;
        }

        if (time > 5f)
        {
            burn = true;
        }

        if (time > slider.maxValue)
        {
            SmokeFire.SetActive(true);
        }
    }

    public void SpawnCutedItem(string ItemName)
    {

        switch (ItemName)
        {
            case "Carrot1":
                targetSpawn = "CutedCarrot1_Step1";
                break;
            case "Carrot2":
                targetSpawn = "CutedCarrot2_Step1";
                break;
            case "Carrot3":
                targetSpawn = "CutedCarrot3_Step1";
                break;
            case "Carrot4":
                targetSpawn = "CutedCarrot4_Step1";
                break;
            case "CutedCarrot1_Step1":
                targetSpawn = "CutedCarrot1_Step2";
                break;
            case "CutedCarrot2_Step1":
                targetSpawn = "CutedCarrot2_Step2";
                break;
            case "CutedCarrot3_Step1":
                targetSpawn = "CutedCarrot3_Step2";
                break;
            case "CutedCarrot4_Step1":
                targetSpawn = "CutedCarrot4_Step2";
                break;
            case "Beef1":
                targetSpawn = "CutedBeef1";
                break;
            case "Beef2":
                targetSpawn = "CutedBeef2";
                break;
            case "Beef3":
                targetSpawn = "CutedBeef3";
                break;
            case "Beef4":
                targetSpawn = "CutedBeef4";
                break;
            case "Chicken1":
                targetSpawn = "CutedChicken1";
                break;
            case "Chicken2":
                targetSpawn = "CutedChicken2";
                break;
            case "Chicken3":
                targetSpawn = "CutedChicken3";
                break;
            case "Chicken4":
                targetSpawn = "CutedChicken4";
                break;
            case "ChineseKale1":
                targetSpawn = "CutedChineseKale1_Step1";
                break;
            case "ChineseKale2":
                targetSpawn = "CutedChineseKale2_Step1";
                break;
            case "ChineseKale3":
                targetSpawn = "CutedChineseKale3_Step1";
                break;
            case "ChineseKale4":
                targetSpawn = "CutedChineseKale4_Step1";
                break;
            case "Cucumber1":
                targetSpawn = "CutedCucumber1";
                break;
            case "Cucumber2":
                targetSpawn = "CutedCucumber2";
                break;
            case "Cucumber3":
                targetSpawn = "CutedCucumber3";
                break;
            case "Cucumber4":
                targetSpawn = "CutedCucumber4";
                break;
            case "Fish1":
                targetSpawn = "CutedFish1";
                break;
            case "Fish2":
                targetSpawn = "CutedFish2";
                break;
            case "Fish3":
                targetSpawn = "CutedFish3";
                break;
            case "Fish4":
                targetSpawn = "CutedFish4";
                break;
            case "Garlic1":
                targetSpawn = "CutedGarlic1";
                break;
            case "Garlic2":
                targetSpawn = "CutedGarlic2";
                break;
            case "Garlic3":
                targetSpawn = "CutedGarlic3";
                break;
            case "Garlic4":
                targetSpawn = "CutedGarlic4";
                break;
            case "Ginger1":
                targetSpawn = "CutedGinger1_Step1";
                break;
            case "Ginger2":
                targetSpawn = "CutedGinger2_Step1";
                break;
            case "Ginger3":
                targetSpawn = "CutedGinger3_Step1";
                break;
            case "Ginger4":
                targetSpawn = "CutedGinger4_Step1";
                break;
            case "CutedGinger1_Step1":
                targetSpawn = "CutedGinger1_Step2";
                break;
            case "CutedGinger2_Step1":
                targetSpawn = "CutedGinger2_Step2";
                break;
            case "CutedGinger3_Step1":
                targetSpawn = "CutedGinger3_Step2";
                break;
            case "CutedGinger4_Step1":
                targetSpawn = "CutedGinger4_Step2";
                break;
            case "Lime1":
                targetSpawn = "CutedLime1_Step1";
                break;
            case "Lime2":
                targetSpawn = "CutedLime2_Step1";
                break;
            case "Lime3":
                targetSpawn = "CutedLime3_Step1";
                break;
            case "Lime4":
                targetSpawn = "CutedLime4_Step1";
                break;
            case "CutedLime1_Step1":
                targetSpawn = "CutedLime1_Step2";
                break;
            case "CutedLime2_Step1":
                targetSpawn = "CutedLime2_Step2";
                break;
            case "CutedLime3_Step1":
                targetSpawn = "CutedLime3_Step2";
                break;
            case "CutedLime4_Step1":
                targetSpawn = "CutedLime4_Step2";
                break;
            case "Onion1":
                targetSpawn = "CutedOnion1_Step1";
                break;
            case "Onion2":
                targetSpawn = "CutedOnion2_Step1";
                break;
            case "Onion3":
                targetSpawn = "CutedOnion3_Step1";
                break;
            case "Onion4":
                targetSpawn = "CutedOnion4_Step1";
                break;
            case "CutedOnion1_Step1":
                targetSpawn = "CutedOnion1_Step2";
                break;
            case "CutedOnion2_Step1":
                targetSpawn = "CutedOnion2_Step2";
                break;
            case "CutedOnion3_Step1":
                targetSpawn = "CutedOnion3_Step2";
                break;
            case "CutedOnion4_Step1":
                targetSpawn = "CutedOnion4_Step2";
                break;
            case "Pork1":
                targetSpawn = "CutedPork1";
                break;
            case "Pork2":
                targetSpawn = "CutedPork2";
                break;
            case "Pork3":
                targetSpawn = "CutedPork3";
                break;
            case "Pork4":
                targetSpawn = "CutedPork4";
                break;
            case "Potato1":
                targetSpawn = "CutedPotato1";
                break;
            case "Potato2":
                targetSpawn = "CutedPotato2";
                break;
            case "Potato3":
                targetSpawn = "CutedPotato3";
                break;
            case "Potato4":
                targetSpawn = "CutedPotato4";
                break;
            case "Shallot1":
                targetSpawn = "CutedShallot1_Step1";
                break;
            case "Shallot2":
                targetSpawn = "CutedShallot2_Step1";
                break;
            case "Shallot3":
                targetSpawn = "CutedShallot3_Step1";
                break;
            case "Shallot4":
                targetSpawn = "CutedShallot4_Step1";
                break;
            case "CutedShallot1_Step1":
                targetSpawn = "CutedShallot1_Step2";
                break;
            case "CutedShallot2_Step1":
                targetSpawn = "CutedShallot2_Step2";
                break;
            case "CutedShallot3_Step1":
                targetSpawn = "CutedShallot3_Step2";
                break;
            case "CutedShallot4_Step1":
                targetSpawn = "CutedShallot4_Step2";
                break;
            case "SpringOnion1":
                targetSpawn = "CutedSpringOnion1_Step1";
                break;
            case "SpringOnion2":
                targetSpawn = "CutedSpringOnion2_Step1";
                break;
            case "SpringOnion3":
                targetSpawn = "CutedSpringOnion3_Step1";
                break;
            case "SpringOnion4":
                targetSpawn = "CutedSpringOnion4_Step1";
                break;
            case "CutedSpringOnion1_Step1":
                targetSpawn = "CutedSpringOnion1_Step2";
                break;
            case "CutedSpringOnion2_Step1":
                targetSpawn = "CutedSpringOnion2_Step2";
                break;
            case "CutedSpringOnion3_Step1":
                targetSpawn = "CutedSpringOnion3_Step2";
                break;
            case "CutedSpringOnion4_Step1":
                targetSpawn = "CutedSpringOnion4_Step2";
                break;
            case "Tomato1":
                targetSpawn = "CutedTomato1";
                break;
            case "Tomato2":
                targetSpawn = "CutedTomato2";
                break;
            case "Tomato3":
                targetSpawn = "CutedTomato3";
                break;
            case "Tomato4":
                targetSpawn = "CutedTomato4";
                break;
            case "CPepper1":
                targetSpawn = "CutedCPepper1";
                break;
            case "CPepper2":
                targetSpawn = "CutedCPepper2";
                break;
            case "CPepper3":
                targetSpawn = "CutedCPepper3";
                break;
            case "CPepper4":
                targetSpawn = "CutedCPepper4";
                break;
        }

        kitchen_UI.HideItem();

        for (int i = 0; i < CutedItems.Length;i++)
        {
            if (targetSpawn == CutedItems[i].name)
            {
                CutedItems[i].SetActive(true);
                targetSpawn = "";
                break;
            }
        }


    }

    IEnumerator DelayHide(GameObject HideObject)
    {
        yield return new WaitForSeconds(0.09f);
        HideObject.SetActive(false);
    }

    public void Spawn(string ItemName)
    {

        for (int i = 0;i < ItemDrop.Length;i++)
        {
            if (ItemDrop[i].gameObject.name == ItemName)
            {
                Instantiate(ItemDrop[i], ItemSpawn.transform);

                if (kitchenwere != "")
                {
                    finishCook.AddItemInCook(ItemName);
                }
                
                break;
            }
        }
    }

  

    public void ActivePot()
    {
        Pot.SetActive(true);
        Pan.SetActive(false);
        kitchenwere = "Pot";
    }

    public void ActivePan()
    {
        Pot.SetActive(false);
        Pan.SetActive(true);
        kitchenwere = "Pan";
    }

    public void SwitchButton()
    {
        if (startCook == false)
        {
            startCook = true;
            Fire.SetActive(true);
            time = 0;
            burn = false;
            eatable = false;
        }
        else
        {
            EndCook();
        }
    }

    public void EndCook()
    {
        startCook = false;
        endCook = true;
        
        for (int i = 0; i < FinishCook.Length; i++)
        {
            if (FinishCook[i].gameObject.name == finishCook.DiagnoseFood(burn,kitchenwere,eatable))
            {
                FinishCook[i].SetActive(true);
                break;
            }
            
        }

        
        Fire.SetActive(false);
        SmokeFire.SetActive(false);
        time = 0;
        StartCoroutine(EndFalse());
    }

    IEnumerator EndFalse()
    {
        yield return new WaitForSeconds(0.5f);
        endCook = false;
    }

    public void DisplayCooked(string ItemName)
    {
        for (int i = 0; i < FinishCook.Length; i++)
        {
            FinishCook[i].SetActive(false);
        }

        for (int i = 0; i < FinishCook.Length; i++)
        {
            if (FinishCook[i].gameObject.name == ItemName)
            {
                FinishCook[i].SetActive(true);
                
                break;
            }
        }
    }

    public void DisplayFood(string ItemName)
    {

        for (int i = 0; i < Food.Length; i++)
        {
            if (ItemName == Food[i].gameObject.name)
            {
                if (ItemName == "Rice")
                {
                    finishCook.Happiness += 5;
                    finishCook.Sodium += 1;
                    finishCook.Fat += 0.3f;
                    finishCook.Protein += 2.7f;
                    finishCook.KiloCalories += 130;
                    PlateGO.SetActive(true);
                }
                else
                {
                    kitchen_UI.ConclusionButton.SetActive(true);
                }
                
                Food[i].SetActive(true);
                break;
            }
            
        }

    }

}
