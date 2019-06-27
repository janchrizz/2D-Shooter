using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    Animator anime;
    SpriteRenderer render;
    public float ms;
    public int hp;
    public bloodEffect other;

    private void Start()
    {
        anime = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
        anime.SetBool("move_x", false);
        other.Hide();
    }
   
    void FixedUpdate()
    {
       
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            
          
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * ms * Time.deltaTime, 0f, 0f));
          
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {

           
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * ms * Time.deltaTime, 0f));
          
        }
        if(Input.GetAxisRaw("Horizontal") > 0) {
            anime.SetBool("move_x", true);
            anime.SetBool("stay", false);
            render.flipX = false;
            anime.speed = 5;
        }
        else if (Input.GetAxisRaw ("Horizontal") < 0) {
            anime.SetBool("move_x", true);
            anime.SetBool("stay", false);
            render.flipX = true;
            anime.speed = 5;
        }
        else {
            anime.SetBool("move_x", false);
            anime.SetBool("stay", true);
        }
        if (hp <= 0) {
            Destroy(gameObject);
            Application.Quit();
            SceneManager.LoadScene("Main");
        }
    }
    public void TakeDamage(int damage) {
        other.Appear();
        hp -= damage;

    }

}
