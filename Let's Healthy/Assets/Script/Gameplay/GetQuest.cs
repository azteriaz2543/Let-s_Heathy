using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetQuest : MonoBehaviour
{
    public string QuestText;
    // Start is called before the first frame update
    void Start()
    {
        QuestText = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetQuestInfo (int questNo)
    {
        QuestText = "";

        switch (questNo)
        {
            case 0:
                QuestText = "";
                break;
            case 1:
                QuestText = "รับประทานอาหารเช้า 6.00 - 8.00 น.";
                break;
            case 2:
                QuestText = "รับประทานอาหารกลางวัน 12.00 - 14.00 น.";
                break;
            case 3:
                QuestText = "รับประทานอาหารเย็น 18.00 - 20.00 น.";
                break;
            case 4:
                QuestText = "เล่นมินิเกมที่ โรงพยาบาล";
                break;
            case 5:
                QuestText = "เล่นมินิเกมที่ โรงเรียน";
                break;
            case 6:
                QuestText = "เล่นมินิเกมที่ ออฟฟิศ";
                break;
            case 7:
                QuestText = "เล่นมินิเกมที่ ฟิตเนส";
                break;
        }

        return QuestText;
    }

}
