using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DOText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("������ ������", 3f);
        _text2.DOText("������ ������", 3f).SetRelative();
        _text3.DOText("������ ������", 3f, true, ScrambleMode.All);
    }
}

