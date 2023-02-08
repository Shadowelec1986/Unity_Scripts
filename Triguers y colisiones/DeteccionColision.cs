using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColision : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject triguer;
    public GameObject bola;
    public GameObject jugador;
    private AudioSource audioSource;

    private bool activated = false;
   

    void Start()
    {
        audioSource = jugador.GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider jugador)
    {
        if (jugador!=null)
        {
            Debug.Log("Entro");
            if (!activated)
            {
                bola.SetActive(true);
                audioSource.Play();
            }


        }
    }

    private void OnTriggerExit(Collider jugador)
    {
        
        if (jugador != null)
        {
            Debug.Log("Salio");
            if (!activated)
            {
                bola.SetActive(false);
                audioSource.Stop();
            }


        }


    }
}

//if (other.tag == "Jugador")