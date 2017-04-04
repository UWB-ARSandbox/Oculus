using UnityEngine;
using System.Collections;

public class HeadTracking : MonoBehaviour
{

    public bool IsHololens;

    private GameObject _camera;

    // Use this for initialization
    void Start()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (_camera != null && IsHololens)
        {
            this.transform.position = _camera.transform.position;
            this.transform.rotation = _camera.transform.rotation;
        }
    }

}
