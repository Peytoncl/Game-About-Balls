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
    public GameObject player;
    public GameObject Player_Red;
    public GameObject Player_Yellow;
    public GameObject Player_Green;
    public GameObject Player_Blue;
    public GameObject Player_Purple;


    void Start()
    {
        randomSpawn();
        characterSpawn();
    }

   
    void Update()
    {
        
    }

    void randomSpawn()
    {
        randomY = new Vector3(5, Random.Range(-3, -1));
        
        Instantiate(pillarTop, randomY, Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(5, randomY.y - 2.5520937f), Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(5, randomY.y - 2.5520937f * 2), Quaternion.identity);
        Instantiate(pillarBottom, new Vector3(5, randomY.y - 2.5520937f * 3), Quaternion.identity);
        
        if(randomY.y >= -3) topPipeY = new Vector3(5, randomY.y * -1.5f);
        if(randomY.y < -3) topPipeY = new Vector3(5, randomY.y * -2);
        Instantiate(pillarTop_UpsideDown, topPipeY, Quaternion.identity);
        Instantiate(pillarBottom_UpsideDown, new Vector3(5, topPipeY.y + 2.5520937f), Quaternion.identity);
        Instantiate(pillarBottom_UpsideDown, new Vector3(5, topPipeY.y + 2.5520937f * 2), Quaternion.identity);
    }

    void characterSpawn()
    {
        if(PlayerPrefs.GetString("Player") == "Player_Blue") Instantiate(Player_Blue, new Vector3(0, 0), Quaternion.identity);
        if(PlayerPrefs.GetString("Player") == "Player_Purple") Instantiate(Player_Purple, new Vector3(0, 0), Quaternion.identity);
        if(PlayerPrefs.GetString("Player") == "Player_Green") Instantiate(Player_Green, new Vector3(0, 0), Quaternion.identity);
        if(PlayerPrefs.GetString("Player") == "Player_Yellow") Instantiate(Player_Yellow, new Vector3(0, 0), Quaternion.identity);
        if(PlayerPrefs.GetString("Player") == "Player_Red") Instantiate(Player_Red, new Vector3(0, 0), Quaternion.identity);
        player = GameObject.Find(PlayerPrefs.GetString("Player") + "(Clone)");
        player.AddComponent<PlayerMovement>();
    }
}
