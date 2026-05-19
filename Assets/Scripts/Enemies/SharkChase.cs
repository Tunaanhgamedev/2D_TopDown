using UnityEngine;

public class SharkChase : MonoBehaviour
{
    [Header("Chase")]
    [SerializeField] private float chaseRange = 10f;
    [SerializeField] private float stopDistance = .5f;
    [SerializeField] private float attackCooldown = 1f;

    [Header("Roam")]
    [SerializeField] private float roamChangeDirTime = 2f;

    private EnemyPathfinding pathfinding;
    private Shark shark;

    private float attackTimer;

    private Vector2 roamDirection;
    private float roamTimer;

    private void Awake()
    {
        pathfinding = GetComponent<EnemyPathfinding>();
        shark = GetComponent<Shark>();
    }

    private void Start()
    {
        ChooseRoamDirection();
    }

    private void Update()
    {
        attackTimer -= Time.deltaTime;
        roamTimer += Time.deltaTime;

        Vector2 playerPos = PlayerController.Instance.transform.position;
        Vector2 myPos = transform.position;

        float distance = Vector2.Distance(myPos, playerPos);

        // =========================
        // CHASE PLAYER
        // =========================
        if (distance <= chaseRange)
        {
            // Di chuyển tới player
            if (distance > stopDistance)
            {
                Vector2 direction = (playerPos - myPos).normalized;

                pathfinding.MoveTo(direction);
            }
            else
            {
                // Attack
                pathfinding.StopMoving();

                if (attackTimer <= 0)
                {
                    attackTimer = attackCooldown;

                    shark.Attack();
                }
            }
        }

        // =========================
        // RANDOM ROAM
        // =========================
        else
        {
            pathfinding.MoveTo(roamDirection);

            if (roamTimer >= roamChangeDirTime)
            {
                ChooseRoamDirection();
            }
        }
    }

    private void ChooseRoamDirection()
    {
        roamTimer = 0f;

        roamDirection = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }
}