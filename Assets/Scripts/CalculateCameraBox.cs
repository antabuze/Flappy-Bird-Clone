using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateCameraBox : MonoBehaviour
{
    private Camera _cam;
    private BoxCollider2D _camBox;
    private float _sizeX, _sizeY, _ratio;
    
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
        _camBox = GetComponent<BoxCollider2D>();
        _sizeY = _cam.orthographicSize * 2;
        _ratio = (float)Screen.width / Screen.height;
        _sizeX = _sizeY * _ratio;
        _camBox.size = new Vector2(_sizeX, _sizeY);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
