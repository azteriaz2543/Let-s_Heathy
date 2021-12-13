using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetQuest : MonoBehaviour
{
    public string QuestText;
    // Start is called before the first frame update
    void Start()
    {
        QuestText = "ะำหะ";
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
                QuestText = "รับประทานอาหารเช้า ก่อนเวลา 8.00 น.";
                break;
            case 2:
                QuestText = "รับประทานอาหารกลางวัน ก่อนเวลา 14.00 น.";
                break;
            case 3:
                QuestText = "รับประทานอาหารเย็น ก่อนเวลา 20.00 น.";
                break;
            case 4:
                QuestText = "เล่นมินิเกมที่ โรงพยาบาล";
                break;
            case 5:
                QuestText = "เล่นมินิเกมที่ โรงเรียน";
                break;
            case 6:
                QuestText = "เล่นมินิเกมที่ ออฟฟิช";
                break;
            case 7:
                QuestText = "เล่นมินิเกมที่ ฟิตเนต";
                break;
        }

        return QuestText;
    }

}
