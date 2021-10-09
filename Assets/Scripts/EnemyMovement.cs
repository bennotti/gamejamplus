using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] float minMoveSpeed = 2f;
    [SerializeField] float maxMoveSpeed = 5f;
    Vector2 moveInput;

    //cachedReference
    PlayerMovement player;
    Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyWalk();
    }

    private void EnemyWalk()
    {
        if (player.IsPlayerWalking())
        {
            float moveSpeed = Random.Range(minMoveSpeed, maxMoveSpeed);
            moveInput.x = player.GetPlayerDirection().x * moveSpeed;
            moveInput.y = player.GetPlayerDirection().y * moveSpeed;
        }

        if (!player.IsPlayerWalking())
        {
            moveInput= new Vector2(0f, 0f);
        }

        myRigidbody.velocity = moveInput;

    }


}
