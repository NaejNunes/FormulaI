using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDeCarrinhos : MonoBehaviour
{
    public GameObject carrinho, sinalPista;
    private int opcaoCarrinho;
    public static float posicaoX, posicaoY;
    public float tempoCriacaoCarrinho, tempoCriacaoAtribuido, tempoCriacaoSinal, tempoCriacaoSinalAtribuido;
    public CarrinhoControlador carrinhoControlador;
    public CarrinhoAdiversario carrinhoAdversario;
    public ContadorDeCarrinhos contadorDeCarrinhos;
    public SinalChao sinalChao;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        posicaoX = transform.position.x;
        posicaoY = transform.position.y;

        tempoCriacaoCarrinho -= Time.deltaTime;
        tempoCriacaoSinal -= Time.deltaTime;

        if (tempoCriacaoCarrinho <= 0)
        {
            CriandoCarrinho();
            tempoCriacaoCarrinho = tempoCriacaoAtribuido;                   
        }

        if (tempoCriacaoSinal <= 0)
        {
            Instantiate(this.sinalPista, new Vector2(ControladorDeCarrinhos.posicaoX, ControladorDeCarrinhos.posicaoY), Quaternion.identity);
            tempoCriacaoSinal = tempoCriacaoSinalAtribuido;
        }
        ControleDeLevel();

        if (carrinhoControlador.carrinhoDestruido == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //CRIA OS CARRINHO NA TELA
    public void CriandoCarrinho()
    {
        opcaoCarrinho = Random.Range(0, 2);

        switch (opcaoCarrinho)
        {
            case 0:
                Instantiate(this.carrinho, new Vector2(ControladorDeCarrinhos.posicaoX + 1.3f, ControladorDeCarrinhos.posicaoY + 6f), Quaternion.identity);
                break;

            case 1:
                Instantiate(this.carrinho, new Vector2(ControladorDeCarrinhos.posicaoX - 1.3f, ControladorDeCarrinhos.posicaoY + 6f), Quaternion.identity);
                break;
        }
    }

    //FUNÇÃO QUE CONTROLA A VELOCIDADE E O TEMPO DE CRIAÇÃOS DOS CARRINHO.
    public void ControleDeLevel()
    {
        if (contadorDeCarrinhos.quantidadeCarrinho <= 9)
        {
            sinalChao.velocidadeSinal = 6f;
            carrinhoAdversario.velocidadeAdversario = 4;
            tempoCriacaoAtribuido = 1.3f;
            tempoCriacaoSinalAtribuido = 1f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 10)
        {
            tempoCriacaoAtribuido = 2f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho >= 10 && contadorDeCarrinhos.quantidadeCarrinho <= 19)
        {
            sinalChao.velocidadeSinal = 7f;
            carrinhoAdversario.velocidadeAdversario = 5;
            tempoCriacaoAtribuido = 1.0f;
            tempoCriacaoSinalAtribuido = 0.9f;

        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 20)
        {
            tempoCriacaoAtribuido = 1.5f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 20 && contadorDeCarrinhos.quantidadeCarrinho <= 29)
        {
            sinalChao.velocidadeSinal = 8f;
            carrinhoAdversario.velocidadeAdversario = 6;
            tempoCriacaoAtribuido = 0.8f;
            tempoCriacaoSinalAtribuido = 0.7f;

        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 30)
        {
            tempoCriacaoAtribuido = 1.1f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 30 && contadorDeCarrinhos.quantidadeCarrinho <= 39)
        {
            sinalChao.velocidadeSinal = 9f;
            carrinhoAdversario.velocidadeAdversario = 7;
            tempoCriacaoAtribuido = 0.7f;
            tempoCriacaoSinalAtribuido = 0.6f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 40)
        {
            tempoCriacaoAtribuido = 0.9f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 40 && contadorDeCarrinhos.quantidadeCarrinho <= 49)
        {
            sinalChao.velocidadeSinal = 10f;
            carrinhoAdversario.velocidadeAdversario = 8;
            tempoCriacaoAtribuido = 0.6f;
            tempoCriacaoSinalAtribuido = 0.5f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 50)
        {
            tempoCriacaoAtribuido = 0.7f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 50 && contadorDeCarrinhos.quantidadeCarrinho <= 59)
        {
            sinalChao.velocidadeSinal = 11f;
            carrinhoAdversario.velocidadeAdversario = 9;
            tempoCriacaoAtribuido = 0.5f;
            tempoCriacaoSinalAtribuido = 0.4f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 60)
        {
            tempoCriacaoAtribuido = 0.6f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 60 && contadorDeCarrinhos.quantidadeCarrinho <= 69)
        {
            sinalChao.velocidadeSinal = 12f;
            carrinhoAdversario.velocidadeAdversario = 9;
            tempoCriacaoAtribuido = 0.5f;
            tempoCriacaoSinalAtribuido = 0.4f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 70)
        {
            tempoCriacaoAtribuido = 0.6f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho > 70 && contadorDeCarrinhos.quantidadeCarrinho <= 79)
        {
            sinalChao.velocidadeSinal = 13f;
            carrinhoAdversario.velocidadeAdversario = 10;
            tempoCriacaoAtribuido = 0.5f;
            tempoCriacaoSinalAtribuido = 0.4f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 80)
        {
            tempoCriacaoAtribuido = 0.7f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho >= 81 && contadorDeCarrinhos.quantidadeCarrinho <= 99)
        {
            sinalChao.velocidadeSinal = 14f;
            carrinhoAdversario.velocidadeAdversario = 11;
            tempoCriacaoAtribuido = 0.4f;
            tempoCriacaoSinalAtribuido = 0.3f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho == 100)
        {
            tempoCriacaoAtribuido = 0.7f;
        }

        else if (contadorDeCarrinhos.quantidadeCarrinho >= 100 && contadorDeCarrinhos.quantidadeCarrinho >= 120)
        {
            sinalChao.velocidadeSinal = 15f;
            carrinhoAdversario.velocidadeAdversario = 13;
            tempoCriacaoAtribuido = 0.4f;
            tempoCriacaoSinalAtribuido = 0.3f;
        }

    }
}
