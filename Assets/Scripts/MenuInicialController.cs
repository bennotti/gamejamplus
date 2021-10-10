using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInicialController : MonoBehaviour
{
    [SerializeField] GameObject btnLigarSom;
    [SerializeField] GameObject btnDesligarSom;
    [SerializeField] GameObject som;

    public void LigarSom()
    {
        btnDesligarSom.SetActive(true);
        btnLigarSom.SetActive(false);
        som.GetComponent<AudioSource>().Play();
    }
    public void DesligarSom()
    {
        btnLigarSom.SetActive(true);
        btnDesligarSom.SetActive(false);
        som.GetComponent<AudioSource>().Stop();
    }
}
