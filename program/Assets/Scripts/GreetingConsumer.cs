using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour {
    
    [Inject]
    private IGreeting greeting;

    private void Update() {
        Debug.Log(greeting.Message);
    }
}
