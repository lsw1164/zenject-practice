using UnityEngine;
using Zenject;

public class GreetingSpawner : MonoBehaviour {
    [Inject] private GreetingConsumer.Factory greetingConsumerFactory;
    [Inject] private IGreeting greeting;
    
    private Bounds bounds;

    public Vector3 boundsSize = new Vector3(1, 1, 0);
    public float timeBetweenSpawns = 1.0f;
    private float timeSinceSpawn = 0;


    private void Start() {
        bounds = new Bounds(Vector3.zero, boundsSize);
    }

    private void Update() {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > timeBetweenSpawns) {
            GreetingConsumer consumer = greetingConsumerFactory.Create();
            consumer.transform.position = GetRandomSpawnPosition();
            timeSinceSpawn = 0;
        }
    }

    private Vector3 GetRandomSpawnPosition() {
        float xPos = (Random.value - 0.5f) * bounds.size.x;
        float yPos = (Random.value - 0.5f) * bounds.size.y;
        float zPos = (Random.value - 0.5f) * bounds.size.z;
        return new Vector3(xPos, yPos, zPos);
    }
}
