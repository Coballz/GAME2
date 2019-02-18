using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(dx, 0.0f, dy);
        movement = Vector3.Normalize(movement) * movementSpeed;

        rb.MovePosition(transform.position + movement * Time.deltaTime);
    }
}
