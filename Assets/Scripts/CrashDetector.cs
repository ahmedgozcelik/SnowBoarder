using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    public GameControl gameControl;

    bool hasCrashed = false;

    /// <summary>
    /// Player'ýn baþý ile zemin temas ederse...
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground" & !hasCrashed)
        {
            hasCrashed = true;
            FindAnyObjectByType<PlayerController>().DisableControls();
            crashEffect.Play(); // Efekt oynasýn
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay); // Invoke methodu ile beraber 1.parametrede belirtilen methoddan sonra loadDelay kadar bekle dedik.

            gameControl.OpenGameOverPanel();
        }
    }




    //void ReloadScene()
    //{
    //    SceneManager.LoadScene(0);
    //}
}
