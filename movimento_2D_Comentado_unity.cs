using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
[SerializeField] // Permite que a variável "speed" seja editada no Inspector do Unity
    private float speed = 3f; // Velocidade máxima do objeto
    private Rigidbody2D rb; // Referência ao componente Rigidbody2D do objeto
    private Vector2 moveDirection; // Direção de movimento do objeto

    // Método chamado quando o objeto é criado

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do objeto atual
    }
    // Método chamado a cada quadro de atualização
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // Lê a entrada do eixo horizontal do jogador
        float vertical = Input.GetAxisRaw("Vertical"); // Lê a entrada do eixo vertical do jogador
        moveDirection = new Vector2(horizontal, vertical); // Atualiza a direção de movimento com base nas entradas do jogador
    }

    // Método chamado a cada quadro fixo de atualização
    private void FixedUpdate()
    {
        Vector3 movePosition = (speed * Time.fixedDeltaTime * moveDirection.normalized) + rb.position; // Calcula a nova posição do objeto com base na direção de movimento e na velocidade máxima
        rb.MovePosition(movePosition); // Move o objeto para a nova posição
    }
}