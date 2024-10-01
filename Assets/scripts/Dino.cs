using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour

{
    public Rigidbody2D rbBody;
    public GameObject gameover;
    int fuerza;
    // Start is called before the first frame update
    void Start()
    {
        fuerza = 10;
        NewBehaviourScript.VelocidadExtra = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbBody.velocity = Vector2.up * fuerza;
            this.enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameover.SetActive(true);
        Destroy(this.gameObject);
    }
}