using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeCarrinhos : MonoBehaviour
{
    public int quantidadeCarrinho;

    // Start is called before the first frame update
    void Start()
    {
        quantidadeCarrinho = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(quantidadeCarrinho);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CarrinhoAdversario"))
        {
            quantidadeCarrinho++;
        }
    }
}
