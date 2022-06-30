using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TomarObjeto : MonoBehaviour
{
    public GameObject ObjectToPickup;
    public GameObject pickedObject;
    public Transform InteractionZone;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
                SceneManager.LoadScene("MenuPrincipal");
            
        }
        if(ObjectToPickup!=null&&ObjectToPickup.GetComponent<Agarraobjeto>().sepuedetomar==true&&pickedObject==null)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                pickedObject = ObjectToPickup;
                pickedObject.GetComponent<Agarraobjeto>().sepuedetomar = false;
                pickedObject.transform.SetParent(InteractionZone);
                pickedObject.transform.position = InteractionZone.position;
                pickedObject.GetComponent<Rigidbody>().useGravity = false;
                pickedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
            
        }
        else if (pickedObject != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                pickedObject.GetComponent<Agarraobjeto>().sepuedetomar = true;
                pickedObject.transform.SetParent(null);

                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject = null;
            }


        }
    }
}
