def censor(text, word):
    new_text = ''
    test = ''
    #Loop through every character 
    for index, char in enumerate(text, start=1):
        #Check if space or last character
        if index == len(text):
            test += char
            if test == word:
                for i in range(len(test)):
                    new_text += '*'
            else:
                new_text += test
            test = ''
        elif char == ' ':
            if test == word:
                for i in range(len(test)):
                    new_text += '*'
            else:
                new_text += test
            new_text += ' '
            test = ''
        else:
            test += char

    return new_text

message = censor("Waht is dat boi what no what ye?", "What")

print message