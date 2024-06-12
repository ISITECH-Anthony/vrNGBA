using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LeftControllerAnimations : MonoBehaviour
{
    // Import du package OVR

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Quand le bouton "grab" est appuyé sur le controller gauche
        if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryHandTrigger")){
            // LOG 
            Debug.Log("Bouton Grab appuyé sur le controller gauche");
            // On récupère le composant Animator du controller gauche
            Animator animator = GetComponent<Animator>();
            // On déclenche l'animation "Grab" du controller gauche
            animator.SetTrigger("Grab");

        }
    }
}
