using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragEvent : MonoBehaviour
{
    Rigidbody PaRig;

    // Start is called before the first frame update
    void Start()
    {
        PaRig = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(Input.GetTouch(0).deltaPosition * Time.deltaTime * 0.1f);
    }


    float distance = 10;
        void OnMouseDrag()
        {
            print("Drag!!");
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
            PaRig.isKinematic = true;

        }

    private void OnMouseUp()
    {
        PaRig.isKinematic = false;

    }



    //Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
    ////마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
    //this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

}
