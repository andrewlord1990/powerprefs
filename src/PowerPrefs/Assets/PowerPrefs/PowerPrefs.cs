namespace PowerPrefs {
  public class PowerPrefs {
    
    private static PowerPrefsAccessor<bool> boolAccessor;
    private static PowerPrefsAccessor<float> floatAccessor;
    private static PowerPrefsAccessor<int> intAccessor;
    private static PowerPrefsAccessor<string> stringAccessor;

    public static PowerPrefsAccessor<bool> ForBool() {
      if (boolAccessor == null) {
        boolAccessor = new PowerPrefsAccessor<bool>(new BoolPrefAccessor());
      }
      return boolAccessor;
    }

    public static PowerPrefsAccessor<float> ForFloat() {
      if (floatAccessor == null) {
        floatAccessor = new PowerPrefsAccessor<float>(new FloatPrefAccessor());
      }
      return floatAccessor;
    }

    public static PowerPrefsAccessor<int> ForInt() {
      if (intAccessor == null) {
        intAccessor = new PowerPrefsAccessor<int>(new IntPrefAccessor());
      }
      return intAccessor;
    }

    public static PowerPrefsAccessor<string> ForString() {
      if (stringAccessor == null) {
        stringAccessor = new PowerPrefsAccessor<string>(new StringPrefAccessor());
      }
      return stringAccessor;
    }
    
  }
}
