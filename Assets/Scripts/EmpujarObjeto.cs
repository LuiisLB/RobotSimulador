using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujarObjeto : MonoBehaviour
{
    public float fuezaempuje = 2.0f;
    private float Calcularmasa;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if(body==null||body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y < -0.3) 
        {
            return;
        }
        Calcularmasa = body.mass;
        Vector3 DireccionEmpuje = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = DireccionEmpuje * fuezaempuje / Calcularmasa;
    }
}
