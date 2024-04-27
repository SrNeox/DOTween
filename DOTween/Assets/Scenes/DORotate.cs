using UnityEngine;
using DG.Tweening;

public class DORotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_rotate, _duration);
    }
}
