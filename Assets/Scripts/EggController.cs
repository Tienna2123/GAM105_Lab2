using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("dat")) {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (collision.gameObject.name.Equals("Egg"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (collision.gameObject.name.Equals("Farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (collision.gameObject.name.Equals("Box"))
        {
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
    }
}
