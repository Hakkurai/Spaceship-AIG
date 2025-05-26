using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float spawnInterval = 1f;
    public float spawnRangeY = 4.5f;

    private float screenRight;

    void Start()
    {
        screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        InvokeRepeating("SpawnMeteor", 1f, spawnInterval);
    }

   void SpawnMeteor()

    {
        float y = Random.Range(-spawnRangeY, spawnRangeY);
        Vector2 spawnPos = new Vector2(screenRight + 1f, y);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }

}
