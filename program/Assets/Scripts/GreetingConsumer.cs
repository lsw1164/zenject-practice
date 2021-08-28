using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour {
    
    [Inject]
    private IGreeting greeting;

    [Inject]
    public void Construct(IGreeting greeting) {
        this.greeting = greeting;
    }

    public float timeBetweenMessage = 1.0f;
    private float timeSinceMessage = 0;

    private void Update() {
        timeSinceMessage += Time.deltaTime;
        if (timeSinceMessage > timeBetweenMessage) {
            Debug.Log(greeting.Message);
            timeSinceMessage = 0;
        }
    }

    public class Factory : PlaceholderFactory<GreetingConsumer> {
    }
}
