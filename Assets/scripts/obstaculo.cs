using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float velocidadX;

   public static float VelocidadExtra;
    // Start is called before the first frame update
    void Start()
    {
        velocidadX = 0.08f+VelocidadExtra;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-velocidadX, 0, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
