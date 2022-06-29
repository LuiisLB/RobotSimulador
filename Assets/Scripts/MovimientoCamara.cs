using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform objetivoAseguir;
    private float distanciaobjetivo = 0f;
    private float velocidadCamara = 0f;
    public bool suavizado = false;
    private Vector3 nuevaposicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nuevaposicion = this.transform.position;
        nuevaposicion.x = objetivoAseguir.transform.position.x - distanciaobjetivo;
        nuevaposicion.z = objetivoAseguir.transform.position.z;
        nuevaposicion.y = objetivoAseguir.transform.position.y+1.224f;

        if(suavizado)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, nuevaposicion, velocidadCamara * Time.deltaTime);
        }
        else
        {
            this.transform.position = nuevaposicion;
        }
    }
}
