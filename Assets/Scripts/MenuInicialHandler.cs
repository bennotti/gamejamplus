using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInicialHandler : MonoBehaviour
{
    public void Awake()
    {
        var btnIniciar = GameObject.Find("/Canvas/Iniciar").GetComponent<Button>();
        var btnOpcoes = GameObject.Find("/Canvas/Opcoes").GetComponent<Button>();

        btnIniciar.onClick.AddListener(delegate { IrParaGameScene(); });
        btnOpcoes.onClick.AddListener(delegate { IrParaOpcoes(); });

        Debug.Log("ok");
    }

    void IrParaGameScene()
    {
        Loader.Load(Loader.Scene.GameScene);
        Debug.Log("ok");
    }

    void IrParaOpcoes()
    {
        Loader.Load(Loader.Scene.OpcoesScene);
        Debug.Log("ok");
    }
}
