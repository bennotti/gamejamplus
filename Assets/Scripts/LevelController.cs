using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelController : MonoBehaviour
{

    int changingBlocksAmount;
    ChangingBlock[] changingBlocks;
    int winNumber;
    float waitTime = 1f;

    [Header("Canvas de vit?ria e derrota")]
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;

    [Header("Sons")]
    [SerializeField] AudioClip winSound;
    [SerializeField] float winSoundVolume = 1f;
    [SerializeField] AudioClip loseSound;
    [SerializeField] float loseSoundVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        changingBlocks = FindObjectsOfType<ChangingBlock>();
        changingBlocksAmount = changingBlocks.Length;

    }
    

    private void HandleDeath()
    {
        if (!FindObjectOfType<PlayerMovement>())
        {
            StartCoroutine(HandleLoseCondition());
        }

    }


    public IEnumerator HandleLoseCondition()
    {
        
        yield return new WaitForSeconds(waitTime);
        Debug.Log("perdeu");
        loseLabel.SetActive(true);
        AudioSource.PlayClipAtPoint(loseSound, Camera.main.transform.position, loseSoundVolume);
        Time.timeScale = 0;
    }

    public IEnumerator HandleWinCondition()
    {
        InputSystem.DisableAllEnabledActions();
        yield return new WaitForSeconds(waitTime);
        Debug.Log("ganhou");
        winLabel.SetActive(true);
        AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position, winSoundVolume);
        Time.timeScale = 0;
    }



    // Update is called once per frame
    void Update()
    {
        HandleWin();
        HandleDeath();
    }

    private void HandleWin()
    {
        winNumber = 0;

        foreach (ChangingBlock block in changingBlocks)
        {
            winNumber += block.GetChangingBlockStatus();
        }

        if (winNumber == changingBlocksAmount)
        {
            StartCoroutine(HandleWinCondition());
        }
    }
}
