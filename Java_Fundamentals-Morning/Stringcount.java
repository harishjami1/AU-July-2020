import java.util.HashMap;
import java.util.Map;
import java.util.*;
class Stringcount {
    public static void count_occur(String [] List) {
        Map<String, Integer> obj = new HashMap<String, Integer>();
        for (String key : List) {
            Integer value = obj.get(key);
            obj.put(key, (value == null) ? 1 : value + 1);
        }
        for (Map.Entry<String, Integer> entry : obj.entrySet())
            System.out.println("No. of occurances of " + entry.getKey() + "  = " + entry.getValue());
    }
}
class Main {
    public static void main(String[] args) {
        String[] arr = {"a","a","Me","b","c","Me","c","c","j"};
        Stringcount.count_occur(arr);
}}