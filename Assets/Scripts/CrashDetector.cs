using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deathTime = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = true;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && hasCrashed)
        {
            hasCrashed = false;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("Death", deathTime);
           
            
        }

        

    }
    void Death()
    {
        SceneManager.LoadScene(0);
    }
}
