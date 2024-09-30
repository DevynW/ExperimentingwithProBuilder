using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomWallGeneration : MonoBehaviour
{
    [SerializeField] GameObject[] wallPrefabs;
    [SerializeField] public static float time = 10f;
    [SerializeField] float rate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("MakeWall", time, rate);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    void MakeWall()
    {
        int wallNum = Random.Range(0, wallPrefabs.Length);
        Instantiate(wallPrefabs[wallNum]);
        Debug.Log("We're making walls!");
    }
    
}
