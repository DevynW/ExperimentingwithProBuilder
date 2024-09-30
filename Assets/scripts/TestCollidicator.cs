using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollidicator : MonoBehaviour
{
    [SerializeField] Collidicator collidable;

    // Start is called before the first frame update
    void Start()
    {
        collidable.SetColliderSize(10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
