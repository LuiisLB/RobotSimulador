using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarraobjeto : MonoBehaviour
{
    public bool sepuedetomar = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone") 
        {
            other.GetComponentInParent<TomarObjeto>().ObjectToPickup = this.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<TomarObjeto>().ObjectToPickup = null;
        }
    }
}
