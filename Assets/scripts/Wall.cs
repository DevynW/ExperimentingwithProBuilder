using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    // Start is called before the first frame update

    //create an array of all my Collidicators
    Collidicator[] collidicators;

    void Start()
    {
        collidicators = GetComponentsInChildren<Collidicator>();

        foreach (Collidicator c in collidicators)
        {
            c.SetColliderSize(10f);
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
    }


}
