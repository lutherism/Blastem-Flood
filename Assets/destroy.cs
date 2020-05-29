using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    float bulletForce = 900.0f;
    public GameObject HUD;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destroyable")
        {
          Destroy(collision.gameObject);
          //GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
          HUD.GetComponent<HUD>().onKill();
        }
    }
}
