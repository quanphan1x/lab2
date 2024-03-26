using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggBroken;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("platform"))
        {
            Instantiate(eggBroken, transform.position, Quaternion.identity);
            Destroy(obj: this);

        }
        if (col.gameObject.name.Equals("box"))
        {
            Destroy(obj: this);
        }

    }
}
