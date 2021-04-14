using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private MainMenu mainMenu;
    public static int health;
    public GameObject deathEffect;

    // Start is called before the first frame update

    void Start() {
        health = 100;    
    }
    public void TakeDamage(int damage){
        health -= damage;

        if (health <= 0){
            Die();
        }
    }

    /*Caleb added this function: This is responsible for the powerups of the game.
     Basically if the tag = powerup then we want to destroy it and add 20 to the health.*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Powerup")
        {
            if (health == 100)
            {
                
                Destroy(collision.gameObject);
            }

            else if (health == 90)
            {
                health = 100;
            }
            else if (health == 80)
            {
                health = 100;
            }
            else if (health <= 70)
            {
                health += 20;

            }
            else if (health > 100)
            {
                Destroy(collision.gameObject);
            }

            
            Destroy(collision.gameObject);
            
        }
    }


    // Update is called once per frame
    void Die(){
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(effect, 0.5f);

    }

}
