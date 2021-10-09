using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    int changingBlocksAmount;
    ChangingBlock[] changingBlocks;
    int winNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        changingBlocks = FindObjectsOfType<ChangingBlock>();
        changingBlocksAmount = changingBlocks.Length;

    }

    // Update is called once per frame
    void Update()
    {
        winNumber = 0;

        foreach (ChangingBlock block in changingBlocks)
        {
            winNumber += block.GetChangingBlockStatus();
        }

        if (winNumber == changingBlocksAmount)
        {
            //Aqui dentro vai tudo que acontece quando ganha o jogo
            Debug.Log("WIN!");
        }
        

    }
}
