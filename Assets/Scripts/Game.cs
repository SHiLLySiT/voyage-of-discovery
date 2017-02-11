using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    #region Editor
    [SerializeField]
    int _width = 10;
    [SerializeField]
    int _height = 10;
    [SerializeField]
    int _regionWidth = 100;
    [SerializeField]
    int _regionHeight = 100;
    #endregion

    public static Game instance { get; private set; }

    public WorldData worldData { get; private set; }

    void Awake () {
        instance = this;
        worldData = null;
    }

    void Start () {
        GenerateWorld();
    }

    void GenerateWorld () {
        worldData = new WorldData(_width, _height, _regionWidth, _regionHeight);
        // TODO: generate world
    }
}
