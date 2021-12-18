using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCook : MonoBehaviour
{
    public string CurrentFood;

    public float Protein, Sodium, Fat, KiloCalories ,Happiness;
    public float NephropathyHealthy, Healthy;

    List<FoodStatus> itemList;

    public float RanbowThing;

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
        CPepper,
        Vegetable,
        Ham,
        Crabsticks,
        Bread,
        WhiteEgg,
        Tuna;
    #endregion

    void Start()
    {
        itemList = new List<FoodStatus>();
        RanbowThing = 0;
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
        RanbowThing += Random.Range(6.0f, 12.0f);
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
                RanbowThing -= 12;
                Water = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Water, amount = 1 });
                break;
            case "RiceC":
                RanbowThing -= 6;
                Happiness += 15;
                Sodium += 1;
                Fat += 0.3f;
                Protein += 2.7f;
                KiloCalories += 130;
                Healthy += 0;
                NephropathyHealthy += 0;
                Rice = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Rice, amount = 1 });
                break;
            case "Beef1":
            case "Beef2":
            case "Beef3":
            case "Beef4":
                Happiness += 10;
                Sodium += 75.6f;
                Fat += 12.4f;
                Protein += 38.9f;
                KiloCalories += 199;
                Healthy += 2;
                NephropathyHealthy += 5;
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
                Healthy += 1;
                NephropathyHealthy += 3;
                Carrot = true;
                Vegetable = true;
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
                Healthy += 1;
                NephropathyHealthy += 3;
                Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "ChineseKale1":
            case "ChineseKale2":
            case "ChineseKale3":
            case "ChineseKale4":
                Happiness += 4;
                Sodium += 6.2f;
                Fat += 0.6f;
                Protein += 1f;
                KiloCalories += 19.4f;
                Healthy += 0;
                NephropathyHealthy += 0;
                ChineseKale = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CoconutMilk1":
            case "CoconutMilk2":
            case "CoconutMilk3":
            case "CoconutMilk4":
                Happiness += 5;
                Sodium += 36;
                Fat += 57.6f;
                Protein += 5.5f;
                KiloCalories += 51f;
                Healthy += 1;
                NephropathyHealthy += 2;
                CoconutMilk = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CoconutMilk, amount = 1 });
                break;
            case "Cucumber1":
            case "Cucumber2":
            case "Cucumber3":
            case "Cucumber4":
                Happiness += 4;
                Sodium += 2;
                Fat += 0.1f;
                Protein += 0.6f;
                KiloCalories += 18;
                Healthy += 0;
                NephropathyHealthy += 0;
                Cucumber = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedBeef1":
            case "CutedBeef2":
            case "CutedBeef3":
            case "CutedBeef4":
                Happiness += 10;
                Sodium += 56.7f;
                Fat += 9.3f;
                Protein += 29.175f;
                KiloCalories += 149.25f;
                Healthy += 2;
                NephropathyHealthy += 5;
                Beef = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedBeef, amount = 1 });
                break;
            case "CutedCarrot1_Step1":
            case "CutedCarrot2_Step1":
            case "CutedCarrot3_Step1":
            case "CutedCarrot4_Step1":
                Happiness += 5;
                Sodium += 31.575f;
                Fat += 0.075f;
                Protein += 0.5f;
                KiloCalories += 21.075f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Carrot = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "CutedCarrot1_Step2":
            case "CutedCarrot2_Step2":
            case "CutedCarrot3_Step2":
            case "CutedCarrot4_Step2":
                Happiness += 5;
                Sodium += 21.05f;
                Fat += 0.05f;
                Protein += 0.25f;
                KiloCalories += 14.05f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Carrot = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "CutedChicken1":
            case "CutedChicken2":
            case "CutedChicken3":
            case "CutedChicken4":
                Happiness += 10;
                Sodium += 33.75f;
                Fat += 1.95f;
                Protein += 16.875f;
                KiloCalories += 90;
                Healthy += 1;
                NephropathyHealthy += 3;
                Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "CutedChineseKale1_Step1":
            case "CutedChineseKale2_Step1":
            case "CutedChineseKale3_Step1":
            case "CutedChineseKale4_Step1":
                Happiness += 4;
                Sodium += 4.65f;
                Fat += 0.45f;
                Protein += 0.75f;
                KiloCalories += 14.55f;
                Healthy += 0;
                NephropathyHealthy += 0;
                ChineseKale = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CutedChineseKale1_Step2":
            case "CutedChineseKale2_Step2":
            case "CutedChineseKale3_Step2":
            case "CutedChineseKale4_Step2":
                Happiness += 4;
                Sodium += 3.1f;
                Fat += 0.3f;
                Protein += 0.5f;
                KiloCalories += 9.7f;
                Healthy += 0;
                NephropathyHealthy += 0;
                ChineseKale = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CutedCucumber1":
            case "CutedCucumber2":
            case "CutedCucumber3":
            case "CutedCucumber4":
                Happiness += 4;
                Sodium += 3;
                Fat += 0.165f;
                Protein += 0.84f;
                KiloCalories += 27;
                Healthy += 0;
                NephropathyHealthy += 0;
                Cucumber = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedFish1":
            case "CutedFish2":
            case "CutedFish3":
            case "CutedFish4":
                Happiness += 10;
                Sodium += 5.25f;
                Fat += 0.525f;
                Protein += 0.825f;
                KiloCalories += 16.5f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Fish = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish, amount = 1 });
                break;
            case "CutedGarlic1":
            case "CutedGarlic2":
            case "CutedGarlic3":
            case "CutedGarlic4":
                Happiness += 2;
                Sodium += 13.5f;
                Fat += 0.15f;
                Protein += 1.275f;
                KiloCalories += 24.75f;
                Healthy += 0;
                NephropathyHealthy += 1;
                Garlic = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "CutedGinger1_Step1":
            case "CutedGinger2_Step1":
            case "CutedGinger3_Step1":
            case "CutedGinger4_Step1":
                Happiness += 1;
                Sodium += 0.975f;
                Fat += 0.06f;
                Protein += 0.135f;
                KiloCalories += 5.925f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Ginger = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedGinger1_Step2":
            case "CutedGinger2_Step2":
            case "CutedGinger3_Step2":
            case "CutedGinger4_Step2":
                Happiness += 1;
                Sodium += 6.65f;
                Fat += 0.04f;
                Protein += 0.09f;
                KiloCalories += 5.925f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Ginger = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedLime1_Step1":
            case "CutedLime2_Step1":
            case "CutedLime3_Step1":
            case "CutedLime4_Step1":
                Happiness += 2;
                Sodium += 1.5f;
                Protein += 0.75f;
                KiloCalories += 16.5f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Lime = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedLime1_Step2":
            case "CutedLime2_Step2":
            case "CutedLime3_Step2":
            case "CutedLime4_Step2":
                Happiness += 2;
                Sodium += 1;
                Protein += 0.5f;
                KiloCalories += 11;
                Healthy += 0;
                NephropathyHealthy += 0;
                Lime = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedOnion1_Step1":
            case "CutedOnion2_Step1":
            case "CutedOnion3_Step1":
            case "CutedOnion4_Step1":
                Happiness += 3;
                Sodium += 3.3f;
                Fat += 0.075f;
                Protein += 0.9f;
                KiloCalories += 33f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Onion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "CutedOnion1_Step2":
            case "CutedOnion2_Step2":
            case "CutedOnion3_Step2":
            case "CutedOnion4_Step2":
                Happiness += 3;
                Sodium += 2.2f;
                Fat += 0.05f;
                Protein += 0.6f;
                KiloCalories += 22f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Onion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "CutedPork1":
            case "CutedPork2":
            case "CutedPork3":
            case "CutedPork4":
                Happiness += 10;
                Sodium += 70.5f;
                Fat += 24.675f;
                Protein += 17.1f;
                KiloCalories += 128.25f;
                Healthy += 3;
                NephropathyHealthy += 6;
                Pork = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "CutedPotato1":
            case "CutedPotato2":
            case "CutedPotato3":
            case "CutedPotato4":
                Happiness += 15;
                Sodium += 315.75f;
                Fat += 0.075f;
                Protein += 0.15f;
                KiloCalories += 57.75f;
                Healthy += 12;
                NephropathyHealthy += 24;
                Potato = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Potato, amount = 1 });
                break;
            case "CutedShallot1_Step1":
            case "CutedShallot2_Step1":
            case "CutedShallot3_Step1":
            case "CutedShallot4_Step1":
                Happiness += 3;
                Sodium += 1.8f;
                Protein += 0.45f;
                KiloCalories += 10.8f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Shallot = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedShallot1_Step2":
            case "CutedShallot2_Step2":
            case "CutedShallot3_Step2":
            case "CutedShallot4_Step2":
                Happiness += 5;
                Sodium += 1.2f;
                Protein += 0.3f;
                KiloCalories += 7.2f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Shallot = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedSpringOnion1_Step1":
            case "CutedSpringOnion2_Step1":
            case "CutedSpringOnion3_Step1":
            case "CutedSpringOnion4_Step1":
                Happiness += 3;
                Sodium += 12f;
                Fat += 0.075f;
                Protein += 1.35f;
                KiloCalories += 12f;
                Healthy += 0;
                NephropathyHealthy += 1;
                SpringOnion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedSpringOnion1_Step2":
            case "CutedSpringOnion2_Step2":
            case "CutedSpringOnion3_Step2":
            case "CutedSpringOnion4_Step2":
                Happiness += 3;
                Sodium += 8f;
                Fat += 0.05f;
                Protein += 0.9f;
                KiloCalories += 8f;
                Healthy += 0;
                NephropathyHealthy += 1;
                SpringOnion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedTomato1":
            case "CutedTomato2":
            case "CutedTomato3":
            case "CutedTomato4":
                Happiness += 6;
                Sodium += 7.5f;
                KiloCalories += 13.275f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Tomato = true;
                Vegetable = true;
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
                Healthy += 2.5f;
                NephropathyHealthy += 5;
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
                Healthy += 2.5f;
                NephropathyHealthy += 5;
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
                Healthy += 0;
                NephropathyHealthy += 0;
                Fish = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish, amount = 1 });
                break;
            case "Garlic1":
            case "Garlic2":
            case "Garlic3":
            case "Garlic4":
                Happiness += 3;
                Sodium += 18;
                Fat += 0.2f;
                Protein += 1.7f;
                KiloCalories += 33;
                Healthy += 0;
                NephropathyHealthy += 1;
                Garlic = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "Ginger1":
            case "Ginger2":
            case "Ginger3":
            case "Ginger4":
                Happiness += 5;
                Sodium += 1.3f;
                Fat += 0.1f;
                Protein += 0.2f;
                KiloCalories += 7.9f;
                Healthy += 0;
                NephropathyHealthy += 1;
                Ginger = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "Lime1":
            case "Lime2":
            case "Lime3":
            case "Lime4":
                Happiness += 2;
                Sodium += 2;
                Protein += 1;
                KiloCalories += 22;
                Healthy += 0;
                NephropathyHealthy += 0;
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
                Healthy += 1;
                NephropathyHealthy += 2;
                Milk = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Milk, amount = 1 });
                break;
            case "MincedBeef1":
            case "MincedBeef2":
            case "MincedBeef3":
            case "MincedBeef4":
                Happiness += 10;
                Sodium += 37.8f;
                Fat += 6.2f;
                Protein += 19.45f;
                KiloCalories += 99.5f;
                Healthy += 2;
                NephropathyHealthy += 5;
                MincedBeef = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MincedBeef, amount = 1 });
                break;
            case "MincedPork1":
            case "MincedPork2":
            case "MincedPork3":
            case "MincedPork4":
                Happiness += 10;
                Sodium += 47;
                Fat += 16.45f;
                Protein += 11.4f;
                KiloCalories += 85.5f;
                Healthy += 3;
                NephropathyHealthy += 6;
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
                Healthy += 0;
                NephropathyHealthy += 0;
                Onion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "Pork1":
            case "Pork2":
            case "Pork3":
            case "Pork4":
                Happiness += 10;
                Sodium += 94;
                Fat += 32.9f;
                Protein += 22.8f;
                KiloCalories += 171;
                Healthy += 3;
                NephropathyHealthy += 6;
                Pork = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "Potato1":
            case "Potato2":
            case "Potato3":
            case "Potato4":
                Happiness += 15;
                Sodium += 421f;
                Fat += 0.1f;
                Protein += 2f;
                KiloCalories += 77f;
                Healthy += 12;
                NephropathyHealthy += 24;
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
                Healthy += 0;
                NephropathyHealthy += 0;
                Shallot = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "SpringOnion1":
            case "SpringOnion2":
            case "SpringOnion3":
            case "SpringOnion4":
                Happiness += 3;
                Sodium += 16f;
                Fat += 0.1f;
                Protein += 1.8f;
                KiloCalories += 16f;
                Healthy += 0;
                NephropathyHealthy += 1;
                SpringOnion = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "Tomato1":
            case "Tomato2":
            case "Tomato3":
            case "Tomato4":
                Happiness += 6;
                Sodium += 10;
                KiloCalories += 17.7f;
                Healthy += 0;
                NephropathyHealthy += 0;
                Tomato = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato, amount = 1 });
                break;
            case "Lemonade":
                Happiness += Random.Range(1.0f,12.0f);
                Sodium += 0.1f;
                Fat += 0.02f;
                Protein += 0.04f;
                KiloCalories += 2.1f;
                Healthy += 0;
                NephropathyHealthy += 0.5f;
                Lemonade = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lemonade, amount = 1 });
                break;
            case "MassamanPowder":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 580f;
                Fat += 3f;
                Protein += 1f;
                KiloCalories += 45f;
                Healthy += 25;
                NephropathyHealthy += 31;
                MassamanPowder = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MassamanPowder, amount = 1 });
                break;
            case "Mayonnaise":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 95.25f;
                Fat += 11.25f;
                Protein += 0.15f;
                KiloCalories += 101.85f;
                Healthy += 4.5f;
                NephropathyHealthy += 5.5f;
                Mayonnaise = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise, amount = 1 });
                break;
            case "Mayonnaise_J":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 70.1f;
                Fat += 2.71f;
                Protein += 0.04f;
                KiloCalories += 32.7f;
                Healthy += 3.5f;
                NephropathyHealthy += 4;
                Mayonnaise = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_J, amount = 1 });
                break;
            case "Mayonnaise_LowFat":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 120;
                Protein += 0.03f;
                KiloCalories += 10.2f;
                Healthy += 5;
                NephropathyHealthy += 7;
                Mayonnaise = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_LowFat, amount = 1 });
                break;
            case "Black_Soysauce":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 560;
                Protein += 0.5f;
                KiloCalories += 5f;
                Healthy += 25;
                NephropathyHealthy += 31;
                Black_Soysauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Black_Soysauce, amount = 1 });
                break;
            case "White_Soysauce":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 400;
                Protein += 0.9f;
                KiloCalories += 15;
                Healthy += 20;
                NephropathyHealthy += 24;
                White_Soysauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Soysauce, amount = 1 });
                break;
            case "Fish_Sauce":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 500;
                Protein += 0.9f;
                KiloCalories += 3;
                Healthy += 25;
                NephropathyHealthy += 30;
                Fish_Sauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish_Sauce, amount = 1 });
                break;
            case "Oyster_Sauce":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 165;
                Protein += 0.2f;
                KiloCalories += 15;
                Healthy += 5;
                NephropathyHealthy += 7;
                Oyster_Sauce = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Oyster_Sauce, amount = 1 });
                break;
            case "Vegetable_Oil":
                Happiness += Random.Range(1.0f, 12.0f);
                Fat += 13.5f;
                KiloCalories += 120;
                Healthy += 0;
                NephropathyHealthy += 0.5f;
                Vegetable_Oil = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Vegetable_Oil, amount = 1 });
                break;
            case "Msg":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 484.1f;
                KiloCalories += 12;
                Healthy += 20;
                NephropathyHealthy += 25;
                Msg = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Msg, amount = 1 });
                break;
            case "Pepper":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 0.5f;
                Fat += 0.1f;
                Protein += 0.2f;
                KiloCalories += 7.5f;
                Healthy += 0;
                NephropathyHealthy += 0.5f;
                Pepper = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper, amount = 1 });
                break;
            case "Pepper_Cayenne":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 98.4f;
                Fat += 0.85f;
                Protein += 0.81f;
                KiloCalories += 16.92f;
                Healthy += 4.5f;
                NephropathyHealthy += 5.5f;
                Pepper_Cayenne = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper_Cayenne, amount = 1 });
                break;
            case "Pink_Salt":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 800;
                Healthy += 40;
                NephropathyHealthy += 50;
                Pink_Salt = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pink_Salt, amount = 1 });
                break;
            case "Powder_Chicken":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 48;
                Protein += 0.5f;
                KiloCalories += 20;
                Healthy += 2f;
                NephropathyHealthy += 3f;
                Powder_Chicken = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Powder_Chicken, amount = 1 });
                break;
            case "Salad_DressingJP":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 41.43f;
                Fat += 1.57f;
                Protein += 0.14f;
                KiloCalories += 26;
                Healthy += 2f;
                NephropathyHealthy += 3f;
                Salad_DressingJP = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salad_DressingJP, amount = 1 });
                break;
            case "Salt":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 950;
                Healthy += 45f;
                NephropathyHealthy += 55f;
                Salt = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salt, amount = 1 });
                break;
            case "White_Sugar":
                Happiness += Random.Range(1.0f, 12.0f);
                KiloCalories += 19;
                Healthy += 0f;
                NephropathyHealthy += 0f;
                White_Sugar = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Sugar, amount = 1 });
                break;
            case "Tomato_Ketchup":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 47.5f;
                KiloCalories += 15;
                Healthy += 2f;
                NephropathyHealthy += 3.5f;
                Tomato_Ketchup = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato_Ketchup, amount = 1 });
                break;
            case "Brown_Sugar":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 1;
                KiloCalories += 18f;
                Healthy += 0f;
                NephropathyHealthy += 0.5f;
                Brown_Sugar = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Brown_Sugar, amount = 1 });
                break;
            case "Cinnamon":
                Happiness += Random.Range(1.0f, 12.0f);
                Sodium += 30.4f;
                Fat += 0.12f;
                Protein += 0.4f;
                KiloCalories += 24.7f;
                Healthy += 1.5f;
                NephropathyHealthy += 2.5f;
                Cinnamon = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cinnamon, amount = 1 });
                break;
            case "Basill1":
            case "Basill2":
            case "Basill3":
            case "Basill4":
                Happiness += 3;
                Sodium += 0.1f;
                Protein += 0.1f;
                KiloCalories += 0.6f;
                Healthy += 0f;
                NephropathyHealthy += 0f;
                Basil = true;
                Vegetable = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Basil, amount = 1 });
                break;
            case "CPepper":
                Happiness += Random.Range(1.0f, 12.0f);
                KiloCalories += 14.1f;
                Healthy += 5f;
                NephropathyHealthy += 7f;
                CPepper = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CPepper, amount = 1 });
                break;
            case "Ham1":
            case "Ham2":
            case "Ham3":
            case "Ham4":
                Happiness += 20;
                Fat += 9f;
                Protein += 17f;
                KiloCalories += 165f;
                Sodium += 900f;
                Healthy += 25f;
                NephropathyHealthy += 50f;
                Ham = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ham, amount = 1 });
                break;
            case "Crabsticks1":
            case "Crabsticks2":
            case "Crabsticks3":
            case "Crabsticks4":
                Happiness += 20;
                Protein += 6.4f; 
                Fat += 0.6f;
                KiloCalories += 84f;
                Sodium += 557.1f;
                Healthy += 15f;
                NephropathyHealthy += 30f;
                Crabsticks = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Crabsticks, amount = 1 });
                break;
            case "Bread1":
            case "Bread2":
            case "Bread3":
            case "Bread4":
                Happiness += 5;
                Fat += 1.3f;
                Protein += 2.5f;
                KiloCalories += 65f;
                Sodium += 110f;
                Healthy += 3f;
                NephropathyHealthy += 6f;
                Bread = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Bread, amount = 1 });
                break;
            case "WhiteEgg1":
            case "WhiteEgg2":
            case "WhiteEgg3":
            case "WhiteEgg4":
                Happiness += 5;
                Fat += 0.1f;
                Protein += 3.6f;
                KiloCalories += 17f;
                Sodium += 54.8f;
                Healthy += 1f;
                NephropathyHealthy += 3f;
                WhiteEgg = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.WhiteEgg, amount = 1 });
                break;
            case "Tuna1":
            case "Tuna2":
            case "Tuna3":
            case "Tuna4":
                Happiness += 15;
                Fat += 0f;
                Protein += 19f;
                KiloCalories += 80f;
                Sodium += 120f;
                Healthy += 3f;
                NephropathyHealthy += 6f;
                Tuna = true;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tuna, amount = 1 });
                break;
        }

    }

    int a, b, c, d; //ใช้เปรียบเทียบ แต่ ใส่ในฟังชั่นแล้วมันขีดเส้นแดง :V

    public string DiagnoseFood(bool burn,string used, bool eatable)
    {
        
        if (burn == true)
        {
            Happiness -= 15;
        }

        if (RanbowThing >= 100 && Turner == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            KiloCalories -= RanbowThing/3;
            Sodium -= RanbowThing/5;
            Happiness += RanbowThing;
            
            CurrentFood = "RainbowSoup";
        } //...

        if (EggBeat == true && Turner == true && used == "Pan" && eatable == true && CurrentFood == "")
        {
            if (MincedPork == true && Carrot == false && burn == false) //ไข่เจียวหมูสับไม่แครอท
            {
                CurrentFood = "Omelet_PW";
            }
            else if (MincedPork == false && Carrot == true && burn == false) //ไข่เจียวแครอทไม่หมูสับ
            {
                CurrentFood = "Omelet_C";
            }
            else if (MincedPork == true && Carrot == true && burn == false) //ไข่เจียวหมูสับแครอท
            {
                CurrentFood = "Omelet_PW_C";
            }
            else if(MincedPork == false && Carrot == false && burn == false) //ไข่เจียว
            {
                CurrentFood = "OmeletOnly";
            }
            else if (MincedPork == true && Carrot == false && burn == true) //ไข่เจียวหมูสับไม่แครอท ไหม้
            {
                CurrentFood = "Omelet_PW_Burn";
            }
            else if (MincedPork == false && Carrot == true && burn == true) //ไข่เจียวแครอทไม่หมูสับ ไหม้
            {
                CurrentFood = "Omelet_C_Burn";
            }
            else if (MincedPork == true && Carrot == true && burn == true) //ไข่เจียวหมูสับแครอท ไหม้
            {
                CurrentFood = "Omelet_PW_C_Burn";
            }
            else if (MincedPork == false && Carrot == false && burn == true)//ไข่เจียว ไหม้
            {
                CurrentFood = "OmeletOnly_Burn";
            }

            #region SetFoodStatus
            if (Protein <= 12.8f)
            {
                Protein = 12.8f;
            }
            if (Sodium <= 634)
            {
                Sodium = 634;
            }
            if (Fat <= 32)
            {
                Fat = 32;
            }
            if (KiloCalories <= 353)
            {
                KiloCalories = 353;
            }
            if (Happiness <= 16.5f)
            {
                Happiness = 16.5f;
            }
            if (Healthy <= 12)
            {
                Healthy = 12;
            }
            if (NephropathyHealthy <= 24)
            {
                NephropathyHealthy = 24;
            }
            #endregion

        } //ไข่เจียว

        if (Water == true && Rice == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "BoiledRice";

        } //ข้าวต้ม

        if (Chicken == true && Lemonade == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "ChickenBreast";

            #region SetFoodStatus
            if (Protein <= 51.4f)
            {
                Protein = 51.4f;
            }
            if (Sodium <= 842.2f)
            {
                Sodium = 842.2f;
            }
            if (Fat <= 5.8f)
            {
                Fat = 5.8f;
            }
            if (KiloCalories <= 296)
            {
                KiloCalories = 296;
            }
            if (Happiness <= 18)
            {
                Happiness = 18;
            }
            if (Healthy <= 16)
            {
                Healthy = 16;
            }
            if (NephropathyHealthy <= 32)
            {
                NephropathyHealthy = 32;
            }
            #endregion

        } //อกไก่ซอสมะนาว

        if (Basil == true && MincedPork == true && Turner == true && used == "Pan" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "BasilMP";

            #region SetFoodStatus
            if (Protein <= 32.2f)
            {
                Protein = 32.2f;
            }
            if (Sodium <= 852.5f)
            {
                Sodium = 852.5f;
            }
            if (Fat <= 6.4f)
            {
                Fat = 6.4f;
            }
            if (KiloCalories <= 231)
            {
                KiloCalories = 231;
            }
            if (Happiness <= 18)
            {
                Happiness = 18;
            }
            if (Healthy <= 18)
            {
                Healthy = 18;
            }
            if (NephropathyHealthy <= 35)
            {
                NephropathyHealthy = 35;
            }
            #endregion


        } //ผัดกระเพรา

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

                    #region SetFoodStatus
                    if (Protein <= 30.1f)
                    {
                        Protein = 30.1f;
                    }
                    if (Sodium <= 709.4f)
                    {
                        Sodium = 709.4f;
                    }
                    if (Fat <= 14.7f)
                    {
                        Fat = 14.7f;
                    }
                    if (KiloCalories <= 478)
                    {
                        KiloCalories = 478;
                    }
                    if (Happiness <= 17)
                    {
                        Happiness = 17;
                    }
                    if (Healthy <= 15)
                    {
                        Healthy = 15;
                    }
                    if (NephropathyHealthy <= 30)
                    {
                        NephropathyHealthy = 30;
                    }
                    #endregion

                }
                else
                {
                    CurrentFood = "FriedricePork";
                    a = 0;
                    b = 0;

                    #region SetFoodStatus
                    if (Protein <= 54.7f)
                    {
                        Protein = 54.7f;
                    }
                    if (Sodium <= 1082)
                    {
                        Sodium = 1082;
                    }
                    if (Fat <= 37.2f)
                    {
                        Fat = 37.2f;
                    }
                    if (KiloCalories <= 627)
                    {
                        KiloCalories = 627;
                    }
                    if (Happiness <= 20)
                    {
                        Happiness = 20;
                    }
                    if (Healthy <= 28)
                    {
                        Healthy = 28;
                    }
                    if (NephropathyHealthy <= 55)
                    {
                        NephropathyHealthy = 55;
                    }
                    #endregion

                }
            }  
        } //ข้าวผัด

        if (Chicken == true && Rice == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "HainaneseChicken";

            #region SetFoodStatus
            if (Protein <= 42.5f)
            {
                Protein = 42.5f;
            }
            if (Sodium <= 2582)
            {
                Sodium = 2582;
            }
            if (Fat <= 18.8f)
            {
                Fat = 18.8f;
            }
            if (KiloCalories <= 704)
            {
                KiloCalories = 704;
            }
            if (Happiness <= 25)
            {
                Happiness = 25;
            }
            if (Healthy <= 50)
            {
                Healthy = 50;
            }
            if (NephropathyHealthy <= 100)
            {
                NephropathyHealthy = 100;
            }
            #endregion

        } //ข้าวมันไก่

        if (Chicken == true && MassamanPowder == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "Massaman";

            #region SetFoodStatus
            if (Protein <= 50.2f)
            {
                Protein = 50.2f;
            }
            if (Sodium <= 612)
            {
                Sodium = 612;
            }
            if (Fat <= 23.4f)
            {
                Fat = 23.4f;
            }
            if (KiloCalories <= 252)
            {
                KiloCalories = 252;
            }
            if (Happiness <= 16.5f)
            {
                Happiness = 16.5f;
            }
            if (Healthy <= 12)
            {
                Healthy = 12;
            }
            if (NephropathyHealthy <= 24)
            {
                NephropathyHealthy = 24;
            }
            #endregion
        } //มัสมั่น

        if (Egg == true && Water == true && Spoon == true && used == "Pot" && eatable == true && CurrentFood == "" && burn == false)
        {
            CurrentFood = "PoachedEgg";

            #region SetFoodStatus
            if (Protein <= 27.7f)
            {
                Protein = 27.7f;
            }
            if (Sodium <= 743.1f)
            {
                Sodium = 743.1f;
            }
            if (Fat <= 20)
            {
                Fat = 20;
            }
            if (KiloCalories <= 370.8f)
            {
                KiloCalories = 370.8f;
            }
            if (Happiness <= 17)
            {
                Happiness = 17;
            }
            if (Healthy <= 15)
            {
                Healthy = 15;
            }
            if (NephropathyHealthy <= 30)
            {
                NephropathyHealthy = 30;
            }
            #endregion
        } //ไข่ดาวน้พ

        if (used == "Bowl" && Bread == true && Mayonnaise == true && CurrentFood == "")
        {
            foreach (FoodStatus usedItem in itemList)
            {

                if (usedItem.itemType == FoodStatus.ItemType.WhiteEgg)
                {
                    a = usedItem.amount;
                }
                else if (usedItem.itemType == FoodStatus.ItemType.Tuna)
                {
                    b = usedItem.amount;
                }
                else if (usedItem.itemType == FoodStatus.ItemType.EggBeat)
                {
                    c = usedItem.amount;
                }
                else if (usedItem.itemType == FoodStatus.ItemType.Crabsticks)
                {
                    d = usedItem.amount;
                }
            }

            if (a > b && a > c && a > d)
            {
                if (Ham == true)
                {
                    CurrentFood = "SandwichWhiteEggHam";
                    #region SetFoodStatus
                    if (Protein <= 33.4f)
                    {
                        Protein = 33.4f;
                    }
                    if (Sodium <= 580)
                    {
                        Sodium = 580;
                    }
                    if (Fat <= 15.1f)
                    {
                        Fat = 15.1f;
                    }
                    if (KiloCalories <= 229.5f)
                    {
                        KiloCalories = 229.5f;
                    }
                    if (Happiness <= 15)
                    {
                        Happiness = 15;
                    }
                    if (Healthy <= 15)
                    {
                        Healthy = 15;
                    }
                    if (NephropathyHealthy <= 30)
                    {
                        NephropathyHealthy = 30;
                    }
                    #endregion
                }
                else
                {
                    CurrentFood = "SandwichWhiteEgg";
                    #region SetFoodStatus
                    if (Protein <= 6.25f)
                    {
                        Protein = 6.25f;
                    }
                    if (Sodium <= 260.05f)
                    {
                        Sodium = 260.05f;
                    }
                    if (Fat <= 12.25f)
                    {
                        Fat = 12.25f;
                    }
                    if (KiloCalories <= 183.85f)
                    {
                        KiloCalories = 183.85f;
                    }
                    if (Happiness <= 15)
                    {
                        Happiness = 15;
                    }
                    if (Healthy <= 8)
                    {
                        Healthy = 8;
                    }
                    if (NephropathyHealthy <= 16)
                    {
                        NephropathyHealthy = 16;
                    }
                    #endregion
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
            }
            else if (b > a && b > c && b > d)
            {
                CurrentFood = "SandwichTuna";
                #region SetFoodStatus
                if (Protein <= 21.5f)
                {
                    Protein = 21.5f;
                }
                if (Sodium <= 230)
                {
                    Sodium = 230;
                }
                if (Fat <= 1.3f)
                {
                    Fat = 1.3f;
                }
                if (KiloCalories <= 145)
                {
                    KiloCalories = 145;
                }
                if (Happiness <= 15)
                {
                    Happiness = 15;
                }
                if (Healthy <= 8)
                {
                    Healthy = 8;
                }
                if (NephropathyHealthy <= 16)
                {
                    NephropathyHealthy = 16;
                }
                #endregion
                a = 0;
                b = 0;
                c = 0;
                d = 0;
            }
            else if (c > a && c > b && c > d)
            {
                CurrentFood = "SandwichEgg";
                #region SetFoodStatus
            if (Protein <= 8.95f)
                {
                    Protein = 8.95f;
                }
                if (Sodium <= 276.25f)
                {
                    Sodium = 276.25f;
                }
                if (Fat <= 17.35f)
                {
                    Fat = 17.35f;
                }
                if (KiloCalories <= 238.85f)
                {
                    KiloCalories = 238.82f;
                }
                if (Happiness <= 15)
                {
                    Happiness = 15;
                }
                if (Healthy <= 8)
                {
                    Healthy = 8;
                }
                if (NephropathyHealthy <= 16)
                {
                    NephropathyHealthy = 16;
                }
                #endregion
                a = 0;
                b = 0;
                c = 0;
                d = 0;
            }
            else if (d > a && d > c && d > b)
            {
                CurrentFood = "SandwichCrabsticks";
                #region SetFoodStatus
                if (Protein <= 9.15f)
                {
                    Protein = 9.15f;
                }
                if (Sodium <= 866.43f)
                {
                    Sodium = 866.43f;
                }
                if (Fat <= 3.27f)
                {
                    Fat = 3.27f;
                }
                if (KiloCalories <= 172)
                {
                    KiloCalories = 172;
                }
                if (Happiness <= 15)
                {
                    Happiness = 15;
                }
                if (Healthy <= 18)
                {
                    Healthy = 18;
                }
                if (NephropathyHealthy <= 35)
                {
                    NephropathyHealthy = 35;
                }
                #endregion
                a = 0;
                b = 0;
                c = 0;
                d = 0;
            }

        }//แซนวิช

        if (eatable == true && CurrentFood == "" && burn == false)
        {
            if (used == "Pot" || used == "Pan")
            {
                if (Spoon == true || Turner == true)
                {
                    if (Vegetable == true)
                    {
                        if (Chicken == true)
                        {
                            CurrentFood = "Custom_Chicken";
                        }
                        else if (Pork == true)
                        {
                            CurrentFood = "Custom_Pork";
                        }
                        else if (Fish == true)
                        {
                            CurrentFood = "Custom_Fish";
                        }
                        else if (Beef == true)
                        {
                            CurrentFood = "Custom_Beef";
                        }
                        else
                        {
                            CurrentFood = "Custom_Vg";
                        }

                    }
                    else
                    {
                        if (Chicken == true)
                        {
                            CurrentFood = "Custom_Chicken_NoVg";
                        }
                        else if (Pork == true)
                        {
                            CurrentFood = "Custom_Pork_NoVg";
                        }
                        else if (Fish == true)
                        {
                            CurrentFood = "Custom_Fish_NoVg";
                        }
                        else if (Beef == true)
                        {
                            CurrentFood = "Custom_Beef_NoVg";
                        }

                    }
                }
            }
            
        }//Custom

        if (eatable == true && CurrentFood == "" && burn == true)
        {
            if (used == "Pot" || used == "Pan")
            {
                CurrentFood = "BurnThing";
            }
        } //ไหม้เกรียม

        if (CurrentFood == "")
        {
            Reset();
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
        Healthy = 0;
        NephropathyHealthy = 0;
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
        Basil = false;
        CPepper = false;
        Vegetable = false;
        Ham = false;
        Crabsticks = false;
        Bread = false;
        WhiteEgg = false;
        Tuna = false;
    }

}
