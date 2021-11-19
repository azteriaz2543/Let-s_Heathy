using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardscan : MonoBehaviour
{
    int check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("sus");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        check++;
        if (check==60)
        {
            print("aa");
        }
    }
}
