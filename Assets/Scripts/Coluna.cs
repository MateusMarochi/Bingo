using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coluna : MonoBehaviour
{
    public int numInicial;

    void Start()
    {
        //Transform[] filhos = GetComponentsInChildren<Transform>(); 
        // Debug.Log(filhos.Length);

        int numAtual = numInicial;

        for (int i = 0; i < 15; i++)
        {
            Bolinha bolinha = transform.GetChild(i).GetComponent<Bolinha>();

            if (bolinha != null)
            {
                bolinha.SetNumero(numAtual.ToString());
                numAtual++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
