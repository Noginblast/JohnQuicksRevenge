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

    // Update is called once per frame
    void Die(){
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(effect, 0.5f);

    }

}
