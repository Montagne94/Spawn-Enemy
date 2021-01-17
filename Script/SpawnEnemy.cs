using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _points;
    void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        int CurrentPoint = 0;
        while (true)
        {
            Instantiate(_enemy, _points[CurrentPoint].transform.position, Quaternion.identity);
            CurrentPoint++;
            if(CurrentPoint >= _points.Length)
            {
                CurrentPoint = 0;
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
