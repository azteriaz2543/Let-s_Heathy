using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedsDrawn : MonoBehaviour
{
    [SerializeField] Image pePer;
    [SerializeField] Sprite[] drawn;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            count += 1;
        }
       switch (count)
        {
            case 20: pePer.sprite = drawn[0]; break;
            case 40: pePer.sprite = drawn[1]; break;
            case 60: pePer.sprite = drawn[2]; break;
            case 80: pePer.sprite = drawn[3]; break;
            case 100: pePer.sprite = drawn[4]; break;
         
        }
        if(count==100)
        {
            print("SucSesraw");
        }
    }
}
