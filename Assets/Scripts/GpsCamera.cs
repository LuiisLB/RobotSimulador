using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GpsCamera : MonoBehaviour
{
    public Transform player;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 newpoosition = this.player.position;

        newpoosition.y = transform.position.y;
        transform.position = newpoosition;
    }
}
