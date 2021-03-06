using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{

    bool playerDead;
    [SerializeField] ParticleSystem deathVFXPrefab;

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
           Instantiate(deathVFXPrefab, playerCollider.transform.position, Quaternion.identity);
           Destroy(playerCollider.gameObject);
           Destroy(gameObject);
           playerDead = true;
        }
    }


    public bool isPlayerDead()
    {
        return playerDead;
    }


  


}
