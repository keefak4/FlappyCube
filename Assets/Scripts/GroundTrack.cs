using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrack : MonoBehaviour
{
    [SerializeField] private Character _character;
    private void Update()
    {
        transform.position = new Vector3(_character.transform.position.x, transform.position.y, transform.position.z);
    }
}
