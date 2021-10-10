using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCanvasController : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] GameObject btnContinuar;
    [SerializeField] GameObject btnTelaInicial;

    public void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1f;

        if (currentSceneIndex == 5)
        {
            btnTelaInicial.SetActive(true);
            btnContinuar.SetActive(false);
        } else
        {
            btnTelaInicial.SetActive(false);
            btnContinuar.SetActive(true);
        }
    }
}
