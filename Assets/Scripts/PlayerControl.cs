using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public int speed;

    
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //Os Imputs valem 1, entao quando apertar uma tecla ele ta fazendo meu eixo ficar com +1 ou -1
        float eixoX = Input.GetAxisRaw("Horizontal");
        float eixoZ =  Input.GetAxisRaw("Vertical");
        float eixoY = Input.GetAxisRaw("Jump");

        Vector3 direcao = new Vector3(eixoX, eixoY, eixoZ);

        transform.Translate(direcao * speed * Time.deltaTime);

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
}
