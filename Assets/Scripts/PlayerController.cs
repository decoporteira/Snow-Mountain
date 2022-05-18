using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float torqueAmount = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            RotatePlayer();
        }
        ReposdToBoost();
    }
    public void DisableControls()
    {
        canMove = false;
    }
     void ReposdToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            surfaceEffector2D.speed = boostSpeed;

        else
            surfaceEffector2D.speed = baseSpeed;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rb2d.AddTorque(torqueAmount);
        else if (Input.GetKey(KeyCode.RightArrow))
            rb2d.AddTorque(-torqueAmount);


    }
}
