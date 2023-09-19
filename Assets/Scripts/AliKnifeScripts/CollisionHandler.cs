using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public static Action Collision;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Knife")
        {
        Collision?.Invoke();
        }
    }
}
