using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class game : MonoBehaviour
{

    public UIDocument gameUI;
    public StyleSheet gameStyle;
    public int gridSize = 1;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(gameUI == null)
        {
            gameUI = GetComponent<UIDocument>();
        }
        gameUI.rootVisualElement.styleSheets.Add(gameStyle);
        BuildGrid(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildGrid(int size)
    {
        gridSize = size;
        var root = gameUI.rootVisualElement;
        root.Clear();
        //We'll add a grid of buttons to the UI
        var grid = new VisualElement();
        grid.name = "grid-container";
        grid.AddToClassList("grid-container"); 
        root.Add(grid);
        for (int i = 0; i < size; i++)
        {
            var row = new VisualElement();
            row.name = "row-" + i;
            row.style.flexDirection = FlexDirection.Row;
            grid.Add(row);
            for (int j = 0; j < size; j++)
            {
                var button = new Button();
                button.name = "button-" + i + "-" + j;
                button.text = "0";
                button.clickable.clicked += () => { ButtonClicked(button); };
                row.Add(button);
            }
        }
        
    }

    public void ButtonClicked(Button button)
    {
        button.text = "1";
    }


}
