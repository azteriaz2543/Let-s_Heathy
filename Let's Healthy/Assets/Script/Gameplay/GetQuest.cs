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
                QuestText = "รับประทานอาหารเช้าก่อนเวลา 8.00 น.";
                break;
            case 2:
                QuestText = "รับประทานอาหารกลางวันก่อนเวลา 14.00 น.";
                break;
            case 3:
                QuestText = "รับประทานอาหารเย็นก่อนเวลา 20.00 น.";
                break;
        }

        return QuestText;
    }

}
