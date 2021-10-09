using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicialHandler : MonoBehaviour
{
    public void Awake()
    {
        var a = transform.Find("Iniciar");
        Debug.Log("ok");
    }
}
