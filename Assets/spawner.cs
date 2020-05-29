using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject cloneSource;
    public float rate = 100.0f;
    float lastSpawnTime;
    float spawnKick = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime > rate) {
          GameObject clone;
          Vector3 spawnPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
          spawnPoint += transform.parent.forward;
          clone = Instantiate(cloneSource, spawnPoint, transform.rotation);//, bulletWorld);
          Rigidbody cloneBody = clone.GetComponent<Rigidbody>();
          cloneBody.isKinematic = false;

          // Give the cloned object an initial velocity along the current
          // object's Z axis
          cloneBody.AddForce(transform.parent.forward * spawnKick);
          lastSpawnTime = Time.time;
        }
    }
}
