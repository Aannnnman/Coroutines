using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Animator _transitionPanel;
    [SerializeField] private string _sceneName;

    public IEnumerator LoadScene(float startTranstionTime)
    {
        _transitionPanel.gameObject.SetActive(true);
        _transitionPanel.Play("EnterToDarkness");

        yield return new WaitForSeconds(startTranstionTime);

        SceneManager.LoadScene(_sceneName);
    }

    private void OnTransitionFinished()
    {
        _transitionPanel.gameObject.SetActive(false);
    }
}
