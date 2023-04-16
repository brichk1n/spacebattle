using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float rotateSpeed = 180;
    private float moveSpeed = 10;
    private float positionCalculating;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        positionCalculating = verticalInput * moveSpeed * Time.deltaTime;
        transform.Translate(Vector2.up * positionCalculating);
        if (positionCalculating < 0f)
        {
            transform.Rotate(Vector3.back * horizontalInput * rotateSpeed * Time.fixedDeltaTime * -1f);
        }
        else
        {
            transform.Rotate(Vector3.back * horizontalInput * rotateSpeed * Time.fixedDeltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        Destroy(gameObject);
    }
}
