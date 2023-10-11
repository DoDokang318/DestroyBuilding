using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControll : MonoBehaviour
{
    public Rigidbody2D Rb;
    public Transform GroundCheck;
    public LayerMask GroundLayer;

    public Animator animator;
    private float Horizontal;
    private float Speed = 8f;
    public float JumpingPower = 16f;
  

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            Rb.velocity = new Vector2(Rb.velocity.x, JumpingPower);
        }

        if (context.canceled && Rb.velocity.y > 0f)
        {
            Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y * 0.5f);
        }
    }


    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
    }


    public void Move(InputAction.CallbackContext context)
    {
        Horizontal = context.ReadValue<Vector2>().x;
    }
    public void Attack(InputAction.CallbackContext context)
    {
        GameManager.Instance.IsAttack = true;
        GameManager.Instance.Isdefence = false;
        Debug.Log("Attack");
        animator.SetTrigger("Attack");     
    }
    public void Diffence(InputAction.CallbackContext context)
    {
        GameManager.Instance.IsAttack = false;
        GameManager.Instance.Isdefence = true;
        animator.SetTrigger("Diffence");
    }

}
