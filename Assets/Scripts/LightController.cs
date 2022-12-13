using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light _light;
    void Start()
    {
        _light = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.checkBong)
            _light.range = 30;
        else if (!GameController.checkBong)
            _light.range = 0;
    }
}
