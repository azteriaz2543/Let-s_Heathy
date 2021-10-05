using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeIcon : MonoBehaviour
{
    public GameObject Icon;
    public bool Show;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Icon.SetActive(Show);
    }

    public void CanCutItem(string ItemName)
    {
        Show = false;
        switch (ItemName)
        {
            case "": 
                Show = false;
                break;
            case "Reset": 
                Show = false; 
                break;
            case "Carrot1":
                Show = true;
                break;
            case "Carrot2":
                Show = true;
                break;
            case "Carrot3":
                Show = true;
                break;
            case "Carrot4":
                Show = true;
                break;
            case "CutedCarrot1_Step1":
                Show = true;
                break;
            case "CutedCarrot2_Step1":
                Show = true;
                break;
            case "CutedCarrot3_Step1":
                Show = true;
                break;
            case "CutedCarrot4_Step1":
                Show = true;
                break;
            case "Beef1":
                Show = true;
                break;
            case "Beef2":
                Show = true;
                break;
            case "Beef3":
                Show = true;
                break;
            case "Beef4":
                Show = true;
                break;
            case "Chicken1":
                Show = true;
                break;
            case "Chicken2":
                Show = true;
                break;
            case "Chicken3":
                Show = true;
                break;
            case "Chicken4":
                Show = true;
                break;
            case "ChineseKale1":
                Show = true;
                break;
            case "ChineseKale2":
                Show = true;
                break;
            case "ChineseKale3":
                Show = true;
                break;
            case "ChineseKale4":
                Show = true;
                break;
            case "Cucumber1":
                Show = true;
                break;
            case "Cucumber2":
                Show = true;
                break;
            case "Cucumber3":
                Show = true;
                break;
            case "Cucumber4":
                Show = true;
                break;
            case "Fish1":
                Show = true;
                break;
            case "Fish2":
                Show = true;
                break;
            case "Fish3":
                Show = true;
                break;
            case "Fish4":
                Show = true;
                break;
            case "Garlic1":
                Show = true; break;
            case "Garlic2":
                Show = true; break;
            case "Garlic3":
                Show = true; break;
            case "Garlic4":
                Show = true; break;
            case "Ginger1":
                Show = true; break;
            case "Ginger2":
                Show = true; break;
            case "Ginger3":
                Show = true; break;
            case "Ginger4":
                Show = true; break;
            case "CutedGinger1_Step1":
                Show = true; break;
            case "CutedGinger2_Step1":
                Show = true; break;
            case "CutedGinger3_Step1":
                Show = true; break;
            case "CutedGinger4_Step1":
                Show = true; break;
            case "Lime1":
                Show = true; break;
            case "Lime2":
                Show = true; break;
            case "Lime3":
                Show = true; break;
            case "Lime4":
                Show = true; break;
            case "CutedLime1_Step1":
                Show = true; break;
            case "CutedLime2_Step1":
                Show = true; break;
            case "CutedLime3_Step1":
                Show = true; break;
            case "CutedLime4_Step1":
                Show = true; break;
            case "Onion1":
                Show = true; break;
            case "Onion2":
                Show = true; break;
            case "Onion3":
                Show = true; break;
            case "Onion4":
                Show = true; break;
            case "CutedOnion1_Step1":
                Show = true; break;
            case "CutedOnion2_Step1":
                Show = true; break;
            case "CutedOnion3_Step1":
                Show = true; break;
            case "CutedOnion4_Step1":
                Show = true; break;
            case "Pork1":
                Show = true; break;
            case "Pork2":
                Show = true; break;
            case "Pork3":
                Show = true; break;
            case "Pork4":
                Show = true; break;
            case "Potato1":
                Show = true; break;
            case "Potato2":
                Show = true; break;
            case "Potato3":
                Show = true; break;
            case "Potato4":
                Show = true; break;
            case "Shallot1":
                Show = true; break;
            case "Shallot2":
                Show = true; break;
            case "Shallot3":
                Show = true; break;
            case "Shallot4":
                Show = true; break;
            case "CutedShallot1_Step1":
                Show = true; break;
            case "CutedShallot2_Step1":
                Show = true; break;
            case "CutedShallot3_Step1":
                Show = true; break;
            case "CutedShallot4_Step1":
                Show = true; break;
            case "SpringOnion1":
                Show = true; break;
            case "SpringOnion2":
                Show = true; break;
            case "SpringOnion3":
                Show = true; break;
            case "SpringOnion4":
                Show = true; break;
            case "CutedSpringOnion1_Step1":
                Show = true; break;
            case "CutedSpringOnion2_Step1":
                Show = true; break;
            case "CutedSpringOnion3_Step1":
                Show = true; break;
            case "CutedSpringOnion4_Step1":
                Show = true; break;
            case "Tomato1":
                Show = true; break;
            case "Tomato2":
                Show = true; break;
            case "Tomato3":
                Show = true; break;
            case "Tomato4":
                Show = true; break;
        }
    }
}
