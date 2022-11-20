HaloAssignmentApp

This app is used to receive a string of alphanumeric characters and return the whole numbers present in that string.

Steps to run application:
  1. Clone HaloAssignment.
  2. Set HaloAssignmentDemo as the StartUp project.
  3. Run HaloAssignmentDemo

Steps to test:

Type in any string which contains alphanumberic characters as the value for input parameter "text".
  1. Scenario1
      Input --> "1234"
      Output --> 1234
      
   2. Scenario2
      Input --> "1234.67"
      Output --> 1235
      
   3. Scenario3
      Input --> "This text contains 1234"
      Output --> 1234

   4. Scenario4
      Input --> "This text contains 1234.67"
      Output --> 1235

   5. Scenario5
      Input --> "This text contains 1234 and 1234.67"
      Output --> 1234, 1235

   6. Scenario6
      Input --> "-1234"
      Output --> -1234

   7. Scenario7
      Input --> "-1234.67"
      Output --> 1235

   8. Scenario8
      Input --> "0"
      Output --> 0

   9. Scenario9
      Input --> "This string has no numbers"
      Output --> null
      
   10. Scenario9
      Input --> "This string contains 1234, 345345.5, 345349, 0, -345345"
      Output --> 1234, 345346, 345349, 0, -345345
      
   11. Scenario9
      Input --> "This string contains 1234 345345.5 345349 0 -345345"
      Output --> 1234, 345346, 345349, 0, -345345
      
      
      
   
