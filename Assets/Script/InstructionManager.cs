﻿using Assets.Script.DatabaseModel;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InstructionManager : MonoBehaviour {

    private Food food;
    private string instructions;
    private int minStep = 0;
    private int maxStep;
    private TextMeshProUGUI proUGUI;

    public List<string> InstructionList { get; set; }

    private void Start() {
        food = MenuManager.Food;

        InstructionList = new List<string>();
        foreach (var item in food.InstructionTranslated.Split('\n')) {
            InstructionList.Add(item);
            instructions += item + "\n";
        }

        GetComponent<TextMeshProUGUI>().SetText(instructions); // Display the instructions on the ScrollRect

        maxStep = InstructionList.Count - 1; // Count is non-zero based index
    }

    private void Update() {
        if(minStep < maxStep) {
            //Debug.Log(InstructionList.ElementAt(minStep++)); // ElementAt is a zero-based index
        }
    }
}