using UnityEngine;

public class Spawner : MonoBehaviour
{    
    public GameObject NewKnife;
    private void OnEnable()
    {
        CollisionHandler.Collision += KnifeSpawner;
    }
    private void OnDisable()
    {
        CollisionHandler.Collision -= KnifeSpawner;
    }
    public void KnifeSpawner()
    {
        if (GameManager.GetState() != "Loose")
        {
        GameObject knife = Instantiate(NewKnife, new Vector3(-289f, -21.2f, 0f), Quaternion.Euler(new Vector3(0, 0, 0)));
	    knife.transform.localScale = new Vector3(2.118996f, 1.645626f, 0.7099291f);
        }
    }
}