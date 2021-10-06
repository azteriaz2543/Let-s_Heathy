using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCook : MonoBehaviour
{
    public string CurrentFood;

    public float Protein, Sodium, Fat, KiloCalories ,Happiness;
    public float Normal_Health, KDP_Health;

    List<FoodStatus> itemList;

    #region checkItem
    bool Spoon,
        Turner,
        Water,
        Beef,
        Carrot,
        Chicken,
        ChineseKale,
        CoconutMilk,
        Cucumber,
        CutedBeef,
        CutedCarrot_Step1,
        CutedCarrot_Step2,
        CutedChicken,
        CutedChineseKale_Step1,
        CutedChineseKale_Step2,
        CutedCucumber,
        CutedFish,
        CutedGarlic,
        CutedGinger_Step1,
        CutedGinger_Step2,
        CutedLime_Step1,
        CutedLime_Step2,
        CutedOnion_Step1,
        CutedOnion_Step2,
        CutedPork,
        CutedPotato,
        CutedShallot_Step1,
        CutedShallot_Step2,
        CutedSpringOnion_Step1,
        CutedSpringOnion_Step2,
        CutedTomato,
        Egg,
        EggBeat,
        Fish,
        Garlic,
        Ginger,
        Lime,
        Milk,
        MincedBeef,
        MincedPork,
        Onion,
        Pork,
        Potato,
        Shallot,
        SpringOnion,
        Tomato,
        Rice,
        Lemonade,
        MassamanPowder,
        Mayonnaise,
        Mayonnaise_J,
        Mayonnaise_LowFat,
        Black_Soysauce,
        White_Soysauce,
        Fish_Sauce,
        Oyster_Sauce,
        Vegetable_Oil,
        Msg,
        Pepper,
        Pepper_Cayenne,
        Pink_Salt,
        Powder_Chicken,
        Salad_DressingJP,
        Salt,
        White_Sugar,
        Tomato_Ketchup,
        Brown_Sugar,
        Cinnamon;
    #endregion //เช็คไอเทม

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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Spoon, amount = 1 });
                break;
            case "Turner":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Turner, amount = 1 });
                break;
            case "Water":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Water, amount = 1 });
                break;
            case "RiceC":
                Happiness += 15;
                Sodium += 1;
                Fat += 0.3f;
                Protein += 2.7f;
                KiloCalories += 130;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Rice, amount = 1 });
                break;
            case "Beef1":
            case "Beef2":
            case "Beef3":
            case "Beef4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Beef, amount = 1 });
                break;
            case "Carrot1":
            case "Carrot2":
            case "Carrot3":
            case "Carrot4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "Chicken1":
            case "Chicken2":
            case "Chicken3":
            case "Chicken4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "ChineseKale1":
            case "ChineseKale2":
            case "ChineseKale3":
            case "ChineseKale4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CoconutMilk1":
            case "CoconutMilk2":
            case "CoconutMilk3":
            case "CoconutMilk4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedBeef1":
            case "CutedBeef2":
            case "CutedBeef3":
            case "CutedBeef4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedBeef, amount = 1 });
                break;
            case "CutedCarrot1_Step1":
            case "CutedCarrot2_Step1":
            case "CutedCarrot3_Step1":
            case "CutedCarrot4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedCarrot_Step1, amount = 1 });
                break;
            case "CutedCarrot1_Step2":
            case "CutedCarrot2_Step2":
            case "CutedCarrot3_Step2":
            case "CutedCarrot4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedCarrot_Step2, amount = 1 });
                break;
            case "CutedChicken1":
            case "CutedChicken2":
            case "CutedChicken3":
            case "CutedChicken4":
                Happiness += 15;
                Sodium += 45;
                Fat += 2.6f;
                Protein += 23f;
                KiloCalories += 79;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedChicken, amount = 1 });
                break;
            case "CutedChineseKale1_Step1":
            case "CutedChineseKale2_Step1":
            case "CutedChineseKale3_Step1":
            case "CutedChineseKale4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedChineseKale_Step1, amount = 1 });
                break;
            case "CutedChineseKale1_Step2":
            case "CutedChineseKale2_Step2":
            case "CutedChineseKale3_Step2":
            case "CutedChineseKale4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedChineseKale_Step2, amount = 1 });
                break;
            case "CutedCucumber1":
            case "CutedCucumber2":
            case "CutedCucumber3":
            case "CutedCucumber4":
                Happiness += 4;
                Sodium += 2;
                Fat += 0.11f;
                Protein += .56f;
                KiloCalories += 18;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedCucumber, amount = 1 });
                break;
            case "CutedFish1":
            case "CutedFish2":
            case "CutedFish3":
            case "CutedFish4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedFish, amount = 1 });
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedGarlic, amount = 1 });
                break;
            case "CutedGinger1_Step1":
            case "CutedGinger2_Step1":
            case "CutedGinger3_Step1":
            case "CutedGinger4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedGinger_Step1, amount = 1 });
                break;
            case "CutedGinger1_Step2":
            case "CutedGinger2_Step2":
            case "CutedGinger3_Step2":
            case "CutedGinger4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedGinger_Step2, amount = 1 });
                break;
            case "CutedLime1_Step1":
            case "CutedLime2_Step1":
            case "CutedLime3_Step1":
            case "CutedLime4_Step1":
                Happiness += 3;
                Sodium += 4;
                Protein += 2;
                KiloCalories += 88;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedLime_Step1, amount = 1 });
                break;
            case "CutedLime1_Step2":
            case "CutedLime2_Step2":
            case "CutedLime3_Step2":
            case "CutedLime4_Step2":
                Happiness += 2;
                Sodium += 2;
                Protein += 1;
                KiloCalories += 44;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedLime_Step2, amount = 1 });
                break;
            case "CutedOnion1_Step1":
            case "CutedOnion2_Step1":
            case "CutedOnion3_Step1":
            case "CutedOnion4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedSpringOnion_Step1, amount = 1 });
                break;
            case "CutedOnion1_Step2":
            case "CutedOnion2_Step2":
            case "CutedOnion3_Step2":
            case "CutedOnion4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedSpringOnion_Step2, amount = 1 });
                break;
            case "CutedPork1":
            case "CutedPork2":
            case "CutedPork3":
            case "CutedPork4":
                Happiness += 10;
                Sodium += 94;
                Fat += 32.9f;
                Protein += 22.8f;
                KiloCalories += 171;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedPork, amount = 1 });
                break;
            case "CutedPotato1":
            case "CutedPotato2":
            case "CutedPotato3":
            case "CutedPotato4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedPotato, amount = 1 });
                break;
            case "CutedShallot1_Step1":
            case "CutedShallot2_Step1":
            case "CutedShallot3_Step1":
            case "CutedShallot4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedShallot_Step1, amount = 1 });
                break;
            case "CutedShallot1_Step2":
            case "CutedShallot2_Step2":
            case "CutedShallot3_Step2":
            case "CutedShallot4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedShallot_Step2, amount = 1 });
                break;
            case "CutedSpringOnion1_Step1":
            case "CutedSpringOnion2_Step1":
            case "CutedSpringOnion3_Step1":
            case "CutedSpringOnion4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedSpringOnion_Step1, amount = 1 });
                break;
            case "CutedSpringOnion1_Step2":
            case "CutedSpringOnion2_Step2":
            case "CutedSpringOnion3_Step2":
            case "CutedSpringOnion4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedSpringOnion_Step2, amount = 1 });
                break;
            case "CutedTomato1":
            case "CutedTomato2":
            case "CutedTomato3":
            case "CutedTomato4":
                Happiness += 6;
                Sodium += 10;
                KiloCalories += 17.7f;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.CutedTomato, amount = 1 });
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.EggBeat, amount = 1 });
                break;
            case "Fish1":
            case "Fish2":
            case "Fish3":
            case "Fish4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "Ginger1":
            case "Ginger2":
            case "Ginger3":
            case "Ginger4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "Milk1":
            case "Milk2":
            case "Milk3":
            case "Milk4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Milk, amount = 1 });
                break;
            case "MincedBeef1":
            case "MincedBeef2":
            case "MincedBeef3":
            case "MincedBeef4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MincedPork, amount = 1 });
                break;
            case "Onion1":
            case "Onion2":
            case "Onion3":
            case "Onion4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "Potato1":
            case "Potato2":
            case "Potato3":
            case "Potato4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Potato, amount = 1 });
                break;
            case "Shallot1":
            case "Shallot2":
            case "Shallot3":
            case "Shallot4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "SpringOnion1":
            case "SpringOnion2":
            case "SpringOnion3":
            case "SpringOnion4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "Tomato1":
            case "Tomato2":
            case "Tomato3":
            case "Tomato4":
                Happiness += 9;
                Sodium += 20;
                KiloCalories += 35.4f;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato, amount = 1 });
                break;
            case "Lemonade":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lemonade, amount = 1 });
                break;
            case "MassamanPowder":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.MassamanPowder, amount = 1 });
                break;
            case "Mayonnaise":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise, amount = 1 });
                break;
            case "Mayonnaise_J":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_J, amount = 1 });
                break;
            case "Mayonnaise_LowFat":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Mayonnaise_LowFat, amount = 1 });
                break;
            case "Black_Soysauce":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Black_Soysauce, amount = 1 });
                break;
            case "White_Soysauce":
                Happiness += 2;
                Sodium += 400;
                Protein += 0.9f;
                KiloCalories += 15;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Soysauce, amount = 1 });
                break;
            case "Fish_Sauce":
                Happiness += 2.5f;
                Sodium += 490;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Fish_Sauce, amount = 1 });
                break;
            case "Oyster_Sauce":
                Happiness += 1.5f;
                Sodium += 165;
                Protein += 0.2f;
                KiloCalories += 15;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Oyster_Sauce, amount = 1 });
                break;
            case "Vegetable_Oil":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Vegetable_Oil, amount = 1 });
                break;
            case "Msg":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Msg, amount = 1 });
                break;
            case "Pepper":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper, amount = 1 });
                break;
            case "Pepper_Cayenne":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pepper_Cayenne, amount = 1 });
                break;
            case "Pink_Salt":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pink_Salt, amount = 1 });
                break;
            case "Powder_Chicken":
                Happiness += 5;
                Sodium += 48;
                Protein += 0.5f;
                KiloCalories += 20;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Powder_Chicken, amount = 1 });
                break;
            case "Salad_DressingJP":
                Happiness += 1;
                Sodium += 41.43f;
                Fat += 1.57f;
                Protein += 0.14f;
                KiloCalories += 26;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salad_DressingJP, amount = 1 });
                break;
            case "Salt":
                Happiness += 10;
                Sodium += 1900;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Salt, amount = 1 });
                break;
            case "White_Sugar":
                Happiness += 1;
                KiloCalories += 19;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.White_Sugar, amount = 1 });
                break;
            case "Tomato_Ketchup":
                Happiness += 1;
                Sodium += 47.5f;
                KiloCalories += 15;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Tomato_Ketchup, amount = 1 });
                break;
            case "Brown_Sugar":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Brown_Sugar, amount = 1 });
                break;
            case "Cinnamon":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cinnamon, amount = 1 });
                break;
            
        }

    }

    public string DiagnoseFood(bool burn,string used, bool eatable)
    {
        foreach (FoodStatus usedItem in itemList)
        {
            switch (usedItem.itemType)
            {
                case FoodStatus.ItemType.Spoon:
                    if (usedItem.amount > 0)
                    {
                        Spoon = true;
                    }
                    break;
                case FoodStatus.ItemType.Turner:
                    if (usedItem.amount > 0)
                    {
                        Turner = true;
                    }
                    break;
                case FoodStatus.ItemType.Water:
                    if (usedItem.amount > 0)
                    {
                        Water = true;
                    }
                    break;
                case FoodStatus.ItemType.Beef:
                    if (usedItem.amount > 0)
                    {
                        Beef = true;
                    }
                    break;
                case FoodStatus.ItemType.Carrot:
                    if (usedItem.amount > 0)
                    {
                        Carrot = true;
                    }
                    break;
                case FoodStatus.ItemType.Chicken:
                    if (usedItem.amount > 0)
                    {
                        Chicken = true;
                    }
                    break;
                case FoodStatus.ItemType.ChineseKale:
                    if (usedItem.amount > 0)
                    {
                        ChineseKale = true;
                    }
                    break;
                case FoodStatus.ItemType.CoconutMilk:
                    if (usedItem.amount > 0)
                    {
                        CoconutMilk = true;
                    }
                    break;
                case FoodStatus.ItemType.Cucumber:
                    if (usedItem.amount > 0)
                    {
                        Cucumber = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedBeef:
                    if (usedItem.amount > 0)
                    {
                        Beef = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedCarrot_Step1:
                    if (usedItem.amount > 0)
                    {
                        Carrot = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedCarrot_Step2:
                    if (usedItem.amount > 0)
                    {
                        Carrot = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedChicken:
                    if (usedItem.amount > 0)
                    {
                        Chicken = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedChineseKale_Step1:
                    if (usedItem.amount > 0)
                    {
                        ChineseKale = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedChineseKale_Step2:
                    if (usedItem.amount > 0)
                    {
                        ChineseKale = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedCucumber:
                    if (usedItem.amount > 0)
                    {
                        Cucumber = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedFish:
                    if (usedItem.amount > 0)
                    {
                        Fish = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedGarlic:
                    if (usedItem.amount > 0)
                    {
                        Garlic = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedGinger_Step1:
                    if (usedItem.amount > 0)
                    {
                        Ginger = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedGinger_Step2:
                    if (usedItem.amount > 0)
                    {
                        Ginger = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedLime_Step1:
                    if (usedItem.amount > 0)
                    {
                        Lime = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedLime_Step2:
                    if (usedItem.amount > 0)
                    {
                        Lime = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedOnion_Step1:
                    if (usedItem.amount > 0)
                    {
                        Onion = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedOnion_Step2:
                    if (usedItem.amount > 0)
                    {
                        Onion = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedPork:
                    if (usedItem.amount > 0)
                    {
                        Pork = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedPotato:
                    if (usedItem.amount > 0)
                    {
                        Potato = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedShallot_Step1:
                    if (usedItem.amount > 0)
                    {
                        Shallot = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedShallot_Step2:
                    if (usedItem.amount > 0)
                    {
                        Shallot = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedSpringOnion_Step1:
                    if (usedItem.amount > 0)
                    {
                        SpringOnion = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedSpringOnion_Step2:
                    if (usedItem.amount > 0)
                    {
                        SpringOnion = true;
                    }
                    break;
                case FoodStatus.ItemType.CutedTomato:
                    if (usedItem.amount > 0)
                    {
                        Tomato = true;
                    }
                    break;
                case FoodStatus.ItemType.Egg:
                    if (usedItem.amount > 0)
                    {
                        Egg = true;
                    }
                    break;
                case FoodStatus.ItemType.EggBeat:
                    if (usedItem.amount > 0)
                    {
                        EggBeat = true;
                    }
                    break;
                case FoodStatus.ItemType.Fish:
                    if (usedItem.amount > 0)
                    {
                        Fish = true;
                    }
                    break;
                case FoodStatus.ItemType.Garlic:
                    if (usedItem.amount > 0)
                    {
                        Garlic = true;
                    }
                    break;
                case FoodStatus.ItemType.Ginger:
                    if (usedItem.amount > 0)
                    {
                        Ginger = true;
                    }
                    break;
                case FoodStatus.ItemType.Lime:
                    if (usedItem.amount > 0)
                    {
                        Lime = true;
                    }
                    break;
                case FoodStatus.ItemType.Milk:
                    if (usedItem.amount > 0)
                    {
                        Milk = true;
                    }
                    break;
                case FoodStatus.ItemType.MincedBeef:
                    if (usedItem.amount > 0)
                    {
                        MincedBeef = true;
                    }
                    break;
                case FoodStatus.ItemType.MincedPork:
                    if (usedItem.amount > 0)
                    {
                        MincedPork = true;
                    }
                    break;
                case FoodStatus.ItemType.Onion:
                    if (usedItem.amount > 0)
                    {
                        Onion = true;
                    }
                    break;
                case FoodStatus.ItemType.Pork:
                    if (usedItem.amount > 0)
                    {
                        Pork = true;
                    }
                    break;
                case FoodStatus.ItemType.Potato:
                    if (usedItem.amount > 0)
                    {
                        Potato = true;
                    }
                    break;
                case FoodStatus.ItemType.Shallot:
                    if (usedItem.amount > 0)
                    {
                        Shallot = true;
                    }
                    break;
                case FoodStatus.ItemType.SpringOnion:
                    if (usedItem.amount > 0)
                    {
                        SpringOnion = true;
                    }
                    break;
                case FoodStatus.ItemType.Tomato:
                    if (usedItem.amount > 0)
                    {
                        Tomato = true;
                    }
                    break;
            }
            

        }


        
        if (EggBeat == true && Turner == true && used == "Pan" && eatable == true)
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
    }
}
