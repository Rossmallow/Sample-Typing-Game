﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
    private static string[] wordList = {"sidewalk", "robin", "three", "protect",
                                        "periodic", "somber", "majestic", "jump",
                                        "pretty", "wound", "jazzy", "memory", 
                                        "join", "crack", "grade", "boot",
                                        "cloudy", "sick", "mug", "hot", "tart",
                                        "dangerous", "mother", "rustic",
                                        "economic", "weird", "cut", "parallel",
                                        "wood", "encouraging", "interrupt",
                                        "guide", "long", "chief", "mom", "signal",
                                        "rely", "abortive", "hair", "representative",
                                        "earth", "greate", "proud", "floor",
                                        "numerous", "friend", "pizzas", "building",
                                        "organic", "past", "mute", "unusual",
                                        "mellow", "analyze", "crate", "homely",
                                        "protest", "painstaking", "society", "head",
                                        "female", "eager", "heap", "dramatic",
                                        "present", "sin", "box", "pies", "awesome",
                                        "root", "available", "sleet", "wax",
                                        "boring", "smash", "anger", "tasty",
                                        "spare", "tray", "daffy", "scarce",
                                        "account", "spot", "thought", "distinct",
                                        "nimble", "practice", "cream", "ablaze",
                                        "thoughtless", "love", "verdict", "giant"};

    public static string GetRandomWord() {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
