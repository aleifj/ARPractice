using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//씬 전환에는 이 유징이 필요
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ProgressText;
    public void OnChangeScene(string value)
    {
        //간단한 씬 전환에는 이것을 사용.
        //SceneManager.LoadScene(value);

        //시간이 걸리는 씬 전환에는 LoadSceneAsync사용.
        StartCoroutine(LoadScene(value));
    }
    IEnumerator LoadScene(string value)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(value);
        while (!ao.isDone)
        {
            ProgressText.text = $"Loading : {ao.progress * 100}%";//로딩을 퍼센트로 확인 할 수 있음.
            yield return null;
        }
    }
}
