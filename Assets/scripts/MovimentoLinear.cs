using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLinear : MonoBehaviour
{
    private Rigidbody2D rb2d; //Variavel
    public float force;
    
    private void Awake() //Tudo o q tiver dentro do alwake significa q ele comeca fazer os objetos
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
      
    private void OnMouseDown() // Ação ao clicar com o mouse
    {
        rb2d.AddForce(transform.right * force); //Empurrão na bola, vetor representa um ponto no espaço
    }
}
