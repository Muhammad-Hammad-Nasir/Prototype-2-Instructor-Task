using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    
    void Update()
    {
        LimitPlayerMove();  // keep the player inbounds
        PlayerMovement();
        FoodLauncher();
    }

    void LimitPlayerMove()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void PlayerMovement()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }

    void FoodLauncher()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile form the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
