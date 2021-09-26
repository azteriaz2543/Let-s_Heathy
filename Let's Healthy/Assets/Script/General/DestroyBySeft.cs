using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBySeft : MonoBehaviour
{
    public float DestroySec;
    void Start()
    {
        Destroy(gameObject,DestroySec);
    }

   
    void Update()
    {
        
    }
}
