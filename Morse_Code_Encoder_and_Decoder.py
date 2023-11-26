```python
def morse_to_text(morse_code):
    morse_code_dict = { 'A':'.-', 'B':'-...',
                    'C':'-.-.', 'D':'-..', 'E':'.',
                    'F':'..-.', 'G':'--.', 'H':'....',
                    'I':'..', 'J':'.---', 'K':'-.-',
                    'L':'.-..', 'M':'--', 'N':'-.',
                    'O':'---', 'P':'.--.', 'Q':'--.-',
                    'R':'.-.', 'S':'...', 'T':'-',
                    'U':'..-', 'V':'...-', 'W':'.--',
                    'X':'-..-', 'Y':'-.--', 'Z':'--..',
                    '1':'.----', '2':'..---', '3':'...--',
                    '4':'....-', '5':'.....', '6':'-....',
                    '7':'--...', '8':'---..', '9':'----.',
                    '0':'-----', ', ':'--..--', '.':'.-.-.-',
                    '?':'..--..', '/':'-..-.', '-':'-....-',
                    '(':'-.--.', ')':'-.--.-'}
    morse_code = morse_code.split(" ")

    decoded_string = ""
    for symbol in morse_code:
        for key, value in morse_code_dict.items():
            if symbol == value:
                decoded_string += key
                break
            elif symbol == '/':
                decoded_string += ' '
    return decoded_string

def text_to_morse(text):
    morse_code_dict = { 'A':'.-', 'B':'-...',
                    'C':'-.-.', 'D':'-..', 'E':'.',
                    'F':'..-.', 'G':'--.', 'H':'....',
                    'I':'..', 'J':'.---', 'K':'-.-',
                    'L':'.-..', 'M':'--', 'N':'-.',
                    'O':'---', 'P':'.--.', 'Q':'--.-',
                    'R':'.-.', 'S':'...', 'T':'-',
                    'U':'..-', 'V':'...-', 'W':'.--',
                    'X':'-..-', 'Y':'-.--', 'Z':'--..',
                    '1':'.----', '2':'..---', '3':'...--',
                    '4':'....-', '5':'.....', '6':'-....',
                    '7':'--...', '8':'---..', '9':'----.',
                    '0':'-----', ', ':'--..--', '.':'.-.-.-',
                    '?':'..--..', '/':'-..-.', '-':'-....-',
                    '(':'-.--.', ')':'-.--.-'}
    text = text.upper()

    encoded_string = ""
    for char in text:
        if char != ' ':
            encoded_string += morse_code_dict[char] + ' '
        else:
            encoded_string += '/ '
    return encoded_string

while True:
    print("\n1. Morse to Text\n2. Text to Morse\n3. Quit")
    choice = input("Enter your choice: ")

    if choice == '1':
        morse_code = input("\nEnter Morse Code: ")
        print("\n" + morse_to_text(morse_code))
    elif choice == '2':
        text = input("\nEnter Text: ")
        print("\n" + text_to_morse(text))
    elif choice == '3':
        break
    else:
        print("\nInvalid choice")
```