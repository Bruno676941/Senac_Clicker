using Unity.VisualScripting;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public Botaodinheiro botaoDinheiro;
    public int precoupgrade = 10;

    public void Comprar()
    {
        if (botaoDinheiro.dinheiro >= precoupgrade)
        {
            botaoDinheiro.dinheiro -= precoupgrade;

            botaoDinheiro.Contadordinheiro.text =
                "Dinheiro: " + botaoDinheiro.dinheiro;
            botaoDinheiro.dinheiroclick += botaoDinheiro.multiplicador;
            precoupgrade += 10;
            botaoDinheiro.Porclick.text = "Click: " + botaoDinheiro.dinheiroclick;
        }
    }
}
