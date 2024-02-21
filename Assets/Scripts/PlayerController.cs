using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 10.0f;
    [SerializeField]
    private float TurnSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // Retrieve Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the player forward based on Input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        // Rotate the player based on input
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
