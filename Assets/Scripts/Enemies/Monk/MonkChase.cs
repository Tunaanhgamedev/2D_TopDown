using UnityEngine;

public class MonkChase : MonoBehaviour
{
    [Header("Chase")]
    [SerializeField] private float chaseRange = 6f;
    [SerializeField] private float stopDistance = .6f;
    [SerializeField] private float attackCooldown = 1f;
    [SerializeField] private float chaseMoveSpeed = 3.5f;
    [SerializeField] private float roamMoveSpeed = 2f;

    [Header("Roam")]
    [SerializeField] private float roamChangeDirTime = 2f;

    private EnemyPathfinding pathfinding;
    private Monk monk;

    private float attackTimer;

    private Vector2 roamDirection;
    private float roamTimer;

    private void Awake()
    {
        pathfinding = GetComponent<EnemyPathfinding>();
        monk = GetComponent<Monk>();
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
        if (distance <= chaseRange)
        {
            pathfinding.SetMoveSpeed(chaseMoveSpeed);

            if (distance > stopDistance)
            {
                Vector2 direction = (playerPos - myPos).normalized;
                pathfinding.MoveTo(direction);
            }
            else
            {
                pathfinding.StopMoving();

                if (attackTimer <= 0)
                {
                    attackTimer = attackCooldown;
                    monk.Attack();
                }
            }
        }
        else
        {
            pathfinding.SetMoveSpeed(roamMoveSpeed);
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