using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private float _offSetX;
    private void Update()
    {
        transform.position = new Vector3(_character.transform.position.x - _offSetX, transform.position.y, transform.position.z);
    }
}
