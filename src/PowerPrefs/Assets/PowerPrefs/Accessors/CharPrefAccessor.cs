namespace PowerPrefs {

  using UnityEngine;

  public class CharPrefAccessor : PrefAccessor<char> {

    public char Get(string prefKey, char defaultValue = default(char)) {
      string storedValue = PlayerPrefs.GetString(prefKey, "");
      if (storedValue.Length > 0){
        return storedValue[0];
      }
      return defaultValue;
    }

    public PrefAccessor<char> Set(string prefKey, char prefValue) {
      PlayerPrefs.SetString(prefKey, char.ToString(prefValue));
      return this;
    }

  }
}