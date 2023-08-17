using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This detects when the character has hit the ground when jumping
/// </summary>
/// <remarks>
/// Used as part of Marco's intense coding training camp
/// This is used <see cref="SamMoves"/>
/// </remarks>
public class groundDetector : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnTriggerEnter(Collider other)
    {
        isGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }
}
