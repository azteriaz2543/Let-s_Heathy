using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenUsed : MonoBehaviour
{
    Cooking cooking;
    void Start()
    {
        cooking = GameObject.Find("Cooking").GetComponent<Cooking>();
    }

    
    void Update()
    {
        if (cooking.endCook == true)
        {
            Destroy(gameObject);
        }
    }
}
