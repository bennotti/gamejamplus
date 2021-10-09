using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;

    Vector2 shootDirection;
    Vector2 speed;

    //cachedReference

    Rigidbody2D myRigidbody2D;
    Enemy enemy;

    

  


    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        enemy = FindObjectOfType<Enemy>();
        SetShootDirection();
        speed = new Vector2(shootDirection.x * projectileSpeed, shootDirection.y * projectileSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody2D.velocity = speed;
    }

    private void SetShootDirection()
    {
        if (enemy.transform.rotation.z == 0)
        {
            shootDirection = new Vector2(0f, -1f);
        }
        else if (enemy.transform.rotation.z == 90)
        {
            shootDirection = new Vector2(1f, 0f);
        }
        else if (enemy.transform.rotation.z == 180)
        {
            shootDirection = new Vector2(0f, 1f);
        }
        else if (enemy.transform.rotation.z == 270)
        {
            shootDirection = new Vector2(-1f, 0f);
        }
    }

   

}
