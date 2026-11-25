using TMPro;
using UnityEngine;
using System.Collections;

public class Botaodinheiro : MonoBehaviour
{
    public TextMeshProUGUI Contadordinheiro;
    public TextMeshProUGUI Porclick;
    public TextMeshProUGUI Porsegundo;
    public int dinheiro = 0;
    public int dinheiroclick = 1;
    public int dinheirosec = 0;
    public int multiplicador = 1;
    public void Start()
    {
        Ganhardinheiro();
        StartCoroutine(gerardinheiro());
    }
    public void Ganhardinheiro()
    {
        dinheiro += dinheiroclick;
        Debug.Log("Dinheiro: " + dinheiro);
        Contadordinheiro.text = "Dinheiro: " + dinheiro;
        Porclick.text = "Click: " + dinheiroclick;
        Porsegundo.text = "Dinheiro/s: " + dinheirosec;
    }
    IEnumerator gerardinheiro()
    {
        while (true)
        {
            dinheiro += dinheirosec;

            Contadordinheiro.text = "Dinheiro: " + dinheiro;

            yield return new WaitForSeconds(1f);
        }
    }
}