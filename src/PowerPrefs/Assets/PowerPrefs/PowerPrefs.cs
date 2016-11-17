namespace PowerPrefs {
  /// <summary>
  /// Read and write values of various different types to PlayerPrefs easily.
  /// </summary>
  public class PowerPrefs {
    
    private static PowerPrefsAccessor<bool> boolAccessor;
    private static PowerPrefsAccessor<float> floatAccessor;
    private static PowerPrefsAccessor<int> intAccessor;
    private static PowerPrefsAccessor<string> stringAccessor;
    private static PowerPrefsAccessor<char> charAccessor;

    /// <summary>
    /// Create a PlayerPrefs accessor to read and write bool type values.
    /// </summary>
    /// <returns>Bool prefs accessor</returns>
    public static PowerPrefsAccessor<bool> ForBool() {
      if (boolAccessor == null) {
        boolAccessor = new PowerPrefsAccessor<bool>(new BoolPrefAccessor());
      }
      return boolAccessor;
    }

    /// <summary>
    /// Create a PlayerPrefs accessor to read and write float type values.
    /// </summary>
    /// <returns>Float prefs accessor</returns>
    public static PowerPrefsAccessor<float> ForFloat() {
      if (floatAccessor == null) {
        floatAccessor = new PowerPrefsAccessor<float>(new FloatPrefAccessor());
      }
      return floatAccessor;
    }

    /// <summary>
    /// Create a PlayerPrefs accessor to read and write int type values.
    /// </summary>
    /// <returns>Int prefs accessor</returns>
    public static PowerPrefsAccessor<int> ForInt() {
      if (intAccessor == null) {
        intAccessor = new PowerPrefsAccessor<int>(new IntPrefAccessor());
      }
      return intAccessor;
    }

    /// <summary>
    /// Create a PlayerPrefs accessor to read and write string type values.
    /// </summary>
    /// <returns>String prefs accessor</returns>
    public static PowerPrefsAccessor<string> ForString() {
      if (stringAccessor == null) {
        stringAccessor = new PowerPrefsAccessor<string>(new StringPrefAccessor());
      }
      return stringAccessor;
    }

    /// <summary>
    /// Create a PlayerPrefs accessor to read and write char type values.
    /// </summary>
    /// <returns>Char prefs accessor</returns>
    public static PowerPrefsAccessor<char> ForChar() {
      if (charAccessor == null) {
        charAccessor = new PowerPrefsAccessor<char>(new CharPrefAccessor());
      }
      return charAccessor;
    }
    
  }
}
