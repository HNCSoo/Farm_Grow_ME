﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_Scale : MonoBehaviour
{
  
    float scale = 0.002f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()   
    {

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Scaleup(new Vector3(scale, scale, scale));
        //}
    }

    public void Scaleup(Vector3 scale)
    {

        transform.localScale += scale;
        print("cow 자랐다.");
    }




}

