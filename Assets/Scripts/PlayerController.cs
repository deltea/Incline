using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    private Rigidbody playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
      playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      playerRigidBody.AddForce(Vector3.left * forwardSpeed);
      if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
        playerRigidBody.AddForce(Vector3.back * speed);
      } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
        playerRigidBody.AddForce(Vector3.forward * speed);
      }
      if (transform.position.y <= -1) {
        SceneManager.LoadScene(sceneName: "Dead");
      }
    }
}
