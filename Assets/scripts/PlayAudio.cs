using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource audio; //Variavel

    private void Start() //Tudo o q tiver dentro do alwake significa q ele comeca fazer os objetos
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnMouseDown() // Ação ao clicar com o mouse
    {
        audio.Play();
    }
}

/* Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        LOOPING quando ele colidir com algum objeto vai adicionar uma forca no objeto, trombo no player??
        até trombar
    }

*/