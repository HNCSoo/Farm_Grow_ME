using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick_Grow : MonoBehaviour
{
    float CreateTime;
    float GrowTime =  5;
    public GameObject GroowchickObj;
    Transform Mama;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateTime += Time.deltaTime;
        if(GrowTime >= CreateTime)
        {
           
        }
    }
}
