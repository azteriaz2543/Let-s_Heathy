using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStatus
{

    public enum ItemType
    {
        Spoon,
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
    }

    public ItemType itemType;
    public int amount;

}
