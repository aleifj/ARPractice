using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesCtrl : MonoBehaviour
{  
    public GameObject UIGlassGroup;
    public Material[] newMaterial;

    private string selectedTag = null;
    private int selectedIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        UIGlassGroup.SetActive(false);
#endif
        SetdisplayOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedTag != null)
        {
            GameObject.FindWithTag(selectedTag).GetComponent<MeshRenderer>().material = newMaterial[selectedIndex];
        }
    }
    private void SetdisplayOff()
    {
        GameObject.FindWithTag("CAT").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindWithTag("MONO").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindWithTag("STAR").GetComponent<MeshRenderer>().enabled = false;
    }
    public void DisplayGlass(string strVal)
    {
        SetdisplayOff();
        GameObject.FindWithTag(strVal).GetComponent<MeshRenderer>().enabled = true;
        selectedTag = strVal;
    }
    public void ChangeGlassColor(int index)
    {
        if (selectedTag != null)
        {
            GameObject.FindWithTag(selectedTag).GetComponent<MeshRenderer>().material = newMaterial[index];
            selectedIndex = index;
        }
        
    }
}
