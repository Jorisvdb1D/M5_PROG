using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] private GameObject towerPrefab;

    [Header("Spawn bounds (world space)")]
    [Tooltip("Inclusive minimum world position for random spawn")]
    [SerializeField] private Vector3 minBounds = new Vector3(-5f, 0f, -5f);
    [Tooltip("Inclusive maximum world position for random spawn")]
    [SerializeField] private Vector3 maxBounds = new Vector3(5f, 0f, 5f);

    [Header("Input")]
    [Tooltip("Use left click (true) or right click (false) to spawn")]
    [SerializeField] private bool useLeftClick = true;

    [Header("Optional")]
    [Tooltip("Parent for spawned towers (optional)")]
    [SerializeField] private Transform parentForSpawnedTowers;

    void Update()
    {
        if ((useLeftClick && Input.GetMouseButtonDown(0)) ||
            (!useLeftClick && Input.GetMouseButtonDown(1)))
        {
            SpawnRandomTower();
        }
    }

    private void SpawnRandomTower()
    {
        if (towerPrefab == null)
        {
            Debug.LogWarning("TowerSpawner: towerPrefab is not assigned.");
            return;
        }

        Vector3 pos = new Vector3(
            Random.Range(minBounds.x, maxBounds.x),
            Random.Range(minBounds.y, maxBounds.y),
            Random.Range(minBounds.z, maxBounds.z)
        );

        Instantiate(towerPrefab, pos, Quaternion.identity, parentForSpawnedTowers);
    }

    // Visualize spawn area in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0f, 1f, 0f, 0.12f);
        Vector3 center = (minBounds + maxBounds) * 0.5f;
        Vector3 size = maxBounds - minBounds;
        Gizmos.DrawCube(center, size);
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(center, size);
    }
}