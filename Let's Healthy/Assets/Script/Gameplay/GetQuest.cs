using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetQuest : MonoBehaviour
{
    public string QuestText;
    // Start is called before the first frame update
    void Start()
    {
        QuestText = "����";
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
                QuestText = "�Ѻ��зҹ�������ҡ�͹���� 8.00 �.";
                break;
            case 2:
                QuestText = "�Ѻ��зҹ����á�ҧ�ѹ��͹���� 14.00 �.";
                break;
            case 3:
                QuestText = "�Ѻ��зҹ�������繡�͹���� 20.00 �.";
                break;
        }

        return QuestText;
    }

}
