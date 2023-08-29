using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public int speed;

    float eixoX;
    float eixoZ;

    Vector3 direcao;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Os Imputs valem 1, entao quando apertar uma tecla ele ta fazendo meu eixo ficar com +1 ou -1
        eixoX = Input.GetAxisRaw("Horizontal");
        eixoZ =  Input.GetAxisRaw("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);

        //Fazendo a anima��o funcionar quando corro (quando meu vector 3 (qualquer eixo) sai de zero)
        if (direcao != Vector3.zero)
        {
            //Pegando o componente que esta no jogador, buscando uma variavel bool nele e setando que ela � true se o vector sair de zero.
            GetComponent<Animator>().SetBool("Movendo", true);
        }
        else
        {
            //Voltando a false se parar de se mover.
            GetComponent<Animator>().SetBool("Movendo", false);
        }

    }

    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().MovePosition PEGANDO A POSI��O DE MOVIMENTO DO PERSONAGEM
        //(direcao * speed * Time.deltaTime) � A DIRE��O QUE QUERO DAR AO MEU PERSONAGEM, � O OBJETIVO DELE, SE MOVER NESSA DIRE��O
        //transform.position + (direcao * speed * Time.deltaTime)); ENTAO PEGO O TRANSFORM.POSITION DO PERSONAGEM E ADICIONO A DIRE��O QUE � O VECTOR 3 DIRECAO

        //To pegando meu rigidBody e movendo ele para uma posi��o (GetComponent<Rigidbody>().MovePosition), que posi��o?  
        //A posi��o que o Rigidbody ja esta (GetComponent<Rigidbody>().position)
        //Somado com a dire��o que eu quero me mover (direcao * speed * Time.deltaTime)

        //Movimenta��o do jogador por segundo
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (direcao * speed * Time.deltaTime));
    }
}
