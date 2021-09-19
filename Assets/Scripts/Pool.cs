using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int sumCollision;
    private Camera _camera;
    private List<GameObject> pool = new List<GameObject>();
    protected void Initialize(GameObject prefab)
    {
        _camera = Camera.main;
        for(int i = 0;i < sumCollision;i++)
        {
            GameObject spawned = Instantiate(prefab,  _container.transform);
            spawned.SetActive(false);
            pool.Add(spawned);
        }
    }
    protected bool TryGetObject(out GameObject result)
    {
        result = pool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }
    protected void DestoyShablon()
    {
        foreach(var item in pool)
        {
            if(item.activeSelf == true)
            {
                Vector3 point = _camera.WorldToViewportPoint(item.transform.position);
                if (point.x < 0)
                    item.SetActive(false);
            }
        }
    }
    public void ResetPool()
    {
        foreach(var item in pool)
        {
            item.SetActive(false);
        }
    }
}
