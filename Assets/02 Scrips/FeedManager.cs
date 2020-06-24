using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedManager : MonoBehaviour
{
    //Ray ray = new Ray();
    RaycastHit hit;
    int FloorMask;
    int buttonMask;
    public GameObject feedObj;
    public GameObject SELLObj;
    Animator truckAnim;
    AudioSource audio;
   
    // Start is called before the first frame update
    void Start()
    {
        FloorMask = LayerMask.GetMask("Floor");
        buttonMask = LayerMask.GetMask("Button");
        truckAnim = SELLObj.GetComponent<Animator>();
        audio = SELLObj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //ray.origin = transform.position;
            //ray.direction = transform.forward;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100, FloorMask))
            {
                Vector3 hitPos = hit.point;
                
                GameObject item = Instantiate(feedObj);

                item.transform.position = hitPos;

            }

            if (Physics.Raycast(ray, out hit, 100, buttonMask))
            {
                print("Ray");
                truckAnim.SetBool("Go", true);
                audio.Play();
                print("go");
                Market market = SELLObj.GetComponent<Market>();
                
                market.CoinUp();

                Invoke("StopAnim", 4);
               

            }
          
        }

      

    }

    void StopAnim()
    {
        truckAnim.SetBool("Go", false);
    }
  
}
