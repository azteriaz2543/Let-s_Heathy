using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCook : MonoBehaviour
{
    public string CurrentFood;

    public float Protein, Sodium, Fat, KiloCalories ,Happiness;
    public float Normal_Health, KDP_Health;

    List<FoodStatus> itemList;

    #region CheckItem
    bool Spoon, //0
        Turner, //1
        Water, //2
        Beef, //3
        Carrot, //4
        Chicken, //5
        ChineseKale, //6
        CoconutMilk, //7
        Cucumber, //8
        CutedBeef, //9
        CutedCarrot_Step1, //10
        CutedCarrot_Step2, //11
        CutedChicken, //12
        CutedChineseKale_Step1, //13
        CutedChineseKale_Step2, //14
        CutedCucumber, //15
        CutedFish, //16
        CutedGarlic, //17
        CutedGinger_Step1, //18
        CutedGinger_Step2, //19
        CutedLime_Step1, //20
        CutedLime_Step2, //21
        CutedOnion_Step1, //22
        CutedOnion_Step2, //23
        CutedPork, //24
        CutedPotato, //25
        CutedShallot_Step1, //26
        CutedShallot_Step2, //27
        CutedSpringOnion_Step1, //28
        CutedSpringOnion_Step2, //29
        CutedTomato, //30
        Egg, //31
        EggBeat, //32
        Fish, //33
        Garlic, //34
        Ginger, //35
        Lime, //36
        Milk, //37
        MincedBeef, //38
        MincedPork, //39
        Onion, //40
        Pork, //41
        Potato, //42
        Shallot, //43
        SpringOnion, //44
        Tomato, //45
        Rice, //46
        Lemonade, //47
        MassamanPowder, //48
        Mayonnaise, //49
        Mayonnaise_J, //50
        Mayonnaise_LowFat, //51
        Black_Soysauce, //52
        White_Soysauce, //53
        Fish_Sauce, //54
        Oyster_Sauce, //55
        Vegetable_Oil, //56
        Msg, //57
        Pepper, //58
        Pepper_Cayenne, //59
        Pink_Salt, //60
        Powder_Chicken, //61
        Salad_DressingJP, //62
        Salt, //63
        White_Sugar, //64
        Tomato_Ketchup, //65
        Brown_Sugar, //66
        Cinnamon,
        Basil, //67
        CPepper;
    #endregion

    void Start()
    {
        itemList = new List<FoodStatus>();
    }
    
    void Update()
    {

    }

    void AddItem(FoodStatus item)
    {
        
        bool itemAlreadyUsed = false;
        foreach (FoodStatus usedItem in itemList)
        {
            if (usedItem.itemType == item.itemType)
            {
                usedItem.amount += item.amount;
                itemAlreadyUsed = true;
            }
        }
        if (!itemAlreadyUsed)
        {
            itemList.Add(item);
        }
    }

    public void AddItemInCook(string ItemName)
    {

        switch (ItemName)
        {
            case "Spoon":
                Spoon = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Spoon, amount = 1 });
                break;
            case "Turner":
                Turner = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Turner, amount = 1 });
                break;
            case "Water":
                Water = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Water, amount = 1 });
                break;
            case "RiceC":
                Happiness += 15;
                Sodium += 1;
                Fat += 0.3f;
                Protein += 2.7f;
                KiloCalories += 130;
                Rice = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Rice, amount = 1 });
                break;
            case "Beef1":
            case "Beef2":
            case "Beef3":
            case "Beef4":
                Happiness += 15;
                Sodium += 75.6f;
                Fat += 12.4f;
                Protein += 38.9f;
                KiloCalories += 199;
                Beef = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Beef, amount = 1 });
                break;
            case "Carrot1":
            case "Carrot2":
            case "Carrot3":
            case "Carrot4":
                Happiness += 8;
                Sodium += 42.1f;
                Fat += 0.1f;
                Protein += 0.5f;
                KiloCalories += 28.1f;
                Carrot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "Chicken1":
            case "Chicken2":
            case "Chicken3":
            case "Chicken4":
                Happiness += 15;
                Sodium += 45;
                Fat += 2.6f;
                Protein += 22.5f;
                KiloCalories += 120;
                Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "ChineseKale1":
            case "ChineseKale2":
            case "ChineseKale3":
            case "ChineseKale4":
                Happiness += 5;
                Sodium += 6.2f;
                Fat += 0.6f;
                Protein += 1f;
                KiloCalories += 19.4f;
                ChineseKale = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CoconutMilk1":
            case "CoconutMilk2":
            case "CoconutMilk3":
            case "CoconutMilk4":
                Happiness += 8;
                Sodium += 36;
                Fat += 57.6f;
                Protein += 5.52f;
                KiloCalories += 813.6f;
                CoconutMilk = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CoconutMilk, amount = 1 });
                break;
            case "Cucumber1":
            case "Cucumber2":
            case "Cucumber3":
            case "Cucumber4":
                Happiness += 6;
                Sodium += 4;
                Fat += 0.22f;
                Protein += 1.12f;
                KiloCalories += 36;
                Cucumber = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedBeef1":
            case "CutedBeef2":
            case "CutedBeef3":
            case "CutedBeef4":
                Happiness += 15;
                Sodium += 75.6f;
                Fat += 12.4f;
                Protein += 38.9f;
                KiloCalories += 199;
                Beef = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedBeef, amount = 1 });
                break;
            case "CutedCarrot1_Step1":
            case "CutedCarrot2_Step1":
            case "CutedCarrot3_Step1":
            case "CutedCarrot4_Step1":
                Happiness += 8;
                Sodium += 42.1f;
                Fat += 0.1f;
                Protein += 0.5f;
                KiloCalories += 28.1f;
                Carrot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "CutedCarrot1_Step2":
            case "CutedCarrot2_Step2":
            case "CutedCarrot3_Step2":
            case "CutedCarrot4_Step2":
                Happiness += 8;
                Sodium += 42.1f;
                Fat += 0.1f;
                Protein += 0.5f;
                KiloCalories += 28.1f;
                Carrot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "CutedChicken1":
            case "CutedChicken2":
            case "CutedChicken3":
            case "CutedChicken4":
                Happiness += 15;
                Sodium += 45;
                Fat += 2.6f;
                Protein += 22.5f;
                KiloCalories += 120;
                Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "CutedChineseKale1_Step1":
            case "CutedChineseKale2_Step1":
            case "CutedChineseKale3_Step1":
            case "CutedChineseKale4_Step1":
                Happiness += 5;
                Sodium += 6.2f;
                Fat += 0.6f;
                Protein += 1f;
                KiloCalories += 19.4f;
                ChineseKale = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CutedChineseKale1_Step2":
            case "CutedChineseKale2_Step2":
            case "CutedChineseKale3_Step2":
            case "CutedChineseKale4_Step2":
                Happiness += 5;
                Sodium += 6.2f;
                Fat += 0.6f;
                Protein += 1f;
                KiloCalories += 19.4f;
                ChineseKale = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CutedCucumber1":
            case "CutedCucumber2":
            case "CutedCucumber3":
            case "CutedCucumber4":
                Happiness += 6;
                Sodium += 4;
                Fat += 0.22f;
                Protein += 1.12f;
                KiloCalories += 36;
                Cucumber = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedFish1":
            case "CutedFish2":
            case "CutedFish3":
            case "CutedFish4":
                Happiness += 15;
                Sodium += 7;
                Fat += 0.7f;
                Protein += 1.1f;
                KiloCalories += 22f;
                Fish = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish, amount = 1 });
                break;
            case "CutedGarlic1":
            case "CutedGarlic2":
            case "CutedGarlic3":
            case "CutedGarlic4":
                Happiness += 2;
                Sodium += 18;
                Fat += 0.2f;
                Protein += 1.7f;
                KiloCalories += 33;
                Garlic = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "CutedGinger1_Step1":
            case "CutedGinger2_Step1":
            case "CutedGinger3_Step1":
            case "CutedGinger4_Step1":
                Happiness += 5;
                Sodium += 1.3f;
                Fat += 0.08f;
                Protein += 0.18f;
                KiloCalories += 7.9f;
                Ginger = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedGinger1_Step2":
            case "CutedGinger2_Step2":
            case "CutedGinger3_Step2":
            case "CutedGinger4_Step2":
                Happiness += 5;
                Sodium += 1.3f;
                Fat += 0.08f;
                Protein += 0.18f;
                KiloCalories += 7.9f;
                Ginger = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedLime1_Step1":
            case "CutedLime2_Step1":
            case "CutedLime3_Step1":
            case "CutedLime4_Step1":
                Happiness += 4;
                Sodium += 8;
                Protein += 4;
                KiloCalories += 176;
                Lime = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedLime1_Step2":
            case "CutedLime2_Step2":
            case "CutedLime3_Step2":
            case "CutedLime4_Step2":
                Happiness += 4;
                Sodium += 8;
                Protein += 4;
                KiloCalories += 176;
                Lime = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedOnion1_Step1":
            case "CutedOnion2_Step1":
            case "CutedOnion3_Step1":
            case "CutedOnion4_Step1":
                Happiness += 3;
                Sodium += 4.4f;
                Fat += 0.1f;
                Protein += 1.2f;
                KiloCalories += 44f;
                Onion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "CutedOnion1_Step2":
            case "CutedOnion2_Step2":
            case "CutedOnion3_Step2":
            case "CutedOnion4_Step2":
                Happiness += 3;
                Sodium += 4.4f;
                Fat += 0.1f;
                Protein += 1.2f;
                KiloCalories += 44f;
                Onion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "CutedPork1":
            case "CutedPork2":
            case "CutedPork3":
            case "CutedPork4":
                Happiness += 15;
                Sodium += 188;
                Fat += 65.8f;
                Protein += 45.6f;
                KiloCalories += 342;
                Pork = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "CutedPotato1":
            case "CutedPotato2":
            case "CutedPotato3":
            case "CutedPotato4":
                Happiness += 8;
                Sodium += 421f;
                Fat += 0.1f;
                Protein += 2f;
                KiloCalories += 77f;
                Potato = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Potato, amount = 1 });
                break;
            case "CutedShallot1_Step1":
            case "CutedShallot2_Step1":
            case "CutedShallot3_Step1":
            case "CutedShallot4_Step1":
                Happiness += 5;
                Sodium += 2.4f;
                Protein += 0.6f;
                KiloCalories += 14.4f;
                Shallot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedShallot1_Step2":
            case "CutedShallot2_Step2":
            case "CutedShallot3_Step2":
            case "CutedShallot4_Step2":
                Happiness += 5;
                Sodium += 2.4f;
                Protein += 0.6f;
                KiloCalories += 14.4f;
                Shallot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedSpringOnion1_Step1":
            case "CutedSpringOnion2_Step1":
            case "CutedSpringOnion3_Step1":
            case "CutedSpringOnion4_Step1":
                Happiness += 5;
                Sodium += 16f;
                Fat += 0.1f;
                Protein += 1.8f;
                KiloCalories += 16f;
                SpringOnion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedSpringOnion1_Step2":
            case "CutedSpringOnion2_Step2":
            case "CutedSpringOnion3_Step2":
            case "CutedSpringOnion4_Step2":
                Happiness += 5;
                Sodium += 16f;
                Fat += 0.1f;
                Protein += 1.8f;
                KiloCalories += 16f;
                SpringOnion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedTomato1":
            case "CutedTomato2":
            case "CutedTomato3":
            case "CutedTomato4":
                Happiness += 9;
                Sodium += 20;
                KiloCalories += 35.4f;
                Tomato = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato, amount = 1 });
                break;
            case "Egg1":
            case "Egg2":
            case "Egg3":
            case "Egg4":
                Happiness += 5;
                Sodium += 71;
                Fat += 4.8f;
                Protein += 6.3f;
                KiloCalories += 72;
                Egg = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Egg, amount = 1 });
                break;
            case "EggBeat1":
            case "EggBeat2":
            case "EggBeat3":
            case "EggBeat4":
                Happiness += 5;
                Sodium += 71;
                Fat += 4.8f;
                Protein += 6.3f;
                KiloCalories += 72;
                EggBeat = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.EggBeat, amount = 1 });
                break;
            case "Fish1":
            case "Fish2":
            case "Fish3":
            case "Fish4":
                Happiness += 15;
                Sodium += 7;
                Fat += 0.7f;
                Protein += 1.1f;
                KiloCalories += 22f;
                Fish = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish, amount = 1 });
                break;
            case "Garlic1":
            case "Garlic2":
            case "Garlic3":
            case "Garlic4":
                Happiness += 3;
                Sodium += 36;
                Fat += 0.4f;
                Protein += 3.4f;
                KiloCalories += 66;
                Garlic = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "Ginger1":
            case "Ginger2":
            case "Ginger3":
            case "Ginger4":
                Happiness += 5;
                Sodium += 1.3f;
                Fat += 0.08f;
                Protein += 0.18f;
                KiloCalories += 7.9f;
                Ginger = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "Lime1":
            case "Lime2":
            case "Lime3":
            case "Lime4":
                Happiness += 4;
                Sodium += 8;
                Protein += 4;
                KiloCalories += 176;
                Lime = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "Milk1":
            case "Milk2":
            case "Milk3":
            case "Milk4":
                Happiness += 8;
                Sodium += 105.6f;
                Fat += 2.4f;
                Protein += 8.16f;
                KiloCalories += 100.8f;
                Milk = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Milk, amount = 1 });
                break;
            case "MincedBeef1":
            case "MincedBeef2":
            case "MincedBeef3":
            case "MincedBeef4":
                Happiness += 10;
                Sodium += 32.3f;
                Fat += 8.2f;
                Protein += 19.3f;
                KiloCalories += 199;
                MincedBeef = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MincedBeef, amount = 1 });
                break;
            case "MincedPork1":
            case "MincedPork2":
            case "MincedPork3":
            case "MincedPork4":
                Happiness += 10;
                Sodium += 94;
                Fat += 32.9f;
                Protein += 22.8f;
                KiloCalories += 171;
                MincedPork = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MincedPork, amount = 1 });
                break;
            case "Onion1":
            case "Onion2":
            case "Onion3":
            case "Onion4":
                Happiness += 3;
                Sodium += 4.4f;
                Fat += 0.1f;
                Protein += 1.2f;
                KiloCalories += 44f;
                Onion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "Pork1":
            case "Pork2":
            case "Pork3":
            case "Pork4":
                Happiness += 15;
                Sodium += 188;
                Fat += 65.8f;
                Protein += 45.6f;
                KiloCalories += 342;
                Pork = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "Potato1":
            case "Potato2":
            case "Potato3":
            case "Potato4":
                Happiness += 8;
                Sodium += 421f;
                Fat += 0.1f;
                Protein += 2f;
                KiloCalories += 77f;
                Potato = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Potato, amount = 1 });
                break;
            case "Shallot1":
            case "Shallot2":
            case "Shallot3":
            case "Shallot4":
                Happiness += 5;
                Sodium += 2.4f;
                Protein += 0.6f;
                KiloCalories += 14.4f;
                Shallot = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "SpringOnion1":
            case "SpringOnion2":
            case "SpringOnion3":
            case "SpringOnion4":
                Happiness += 5;
                Sodium += 16f;
                Fat += 0.1f;
                Protein += 1.8f;
                KiloCalories += 16f;
                SpringOnion = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "Tomato1":
            case "Tomato2":
            case "Tomato3":
            case "Tomato4":
                Happiness += 9;
                Sodium += 20;
                KiloCalories += 35.4f;
                Tomato = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato, amount = 1 });
                break;
            case "Lemonade":
                Happiness += Random.Range(8,17);
                Sodium += 0.1f;
                Fat += 0.02f;
                Protein += 0.04f;
                KiloCalories += 2.1f;
                Lemonade = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lemonade, amount = 1 });
                break;
            case "MassamanPowder":
                Happiness += Random.Range(8, 17);
                Sodium += 580f;
                Fat += 3f;
                Protein += 1f;
                KiloCalories += 45f;
                MassamanPowder = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MassamanPowder, amount = 1 });
                break;
            case "Mayonnaise":
                Happiness += Random.Range(8, 17);
                Sodium += 95.25f;
                Fat += 11.25f;
                Protein += 0.15f;
                KiloCalories += 101.85f;
                Mayonnaise = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise, amount = 1 });
                break;
            case "Mayonnaise_J":
                Happiness += Random.Range(8, 17);
                Sodium += 70.1f;
                Fat += 2.71f;
                Protein += 0.04f;
                KiloCalories += 32.7f;
                Mayonnaise_J = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_J, amount = 1 });
                break;
            case "Mayonnaise_LowFat":
                Happiness += Random.Range(8, 12);
                Sodium += 120;
                Protein += 0.03f;
                KiloCalories += 10.2f;
                Mayonnaise_LowFat = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_LowFat, amount = 1 });
                break;
            case "Black_Soysauce":
                Happiness += Random.Range(8, 17);
                Sodium += 560;
                Protein += 0.5f;
                KiloCalories += 5f;
                Black_Soysauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Black_Soysauce, amount = 1 });
                break;
            case "White_Soysauce":
                Happiness += Random.Range(8, 17);
                Sodium += 400;
                Protein += 0.9f;
                KiloCalories += 15;
                White_Soysauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Soysauce, amount = 1 });
                break;
            case "Fish_Sauce":
                Happiness += Random.Range(8, 17);
                Sodium += 490;
                Fish_Sauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish_Sauce, amount = 1 });
                break;
            case "Oyster_Sauce":
                Happiness += Random.Range(8, 17);
                Sodium += 165;
                Protein += 0.2f;
                KiloCalories += 15;
                Oyster_Sauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Oyster_Sauce, amount = 1 });
                break;
            case "Vegetable_Oil":
                Happiness += Random.Range(8, 12);
                Fat += 13.5f;
                KiloCalories += 120;
                Mayonnaise_LowFat = true;
                Vegetable_Oil = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Vegetable_Oil, amount = 1 });
                break;
            case "Msg":
                Happiness += Random.Range(8, 12);
                Sodium += 484.1f;
                KiloCalories += 12;
                Mayonnaise_LowFat = true;
                Msg = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Msg, amount = 1 });
                break;
            case "Pepper":
                Happiness += Random.Range(8, 17);
                Sodium += 0.5f;
                Fat += 0.1f;
                Protein += 0.2f;
                KiloCalories += 7.5f;
                Pepper = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper, amount = 1 });
                break;
            case "Pepper_Cayenne":
                Happiness += Random.Range(8, 17);
                Sodium += 98.4f;
                Fat += 0.85f;
                Protein += 0.81f;
                KiloCalories += 16.92f;
                Pepper_Cayenne = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper_Cayenne, amount = 1 });
                break;
            case "Pink_Salt":
                Happiness += Random.Range(8, 17);
                Sodium += 1900;
                Pink_Salt = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pink_Salt, amount = 1 });
                break;
            case "Powder_Chicken":
                Happiness += Random.Range(8, 17);
                Sodium += 48;
                Protein += 0.5f;
                KiloCalories += 20;
                Powder_Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Powder_Chicken, amount = 1 });
                break;
            case "Salad_DressingJP":
                Happiness += Random.Range(8, 17);
                Sodium += 41.43f;
                Fat += 1.57f;
                Protein += 0.14f;
                KiloCalories += 26;
                Salad_DressingJP = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salad_DressingJP, amount = 1 });
                break;
            case "Salt":
                Happiness += Random.Range(8, 17);
                Sodium += 1900;
                Salt = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salt, amount = 1 });
                break;
            case "White_Sugar":
                Happiness += Random.Range(8, 17);
                KiloCalories += 19;
                White_Sugar = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Sugar, amount = 1 });
                break;
            case "Tomato_Ketchup":
                Happiness += Random.Range(8, 17);
                Sodium += 47.5f;
                KiloCalories += 15;
                Tomato_Ketchup = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato_Ketchup, amount = 1 });
                break;
            case "Brown_Sugar":
                Happiness += Random.Range(8, 17);
                Sodium += 1;
                KiloCalories += 18f;
                Brown_Sugar = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Brown_Sugar, amount = 1 });
                break;
            case "Cinnamon":
                Happiness += Random.Range(8, 17);
                Sodium += 30.4f;
                Fat += 0.12f;
                Protein += 0.4f;
                KiloCalories += 24.7f;
                Cinnamon = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cinnamon, amount = 1 });
                break;
            case "Basil":
                Sodium += 0.1f;
                Protein += 0.1f;
                KiloCalories += 0.6f;
                Basil = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Basil, amount = 1 });
                break;
            case "CPepper":
                KiloCalories += 14.1f;
                CPepper = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CPepper, amount = 1 });
                break;

        }

    }

    int a, b; //„™È‡ª√’¬∫‡∑’¬∫ ·µË „ Ë„πø—ß™—Ëπ·≈È«¢’¥‡ Èπ :V

    public string DiagnoseFood(bool burn,string used, bool eatable)
    {

        if (burn == true)
        {
            Happiness -= 15;
        }

        if (EggBeat == true && Turner == true && used == "Pan" && eatable == true && CurrentFood == "")
        {
            if (MincedPork == true && Carrot == false && burn == false) //‰¢Ë‡®’¬«À¡Ÿ —∫‰¡Ë·§√Õ∑
            {
                CurrentFood = "Omelet_PW";
            }
            else if (MincedPork == false && Carrot == true && burn == false) //‰¢Ë‡®’¬«·§√Õ∑‰¡ËÀ¡Ÿ —∫
            {
                CurrentFood = "Omelet_C";
            }
            else if (MincedPork == true && Carrot == true && burn == false) //‰¢Ë‡®’¬«À¡Ÿ —∫·§√Õ∑
            {
                CurrentFood = "Omelet_PW_C";
            }
            else if(MincedPork == false && Carrot == false && burn == false) //‰¢Ë‡®’¬«
            {
                CurrentFood = "OmeletOnly";
            }
            else if (MincedPork == true && Carrot == false && burn == true) //‰¢Ë‡®’¬«À¡Ÿ —∫‰¡Ë·§√Õ∑ ‰À¡È
            {
                CurrentFood = "Omelet_PW_Burn";
            }
            else if (MincedPork == false && Carrot == true && burn == true) //‰¢Ë‡®’¬«·§√Õ∑‰¡ËÀ¡Ÿ —∫ ‰À¡È
            {
                CurrentFood = "Omelet_C_Burn";
            }
            else if (MincedPork == true && Carrot == true && burn == true) //‰¢Ë‡®’¬«À¡Ÿ —∫·§√Õ∑ ‰À¡È
            {
                CurrentFood = "Omelet_PW_C_Burn";
            }
            else if (MincedPork == false && Carrot == false && burn == true)//‰¢Ë‡®’¬« ‰À¡È
            {
                CurrentFood = "OmeletOnly_Burn";
            }
        } //‰¢Ë‡®’¬«

        if (Water == true && Rice == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "BoiledRice";
        } //¢È“«µÈ¡

        if (Chicken == true && Lemonade == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "ChickenBreast";
        } //Õ°‰°Ë´Õ ¡–π“«

        if (Basil == true && MincedPork == true && Turner == true && used == "Pan" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "BasilMP";
        } //º—¥°√–‡æ√“

        if (Rice == true && Egg == true && Turner == true && used == "Pan" && eatable == true && CurrentFood == "" && burn == false)
        {
            if (Ginger == true || Pork == true)
            {
               
                foreach (FoodStatus usedItem in itemList)
                {
                    
                    if (usedItem.itemType == FoodStatus.ItemType.Ginger)
                    {
                        a = usedItem.amount;
                    }
                    else if (usedItem.itemType == FoodStatus.ItemType.Pork)
                    {
                        b = usedItem.amount;
                    }
                }

                if (a > b)
                {
                    CurrentFood = "FriedriceGinger";
                    a = 0;
                    b = 0;
                }
                else
                {
                    CurrentFood = "FriedricePork";
                    a = 0;
                    b = 0;
                }
            }  
        } //¢È“«º—¥

        if (Chicken == true && Rice == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "HainaneseChicken";
        } //¢È“«¡—π‰°Ë

        if (Chicken == true && MassamanPowder == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "Massaman";
        } //¡— ¡—Ëπ

        if (Egg == true && Water == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "PoachedEgg";
        } //‰¢Ë¥“«πÈæ

        if (Msg == true && Pepper == true && CoconutMilk == true && SpringOnion == true && Ginger == true && Carrot == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "RainbowSoup";
        } //...

        if (eatable == true && CurrentFood == "" && burn == true)
        {
            CurrentFood = "BurnThing";
        }

        return CurrentFood;
        
    }

    public void Reset()
    {
        Protein = 0;
        Sodium = 0;
        Fat = 0;
        KiloCalories = 0;
        Happiness = 0;
        Normal_Health = 0;
        KDP_Health = 0;
        CurrentFood = "";
        itemList = new List<FoodStatus>();
        setCheckFalse();
    }

    void setCheckFalse()
    {
        Spoon = false;
        Turner = false;
        Water = false;
        Beef = false;
        Carrot = false;
        Chicken = false;
        ChineseKale = false;
        CoconutMilk = false;
        Cucumber = false;
        CutedBeef = false;
        CutedCarrot_Step1 = false;
        CutedCarrot_Step2 = false;
        CutedChicken = false;
        CutedChineseKale_Step1 = false;
        CutedChineseKale_Step2 = false;
        CutedCucumber = false;
        CutedFish = false;
        CutedGarlic = false;
        CutedGinger_Step1 = false;
        CutedGinger_Step2 = false;
        CutedLime_Step1 = false;
        CutedLime_Step2 = false;
        CutedOnion_Step1 = false;
        CutedOnion_Step2 = false;
        CutedPork = false;
        CutedPotato = false;
        CutedShallot_Step1 = false;
        CutedShallot_Step2 = false;
        CutedSpringOnion_Step1 = false;
        CutedSpringOnion_Step2 = false;
        CutedTomato = false;
        Egg = false;
        EggBeat = false;
        Fish = false;
        Garlic = false;
        Ginger = false;
        Lime = false;
        Milk = false;
        MincedBeef = false;
        MincedPork = false;
        Onion = false;
        Pork = false;
        Potato = false;
        Shallot = false;
        SpringOnion = false;
        Tomato = false;
        Rice = false;
        Lemonade = false;
        MassamanPowder = false;
        Mayonnaise = false;
        Mayonnaise_J = false;
        Mayonnaise_LowFat = false;
        Black_Soysauce = false;
        White_Soysauce = false;
        Fish_Sauce = false;
        Oyster_Sauce = false;
        Vegetable_Oil = false;
        Msg = false;
        Pepper = false;
        Pepper_Cayenne = false;
        Pink_Salt = false;
        Powder_Chicken = false;
        Salad_DressingJP = false;
        Salt = false;
        White_Sugar = false;
        Tomato_Ketchup = false;
        Brown_Sugar = false;
        Cinnamon = false;
    }
}
