using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public GameObject[] shapePrefabs;
    public float spawnInterval = 2f;
    public Vector2 spawnAreaMin = new Vector2(-8, -4);
    public Vector2 spawnAreaMax = new Vector2(8, 4);

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomShape), 1f, spawnInterval);
    }

    void SpawnRandomShape()
    {
        if (shapePrefabs.Length == 0) return;

        int index = Random.Range(0, shapePrefabs.Length);
        Vector2 position = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(shapePrefabs[index], position, Quaternion.identity);
    }
}
