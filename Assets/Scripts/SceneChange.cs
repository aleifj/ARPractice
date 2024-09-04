using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�� ��ȯ���� �� ��¡�� �ʿ�
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ProgressText;
    public void OnChangeScene(string value)
    {
        //������ �� ��ȯ���� �̰��� ���.
        //SceneManager.LoadScene(value);

        //�ð��� �ɸ��� �� ��ȯ���� LoadSceneAsync���.
        StartCoroutine(LoadScene(value));
    }
    IEnumerator LoadScene(string value)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(value);
        while (!ao.isDone)
        {
            ProgressText.text = $"Loading : {ao.progress * 100}%";//�ε��� �ۼ�Ʈ�� Ȯ�� �� �� ����.
            yield return null;
        }
    }
}
