using UnityEngine;
using DG.Tweening;
using System.Diagnostics;


public class Enemyinteligent : MonoBehaviour
{
    void Start()
    {
        Sequence completerun = DOTween.Sequence();
        completerun.Append(transform.DOMoveY(33.5f,4).SetEase(Ease.InSine));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-89),0.5f));
        completerun.Append(transform.DOMoveX(8,3));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-180),0.5f));
        completerun.Append(transform.DOMoveY(0f,4).SetEase(Ease.InSine));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-89),0.5f));
        completerun.Append(transform.DOMoveX(26,2.5f));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-180),0.5f));
        completerun.Append(transform.DOMoveY(-7f,2).SetEase(Ease.InSine));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-270),0.5f));
        completerun.Append(transform.DOMoveX(17,2.5f));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-180),0.5f));
        completerun.Append(transform.DOMoveY(-15f,2).SetEase(Ease.InSine));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-270),0.5f));
        completerun.Append(transform.DOMoveX(-0.5f,2.5f));
        completerun.Append(transform.DOLocalRotate(new Vector3(0,0,-360),0.5f));
        completerun.Append(transform.DOMoveY(12f,2).SetEase(Ease.InSine));
    }
    void Update()
    {
        
    }
}
