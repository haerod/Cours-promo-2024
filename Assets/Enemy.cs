using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public UnityEvent OnDamageTaken;

    private void OnMouseDown()
    {
        OnDamageTaken.Invoke();
    }

    public void Exemple()
    {
        print("lm");
    }
}
