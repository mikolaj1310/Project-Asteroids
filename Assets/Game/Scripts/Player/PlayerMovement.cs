using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float maxVelocity;

    private float hVal, vVal;

    private void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        hVal = 0; 
        vVal = 0;
        if (Input.GetButton("Horizontal"))
        {
            hVal = Input.GetAxisRaw("Horizontal");
        }
        if (Input.GetButton("Vertical"))
        {
            vVal = Input.GetAxisRaw("Vertical");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity += new Vector2(hVal, vVal) * speed * Time.deltaTime;
        body.velocity = Vector2.ClampMagnitude(body.velocity, maxVelocity);
    }
}
