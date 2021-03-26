using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
    public Transform GrounCheck;
    public bool noChao = false;
    public Animator anim;
    public float jumpforce=1;

    
    

    
    public GameObject player;
    //public Animator anim;


    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();   
    }

    

    void Update()
        
    {

        

        
           
        

        if (moveInput == 0)
        {
          
        }
        else
        {
            //anim.SetBool("isRunning", true);
        }

        Vector3 characterScale = transform.localScale;

        if (moveInput > 0)
        {
            
            
        }
        

        else if (moveInput < 0)
        {
            
        }
        if(noChao && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2 (0, 350)*jumpforce);
            noChao = false;
            anim.SetBool("pulou", true);
        }
       
        
        anim.SetFloat("velocidade", Mathf.Abs(Input.GetAxis("Horizontal")));



    }
    private void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.name== "chao")
        {
            noChao = true;
            anim.SetBool("pulou", false);
        }
        else
        {

        }
    }
    private void OnCollisionExit(Collision collison)
    {

    }


    private void FixedUpdate()
    {
        Vector3 characerScale = transform.localScale;
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (Input.GetAxis("Horizontal")<0)
        {
            characerScale.x = -0.3f;

        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characerScale.x = 0.3f;

        }
        transform.localScale = characerScale;

    }
}
