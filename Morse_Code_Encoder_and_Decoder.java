```java
import java.util.HashMap;
import java.util.Map;

public class MorseCode {
    private static final Map<Character, String> TO_MORSE = new HashMap<>();
    private static final Map<String, Character> FROM_MORSE = new HashMap<>();

    static {
        String[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
        for (int i = 0; i < 26; i++) {
            char letter = (char) ('A' + i);
            TO_MORSE.put(letter, morse[i]);
            FROM_MORSE.put(morse[i], letter);
        }
    }

    public static String encode(String message) {
        StringBuilder sb = new StringBuilder();
        for (char c : message.toUpperCase().toCharArray()) {
            if (TO_MORSE.containsKey(c)) {
                sb.append(TO_MORSE.get(c)).append(" ");
            }
        }
        return sb.toString().trim();
    }

    public static String decode(String morse) {
        StringBuilder sb = new StringBuilder();
        String[] words = morse.split("   ");
        for (String word : words) {
            for (String letter : word.split(" ")) {
                if (FROM_MORSE.containsKey(letter)) {
                    sb.append(FROM_MORSE.get(letter));
                }
            }
            sb.append(" ");
        }
        return sb.toString().trim();
    }

    public static void main(String[] args) {
        String message = "HELLO WORLD";
        String morse = encode(message);
        System.out.println(morse);
        System.out.println(decode(morse));
    }
}
```