using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBlock : MonoBehaviour
{


    [SerializeField] Sprite[] changingBlocksSprites;
    int currentBlockIndex;

    //cache reference
    SpriteRenderer mySpriteRenderer;
    int myLayer;
    BoxCollider2D playerFeetCollider;


    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        currentBlockIndex = 0;
        SetBlock();

    }

    private void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (currentBlockIndex == 0)
        {
            currentBlockIndex = 1;
            SetBlock();
        }

        else if (currentBlockIndex == 1)
        {
            currentBlockIndex = 0;
            SetBlock();
        }
    }

    private void SetBlock()
    {
        mySpriteRenderer.sprite = changingBlocksSprites[currentBlockIndex];
    }


    public int GetChangingBlockStatus()
    {
        return currentBlockIndex;
    }

}
