namespace PowerPrefs {

  using UnityEngine;

  /// <summary>
  /// Get and set bool values.
  /// </summary>
  public class BoolPrefAccessor : PrefAccessor<bool> {

    /// <summary>
    /// Get a bool value from PlayerPrefs.
    /// </summary>
    /// <param name="prefKey">The key to retrieve the value for.</param>
    /// <param name="defaultValue">
    /// The default value to return if the key doesn't exist. If not specified it will be false.
    /// </param>
    /// <returns>The bool value stored at the key prefKey or if not present then false.</returns>
    public bool Get(string prefKey, bool defaultValue = false) {
        int prefValue = PlayerPrefs.GetInt(prefKey, boolToInt(defaultValue));
        return prefValue == 1 ? true : false;
    }

    /// <summary>
    /// Set a bool value into PlayerPrefs.
    /// </summary>
    /// <param name="prefKey">The key to set a value for.</param>
    /// <param name="prefValue">The value to set.</param>
    /// <returns>This accessor.</returns>
    public PrefAccessor<bool> Set(string prefKey, bool prefValue) {
        PlayerPrefs.SetInt(prefKey, boolToInt(prefValue));
        return this;
    }

    private int boolToInt(bool prefValue) {
      return prefValue ? 1 : 0;
    }

  }
}