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
                QuestText = "�Ѻ��зҹ�������� 6.00 - 8.00 �.";
                break;
            case 2:
                QuestText = "�Ѻ��зҹ����á�ҧ�ѹ 12.00 - 14.00 �.";
                break;
            case 3:
                QuestText = "�Ѻ��зҹ�������� 18.00 - 20.00 �.";
                break;
            case 4:
                QuestText = "����Թ������ �ç��Һ��";
                break;
            case 5:
                QuestText = "����Թ������ �ç���¹";
                break;
            case 6:
                QuestText = "����Թ������ �Ϳ���";
                break;
            case 7:
                QuestText = "����Թ������ �Ե��";
                break;
        }

        return QuestText;
    }

}
