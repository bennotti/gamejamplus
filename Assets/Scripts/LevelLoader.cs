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
        Time.timeScale = 1f;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadCurrentScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
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

    public void IrParaOpcoes()
    {
        SceneManager.LoadScene("OpcoesScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
