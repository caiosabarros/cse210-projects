Explain the meaning of Inheritance
Highlight a benefit of Inheritance
Provide an application of Inheritance
Use a code example of Inheritance from the program you wrote
Thoroughly explain these concepts (this likely cannot be done in less than 100 words)

1. Meaning of Inheritance:
Inheritance means to avoid duplicate code by making different classes share the same functions or variables defined in a specific class and this function or variables are available in all the classes inheriting from the specific class.

2. A benefit of Inheritance:
By definition, inheritance makes it easier for a programmer to obey the DRY (Don't Repeat Yourself) programming principle.

3. Provide an application of Inheritance:
Let's say I have a function that I want to be displayed in all classes across my program. I can just make all the classes inherit the function from a base class and it's going to be available in all classes inheriting from the base class.

4. A code example of Inheritance from the program you wrote:
The below code snippet shows a function I want to be used in all the different activities I've done in the program.
```
  public void DisplayAnimation(bool getReady)
  {
    if(getReady){
        Console.WriteLine("Get ready...");
        Console.WriteLine("");
    }
        var spinner = new[] { '|', '/', '-', '\\' };
        var index = 0;
        var count = 30;
        while (count >= 1) {
            Console.Write(spinner[index]);
            index = (index + 1) % spinner.Length;
            Console.SetCursorPosition(Console.CursorLeft - 1,
              Console.CursorTop);
            System.Threading.Thread.Sleep(100);
            count--;
        }
  }
  ```
  So, I made all the activities' classes inherit from this class so that they'd have access to this function as well.
  The code snippet below shows the Listing activity class inheriting from the Activity class
  ```
  class Listing : Activity
  ```