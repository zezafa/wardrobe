using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCameraPicture : MonoBehaviour
{
    public Button takePictureButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = takePictureButton.GetComponent<Button>();
        btn.onClick.AddListener(Snap);
    }

    // Take picture
    void Snap()
    {
        Debug.Log("TODO: Take picture");
    }
}
