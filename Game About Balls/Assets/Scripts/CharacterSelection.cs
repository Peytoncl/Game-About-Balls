using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public AudioSource selectSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
        checkDone();
    }

    void checkInput()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x != -6.12f) 
        {
            this.transform.position = new Vector3(this.transform.position.x - 3.06f, this.transform.position.y);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x != 6.12f)
        {
            this.transform.position = new Vector3(this.transform.position.x + 3.06f, this.transform.position.y);
        }
    }

    void checkDone()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            selectSound.Play();
            RaycastHit2D hit = Physics2D.Raycast(this.transform.position, -Vector2.up);
            if (hit.collider != null) Debug.Log(hit.transform.name);
        }
    }
}
