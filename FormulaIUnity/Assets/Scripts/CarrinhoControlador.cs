using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrinhoControlador : MonoBehaviour
{
    public Transform posicaoEsquerda, posicaoDireita;
    private bool posicaoDir, posicaoEsq;
    public float speed = 0.3f;
    public static int  pontos, PontacaoAtual, pontosFinal;
    public Text txtpontos, txtPontosFinal;
    public bool carrinhoDestruido;
    public GameObject painelFimJogo, painelRecorde;
    public AudioClip efeitoPontos;

    // Start is called before the first frame update
    void Start()
    {
        painelRecorde.SetActive(false);
        painelFimJogo.SetActive(false);

        carrinhoDestruido = false;

        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtpontos.text = "" + pontos;
        txtPontosFinal.text = "" + pontos;
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position != posicaoDireita.position)
            {
                Vector2 p = Vector2.MoveTowards(transform.position, posicaoDireita.position, speed);
                GetComponent<Rigidbody2D>().MovePosition(p);
            }

            Vector2 dirDirs = posicaoDireita.position - transform.position;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position != posicaoEsquerda.position)
            {
                Vector2 p = Vector2.MoveTowards(transform.position, posicaoEsquerda.position, speed);
                GetComponent<Rigidbody2D>().MovePosition(p);
            }

            Vector2 dirEsq = posicaoEsquerda.position - transform.position;
        }
    }

    public void BotaoDireita()
    {
        if (transform.position != posicaoDireita.position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, posicaoDireita.position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        Vector2 dirDirs = posicaoDireita.position - transform.position;
    }

    public void BotaoEsquerda()
    {
        if (transform.position != posicaoEsquerda.position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, posicaoEsquerda.position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        Vector2 dirEsq = posicaoEsquerda.position - transform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CarrinhoAdversario"))
        {
            pontosFinal = pontos;
            SalvarPontos();
            painelFimJogo.SetActive(true);
            carrinhoDestruido = true;
        }

        if (collision.gameObject.CompareTag("Pontuar"))
        {
            AudioSource.PlayClipAtPoint(efeitoPontos, Camera.main.transform.position * Time.deltaTime);

            pontos++;
        }
    }

    public void SalvarPontos()
    {
        if (pontos > PontacaoAtual)
        {
            painelRecorde.SetActive(true);
            PontacaoAtual = pontos;
            PlayerPrefs.SetInt("pontos", PontacaoAtual);
        }
    }
}
