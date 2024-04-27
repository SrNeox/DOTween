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
        _text1.DOText("Замена текста", 3f);
        _text2.DOText("Замена текста", 3f).SetRelative();
        _text3.DOText("Замена текста", 3f, true, ScrambleMode.All);
    }
}

