using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;

    /// <summary>
    /// Player'ýn baþý ile zemin temas ederse...
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", loadDelay); // Invoke methodu ile beraber 1.parametrede belirtilen methoddan sonra loadDelay kadar bekle dedik.
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
