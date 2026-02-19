using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorAbility : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _targetSprite;
    [SerializeField] private Button _abilityButton;
    [SerializeField] private float _abilityCooldown;
    [SerializeField] private Color _whatColor;

    private Color _originColor;

    private void OnEnable()
    {
        _abilityButton.onClick.AddListener(CallAbility);
        _originColor = _targetSprite.color;
    }

    private void OnDisable()
    {
        _abilityButton.onClick.RemoveAllListeners();
    }

    private void CallAbility()
    {
        _abilityButton.interactable = false;
        _targetSprite.color = _whatColor;
        StartCoroutine(CallAbilityCooldown());
    }

    private IEnumerator CallAbilityCooldown()
    {
        yield return new WaitForSeconds(_abilityCooldown);

        _targetSprite.color = _originColor;
        _abilityButton.interactable = true;
    }
}
