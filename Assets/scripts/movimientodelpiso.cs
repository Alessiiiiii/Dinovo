using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientodelpiso : MonoBehaviour
{
    public float offsetX = 17;
    public int velocidadPiso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidadPiso*Time.deltaTime, 0, 0);
        if (transform.position.x <= offsetX)
        {
            transform.position= new Vector3(offsetX,transform.position.y, 0);
        }
    }
}
