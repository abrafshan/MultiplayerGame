using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class KnifeControler : MonoBehaviour
{
    private float jumpForce = 3f;
    private string State = "Stop";
    private Sprite KnifeSkin = ChangeKnifeSkin.KnifeSkin;

    void Update()
    {
        ChangeSkin();
        if (Input.GetKeyDown(KeyCode.W) && State == "Stop")
        {
            State = "Move";
        }

        if (State == "Move")
        {
            Move();
        }
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            transform.SetParent(other.transform);
            State = "PostStop";
        }

        if (other.collider.tag == "Knife")
        {
            GameManager.ChangeState("Loose");
            SpriteRenderer _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.material.color = Color.red;
            SceneManager.LoadScene("Loose");
            
        }
    }
    void Move()
    {
        transform.position += new Vector3(0,jumpForce,0);
    }
    void ChangeSkin()
    {
        SpriteRenderer _SpriteRenderer = GetComponent<SpriteRenderer>();
        _SpriteRenderer.sprite = KnifeSkin;
    }
}
