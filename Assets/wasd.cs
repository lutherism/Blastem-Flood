using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wasd : MonoBehaviour
{
    // Start is called before the first frame update
    float camSens = 0.25f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun= 1.0f;
    public float speed = 6.0F;
    public float airSpeed = 2.0F;
    public float jumpSpeed = 250.0F;
    public float gravity = 8.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Start() {

    }

    void Update () {
      if (Input.GetKeyDown(KeyCode.Escape)) {
        SceneManager.LoadScene("Menu");
      }
      CharacterController controller = GetComponent<CharacterController>();
      if (controller.isGrounded) {
          moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
          moveDirection = transform.TransformDirection(moveDirection);
          moveDirection *= speed;
          if (Input.GetButton("Jump"))
              moveDirection.y = jumpSpeed;

      } /*else {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 1, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= airSpeed;
      }*/
      moveDirection.y -= gravity * Time.deltaTime;
      controller.Move(moveDirection * Time.deltaTime);

    }
}
