using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 moveDirection;
    public float speed = 1000f;
    public int damage = 25;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        moveDirection.z = 0;       
        moveDirection.Normalize();

        rb.velocity = moveDirection * speed * 100 * Time.deltaTime;

        var rbRotate = Mathf.Atan(moveDirection.y/moveDirection.x)*180/Mathf.PI;

        if(moveDirection.x < 0){
            rbRotate += 180;
        }

        if(GameObject.FindGameObjectWithTag("Player").transform.rotation.y < 0){
            rb.SetRotation(rbRotate + 180);
        }
        else{
            rb.SetRotation(rbRotate);
        }
        
    }
    void Update() {
        if(rb.transform.position.y > 35 || rb.transform.position.x > 109 || rb.transform.position.x < -60)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
}
