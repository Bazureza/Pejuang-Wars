using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public type bulletType;
    public enum type
    {
        player, enemy
    }
    public int damage;
    public Vector2 direction;
    public int speed;
    private Animator animator;

    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
    }
      

	// Update is called once per frame
	void Update () {
    transform.Translate(direction * Time.deltaTime * speed);
    }

    /*IEnumerator destroy()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        //Destroy(gameobject);
    }
         private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag ==“Enemy” && bulletType.Equals(type.player))
                {
                speed = 0;
                animator.SetTrigger("Hit");
                StartCoroutine(destroy());
                collision.GetComponent<EnemyBehaviour>().takeDamage(damage);
            }
            if (collision.tag == "Player" && bulletType.Equals(type.enemy))
            {
                speed = 0;
                animator.SetTrigger("Hit");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }*/
}
