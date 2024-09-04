using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEdgeColliders : MonoBehaviour
{
  private Camera _camera;
    void Awake ()
    {
      _camera = GetComponent<Camera>();
      GenerateCollidersAcrossScreen();
    }

    void GenerateCollidersAcrossScreen()
        {
         Vector2 lDCorner = _camera.ViewportToWorldPoint(new Vector3(0, 0f, _camera.nearClipPlane));
         Vector2 rUCorner = _camera.ViewportToWorldPoint(new Vector3(1f, 1f, _camera.nearClipPlane));
         Vector2[] colliderpoints;
    
        EdgeCollider2D upperEdge = new GameObject("upperEdge").AddComponent<EdgeCollider2D>();
        colliderpoints = upperEdge.points;
        colliderpoints[0] = new Vector2(lDCorner.x, rUCorner.y);
        colliderpoints[1] = new Vector2(rUCorner.x, rUCorner.y);
        upperEdge.points = colliderpoints;
    
        EdgeCollider2D lowerEdge = new GameObject("lowerEdge").AddComponent<EdgeCollider2D>();
        colliderpoints = lowerEdge.points;
        colliderpoints[0] = new Vector2(lDCorner.x, lDCorner.y);
        colliderpoints[1] = new Vector2(rUCorner.x, lDCorner.y);
        lowerEdge.points = colliderpoints;
    
        EdgeCollider2D leftEdge = new GameObject("leftEdge").AddComponent<EdgeCollider2D>();
        colliderpoints = leftEdge.points;
        colliderpoints[0] = new Vector2(lDCorner.x, lDCorner.y);
        colliderpoints[1] = new Vector2(lDCorner.x, rUCorner.y);
        leftEdge.points = colliderpoints;
    
        EdgeCollider2D rightEdge = new GameObject("rightEdge").AddComponent<EdgeCollider2D>();
    
        colliderpoints = rightEdge.points;
        colliderpoints[0] = new Vector2(rUCorner.x, rUCorner.y);
        colliderpoints[1] = new Vector2(rUCorner.x, lDCorner.y);
        rightEdge.points = colliderpoints;
    }
  }

