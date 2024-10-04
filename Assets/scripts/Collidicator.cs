using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidicator : MonoBehaviour
{
    //[SerializeField] Light Indicator;
    [SerializeField] PagingIndicator Collider;
    [SerializeField] float translationFactor = 4f;


    float ColliderSize = 1f;
    public void SetColliderSize(float size)
    {
        ColliderSize = size;
        Collider.transform.localScale = new Vector3(Collider.transform.localScale.x, Collider.transform.localScale.y, ColliderSize);
        Collider.transform.Translate(Vector3.forward * ColliderSize / translationFactor);
    }
    
    /*public bool willPassThrough
    {
        set {
            if (value == true)
            {
                Indicator.color = pass;
            }
            else
            {
                Indicator.color = hit;
            }
        }
    }*/
 
    public bool IsHit()
    {
        return Collider.IsHit();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
