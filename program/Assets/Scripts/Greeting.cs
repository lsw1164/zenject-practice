using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting : IGreeting {
    private string _message = "Hello World";
    public string Message {
        get { return _message; }
    }
}
