using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private Vector3 lastMoveDir;

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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY += 1f;
        }

        // down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY -= 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX -= 1f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveX += 1f;
        }

        bool isIdle = moveX == 0 && moveY == 0;

        if (isIdle)
        {
            // TODO
            // play idle animation
        }
        else
        {
            Vector3 moveDir = new Vector3(moveX, moveY).normalized;
            this.lastMoveDir = moveDir;
            // TODO 
            // play walking animation
            transform.position += moveDir * speed * Time.deltaTime;
        }

        
    }
}
