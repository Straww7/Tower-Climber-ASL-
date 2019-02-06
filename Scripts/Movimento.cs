using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //movimento del player

   public float speed,actualspeed;
    Vector3 newScale;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public Vector2 jumpForce = new Vector2(0f, 6.1f);
    private Rigidbody2D rb;
    public LayerMask groundLayer;
    public LayerMask wallLayer;
    private int jumpNumber = 0;

    void Start()
    {
        speed = 2f;
        groundLayer = LayerMask.GetMask("Ground");
        jumpForce = new Vector2(0f, 6.1f);
        wallLayer = LayerMask.GetMask("Walls");
        rb = GetComponent<Rigidbody2D>();
        actualspeed = speed;
    }

    void Update(){
        Move();
        salto(); 
    }

    bool isGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1f;
        RaycastHit2D hitg = Physics2D.Raycast(position, direction, distance, groundLayer);
        RaycastHit2D hitw = Physics2D.Raycast(position, direction, distance, wallLayer);
        if (hitg.collider != null || hitw.collider != null)
        {
            return true;
        }
        return false;
    }

    void sblocca(){ 
        speed=actualspeed;
    }

void OnCollisionEnter2D(Collision2D col) {
    if(col.gameObject.tag.Equals("wall")){
            jumpNumber = 1;
            newScale.x *= -1;
            transform.localScale = newScale;
            actualspeed =speed*-1;
            if (!isGrounded())
            {
                speed = 0;
                if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
                {
                    sblocca();
                }
            }
            else
            {
                speed = actualspeed;
            }
    }
}

private void OnCollisionStay2D(Collision2D col) {
       if(col.gameObject.tag.Equals("wall")){
        if(Input.GetKeyDown(KeyCode.Space)|| Input.touchCount > 0 || isGrounded()){
            sblocca();
        }
    }
}

void OnCollisionExit2D(Collision2D col) {
    if(col.gameObject.tag.Equals("wall") ){
        jumpForce= new Vector2(0f, 6.1f);
        rb.gravityScale=1.5f;
        speed=actualspeed;
    }
}


void Move(){
 newScale = transform.localScale;
       if (transform.position.x > 1.1f)
        {
            speed = speed * -1;
          
            newScale.x *= -1;
          transform.localScale = newScale;
        }

        if (transform.position.x < -1.0920f)
        {
            speed = speed * -1;
                        newScale.x *= -1;
          transform.localScale = newScale;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
}

void salto(){
if (isGrounded() && (Input.GetKeyDown(KeyCode.Space)|| Input.touchCount > 0)){
            jumpNumber=1;
            rb.velocity = jumpForce;
        }
        else if (jumpNumber == 1 && (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0))
        {
            jumpNumber = 0;
            rb.velocity = jumpForce;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && (!Input.GetKeyDown(KeyCode.Space) || Input.touchCount == 0))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemied"))
        {
            Destroy(other.gameObject);
        }
    }
}