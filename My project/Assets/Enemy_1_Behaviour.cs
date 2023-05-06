using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1_Behaviour : MonoBehaviour
{
    public int life = 20;
    public int dmg = 2;
    [SerializeField] float moveSpeed = 4f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            moveDirection = direction;
        }

        if(life <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            life -= 5;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {

            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }
}
