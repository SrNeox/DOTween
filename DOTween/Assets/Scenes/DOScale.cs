using UnityEngine;
using DG.Tweening;

public class DOScale : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_scale, _duration);
    }
}
