using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    Vector2 moveInput;
    [SerializeField] float moveSpeed = 2f;
    bool isWalking;
    

    //Cached references
    Rigidbody2D myRigidbody;
    Animator myAnimator;



    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerWalk();
        CheckWalk();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        isWalking = true;
    }

    public bool IsPlayerWalking()
    {
        return isWalking;
    }

    public Vector2 GetPlayerDirection()
    {
        return myRigidbody.velocity;
    }

    private void PlayerWalk()
    {
        Vector2 playerVelocity = new Vector2(0f,0f);
        if (moveInput.x != 0)
        {
            playerVelocity = new Vector2(moveInput.x * moveSpeed, 0);
        }

        else if (moveInput.y != 0)
        {
            playerVelocity = new Vector2(0, moveInput.y * moveSpeed);
        }

        myRigidbody.velocity = playerVelocity;
        SetWalkAnimation();
    }

    private void SetWalkAnimation()
    {
        bool playerHasSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon && Mathf.Abs(myRigidbody.velocity.y) > Mathf.Epsilon;
        float playerSpeedX = myRigidbody.velocity.x;
        float playerSpeedY = myRigidbody.velocity.y;

        if (!playerHasSpeed)
        {
            myAnimator.speed = 0f;
        }

        if (Mathf.Abs(playerSpeedX) > 0)
        {
            myAnimator.speed = 1f;
            ResetWalkAnimation();
            transform.localScale = new Vector2(Mathf.Sign(myRigidbody.velocity.x), 1f); //FlipSprite
            myAnimator.SetBool("isWalkingSide", true);
        }

        if (playerSpeedY > 0)
        {
            myAnimator.speed = 1f;
            ResetWalkAnimation();
            myAnimator.SetBool("isWalkingUp", true);
        }

        if (playerSpeedY < 0)
        {
            myAnimator.speed = 1f;
            ResetWalkAnimation();
            myAnimator.SetBool("isWalkingDown", true);
        }

    }

    private void CheckWalk()
    {
        bool playerHasSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon || Mathf.Abs(myRigidbody.velocity.y) > Mathf.Epsilon;
        if (!playerHasSpeed)
        { 
            isWalking = false;
        }

    }

    private void ResetWalkAnimation()
    {
        myAnimator.SetBool("isWalkingSide", false);
        myAnimator.SetBool("isWalkingUp", false);
        myAnimator.SetBool("isWalkingDown", false);
    }
    





}
