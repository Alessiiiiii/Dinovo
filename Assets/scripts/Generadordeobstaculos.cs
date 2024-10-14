using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generadordeobstaculos : MonoBehaviour
{

    public GameObject[] prefapcactus;
    // Start is called before the first frame update
    void Start()
    {
        Generar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Generar()
    {
        NewBehaviourScript.VelocidadExtra += 0.04f;
        int seleccionado = Random.Range(0,3);
        Instantiate(prefapcactus[seleccionado]);

        float tiempoAleatorio = Random.Range(2f, 5f);

        Invoke("Generar", tiempoAleatorio);
    }

}
