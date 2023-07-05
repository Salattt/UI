using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HPBar : MonoBehaviour
{
    [SerializeField] private float _targetTime;

    private Slider _slider;

    private Coroutine _hpBarAnimation;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void OnHealthChanged(float newHealth)
    {
        if(_hpBarAnimation != null)
            StopCoroutine(_hpBarAnimation);

        _hpBarAnimation = StartCoroutine(AnimateHpBar(newHealth));
    }

    private IEnumerator AnimateHpBar(float targetValue)
    {
        float startingBarValue = _slider.value;
        float procentageOfCompletion = 0;

        while(procentageOfCompletion < 1)
        {
            procentageOfCompletion += Time.deltaTime / _targetTime;
            _slider.value = Mathf.Lerp(startingBarValue, targetValue, procentageOfCompletion);

            yield return null;
        }
    }
}
