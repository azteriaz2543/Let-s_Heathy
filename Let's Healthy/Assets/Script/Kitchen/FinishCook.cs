using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCook : MonoBehaviour
{
    public string CurrentFood;

    public float Protein, Sodium, Fat, KiloCalories ,Happiness;
    public float Normal_Health, KDP_Health;

    List<FoodStatus> itemList;

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
                usedItem.used = true;
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
                break;
            case "CutedCarrot1_Step2":
            case "CutedCarrot2_Step2":
            case "CutedCarrot3_Step2":
            case "CutedCarrot4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Carrot, amount = 1 });
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Chicken, amount = 1 });
                break;
            case "CutedChineseKale1_Step1":
            case "CutedChineseKale2_Step1":
            case "CutedChineseKale3_Step1":
            case "CutedChineseKale4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
                break;
            case "CutedChineseKale1_Step2":
            case "CutedChineseKale2_Step2":
            case "CutedChineseKale3_Step2":
            case "CutedChineseKale4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.ChineseKale, amount = 1 });
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Cucumber, amount = 1 });
                break;
            case "CutedFish1":
            case "CutedFish2":
            case "CutedFish3":
            case "CutedFish4":
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Garlic, amount = 1 });
                break;
            case "CutedGinger1_Step1":
            case "CutedGinger2_Step1":
            case "CutedGinger3_Step1":
            case "CutedGinger4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedGinger1_Step2":
            case "CutedGinger2_Step2":
            case "CutedGinger3_Step2":
            case "CutedGinger4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Ginger, amount = 1 });
                break;
            case "CutedLime1_Step1":
            case "CutedLime2_Step1":
            case "CutedLime3_Step1":
            case "CutedLime4_Step1":
                Happiness += 3;
                Sodium += 4;
                Protein += 2;
                KiloCalories += 88;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedLime1_Step2":
            case "CutedLime2_Step2":
            case "CutedLime3_Step2":
            case "CutedLime4_Step2":
                Happiness += 2;
                Sodium += 2;
                Protein += 1;
                KiloCalories += 44;
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Lime, amount = 1 });
                break;
            case "CutedOnion1_Step1":
            case "CutedOnion2_Step1":
            case "CutedOnion3_Step1":
            case "CutedOnion4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
                break;
            case "CutedOnion1_Step2":
            case "CutedOnion2_Step2":
            case "CutedOnion3_Step2":
            case "CutedOnion4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Onion, amount = 1 });
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
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Pork, amount = 1 });
                break;
            case "CutedPotato1":
            case "CutedPotato2":
            case "CutedPotato3":
            case "CutedPotato4":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Potato, amount = 1 });
                break;
            case "CutedShallot1_Step1":
            case "CutedShallot2_Step1":
            case "CutedShallot3_Step1":
            case "CutedShallot4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedShallot1_Step2":
            case "CutedShallot2_Step2":
            case "CutedShallot3_Step2":
            case "CutedShallot4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.Shallot, amount = 1 });
                break;
            case "CutedSpringOnion1_Step1":
            case "CutedSpringOnion2_Step1":
            case "CutedSpringOnion3_Step1":
            case "CutedSpringOnion4_Step1":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedSpringOnion1_Step2":
            case "CutedSpringOnion2_Step2":
            case "CutedSpringOnion3_Step2":
            case "CutedSpringOnion4_Step2":
                AddItem(new FoodStatus { itemType = FoodStatus.ItemType.SpringOnion, amount = 1 });
                break;
            case "CutedTomato1":
            case "CutedTomato2":
            case "CutedTomato3":
            case "CutedTomato4":
                Happiness += 6;
                Sodium += 10;
                KiloCalories += 17.7f;
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
        /*
        
        if (itemList[32].used == true && itemList[1].used == true && used == "Pan" && eatable == true)
        {
            if (itemList[39].used == true && itemList[4].used == false && burn == false) //‰¢Ë‡®’¬«À¡Ÿ —∫‰¡Ë·§√Õ∑
            {
                CurrentFood = "Omelet_PW";
            }
            else if (itemList[39].used == false && itemList[4].used == true && burn == false) //‰¢Ë‡®’¬«·§√Õ∑‰¡ËÀ¡Ÿ —∫
            {
                CurrentFood = "Omelet_C";
            }
            else if (itemList[39].used == true && itemList[4].used == true && burn == false) //‰¢Ë‡®’¬«À¡Ÿ —∫·§√Õ∑
            {
                CurrentFood = "Omelet_PW_C";
            }
            else if(itemList[39].used == false && itemList[4].used == false && burn == false) //‰¢Ë‡®’¬«
            {
                CurrentFood = "OmeletOnly";
            }
            else if (itemList[39].used == true && itemList[4].used == false && burn == true) //‰¢Ë‡®’¬«À¡Ÿ —∫‰¡Ë·§√Õ∑ ‰À¡È
            {
                CurrentFood = "Omelet_PW_Burn";
            }
            else if (itemList[39].used == false && itemList[4].used == true && burn == true) //‰¢Ë‡®’¬«·§√Õ∑‰¡ËÀ¡Ÿ —∫ ‰À¡È
            {
                CurrentFood = "Omelet_C_Burn";
            }
            else if (itemList[39].used == true && itemList[4].used == true && burn == true) //‰¢Ë‡®’¬«À¡Ÿ —∫·§√Õ∑ ‰À¡È
            {
                CurrentFood = "Omelet_PW_C_Burn";
            }
            else if (itemList[39].used == false && itemList[4].used == false && burn == true)//‰¢Ë‡®’¬« ‰À¡È
            {
                CurrentFood = "OmeletOnly_Burn";
            }
        }
        */

        if (burn == false)
        {
            CurrentFood = "OmeletOnly";
        }
        else
        {
            CurrentFood = "OmeletOnly_Burn";
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
