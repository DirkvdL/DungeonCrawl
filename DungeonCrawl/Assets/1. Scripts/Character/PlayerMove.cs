using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float normalspeed = 0.0f;
    public Animator animator;
    public int playerHealth = 100;
    public Transform respawnPoint;
    public Slider healthSlider;

    private Rigidbody player;

    private float horizontal;
    private float vertical;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        animator = animator.gameObject.GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * normalspeed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * normalspeed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);

        #region WalkingAnim

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("isWalking", true);
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            animator.SetBool("isWalking", false);
        }
        #endregion

        #region AttackAnim
        if (Input.GetButton("Attack"))
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }


        #endregion

        #region Health
        if (playerHealth <= 0)
        {
            transform.position = respawnPoint.position;
            playerHealth = 100;
        }

        healthSlider.value = playerHealth;
        #endregion

    }
}
