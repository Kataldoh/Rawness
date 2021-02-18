using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float Speed = 5f;  //Questa variabile setta la velocità di movimento del player

    public Rigidbody2D rb;

    Vector2 movimento; //Vector2 contiene le coordinate x e y, è essenziale poichè altrimenti non si possono inserire i valori nel fixed update

    public Animator anim;



    // Update is called once per frame
    void Update() //Il metodo update non dovrebbe essere utilizzato per programmare la fisica, visto che il framerate può oscillare
    {
        movimento.x = Input.GetAxisRaw("Horizontal"); // "GetAxisRaw" permette alla funzione di oscillare tra i valori -1 ed 1
        movimento.y = Input.GetAxisRaw("Vertical");   // quindi se voglio andare a sinistra la x sarà -1 e quando vado a destra 1
        anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Speed", movimento.sqrMagnitude);
    }

    private void FixedUpdate() // is called 50 times a second
    {
        rb.MovePosition(rb.position + movimento * Speed * Time.fixedDeltaTime);
    }
}
