using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2)
        {
            Destroy(gameObject);
        }
    }
}