using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrails : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dustEffect;

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Ground")
        { 
        dustEffect.Play();
        Debug.Log("Tocou o chão");
        }


    }
    void OnCollisionExit2D()
    {

        dustEffect.Stop();
        Debug.Log("Soltou do chão");


    }
}
