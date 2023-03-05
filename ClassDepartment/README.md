The large international promising company Vector has 4 departments: the department of purchases, sales, advertising and logistics. These 4 departments are staffed by managers (manager), marketers (marketer), engineers (engineer) and analysts (analyst).

Manager receives 50,000 tugriks per month, drinks 20 liters of coffee and produces 200 pages of reports per month

Marketer - 40,000 tugriks, 15 liters of coffee and 150 pages of reports

Engineer - 20,000 tugriks, 5 liters of coffee and 50 pages of blueprints

Analyst - 80,000 tugriks and 50 liters of coffee and 5 pages of strategic research

In addition, all employees come in 3 ranks: first, second and third. An employee of the second rank receives 25% more than the first, and an employee of the 3rd rank - 50% more than the first. The final value is mathematically rounded to an integer.

For convenience, we will abbreviate the position, for example, manager of the 2nd rank = manager2

Example of departments:

Purchasing department: 9*manager1, 3*manager2, 2*manager3, 2*marketer1 + manager2
Sales department: 12*manager1, 6*manager1, 3*analyst1, 2*analyst2 + department head marketer2
Advertising department: 15*marketer1, 10*marketer2, 8*manager1, 2*engineer1 + head of marketer3 department
Logistics department: 13*manager1, 5*manager2, 5*engineer1 + manager1
A manager earns 50% more (total value mathematically rounded up to a whole number) than a typical employee of the same level, drinks twice as much coffee, and produces no reports, blueprints, or strategic research.

Write a program to account for the costs and results of the work of the entire friendly team of the Vector company. The program should output:

Number of employees in each department
Spending on salaries and coffee by department and in total
The number of pages of documents and reports produced by each department and in total
Calculate the average consumption of tugriks per page. Mathematically round the result to 2 decimal places
The final output in the form of a table:

          5 spaces
          
            |<->|
            
Department of Employees Tugriks Coffee Pages Tugr./page

-------------------------------------------------- --------------------------

Purchasing 17 961250 350 3100 310.08

Sales 24 1415000 640 3625 390.34

Advertising 36 1630000 575 5450 299.08

Logistics 24 1137500 425 3850 295.45

-------------------------------------------------- --------------------------

Total 101 5143750 1990 16025 320.98
