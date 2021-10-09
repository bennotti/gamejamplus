using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        PlayerMovement playerCollider = otherCollider.gameObject.GetComponent<PlayerMovement>();

        if (playerCollider)
        {
            Destroy(gameObject);
            Destroy(playerCollider.gameObject);
        }
    }



}
