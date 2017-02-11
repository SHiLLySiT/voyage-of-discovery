using System.Collections.Generic;

public class WorldData {
    List<List<RegionData>> _regions;

    public class RegionData {
        public int x { get; set; }
        public int y { get; set; }
        public int turnLastLoaded { get; set; }

        List<List<int>> _tiles;
        List<EntityData> _entities;

        public class EntityData {
            public int x { get; set; }
            public int y { get; set; }

            Dictionary<string, string> _data;

            public EntityData () {
                x = 0;
                y = 0;
                _data = new Dictionary<string, string>();
            }

            public void SetProperty (string key, string value) {
                _data[key] = value;
            }

            public string GetProperty (string key) {
                return _data[key];
            }
        }

        public RegionData (int x, int y, int width, int height) {
            _entities = new List<EntityData>();
            _tiles = new List<List<int>>();
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    _tiles[i][j] = 0;
                }
            }
        }

        public int GetTileAt (int x, int y) {
            return _tiles[x][y];
        }

        public void SetTileAt (int x, int y, int tile) {
            _tiles[x][y] = tile;
        }

        public List<EntityData> GetEntitiesAt (int x, int y) {
            // TODO: search for entities at position
            return _entities;
        }

        public void AddEntity (EntityData entity) {
            _entities.Add(entity);
        }

        public void RemoveEntity (EntityData entity) {
            _entities.Remove(entity);
        }
    }

    public WorldData (int width, int height, int regionWidth, int regionHeight) {
        _regions = new List<List<RegionData>>(width * height);
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                _regions[i][j] = new RegionData(i, j, regionWidth, regionHeight);
            }
        }
    }

    public RegionData GetRegionAt (int x, int y) {
        return _regions[x][y];
    }

    // TODO: save/load world data
}
