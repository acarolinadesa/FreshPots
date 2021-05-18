using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    public float jumpForce;
    public bool isJumping;
    private Rigidbody2D rig; // armazena variável do rigidbody
    private Animator anim;

    // Start is called before the first frame update
    void Start() {
        rig =  GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update() {
        Move();
        Jump();
    }

    void Move() {
        // Vector3 - Variável local que armazena os eixos x, y e z
        // Input.GetAxis("Horizontal") - detecta quando são apertados os botões do eixo horizontal e armazena os botões
        // Transform.position - soma posição * o time (suaviza movimentação) * força da movimentação
        Vector3 movement =  new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        // Movimentação para esquerda
        if(Input.GetAxis("Horizontal") > 0f) {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        // Movimentação para a direita
        if(Input.GetAxis("Horizontal") < 0f) {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
        // Personagem parado
        if(Input.GetAxis("Horizontal") == 0f) {
            anim.SetBool("walk", false);
        }
    }
    void Jump() {
        if(Input.GetButtonDown("Jump") && !isJumping){
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); //AddForce - classe para pular ou arremessar objetos
        }
    }
}
