using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    float scale = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        UP_Scale uP_Scale = GetComponent<UP_Scale>();
        uP_Scale.Scaleup(new Vector3(scale,scale,scale));
    }
}
