using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{
    public Sprite KnifeSkin;
    public void Awake()
    {
        if (!ChangeKnifeSkin.KnifeSkin)ChangeKnifeSkin.KnifeSkin = KnifeSkin;
    }
    private void OnEnable()
    {
        GameManager.StateChanged += HandleStateChange;
    }
    private void OnDisable()
    {
        GameManager.StateChanged -= HandleStateChange;
    }
    private void HandleStateChange()
    {
        string state = GameManager.GetState();
    }
}