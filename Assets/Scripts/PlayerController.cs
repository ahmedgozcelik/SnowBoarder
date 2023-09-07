using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f; // Uygulanacak tork kuvveti
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;

    Rigidbody2D rb2d; // Torku Rigidbody'e uygulayaca��m�z i�in rigidbody'i tan�mlad�k.
    SurfaceEffector2D surfaceEffector2D; // SurfaceEffector'u tan�mlad�k.

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RotatePlayer()
    {
        //Sol ok tu�una bas�l�rsa torqueAmount kadar tork uygula.
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        //Sa� ok tu�una bas�l�rsa torqueAmount kadar tork uygula. Z�t y�n olmas�na dikkat!
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }// Player d�nd�rme - tork ile

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
