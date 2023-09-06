using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f; // Uygulanacak tork kuvveti
    Rigidbody2D rb2d; // Torku Rigidbody'e uygulayaca��m�z i�in rigidbody'i tan�mlad�k.
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Sol ok tu�una bas�l�rsa torqueAmount kadar tork uygula.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        //Sa� ok tu�una bas�l�rsa torqueAmount kadar tork uygula. Z�t y�n olmas�na dikkat!
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
