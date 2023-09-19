using UnityEngine;
using DG.Tweening;
using System.Diagnostics;

public abstract class  KnifeContorler : MonoBehaviour
{
    public Vector3 force;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 Scale;
    public GameObject KnifePrefab; 

    public virtual void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Truck")
        {
            transform.SetParent(other.transform);
        }
    }
    public void Move(Vector3 force)
    {
            transform.position += force;
    }
    
    public void Spawn(Vector3 position,Quaternion rotation,Vector3 Scale,GameObject KnifePrefab)
    {
        GameObject Knife = Instantiate(KnifePrefab,position,Quaternion.identity);
        Knife.transform.rotation = rotation;
        Knife.transform.localScale = Scale;

    }
}
