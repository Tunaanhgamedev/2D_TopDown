using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour, IEnemy
{
    private Animator myAnimator;
    private SpriteRenderer spriteRenderer;

    readonly int ATTACK_HASH = Animator.StringToHash("attacking");
    readonly int DIE_HASH = Animator.StringToHash("die");

    private bool isDead = false;

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Attack()
    {
        if (isDead) return;

        myAnimator.SetTrigger(ATTACK_HASH);

        if (transform.position.x < PlayerController.Instance.transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }

    public void Die()
    {
        if (isDead) return;

        isDead = true;

        myAnimator.SetTrigger(DIE_HASH);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SharkChase>().enabled = false;
        GetComponent<EnemyPathfinding>().StopMoving();

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }

        Destroy(gameObject, 1.5f);
    }

    public void DamagePlayerAnimEvent()
    {
        PlayerHealth.Instance.TakeDamage(1, transform);
    }
}
