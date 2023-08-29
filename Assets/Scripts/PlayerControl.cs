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

        //Fazendo a animação funcionar quando corro (quando meu vector 3 (qualquer eixo) sai de zero)
        if (direcao != Vector3.zero)
        {
            //Pegando o componente que esta no jogador, buscando uma variavel bool nele e setando que ela é true se o vector sair de zero.
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
        //GetComponent<Rigidbody>().MovePosition PEGANDO A POSIÇÃO DE MOVIMENTO DO PERSONAGEM
        //(direcao * speed * Time.deltaTime) É A DIREÇÃO QUE QUERO DAR AO MEU PERSONAGEM, É O OBJETIVO DELE, SE MOVER NESSA DIREÇÃO
        //transform.position + (direcao * speed * Time.deltaTime)); ENTAO PEGO O TRANSFORM.POSITION DO PERSONAGEM E ADICIONO A DIREÇÃO QUE É O VECTOR 3 DIRECAO

        //To pegando meu rigidBody e movendo ele para uma posição (GetComponent<Rigidbody>().MovePosition), que posição?  
        //A posição que o Rigidbody ja esta (GetComponent<Rigidbody>().position)
        //Somado com a direção que eu quero me mover (direcao * speed * Time.deltaTime)

        //Movimentação do jogador por segundo
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (direcao * speed * Time.deltaTime));
    }
}
