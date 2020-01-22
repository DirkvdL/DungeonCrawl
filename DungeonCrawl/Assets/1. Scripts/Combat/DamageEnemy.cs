using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public float range;

    public List <Enemies> FindClosestEnemies()
    {
        Enemies[] gos = FindObjectsOfType<Enemies>();

        Vector3 position = transform.position;

        List<Enemies> result = new List<Enemies>();

        foreach (Enemies go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance <= range)
            {
                Debug.Log(new Vector3(1, 1, 0).sqrMagnitude);
                result.Add(go);
            }
        }
        return result;
    }

    private void Update()
    {
        if (Input.GetButtonDown ("Attack"))
        {
            StartCoroutine(KillAnimationWait());
            foreach (Enemies go in FindClosestEnemies())
            {
                go.DealDamage();
            }
        }
    }

    IEnumerator KillAnimationWait()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
