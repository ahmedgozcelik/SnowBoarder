using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    /// <summary>
    /// Player ile finishLine temas ederse...
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishEffect.Play(); // Efekt
            Invoke("ReloadScene", loadDelay); // Delay ekle
        }

        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
