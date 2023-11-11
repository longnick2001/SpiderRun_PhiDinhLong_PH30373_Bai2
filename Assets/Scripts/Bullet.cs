// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class Bullet : MonoBehaviour
// {
//     private Rigidbody2D rb;
//     private bool isFiring;
//
//     private float direction = -1;
//
//     public int damage = 1;
//
//     public float startX = 0;
//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }
//
//     private void OnCollisionEnter2D(Collision2D other)
//     {
//         if (other.gameObject.tag == "enemy")
//         {
//             MovingEnemy enemy = other.gameObject.GetComponent<MovingEnemy>();
//             if (enemy != null)
//             {
//                 if (enemy.Blood > 0)
//                 {
//                     enemy.Blood -= damage;
//                 }
//
//                 if (enemy.Blood <= 0)
//                 {
//                     PlayerController.Instance.killEnemy(enemy);
//                 }
//             }
//         }else if (other.gameObject.tag == "ground")
//         {
//             Vector2 v = rb.velocity;
//             v.x -= 0.5f * Mathf.Sign(rb.velocity.x);
//             rb.velocity = v;
//             if (Mathf.Abs(rb.velocity.x) < 1f)
//             {
//                 Destroy(gameObject);
//             }
//         }
//     }
//
//     public void fire(float velocity)
//     {
//         Vector2 force = new Vector2();
//         force.x = velocity * 1000;
//         force.y = 50;
//         direction = velocity;
//         rb.AddForce(force);
//         isFiring = true;
//     }
//     // Update is called once per frame
//     void Update()
//     {
//         if (isFiring && Mathf.Sign(direction) != Mathf.Sign(rb.velocity.x))
//         {
//             Destroy(gameObject);
//         }
//         else
//         {
//             rb.rotation += 1;
//             if (rb.rotation >= 180)
//             {
//                 rb.rotation = 0;
//             }
//         }
//     }
// }
