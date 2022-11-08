using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float delay = 2f;
    public Coroutine currentRoutine;

    private void Start()
    {
        // Lancer
        currentRoutine = StartCoroutine(MoveSphereWithDelay());

        // EXEMPLES

        // Stopper
        StopCoroutine(currentRoutine);
        // Stopper toutes les coroutines
        StopAllCoroutines();
    }

    private IEnumerator MoveSphereWithDelay()
    {
        transform.position = Vector3.zero;
        // Attendre x secondes
        yield return new WaitForSeconds(delay);
        transform.position = Vector3.one;
        yield return new WaitForSeconds(delay);
        StartCoroutine(MoveSphereWithDelay());
    }
}
