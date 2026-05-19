using System.Collections;
using UnityEngine;

public class GreenSlime : MonoBehaviour, IEnemy
{
    [Header("Projectile")]
    [SerializeField] private GameObject greenSlimeProjectilePrefab;
    [SerializeField] private Transform firePoint;

    [Header("Death")]
    [SerializeField] private float destroyDelay = 1.5f;

    private Animator myAnimator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private Collider2D myCollider;

    private bool isDead = false;

    readonly int ATTACK_HASH = Animator.StringToHash("attack");
    readonly int DIE_HASH = Animator.StringToHash("die");

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
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

    public void SpawnProjectileAnimEvent()
    {
        if (greenSlimeProjectilePrefab == null || firePoint == null)
        {
            Debug.LogWarning("Projectile Prefab hoặc FirePoint chưa được gán!");
            return;
        }

        Instantiate(
            greenSlimeProjectilePrefab,
            firePoint.position,
            Quaternion.identity
        );
    }

    public void Die()
    {
        if (isDead) return;

        isDead = true;

        myAnimator.SetTrigger(DIE_HASH);

        if (myCollider != null)
        {
            myCollider.enabled = false;
        }

        EnemyAI enemyAI = GetComponent<EnemyAI>();

        if (enemyAI != null)
        {
            enemyAI.enabled = false;
        }

        EnemyPathfinding enemyPathfinding = GetComponent<EnemyPathfinding>();

        if (enemyPathfinding != null)
        {
            enemyPathfinding.enabled = false;
        }
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }
        Destroy(gameObject, destroyDelay);
    }
}