using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealthBarPosition : MonoBehaviour
{
    [SerializeField] private GameObject _healthBar;
    [SerializeField] private Vector3 _offset;
    void Update()
    {
        _healthBar.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + _offset);
    }

}
