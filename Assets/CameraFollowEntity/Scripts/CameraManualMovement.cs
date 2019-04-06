using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManualMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float speed = 5f;
        float moveX = 0f;
        float moveY = 0f;

        // up
        if (Input.GetKey(KeyCode.Z))
        {
            moveY += 1f;
        }

        // down
        if (Input.GetKey(KeyCode.S))
        {
            moveY -= 1f;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            moveX -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1f;
        }
        
        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
    }
}
