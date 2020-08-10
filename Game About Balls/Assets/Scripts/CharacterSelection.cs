using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
}
