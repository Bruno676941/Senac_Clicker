using Unity.VisualScripting;
using UnityEngine;

public class Geradorporsegundo : MonoBehaviour
{
    public Botaodinheiro botaoDinheiro;
    public int precoupgrade = 15;

    public void Comprar()
    {
        if (botaoDinheiro.dinheiro >= precoupgrade)
        {
            botaoDinheiro.dinheiro -= precoupgrade;

            botaoDinheiro.dinheirosec += 1;

            precoupgrade += 10  ;
            botaoDinheiro.Porsegundo.text = "Dinheiro/s: " + botaoDinheiro.dinheirosec;
        }
    }
}
