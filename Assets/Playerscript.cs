using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Gamecontroller gcontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gcontroller.GetComponent<Gamecontroller>().gameover)
        {

        }
        else
        {
            print("Game Over");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "coin")
        {
            gcontroller.GetComponent<Gamecontroller>().coin++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "nemico")
        {
            gcontroller.GetComponent<Gamecontroller>().vite--;
        }
    }



}
