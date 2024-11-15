using System;
using UnityEngine;

public class helicopterScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float windStrength;
    public LogicScript logic;
    public Boolean helicopterNotDestroyed = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && helicopterNotDestroyed)
        {
            myRigidbody.linearVelocity = Vector2.up * windStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        helicopterNotDestroyed = false;
    }

}
