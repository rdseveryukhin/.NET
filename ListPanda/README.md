The coordinates of the detected pandas will be sent as input in the format {X,Y} where X and Y are integers and the sex of the detected panda {male/female}.

Input string example: "0 0 male"

Each panda is served on a separate line.

All discovered pandas must be paired by sex and the shortest distance between them. You already know the formula for calculating the distance between pandas from previous lessons.

Expected output:

1) Display the total number of pandas: Total pandas count: {pandasCount};

2) If the panda is left without a pair, print on a new line: "Lonely {Gender} panda at X: {X}, Y: {Y}";

3) If there is a pair of pandas on a new line, output: "Pandas pair at distance {Distance}, male panda at X: {X}, Y: {Y}, female panda at X: {X}, Y: {Y}" ;

4) Mathematically round the distance to two decimal places.

The input string "end" means the end of the input. The number of input lines in the test is not known in advance, be guided by the "end" key.

 

Sort the output lines in the following order:

1) First unpaired pandas in input order.

2) The resulting pairs, sorted by increasing distance between them.
