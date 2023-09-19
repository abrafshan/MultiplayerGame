using DG.Tweening;  
using UnityEngine;
public class Rotation : MonoBehaviour
{
    public float speed;
    public GameObject Boom;
    Sequence MySequence = DOTween.Sequence();
    
    
    void Update()
    {
    MySequence.Append(transform.DORotate(new Vector3(0,0,speed), 3,RotateMode.FastBeyond360));
    MySequence.Append(transform.DORotate(new Vector3(0,0,-speed), 3,RotateMode.FastBeyond360));
    //.OnComplete(()=>transform.DORotate(new Vector3(0,0,-360), 3,RotateMode.FastBeyond360).SetEase(Ease.InCirc).SetLoops(-1,LoopType.Yoyo));
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        GameObject effect = Instantiate(Boom);
        effect.transform.position = new Vector3(-289.940002f,13.9200001f,0f);
    }
}