using UnityEngine;

public class PatrolPoint : MonoBehaviour
{
    public Transform targetPosition;
    public float moveSpeed = 5f;

    private Vector3 originalPosition;
    private bool movingTowardsTarget = true;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        if (movingTowardsTarget)
        {
            MoveTowardsTarget();
        }
        else
        {
            MoveBackToOriginalPosition();
        }
    }

    private void MoveTowardsTarget()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, step);

        if (transform.position == targetPosition.position)
        {
            movingTowardsTarget = false;
            transform.Rotate(0, 180, 0);
        }
    }

    private void MoveBackToOriginalPosition()
    {
        
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, originalPosition, step);


        if (transform.position == originalPosition)
        {
            movingTowardsTarget = true;
            transform.Rotate(0, -180, 0);
        }
    }
}
