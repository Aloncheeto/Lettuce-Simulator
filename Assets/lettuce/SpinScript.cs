using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    [SerializeField]
    float rot;
    [SerializeField]
    Vector3 rotdirection = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rot >= 360)
        {
            rot = 0;
        }
        transform.Rotate(rot * rotdirection * Time.deltaTime);
    }
}
