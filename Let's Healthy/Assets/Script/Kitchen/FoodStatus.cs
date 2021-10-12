using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStatus
{

    public enum ItemType
    {
        Spoon, //0
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
        Cinnamon, //67
        Basil,
    }

    public ItemType itemType;
    public int amount;

}
