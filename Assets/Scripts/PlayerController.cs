using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f; // Uygulanacak tork kuvveti
    Rigidbody2D rb2d; // Torku Rigidbody'e uygulayacaðýmýz için rigidbody'i tanýmladýk.
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Sol ok tuþuna basýlýrsa torqueAmount kadar tork uygula.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        //Sað ok tuþuna basýlýrsa torqueAmount kadar tork uygula. Zýt yön olmasýna dikkat!
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
