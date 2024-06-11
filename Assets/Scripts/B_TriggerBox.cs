using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Quand un objet entre dans le trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<XRGrabInteractable>().isSelected == false) {
            // On Change la couleur de l'objet
            other.GetComponent<Renderer>().material.color = Color.blue;
            // On fait en sorte de plus pouvoir le bouger 
            other.GetComponent<XRGrabInteractable>().enabled = false;
            // On joue le son
            other.GetComponent<AudioSource>().Play();
            // On supprime le son
            // Destroy(other.GetComponent<AudioSource>(), 1);
        }

    }
}
