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
                Application.Quit();//현재 무슨씬인지 보는 코드문법.
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            SceneManager.LoadScene(0);//어차피 돌아갈 곳을 정했고, 그 씬은 수정을 안하니까 숫자0으로 코드함.
        }
    }
}
