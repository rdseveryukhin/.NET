Describe the class of monetary amounts given as the number of rubles and kopecks.

Define in it:

1) A constructor that accepts the number of rubles or kopecks in the format of strings ("10", "r.") or ("25", "kop.")

2) A constructor that accepts rubles and kopecks at the same time in the format of strings ("10", "r.", "25", "kop.")

Constructors should correctly handle the following situations:

kopeck values > 99 (for example, "101 kopecks" == "1 rub. 1 kop."
in the case when rubles are entered after kopecks "10 kop. 5 r." - display the message "Rubles and kopecks are mixed up!".
in the case when a negative number is entered - display the message "Cannot be negative!"

3) Addition and subtraction operations - methods static Sum(Money a, Money b) and static Difference(Money a, Money b), which return a new object of the same Money class.

4) The Print() method - outputting the entire amount to the console.
If the amount of rubles in the amount is 0, you do not need to withdraw rubles.
In all other cases, a full withdrawal is expected.

5) The PrintTransferCost() method that takes a real number as an argument - the value of the commission for the transfer (for example, 0.05). The method displays in the console the full cost of the transfer with a commission rounded to kopecks (example for the amount of 10 rubles 15 kopecks and the commission value of 5%, the total cost will be 10 rubles 66 kopecks)
