using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{

    public GameObject[] Carrot;
    public GameObject[] CutedCarrot;

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
    public GameObject FoodStatus;

    string kitchenwere;

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

        for (int i = 0;i < CutedCarrot.Length;i++)
        {
            CutedCarrot[i].SetActive(false);
        }

        Pot.SetActive(false);
        Pan.SetActive(false);

        startCook = false;
        endCook = false;
        Fire.SetActive(false);
        SmokeFire.SetActive(false);

        finishCook = finishCook.GetComponent<FinishCook>();

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

        if (time > 3.2f)
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
                CutedCarrot[0].SetActive(true);
                StartCoroutine(DelayHide(Carrot[0]));
                break;
            case "Carrot2":
                CutedCarrot[1].SetActive(true);
                StartCoroutine(DelayHide(Carrot[1]));
                break;
            case "Carrot3":
                CutedCarrot[2].SetActive(true);
                StartCoroutine(DelayHide(Carrot[2]));
                break;
            case "Carrot4":
                CutedCarrot[3].SetActive(true);
                StartCoroutine(DelayHide(Carrot[3]));
                break;
            case "CutedCarrot1_Step1":
                CutedCarrot[4].SetActive(true);
                StartCoroutine(DelayHide(CutedCarrot[0]));
                break;
            case "CutedCarrot2_Step1":
                CutedCarrot[5].SetActive(true);
                StartCoroutine(DelayHide(CutedCarrot[1]));
                break;
            case "CutedCarrot3_Step1":
                CutedCarrot[6].SetActive(true);
                StartCoroutine(DelayHide(CutedCarrot[2]));
                break;
            case "CutedCarrot4_Step1":
                CutedCarrot[7].SetActive(true);
                StartCoroutine(DelayHide(CutedCarrot[3]));
                break;
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

        finishCook.Reset();
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
                Food[i].SetActive(true);
                break;
            }
            
        }

    }

}
