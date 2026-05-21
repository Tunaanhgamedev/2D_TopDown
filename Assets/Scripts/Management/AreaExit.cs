using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private string sceneTransitionName;

    private float waitToLoadTime = 1f;
    private bool canTeleport = false;

    private void Start()
    {
        StartCoroutine(EnableTeleportRoutine());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!canTeleport) { return; }

        if (other.gameObject.GetComponent<PlayerController>())
        {
            Debug.Log("TRIGGER: " + gameObject.name);
            SceneManagement.Instance.SetTransitionName(sceneTransitionName);
            UIFade.Instance.FadeToBlack();
            StartCoroutine(LoadSceneRoutine());
        }
    }

    private IEnumerator LoadSceneRoutine()
    {
        while(waitToLoadTime >= 0)
        {
            waitToLoadTime -= Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene(sceneToLoad);
    }

    private IEnumerator EnableTeleportRoutine()
    {
        yield return new WaitForSeconds(0.5f);

        canTeleport = true;
    }
}
