using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader: MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1f;
        Debug.Log(currentSceneIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadCurrentScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Debug.Log(currentSceneIndex);
        Time.timeScale = 1f;
    }
    public void LoadStartScreen()
    {
        SceneManager.LoadScene("MenuInicialScene");
    }

    public void IrParaLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void IrParaLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void IrParaLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void IrParaOpcoes()
    {
        SceneManager.LoadScene("OpcoesScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
