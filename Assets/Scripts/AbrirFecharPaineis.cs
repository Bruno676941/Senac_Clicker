using Unity.VisualScripting;
using UnityEngine;

public class AbrirFecharPaineis : MonoBehaviour
{
    public GameObject Canva;
    public GameObject layoutdarecepcao;

    void Start()
    {
        layoutdarecepcao.SetActive(true);
        Canva.SetActive(false);
    }

    void Update()
    {
        AbrirPainelEFechaPainel();
    }
    void AbrirPainelEFechaPainel()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            layoutdarecepcao.SetActive(!layoutdarecepcao.activeSelf);
            Canva.SetActive(!Canva.activeSelf);
        }

    }
         
}
