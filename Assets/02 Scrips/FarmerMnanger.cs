using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMnanger : MonoBehaviour
{
    Ray ray = new Ray();
    RaycastHit hit;
    int FlowerMask;
    UP_Scale Scaleup;
    public float Range = 100f;
    public float scale = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        FlowerMask = LayerMask.GetMask("Flower");

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            print("Click");
            Shoot();
        }



    }

    public void Shoot()
    {
        //ray.origin = transform.position;
        //ray.direction = transform.forward;
        //print("들어왔나");

        //if (Physics.Raycast(ray, out hit, Range, FlowerMask))
        //{
        //    print("cow 클릭");

        //    UP_Scale uP_Scale = hit.collider.GetComponent<UP_Scale>();
        //    uP_Scale.Scaleup(new Vector3(scale, scale, scale));

        //    print("cow 자라라");

        //    GameObject.Find("CowBlW").GetComponent<UP_Scale>().Scaleup(new Vector3(scale, scale, scale));

        }
    }


