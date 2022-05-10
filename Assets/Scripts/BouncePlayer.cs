using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlayer : MonoBehaviour
{
    public float bounciness = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
      if (collision.collider.name == "Sphere") {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * bounciness);
      }
    }
}
