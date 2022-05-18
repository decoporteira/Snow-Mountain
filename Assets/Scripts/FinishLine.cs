using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadTime = 1.5f;
    [SerializeField] ParticleSystem finishEffect;
    bool win = true;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && win == true)
        {
            win = false;
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Reload", loadTime);
            
        }   
        
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
