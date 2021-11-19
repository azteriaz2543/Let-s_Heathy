using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EX : MonoBehaviour
{
    [SerializeField] GameObject[] a;
    [SerializeField] int[] answer, problem;
    [SerializeField] Sprite[] numBer;
    [SerializeField] Sprite tRueS;
    [SerializeField] Image[] imageNumber, iconTrue;
    [SerializeField] InputField[] inputField;
    // Start is called before the first frame update
    void Start()
    {
        //problem[0] = Random.Range(1, 101);
        //problem[1]= Random.Range(1, 101);
        //answer[0] = problem[0] + problem[1];
        //print(answer[0]);

        for (int i=0; i <= 9; i++)
        {
            problem[i] = Random.Range(1, 100);
            switch (problem[i])
            {
                case 1: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 2: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 3: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 4: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 5: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 6: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 7: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 8: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 9: imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 10: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 11: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 12: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 13: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 14: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 15: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 16: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 17: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 18: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 19: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[1]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 20: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 21: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 22: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 23: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 24: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 25: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 26: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 27: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 28: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 29: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[2]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 30: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 31: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 32: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 33: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 34: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 35: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 36: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 37: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 38: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 39: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[3]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 40: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 41: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 42: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 43: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 44: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 45: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 46: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 47: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 48: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 49: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[4]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 50: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 51: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 52: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 53: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 54: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 55: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 56: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 57: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 58: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 59: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 60: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[5]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 61: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 62: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 63: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 64: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 65: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 66: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 67: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 68: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 69: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[6]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 70: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 71: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 72: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 73: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 74: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 75: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 76: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 77: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 78: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 79: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[7]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 80: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 81: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 82: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 83: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 84: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 85: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 86: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 87: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 88: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 89: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[8]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
                case 90: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[0]; break;
                case 91: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[1]; break;
                case 92: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[2]; break;
                case 93: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[3]; break;
                case 94: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[4]; break;
                case 95: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[5]; break;
                case 96: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[6]; break;
                case 97: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[7]; break;
                case 98: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[8]; break;
                case 99: imageNumber[i * 2].GetComponent<Image>().sprite = numBer[9]; imageNumber[i * 2 + 1].GetComponent<Image>().sprite = numBer[9]; break;
            }
            answer[0] = problem[0] + problem[1];
            answer[1] = problem[2] + problem[3];
            answer[2] = problem[4] + problem[5];
            answer[3] = problem[6] + problem[7];
            answer[4] = problem[8] + problem[9];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(inputField[0].text) == answer[0])
        {
            iconTrue[0].GetComponent<Image>().sprite = tRueS;
        }
        if (int.Parse(inputField[1].text) == answer[1])
        {         iconTrue[1].GetComponent<Image>().sprite = tRueS;
        }
        if (int.Parse(inputField[2].text) == answer[2])
        {
            iconTrue[2].GetComponent<Image>().sprite = tRueS;
        }
        if (int.Parse(inputField[3].text) == answer[3])
        {
            iconTrue[3].GetComponent<Image>().sprite = tRueS;
        }
        if (int.Parse(inputField[4].text) == answer[4])
        {
            iconTrue[4].GetComponent<Image>().sprite = tRueS;
        }
    }

}
