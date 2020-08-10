using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameObject x;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        x = GameObject.Find(PlayerPrefs.GetString("Player") + "(Clone)");
        x.AddComponent<Rigidbody2D>();
        rb = x.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkInput()
    {
        
    }
}
