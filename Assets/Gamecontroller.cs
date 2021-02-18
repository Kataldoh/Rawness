using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public int energy;
    public int monstercount;
    public int coin;
    public GameObject target;
    public int vite;
    public bool gameover;

    // Gamecontroller

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (vite <= 0)
        {
            gameover = true;
        }
    }
}
