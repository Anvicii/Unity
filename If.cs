using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{

    public int n1;
    public int n2;
    public int n3;
    public bool valor;
    // Start is called before the first frame update

   //faça um algoritmo que imprima se o número for positivo, negativo ou 0
    void Start()
    {
        if (0 > n2) 
        {
            Debug.Log("negativo");
        }
        else if (0 < n2)
        {
            Debug.Log("positivo");
        }
        else
        {
            Debug.Log("zero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
