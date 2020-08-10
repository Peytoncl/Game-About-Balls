using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawn : MonoBehaviour
{

    private Vector3 randomY;
    private Vector3 topPipeY;
    public GameObject pillarBottom;
    public GameObject pillarTop;
    public GameObject pillarBottom_UpsideDown;
    public GameObject pillarTop_UpsideDown;


    void Start()
    {
        randomSpawn();
    }

   
    void Update()
    {
        
    }

    void randomSpawn()
    {
        randomY = new Vector3(4, Random.Range(-3, -1));
        //bottom pipe
        Instantiate(pillarTop, randomY, Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(4, randomY.y - 2.5520937f), Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(4, randomY.y - 2.5520937f * 2), Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(4, randomY.y - 2.5520937f * 3), Quaternion.identity);
        //top pipe
        if(randomY.y >= -3) topPipeY = new Vector3(4, randomY.y * -1.5f);
        if(randomY.y < -3) topPipeY = new Vector3(4, randomY.y * -2);
        Instantiate(pillarTop_UpsideDown, topPipeY, Quaternion.identity);
        Instantiate(pillarBottom_UpsideDown, new Vector3(4, topPipeY.y + 2.5520937f), Quaternion.identity);
        Instantiate(pillarBottom_UpsideDown, new Vector3(4, topPipeY.y + 2.5520937f * 2), Quaternion.identity);
    }
}
