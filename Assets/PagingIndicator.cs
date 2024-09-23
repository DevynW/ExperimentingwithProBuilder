using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class PagingIndicator : MonoBehaviour
{
    [SerializeField] Light Indicator;
    [SerializeField] Color pass;
    [SerializeField] Color hit;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        //assume we are not colliding
        Indicator.color = pass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("I've been hit!");

        //if we hit the player, turn red
        if (other.gameObject.CompareTag("Player"))
        {
            Indicator.color = hit;
        }
    }

    private void OnTriggerExit(UnityEngine.Collider other)
    {
        //if we stop hitting the player, turn green
        if (other.gameObject.CompareTag("Player"))
        {
            Indicator.color = pass;
        }
    }


}
