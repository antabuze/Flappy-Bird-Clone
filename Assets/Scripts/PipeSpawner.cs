using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 1;
    public float minHeight = -1;
    public float maxHeight = 1;


    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipes), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipes));
    }

    private void SpawnPipes()
    {
        var pipe = Instantiate(pipes, transform.position, Quaternion.identity);
        pipe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
