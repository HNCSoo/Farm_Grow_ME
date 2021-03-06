﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveObj());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MoveObj()
    {
        rig = GetComponent<Rigidbody>();

        while (true)
        {
            float dir1 = Random.Range(-1f, 1f);
            float dir2 = Random.Range(-1f, 1f);

            yield return new WaitForSeconds(2);
            rig.velocity = new Vector3(dir1, 0, dir2);
        }
    }
}
