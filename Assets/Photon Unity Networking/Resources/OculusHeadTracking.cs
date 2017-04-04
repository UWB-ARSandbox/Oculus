using UnityEngine;
using System.Collections;

public class OculusHeadTracking : MonoBehaviour
{
    private GameObject _camera;

    void Start()
    {
        _camera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update() {
        if (_camera != null) {
            this.transform.position = _camera.transform.position;
            this.transform.rotation = _camera.transform.rotation;
        }
    }
}
