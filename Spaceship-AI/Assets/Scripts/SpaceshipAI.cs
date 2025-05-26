using UnityEngine;

public class SpaceshipAI : MonoBehaviour
{
    public float speed = 5f;
    public float avoidStrength = 3f;
    public float detectDistance = 2f;

    private Vector2 direction = Vector2.right;

   void Update()
{
    RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, detectDistance);

    if (hit.collider != null && hit.collider.CompareTag("Asteroid"))
    {
        Vector2 avoidDir = Vector2.Perpendicular(Vector2.right) * (Random.value > 0.5f ? 1 : -1);
        direction = Vector2.Lerp(direction, avoidDir.normalized, Time.deltaTime * avoidStrength);
    }
    else
    {
        direction = Vector2.Lerp(direction, Vector2.right, Time.deltaTime * 0.5f);
    }

    // Force movement only in world right direction
    transform.position += new Vector3(direction.x, direction.y, 0).normalized * speed * Time.deltaTime;
}

}
