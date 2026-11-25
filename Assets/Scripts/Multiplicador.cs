using Unity.VisualScripting;
using UnityEngine;

public class Multiplicador : MonoBehaviour
{
    public Botaodinheiro botaoDinheiro;
    public int precoupgrade = 1000;

    bool multiplicadorm = false;

    public void Comprar()
    {
        if (!multiplicadorm && botaoDinheiro.dinheiro >= precoupgrade)
        {
            botaoDinheiro.dinheiro -= precoupgrade;

            botaoDinheiro.multiplicador = 10;

            multiplicadorm = true;

            Debug.Log(gameObject.name);
            gameObject.SetActive(false);
        }
    }
}