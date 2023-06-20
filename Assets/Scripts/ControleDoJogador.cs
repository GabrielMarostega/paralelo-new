using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;
    public float velocidadeDaNave;
    public GameObject laserDoJogador;
    public Transform localDoDisparoUnico;
    private Vector2 teclasApertadas;
    public bool podeDisparar = true;
    
    public float tempoEntreTiros;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
        AtirarLaser();
    }

    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDaNave;
    }

    private void AtirarLaser()
    {
        if(Input.GetButtonDown("Fire1")&& podeDisparar ==  true)
        {
            podeDisparar = false;
            Instantiate(laserDoJogador, localDoDisparoUnico.position, localDoDisparoUnico.rotation);
            Invoke("CDTiros", tempoEntreTiros);

        }
    }
        void CDTiros(){

        podeDisparar = true;
            


        }


}
 