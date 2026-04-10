using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class NetAction : MonoBehaviour
{
    public bool isFast = false;
    public bool isLarge = false;

    public float speedDefault;
    public float speedFast;
    public float sizeDefault;
    public float sizeLarge;

    public InputActionReference interactButton; // MAKE new button for slinging net
    private bool isNearby;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // or try if (other.CompareTag("Player") || other.CompareTag("Agent"))
        {
            isNearby = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearby = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactButton.action.triggered)
        {
            // Turn on net hitbox
            // Wait
            if (isNearby)
            {
                
            }
            // Turn off net hitbox
        }
    }
}
