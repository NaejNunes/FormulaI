using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JogoControlador : MonoBehaviour
{
    public GameObject painelInformacoes, painelSair;
    public Text txtPontuacaoAtual;
    public int recorde;
    // Start is called before the first frame update
    void Start()
    {
        recorde = PlayerPrefs.GetInt("Pontos");
    }

    // Update is called once per frame
    void Update()
    {
        txtPontuacaoAtual.text = "" + CarrinhoControlador.PontacaoAtual;
    }

    public void CenaInicio()
    {
        SceneManager.LoadScene("Inicio");            
    }

    public void CenaJogar()
    {
        SceneManager.LoadScene("Jogar"); 
    }

    public void AbrirPainelSair()
    {
        painelSair.SetActive(true);
    }

    public void FecharPainelSair()
    {
        painelSair.SetActive(false);
    }

    public void SairApp()
    {
        Application.Quit();
    }

    public void PainelInformacoes()
    {
        painelInformacoes.SetActive(true);
    }

    public void FecharPainelInformacoes()
    {
        painelInformacoes.SetActive(false);
    }
}
