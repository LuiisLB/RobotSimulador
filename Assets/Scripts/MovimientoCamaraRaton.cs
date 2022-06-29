using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamaraRaton : MonoBehaviour
{
    public float speedMH;
    public float speedMV;
    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += speedMH * Input.GetAxis("Mouse X");
        y -= speedMV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(y, x, 0);
    }
}
