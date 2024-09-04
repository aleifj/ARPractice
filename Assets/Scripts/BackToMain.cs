using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                Application.Quit();//���� ���������� ���� �ڵ幮��.
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            SceneManager.LoadScene(0);//������ ���ư� ���� ���߰�, �� ���� ������ ���ϴϱ� ����0���� �ڵ���.
        }
    }
}
