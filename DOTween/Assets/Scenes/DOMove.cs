using DG.Tweening;
using UnityEngine;

public class DOMove : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration);
    }
}
