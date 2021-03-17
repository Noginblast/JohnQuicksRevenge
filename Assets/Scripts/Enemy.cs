using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    
    public GameObject deathEffect;
    public int enemyDamage = 10;


    void Start() {
        
    }

    

    public void TakeDamage(int damage){
        health -= damage;

        if (health <= 0){
            Die();
        }
    }

    void Die(){
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
       // ScoreScript.scoreValue += 10;
        //dead.DeathSound();
        Destroy(gameObject);
        Destroy(effect, 0.5f);
    }
    void Die2(){
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        
        //dead.DeathSound();
        Destroy(gameObject);
        Destroy(effect, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        if(player != null){
            player.TakeDamage(enemyDamage);
            Die2();
        }
        
    }

}
