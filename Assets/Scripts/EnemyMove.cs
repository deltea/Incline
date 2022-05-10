using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 1;
    public float activationRange = 100;
    public float direction = 1;
    public GameObject player;
    private Rigidbody enemyRigidBody;

    // Start is called before the first frame update
    void Start()
    {
      enemyRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (player.transform.position.x <= transform.position.x + activationRange) {
        enemyRigidBody.AddForce(Vector3.forward * speed * direction);
      }
    }
}
