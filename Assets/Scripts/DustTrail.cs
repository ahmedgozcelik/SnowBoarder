using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground") // Zemin ile temas ederken dustParticles efektini oynat
        {
            dustParticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Ground") // Zemin ile temas halinde deðilse durdur
        {
            dustParticles.Stop();
        }
    }
}
