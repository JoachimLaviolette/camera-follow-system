using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Transform playerTransform;
    public Transform enemy1Transform;
    public Transform enemy2Transform;
    public Transform manualMovementTransform;

    // Start is called before the first frame update
    void Start()
    {
        this.cameraFollow.Setup(() => playerTransform.position);
    }

    public void FollowPlayer()
    {
        this.cameraFollow.SetGetCameraFollowPosition(() => playerTransform.position);
    }

    public void FollowEnemy1()
    {
        this.cameraFollow.SetGetCameraFollowPosition(() => enemy1Transform.position);
    }

    public void FollowEnemy2()
    {
        this.cameraFollow.SetGetCameraFollowPosition(() => enemy2Transform.position);
    }

    public void FollowManual()
    {
        this.cameraFollow.SetGetCameraFollowPosition(() => manualMovementTransform.position);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
