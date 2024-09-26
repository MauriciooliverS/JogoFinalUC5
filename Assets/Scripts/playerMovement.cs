using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
 private SpriteRenderer spriteRenderer;
    public bool isRunning = false;
    public Animator animPlayer;
    public float moveH;
    private Rigidbody2D rb; 
    public float forcaPulo;
    public float velocidade;
    public float rotacao;
    public bool isFlying = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animPlayer = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        velocidade = 5f;
        forcaPulo = 8f;
        moveH = 5f;
    }

    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0 );

        if(Input.GetKeyDown(KeyCode.Space) && !isFlying)
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode2D.Impulse);
            isFlying = true;
        }

        //animação

        if(Input.GetKey(KeyCode.D))
        {
            animPlayer.SetLayerWeight(1, 1);
            spriteRenderer.flipX = false;
            isRunning = true;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animPlayer.SetLayerWeight(1, 1);
            spriteRenderer.flipX = true;
            isRunning = true;
        }
        else
        {
            animPlayer.SetLayerWeight(1, 0);
        }

        animPlayer.SetBool("isRunning", isRunning);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag ("Chão"))
            {
                isFlying = false;
            }
    }
    
}