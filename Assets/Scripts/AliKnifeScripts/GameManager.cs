using System;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static Action StateChanged;
    private static string _state;
    private static string _KnifeState;
    public static void ChangeState(string state)
    {
        _state = state;
        StateChanged?.Invoke();
    }
    public static void ChangeStateKnife(string state)
    {
        _KnifeState = state;
        StateChanged?.Invoke();
    }
    public static string GetState()
    {
        return _state;
    }
    public static string GetStateKinfe()
    {
        return _KnifeState;
    }
}