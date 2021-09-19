using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generitar : Pool
{
    [SerializeField] private float _max;
    [SerializeField] private float _min;
    [SerializeField] private GameObject _shablon;
    [SerializeField] private float _timeSpawn;
    private float tamenull = 0;
    private void Start()
    {
        Initialize(_shablon);
    }
    private void Update()
    {
        tamenull += Time.deltaTime;
        if(tamenull > _timeSpawn)
        {
            if(TryGetObject(out GameObject tr))
            {
                tamenull = 0;
                float spawnPositionY = Random.Range(_min,_max);
                Vector3 _sP = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
                tr.SetActive(true);
                tr.transform.position = _sP;
                DestoyShablon();

            }
        }
    }
}
