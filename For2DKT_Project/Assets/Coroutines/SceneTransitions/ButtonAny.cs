using UnityEngine;
using UnityEngine.UI;

public class ButtonAny : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private float _startTransitionTime = 1f;

    private void OnEnable()
    {
        _button.onClick.AddListener(() => SetInteractable(false));
        _button.onClick.AddListener(() => StartCoroutine(_sceneLoader.LoadScene(_startTransitionTime)));
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void SetInteractable(bool isActive)
    {
        _button.interactable = isActive;
    }
}
