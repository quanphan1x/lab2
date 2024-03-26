using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class chickenController : MonoBehaviour
{
    public GameObject egg;
    private int count;
    //Start is called before the first frame update
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 100)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
            count = 0;
        }
    }
}
