using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RedKnifeContorler : KnifeContorler
{
    private bool MoveState = false;
    [SerializeField] private GameObject Prefab;
    
    void Awake()
    {
        position = transform.position;
        rotation = transform.rotation;
        Scale = transform.localScale;
        KnifePrefab = Prefab;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
        MoveState = true;
        Spawn(position,rotation,Scale,KnifePrefab);
        }
        if (MoveState == true)
        {
            Move(force);
        }
    }
    public override void OnCollisionEnter2D(Collision2D other)
    {
        base.OnCollisionEnter2D(other);
        MoveState = false;
    }
}
