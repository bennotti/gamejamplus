using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcoesController : MonoBehaviour
{
    [SerializeField] GameObject btnLigarSom;
    [SerializeField] GameObject btnDesligarSom;

    public void LigarSom()
    {
        btnDesligarSom.SetActive(true);
        btnLigarSom.SetActive(false);
    }
    public void DesligarSom()
    {
        btnLigarSom.SetActive(true);
        btnDesligarSom.SetActive(false);
    }
}
