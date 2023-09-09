using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 0.1f; // Uygulanacak tork kuvveti
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 0f;


    Rigidbody2D rb2d; // Torku Rigidbody'e uygulayaca��m�z i�in rigidbody'i tan�mlad�k.
    SurfaceEffector2D surfaceEffector2D; // SurfaceEffector'u tan�mlad�k.
    bool canMove = true;
    float timeCounter = 0.0f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            //RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A)) //Sol ok tu�una bas�l�rsa torqueAmount kadar tork uygula. 
        {
            rb2d.AddTorque(torqueAmount);

            timeCounter += Time.deltaTime;
            if(timeCounter >= 0.3f)
            {
                surfaceEffector2D.speed--;
                timeCounter = 0.0f;
            }
        }
        else if (Input.GetKey(KeyCode.D)) //Sa� ok tu�una bas�l�rsa torqueAmount kadar tork uygula. Z�t y�n olmas�na dikkat!
        {
            rb2d.AddTorque(-torqueAmount);

            timeCounter += Time.deltaTime;
            if (timeCounter >= 0.3f)
            {
                surfaceEffector2D.speed++;
                timeCounter = 0.0f;
            }
        }
        else
        {
            timeCounter += Time.deltaTime;
            if (timeCounter >= 0.8f && surfaceEffector2D.speed > 0)
            {
                surfaceEffector2D.speed--;
                timeCounter = 0.0f;
            }
        }
    }// Player d�nd�rme - tork ile

    //void RespondToBoost()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        surfaceEffector2D.speed = boostSpeed;
    //    }
    //    else if (Input.GetKey(KeyCode.S))
    //    {
    //        surfaceEffector2D.speed = slowSpeed;
    //    }
    //    else
    //    {
    //        surfaceEffector2D.speed = baseSpeed;
    //    }
    //}
}
