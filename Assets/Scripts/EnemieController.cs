using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour
{
    Rigidbody rb;

    public GameObject player;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 direcao = player.transform.position - transform.position;

        rb.MovePosition(rb.position + direcao.normalized * speed * Time.deltaTime);
    }
}
