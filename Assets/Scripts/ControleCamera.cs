using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    public GameObject jogador;

    Vector3 distCompensar;

    // Start is called before the first frame update
    void Start()
    {
        distCompensar = transform.position - jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.transform.position + distCompensar;
    }
}
