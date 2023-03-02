In this task, you need to check the user input for correctness.

The input is strings with the data that the user entered in the registration form,

space separated: {name} {password} {email}. Each entry is submitted on a separate line.

Input string example: "validName valiDpas5Word valid@email.com"

The input string "end" means the end of the input. The number of input lines in the test is not known in advance, be guided by the "end" key.

Your task is to check if the data matches the rules:

1) Name: non-empty, cannot start with a space, contain a space, or consist of only spaces. Length of at least 4 characters.

2) Password: non-empty, cannot start with a space, contain a space, or consist of only spaces. Must contain a number, a lowercase letter, and an uppercase letter. Length of at least 6 characters.

3) Mail: non-empty, cannot start with a space, contain a space, or consist of only spaces. Check the correctness of the entry: name, domain, location and uniqueness of the key characters "@", ".".

For records that have successfully passed validation, you need to create an instance of the Account class and transfer data to it.

The resulting object needs to be added to our impromptu database. The NoobDb class is already in the program, you do not need to create it yourself.
