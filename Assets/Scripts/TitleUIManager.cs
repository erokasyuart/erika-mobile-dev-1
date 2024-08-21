using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TitleUIManager : MonoBehaviour
{

    private UIDocument titleUIDocument;
    private Button newGameButton;

    // Start is called before the first frame update
    void Start()
    {
        titleUIDocument = GetComponent<UIDocument>();
        newGameButton = titleUIDocument.rootVisualElement.Q<Button>("new-game-button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
