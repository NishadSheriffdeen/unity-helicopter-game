using UnityEngine;

public class helecopterScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float windStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.linearVelocity = Vector2.up * windStrength;
        }


    }
}
