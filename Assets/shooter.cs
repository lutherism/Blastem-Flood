using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletWorld;
    float bulletForce = 2000.0f;
    float bulletReload = 0.02f;
    float lastShot;
    // Start is called before the first frame update
    void Start()
    {
      //bullet = GetComponent<Rigidbody>();
      lastShot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButton("Fire1") && Time.time - lastShot > bulletReload) {
        lastShot = Time.time;
        GameObject clone;
        Vector3 spawnPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        spawnPoint += transform.parent.forward;
        clone = Instantiate(bullet, spawnPoint, transform.rotation);//, bulletWorld);
        clone.GetComponent<MeshRenderer>().enabled = true;
        Rigidbody cloneBody = clone.GetComponent<Rigidbody>();
        cloneBody.isKinematic = false;

        // Give the cloned object an initial velocity along the current
        // object's Z axis
        cloneBody.AddForce(transform.parent.forward * bulletForce);
      }
    }
}
