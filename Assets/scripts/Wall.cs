using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Wall : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    // Start is called before the first frame update
    [SerializeField] float colliderSize = 27f;
    [SerializeField] float score;


    //create an array of all my Collidicators
    Collidicator[] collidicators;

    void Start()
    {
        collidicators = GetComponentsInChildren<Collidicator>();

        foreach (Collidicator c in collidicators)
        {
            c.SetColliderSize(colliderSize);
            //c.willPassThrough = true;
           
            //this is a great place to make them invisible
            //I just turned them off in the pager script
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(speed * Time.deltaTime * Vector3.forward, Space.World);
        Destroy(gameObject, randomWallGeneration.time);
        CalculateScore();
        //music based on game mode
        //maybe model mode
        //Dance mode
    }

    float CalculateScore()
    {
        int numPass = 0;

        foreach (Collidicator c in collidicators)
        {
            if (!c.IsHit()) { numPass++; }
        }

        score = (float)numPass / (float)collidicators.Length;
        return score;
    }


}
