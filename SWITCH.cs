using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWITCH : MonoBehaviour
{

    public int DiasDaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (DiasDaSemana)
        {
            case 1:
                Debug.Log("domingo");
                break;
            case 2:
                Debug.Log("segunda");
                break;
            case 3:
                Debug.Log("Terça");
                break;
            case 4:
                Debug.Log("Quarta");
                break;
            case 5:
                Debug.Log("Quinta");
                break;
            case 6:
                Debug.Log("Sexta");
                break;
            case 7:
                Debug.Log("Sabado");
                break;

            default:
                Debug.Log("Fora de data ein");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
