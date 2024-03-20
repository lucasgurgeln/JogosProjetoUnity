using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{

    public AudioSource CoinSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            CoinSound.Play();
            FindObjectOfType<GameController>().MoedaColetada(); 
            gameObject.SetActive(false); 
        }
    }
}
