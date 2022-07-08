using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float rotationSpeed;
    
    public Animator animator;

    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal"); // Raw movement for left and right
        float verticalInput = Input.GetAxisRaw("Vertical"); // Raw movement for up and down

        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(moveDirection.magnitude);
        moveDirection.Normalize();

        transform.Translate(moveDirection * playerSpeed * inputMagnitude * Time.deltaTime, Space.World);


        animator.SetFloat("Speed", Mathf.Abs(inputMagnitude)); // Checks speed to toggle between idle animation and moving animation


        if (moveDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, moveDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        if (inputMagnitude == 0)
        {
            Vector3 mouseScreen = Input.mousePosition;
            Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);

            transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg - 90);
        }
        

    }
}
